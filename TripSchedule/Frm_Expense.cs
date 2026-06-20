using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripSchedule
{
    public partial class Frm_Expense : Form
    {
        public Frm_Expense()
        {
            InitializeComponent();
        }

        private void Frm_Expense_Load(object sender, EventArgs e)
        {
            if (SessionManager.CurrentTrip == null) return;

            // 初始化付款人下拉選單 (comboBox1) 與 分攤名單 (clbMembers)
            comboBox1.Items.Clear();
            clbMembers.Items.Clear();
            foreach (string member in SessionManager.CurrentTrip.Members)
            {
                comboBox1.Items.Add(member);
                clbMembers.Items.Add(member, true); // 預設全勾選
            }

            // 初始化幣別選項
            cboCurrency.Items.Clear();
            cboCurrency.Items.Add("TWD"); // 台幣
            cboCurrency.Items.Add(SessionManager.CurrentTrip.MainCurrency); // 使用者建旅程時選的外幣 (如 KRW)
            cboCurrency.SelectedIndex = 1; // 預設選外幣

            // 預設選中「全體平分」，並把自訂名單反灰
            rdoSplitEqual.Checked = true;
            clbMembers.Enabled = false;

            // 載入舊有的記帳資料到畫面上
            RefreshDataGridView();
        }

        private void cboCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCurrency.SelectedItem != null && cboCurrency.SelectedItem.ToString() == "TWD")
            {
                txtExchangeRate.Text = "1";
                txtExchangeRate.Enabled = false; // 台幣匯率永遠是 1，不給改
            }
            else
            {
                txtExchangeRate.Text = "";
                txtExchangeRate.Enabled = true; // 外幣開放讓主辦人輸入換錢所匯率
            }
        }

        private void rdoSplitCustom_CheckedChanged(object sender, EventArgs e)
        {
            // 只有選「自訂分攤」時，核取清單才能操作
            clbMembers.Enabled = rdoSplitCustom.Checked;
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            // 基礎防呆檢查
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("請選擇付款人！", "提示");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("請輸入消費項目名稱！", "提示");
                return;
            }

            // 嘗試解析金額與匯率是否為合法數字
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("外幣金額格式錯誤，請輸入數字！", "錯誤");
                return;
            }
            if (!decimal.TryParse(txtExchangeRate.Text, out decimal exchangeRate))
            {
                MessageBox.Show("匯率格式錯誤，請輸入數字！", "錯誤");
                return;
            }

            // 計算台幣總額 (四捨五入到整數)
            decimal twdTotal = Math.Round(amount * exchangeRate, 0);

            // 處理分攤名單
            List<string> splitList = new List<string>();
            if (rdoSplitEqual.Checked)
            {
                // 全體平分：直接抓旅程的所有成員
                splitList.AddRange(SessionManager.CurrentTrip.Members);
            }
            else
            {
                // 自訂分攤：只抓有被打勾的成員
                foreach (var item in clbMembers.CheckedItems)
                {
                    splitList.Add(item.ToString());
                }

                if (splitList.Count == 0)
                {
                    MessageBox.Show("自訂分攤至少要勾選一個人！", "提示");
                    return;
                }
            }

            // 建立記帳明細物件
            ExpenseItem newExpense = new ExpenseItem
            {
                Date = dateTimePicker1.Value.Date,
                Payer = comboBox1.SelectedItem.ToString(),
                ItemName = txtItemName.Text.Trim(),
                Currency = cboCurrency.SelectedItem.ToString(),
                OriginalAmount = amount,
                ExchangeRate = exchangeRate,
                TwdAmount = twdTotal,
                SplitMembers = splitList
            };

            // 寫入全域變數並更新表格
            SessionManager.CurrentTrip.Expenses.Add(newExpense);
            RefreshDataGridView();

            // 清空輸入框，等待下一筆輸入
            txtItemName.Clear();
            txtAmount.Clear();
            // 匯率不特別清空，因為同一天通常匯率一樣，保留著讓主辦人連續輸入比較方便
        }
        
        // 刷新 DataGridView
        private void RefreshDataGridView()
        {
            dgvExpenseList.Rows.Clear();

            // 依照日期排序顯示
            var sortedExpenses = SessionManager.CurrentTrip.Expenses.OrderBy(e => e.Date).ToList();

            foreach (var exp in sortedExpenses)
            {
                // 依序填入：日期、付款人、消費項目、幣別、外幣金額、台幣總額
                // 請確認這裡加入的順序與你 dgvExpenseList 設定的 Columns 順序一致！
                dgvExpenseList.Rows.Add(
                    exp.Date.ToString("MM/dd"),
                    exp.Payer,
                    exp.ItemName,
                    exp.Currency,
                    exp.OriginalAmount.ToString("N0"), // N0 會加上千位數逗號，例如 50,000
                    exp.TwdAmount.ToString("N0")
                );
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
