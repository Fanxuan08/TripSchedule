using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq; // 資料篩選與排序

namespace TripSchedule
{
    public partial class Frm_Planner_J : Form
    {
        public Frm_Planner_J()
        {
            InitializeComponent();
        }

        private void Frm_Planner_J_Load(object sender, EventArgs e)
        {
            if (SessionManager.CurrentTrip == null) return;

            // 計算出發到回程的總天數
            int totalDays = (SessionManager.CurrentTrip.EndDate - SessionManager.CurrentTrip.StartDate).Days + 1;

            // 取得這趟旅程的出發日
            DateTime startDate = SessionManager.CurrentTrip.StartDate;

            cboDaySelector.Items.Clear();
            for (int i = 1; i <= totalDays; i++)
            {
                // 用出發日加上 (i - 1) 天，精準算出每一天的日期
                DateTime currentDate = startDate.AddDays(i - 1);

                // 將字串格式化，例如：Day 1 (02/05)
                cboDaySelector.Items.Add($"Day {i} ({currentDate:MM/dd})");
            }

            // 預設選擇第一天
            if (cboDaySelector.Items.Count > 0)
            {
                cboDaySelector.SelectedIndex = 0;
            }
        }

        private void cboDaySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        // 把全域變數裡的資料抓出來，填入 DataGridView
        private void RefreshDataGridView()
        {
            if (cboDaySelector.SelectedItem == null) return;
            string currentDay = cboDaySelector.SelectedItem.ToString();

            dgvSchedule.Rows.Clear(); // 清空目前畫面上的表格

            // 使用 LINQ 篩選出「屬於今天」的行程，並依照「開始時間」排序
            var dailySchedules = SessionManager.CurrentTrip.Schedules
                .Where(s => s.Day == currentDay)
                .OrderBy(s => s.StartTime)
                .ToList();

            // 將篩選後的資料一筆一筆倒進表格裡
            foreach (var schedule in dailySchedules)
            {
                // 注意：這裡的放入順序必須跟你設定的 DataGridView 欄位順序完全一樣！
                // 假設依序是：開始、結束、地點、活動、交通、備註
                dgvSchedule.Rows.Add(
                    schedule.StartTime,
                    schedule.EndTime,
                    schedule.Location,
                    schedule.ActivityName,
                    schedule.Transport,
                    schedule.Notes
                );
            }
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            if (cboDaySelector.SelectedItem == null) return;

            string selectedDay = cboDaySelector.SelectedItem.ToString();
            string start = dtpStartTime.Value.ToString("HH:mm");
            string end = dtpEndTime.Value.ToString("HH:mm");
            string activity = txtActivity.Text.Trim();
            string location = txtLocation.Text.Trim();
            string transport = txtTransport.Text.Trim();
            string notes = txtNotes.Text.Trim();

            // 基礎防呆
            if (string.IsNullOrEmpty(activity))
            {
                MessageBox.Show("請輸入活動名稱！", "提示");
                return;
            }
            if (string.Compare(start, end) >= 0) // 字串比對時間大小
            {
                MessageBox.Show("結束時間必須晚於開始時間！", "錯誤");
                return;
            }

            // 防衝堂檢查：只要有任何一個現有行程的時間與新行程重疊，就會抓出來
            // 邏輯：新行程的開始時間 < 舊行程的結束時間 且 新行程的結束時間 > 舊行程的開始時間
            bool isConflict = SessionManager.CurrentTrip.Schedules.Any(s =>
                s.Day == selectedDay &&
                (string.Compare(start, s.EndTime) < 0 && string.Compare(end, s.StartTime) > 0)
            );

            if (isConflict)
            {
                // 採用「柔性勸導」模式
                DialogResult result = MessageBox.Show(
                    "警告：此行程與既有行程時間重疊！\n確定要硬塞進去嗎？",
                    "時間衝突",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No) return;
            }

            // 建立新的行程物件
            ScheduleItem newItem = new ScheduleItem
            {
                Day = selectedDay,
                StartTime = start,
                EndTime = end,
                ActivityName = activity,
                Location = location,
                Transport = transport,
                Notes = notes
            };

            // 寫入全域變數的 List 中
            SessionManager.CurrentTrip.Schedules.Add(newItem);

            // 重新刷新表格畫面
            RefreshDataGridView();

            // 清空輸入框，方便連續輸入下一個行程
            txtActivity.Clear();
            txtLocation.Clear();
            txtTransport.Clear();
            txtNotes.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
