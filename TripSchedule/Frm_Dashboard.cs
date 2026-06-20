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
    public partial class Frm_Dashboard : Form
    {
        public Frm_Dashboard()
        {
            InitializeComponent();
        }

        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {
            // 顯示旅程名稱
            if (SessionManager.CurrentTrip != null)
            {
                lblTripTitle.Text = SessionManager.CurrentTrip.TripName;

                // 動態生成身分選單 (加入主辦人與所有成員)
                cboRole.Items.Clear();
                foreach (string member in SessionManager.CurrentTrip.Members)
                {
                    cboRole.Items.Add(member);
                }

                // 將下拉選單預設為目前登入的身分 (通常剛建立完是 "主辦人")
                cboRole.SelectedItem = SessionManager.CurrentUserRole;
            }
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRole.SelectedItem != null)
            {
                // 更新全域身分
                SessionManager.CurrentUserRole = cboRole.SelectedItem.ToString();

                // 權限控管展示：如果是同行者，不允許點擊「儲存檔案」按鈕
                bool isAdmin = (SessionManager.CurrentUserRole == "主辦人");
                btnSaveAll.Enabled = isAdmin;

                // (註：其他「開始行程規劃」、「開始記帳」的按鈕仍保持開啟，
                // 因為同行者需要點進去「瀏覽」唯讀畫面，我們會在那些子表單內部做編輯功能的鎖定。)
            }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            SessionManager.SaveToFile();
            MessageBox.Show("旅程資料已成功儲存至 JSON 檔案！", "儲存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpenPlanner_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentTrip == null) return;

            // 根據建立旅程時選擇的模式，動態決定要開哪一個表單
            if (SessionManager.CurrentTrip.PlanMode == "P")
            {
                Frm_Planner_P plannerP = new Frm_Planner_P();
                plannerP.ShowDialog();
            }
            else
            {
                Frm_Planner_J plannerJ = new Frm_Planner_J();
                plannerJ.ShowDialog();
            }
        }

        private void btnOpenExpense_Click(object sender, EventArgs e)
        {
            Frm_Expense expenseForm = new Frm_Expense();
            expenseForm.ShowDialog();
        }

        private void btnOpenSettlement_Click(object sender, EventArgs e)
        {
            Frm_Settlement settlementForm = new Frm_Settlement();
            settlementForm.ShowDialog();
        }
    }
}
