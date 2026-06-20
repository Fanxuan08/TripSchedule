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
    public partial class Frm_Planner_P : Form
    {
        public Frm_Planner_P()
        {
            InitializeComponent();
        }

        private void Frm_Planner_P_Load(object sender, EventArgs e)
        {
            if (SessionManager.CurrentTrip == null) return;

            int totalDays = (SessionManager.CurrentTrip.EndDate - SessionManager.CurrentTrip.StartDate).Days + 1;
            DateTime startDate = SessionManager.CurrentTrip.StartDate;

            cboDaySelector.Items.Clear();
            for (int i = 1; i <= totalDays; i++)
            {
                DateTime currentDate = startDate.AddDays(i - 1);
                cboDaySelector.Items.Add($"Day {i} ({currentDate:MM/dd})");
            }

            if (cboDaySelector.Items.Count > 0)
            {
                cboDaySelector.SelectedIndex = 0;
            }
        }

        // 更新面板內容
        private void cboDaySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDaySelector.SelectedItem == null) return;
            string currentDay = cboDaySelector.SelectedItem.ToString();

            // 讀取這天是否有設定「區域目標」(P人定錨點)
            var dayTasks = SessionManager.CurrentTrip.Schedules.Where(s => s.Day == currentDay).ToList();
            var firstTask = dayTasks.FirstOrDefault(s => !string.IsNullOrEmpty(s.AreaName));
            txtAreaName.Text = firstTask != null ? firstTask.AreaName : "";

            // 清空三個面板
            flpMorning.Controls.Clear();
            flpNoon.Controls.Clear();
            flpNight.Controls.Clear();

            // 依序生出卡片並塞入對應面板
            foreach (var task in dayTasks)
            {
                TaskItemControl card = new TaskItemControl();
                card.Setup(task);

                if (task.TimePeriod == "Morning") flpMorning.Controls.Add(card);
                else if (task.TimePeriod == "Noon") flpNoon.Controls.Add(card);
                else if (task.TimePeriod == "Night") flpNight.Controls.Add(card);
            }
        }
        private void AddNewTask(string timePeriod, TextBox inputTextBox)
        {
            if (cboDaySelector.SelectedItem == null) return;

            string taskName = inputTextBox.Text.Trim();
            if (string.IsNullOrEmpty(taskName)) return;

            string currentDay = cboDaySelector.SelectedItem.ToString();
            string currentArea = txtAreaName.Text.Trim();

            // 建立新資料
            ScheduleItem newItem = new ScheduleItem
            {
                Day = currentDay,
                AreaName = currentArea,
                TimePeriod = timePeriod,
                ActivityName = taskName,
                IsDone = false,
                Notes = ""
            };

            // 寫入全域變數
            SessionManager.CurrentTrip.Schedules.Add(newItem);

            // 動態生出 UI 卡片
            TaskItemControl newCard = new TaskItemControl();
            newCard.Setup(newItem);

            if (timePeriod == "Morning") flpMorning.Controls.Add(newCard);
            else if (timePeriod == "Noon") flpNoon.Controls.Add(newCard);
            else if (timePeriod == "Night") flpNight.Controls.Add(newCard);

            // 清空輸入框
            inputTextBox.Clear();
        }

        // 綁定早上的輸入 (按鈕與 Enter 鍵)
        private void btnNewTask_Morning_Click(object sender, EventArgs e) => AddNewTask("Morning", txtNewTask_Morning);
        private void txtNewTask_Morning_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; AddNewTask("Morning", txtNewTask_Morning); }
        }

        // 綁定中午的輸入 (按鈕與 Enter 鍵)
        private void btnNewTask_Noon_Click(object sender, EventArgs e) => AddNewTask("Noon", txtNewTask_Noon);
        private void txtNewTask_Noon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; AddNewTask("Noon", txtNewTask_Noon); }
        }

        // 綁定晚上的輸入 (按鈕與 Enter 鍵)
        private void btnNewTask_Night_Click(object sender, EventArgs e) => AddNewTask("Night", txtNewTask_Night);
        private void txtNewTask_Night_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; AddNewTask("Night", txtNewTask_Night); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}