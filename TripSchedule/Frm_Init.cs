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
    public partial class Frm_Init : Form
    {
        public Frm_Init()
        {
            InitializeComponent();
        }

        private void btnCreateTrip_Click(object sender, EventArgs e)
        {
            Frm_CreateTrip createForm = new Frm_CreateTrip();

            // 如果在新建表單按下確認 (DialogResult.OK)
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                this.Hide(); // 隱藏起始畫面

                Frm_Dashboard dashboard = new Frm_Dashboard();
                dashboard.ShowDialog(); // 開啟主控台

                this.Close(); // 當主控台關閉時，結束整個程式
            }
        }

        private void btnLoadTrip_Click(object sender, EventArgs e)
        {
            // 呼叫寫好的讀取功能
            if (SessionManager.LoadFromFile())
            {
                MessageBox.Show($"成功載入旅程：{SessionManager.CurrentTrip.TripName}！", "系統提示");

                this.Hide();
                Frm_Dashboard dashboard = new Frm_Dashboard();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("找不到存檔紀錄 (TripData.json)，請先建立新旅程。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
