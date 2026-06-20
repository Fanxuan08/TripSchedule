using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TripSchedule
{
    public partial class Frm_Settlement : Form
    {
        // 儲存每個人的最終結算餘額 (正數代表別人欠他錢，負數代表他欠別人錢)
        private Dictionary<string, decimal> userBalances = new Dictionary<string, decimal>();

        public Frm_Settlement()
        {
            InitializeComponent();
        }

        // 表單載入，計算所有人的餘額，並處理權限顯示
        private void Frm_Settlement_Load(object sender, EventArgs e)
        {
            if (SessionManager.CurrentTrip == null) return;

            string currentUser = SessionManager.CurrentUserRole;
            lblCurrentUser.Text = currentUser;

            // 執行記帳清算邏輯
            CalculateAllBalances();

            // 顯示目前登入者的個人概況
            if (userBalances.ContainsKey(currentUser))
            {
                decimal myBalance = userBalances[currentUser];
                // 這裡簡單計算他「參與分攤」的總金額當作總花費
                decimal myTotalSpent = SessionManager.CurrentTrip.Expenses
                    .Where(exp => exp.SplitMembers.Contains(currentUser))
                    .Sum(exp => exp.TwdAmount / exp.SplitMembers.Count);

                lblTotalSpent.Text = $"{Math.Round(myTotalSpent, 0):N0} TWD";

                if (myBalance > 0)
                    lblPendingAmount.Text = $"應收回款項： {Math.Round(myBalance, 0):N0} TWD";
                else if (myBalance < 0)
                    lblPendingAmount.Text = $"尚欠他人： {Math.Round(Math.Abs(myBalance), 0):N0} TWD";
                else
                    lblPendingAmount.Text = "已結清，無欠款";
            }
        }

        // 計算每個人的淨餘額
        private void CalculateAllBalances()
        {
            userBalances.Clear();
            // 初始化所有成員的餘額為 0
            foreach (string member in SessionManager.CurrentTrip.Members)
            {
                userBalances[member] = 0;
            }

            // 掃描每一筆花費
            foreach (var exp in SessionManager.CurrentTrip.Expenses)
            {
                // 付款人墊了這筆錢，所以他的餘額增加 (別人欠他)
                if (userBalances.ContainsKey(exp.Payer))
                    userBalances[exp.Payer] += exp.TwdAmount;

                // 參與分攤的人，每個人要扣掉應付的份額
                if (exp.SplitMembers.Count > 0)
                {
                    decimal share = exp.TwdAmount / exp.SplitMembers.Count;
                    foreach (string member in exp.SplitMembers)
                    {
                        if (userBalances.ContainsKey(member))
                            userBalances[member] -= share;
                    }
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            // 篩選出債權人(需收款)與債務人(需付款)
            var creditors = userBalances.Where(x => x.Value > 1).OrderByDescending(x => x.Value).ToList();
            var debtors = userBalances.Where(x => x.Value < -1).OrderBy(x => x.Value).ToList();

            int cIndex = 0;
            int dIndex = 0;

            // 當還有債權人和債務人時，互相抵銷
            while (cIndex < creditors.Count && dIndex < debtors.Count)
            {
                var creditor = creditors[cIndex];
                var debtor = debtors[dIndex];

                // 取欠款與收款中，絕對值較小的那個數字來轉帳
                decimal transferAmount = Math.Min(creditor.Value, Math.Abs(debtor.Value));
                transferAmount = Math.Round(transferAmount, 0);

                if (transferAmount > 0)
                {
                    // 加入 DataGridView (付款方, 收款方, 轉帳金額)
                    dataGridView1.Rows.Add(debtor.Key, creditor.Key, $"{transferAmount:N0} TWD");
                }

                // 扣除掉剛剛轉完的金額
                creditors[cIndex] = new KeyValuePair<string, decimal>(creditor.Key, creditor.Value - transferAmount);
                debtors[dIndex] = new KeyValuePair<string, decimal>(debtor.Key, debtor.Value + transferAmount);

                // 如果帳平了，就換下一個
                if (creditors[cIndex].Value < 1) cIndex++;
                if (Math.Abs(debtors[dIndex].Value) < 1) dIndex++;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("目前所有人的帳務都已結清，無需轉帳！", "結算結果");
            }
        }

        private void btnExportTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.FileName = $"{SessionManager.CurrentTrip.TripName}_行程手冊.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"====== {SessionManager.CurrentTrip.TripName} 行程手冊 ======");
                sb.AppendLine($"日期：{SessionManager.CurrentTrip.StartDate:yyyy/MM/dd} ~ {SessionManager.CurrentTrip.EndDate:yyyy/MM/dd}");
                sb.AppendLine("==========================================\n");

                // 將行程依日期排序匯出
                var groupedSchedules = SessionManager.CurrentTrip.Schedules.GroupBy(s => s.Day).OrderBy(g => g.Key);
                foreach (var dayGroup in groupedSchedules)
                {
                    sb.AppendLine($"【 {dayGroup.Key} 】");
                    foreach (var s in dayGroup.OrderBy(x => x.StartTime))
                    {
                        if (SessionManager.CurrentTrip.PlanMode == "J")
                            sb.AppendLine($"  {s.StartTime}-{s.EndTime} | {s.ActivityName} @ {s.Location} ({s.Transport})");
                        else
                            sb.AppendLine($"  [{s.TimePeriod}] {s.ActivityName} - {s.Notes}");
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(saveFileDialog.FileName, sb.ToString());
                MessageBox.Show("行程手冊匯出成功！", "提示");
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.FileName = $"{SessionManager.CurrentTrip.TripName}_帳目明細.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                // 寫入 CSV 標題列 (需處理亂碼問題，加入 UTF8 BOM)
                sb.AppendLine("日期,付款人,消費項目,外幣幣別,外幣金額,台幣總額,參與分攤成員");

                foreach (var exp in SessionManager.CurrentTrip.Expenses.OrderBy(x => x.Date))
                {
                    string members = string.Join("/", exp.SplitMembers);
                    sb.AppendLine($"{exp.Date:MM/dd},{exp.Payer},{exp.ItemName},{exp.Currency},{exp.OriginalAmount},{exp.TwdAmount},{members}");
                }

                File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("對帳明細匯出成功！", "提示");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
