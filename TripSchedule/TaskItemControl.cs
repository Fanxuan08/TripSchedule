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
    public partial class TaskItemControl : UserControl
    {
        // 記住卡片對應到哪一筆資料
        public ScheduleItem BoundItem { get; private set; }

        public TaskItemControl()
        {
            InitializeComponent();
        }

        // 接收資料並初始化 UI
        public void Setup(ScheduleItem item)
        {
            BoundItem = item;
            chkIsDone.Checked = item.IsDone;
            lblTaskName.Text = item.ActivityName;

            // 判斷備註是否有內容
            if (!string.IsNullOrEmpty(item.Notes))
            {
                txtTaskNote.Text = item.Notes;
                txtTaskNote.Visible = true;
                this.Height = 80; // 展開備註時的高度
            }
            else
            {
                txtTaskNote.Visible = false;
                this.Height = 35; // 隱藏備註時的高度
            }
        }

        private void chkIsDone_CheckedChanged(object sender, EventArgs e)
        {
            if (BoundItem != null)
            {
                BoundItem.IsDone = chkIsDone.Checked; // 即時更新底層資料
            }
        }

        private void lblTaskName_Click(object sender, EventArgs e)
        {
            txtTaskNote.Visible = !txtTaskNote.Visible;
            this.Height = txtTaskNote.Visible ? 80 : 35; // 展開或收合備註框
        }

        private void txtTaskNote_TextChanged(object sender, EventArgs e)
        {
            if (BoundItem != null)
            {
                BoundItem.Notes = txtTaskNote.Text; // 即時更新底層資料
            }
        }
    }
}
