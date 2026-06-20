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
    public partial class Frm_CreateTrip : Form
    {
        public Frm_CreateTrip()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // 基礎防呆檢查
            if (string.IsNullOrWhiteSpace(txtTripName.Text))
            {
                MessageBox.Show("請輸入旅程名稱！", "提示");
                return;
            }

            // 建立全新的 Trip 物件並塞入資料
            Trip newTrip = new Trip();
            newTrip.TripName = txtTripName.Text.Trim();
            newTrip.StartDate = dtpStartDate.Value.Date;
            newTrip.EndDate = dtpEndDate.Value.Date;
            newTrip.MainCurrency = cboMainCurrency.Text; // 例如 KRW

            // 判斷選了哪一個模式
            newTrip.PlanMode = rdoModeP.Checked ? "P" : "J";

            // 處理成員名單 (用逗號切割字串)
            string membersText = txtMembers.Text.Trim();
            if (!string.IsNullOrEmpty(membersText))
            {
                // 將 "小明, 小華" 切割成陣列並加入 List
                string[] memberArray = membersText.Split(new char[] { ',', '，' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string m in memberArray)
                {
                    newTrip.Members.Add(m.Trim()); // Trim() 可以去掉多餘的空白
                }
            }

            // 預設將主辦人自己也加入名單中 (如果沒打的話)
            if (!newTrip.Members.Contains("主辦人"))
            {
                newTrip.Members.Insert(0, "主辦人");
            }

            // 3. 存入全域變數，並設定當前身分為主辦人
            SessionManager.CurrentTrip = newTrip;
            SessionManager.CurrentUserRole = "主辦人";

            // 4. 設定回傳狀態並自動關閉表單
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
