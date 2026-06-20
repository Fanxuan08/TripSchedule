namespace TripSchedule
{
    partial class Frm_Planner_J
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDaySelector = new System.Windows.Forms.Label();
            this.cboDaySelector = new System.Windows.Forms.ComboBox();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.ColStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpNewTask = new System.Windows.Forms.GroupBox();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.lblTransport = new System.Windows.Forms.Label();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.grpNewTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDaySelector
            // 
            this.lblDaySelector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDaySelector.AutoSize = true;
            this.lblDaySelector.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDaySelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.lblDaySelector.Location = new System.Drawing.Point(14, 44);
            this.lblDaySelector.Name = "lblDaySelector";
            this.lblDaySelector.Size = new System.Drawing.Size(112, 25);
            this.lblDaySelector.TabIndex = 3;
            this.lblDaySelector.Text = "選擇天數：";
            // 
            // cboDaySelector
            // 
            this.cboDaySelector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDaySelector.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboDaySelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.cboDaySelector.FormattingEnabled = true;
            this.cboDaySelector.Location = new System.Drawing.Point(132, 41);
            this.cboDaySelector.Name = "cboDaySelector";
            this.cboDaySelector.Size = new System.Drawing.Size(160, 33);
            this.cboDaySelector.TabIndex = 2;
            this.cboDaySelector.SelectedIndexChanged += new System.EventHandler(this.cboDaySelector_SelectedIndexChanged);
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dgvSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStartTime,
            this.ColEndTime,
            this.ColLocation,
            this.ColActivity,
            this.ColTransport,
            this.ColNotes});
            this.dgvSchedule.EnableHeadersVisualStyles = false;
            this.dgvSchedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvSchedule.Location = new System.Drawing.Point(19, 90);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 62;
            this.dgvSchedule.RowTemplate.Height = 31;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(1022, 484);
            this.dgvSchedule.TabIndex = 4;
            // 
            // ColStartTime
            // 
            this.ColStartTime.HeaderText = "開始時間";
            this.ColStartTime.MinimumWidth = 8;
            this.ColStartTime.Name = "ColStartTime";
            // 
            // ColEndTime
            // 
            this.ColEndTime.HeaderText = "結束時間";
            this.ColEndTime.MinimumWidth = 8;
            this.ColEndTime.Name = "ColEndTime";
            // 
            // ColLocation
            // 
            this.ColLocation.HeaderText = "活動地點";
            this.ColLocation.MinimumWidth = 8;
            this.ColLocation.Name = "ColLocation";
            // 
            // ColActivity
            // 
            this.ColActivity.HeaderText = "活動名稱";
            this.ColActivity.MinimumWidth = 8;
            this.ColActivity.Name = "ColActivity";
            // 
            // ColTransport
            // 
            this.ColTransport.HeaderText = "交通方式";
            this.ColTransport.MinimumWidth = 8;
            this.ColTransport.Name = "ColTransport";
            // 
            // ColNotes
            // 
            this.ColNotes.HeaderText = "備註";
            this.ColNotes.MinimumWidth = 8;
            this.ColNotes.Name = "ColNotes";
            // 
            // grpNewTask
            // 
            this.grpNewTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpNewTask.Controls.Add(this.btnAddSchedule);
            this.grpNewTask.Controls.Add(this.txtNotes);
            this.grpNewTask.Controls.Add(this.lblNotes);
            this.grpNewTask.Controls.Add(this.txtTransport);
            this.grpNewTask.Controls.Add(this.lblTransport);
            this.grpNewTask.Controls.Add(this.txtActivity);
            this.grpNewTask.Controls.Add(this.lblActivity);
            this.grpNewTask.Controls.Add(this.txtLocation);
            this.grpNewTask.Controls.Add(this.lblLocation);
            this.grpNewTask.Controls.Add(this.lblEndTime);
            this.grpNewTask.Controls.Add(this.dtpEndTime);
            this.grpNewTask.Controls.Add(this.lblStartTime);
            this.grpNewTask.Controls.Add(this.dtpStartTime);
            this.grpNewTask.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpNewTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.grpNewTask.Location = new System.Drawing.Point(19, 580);
            this.grpNewTask.Name = "grpNewTask";
            this.grpNewTask.Size = new System.Drawing.Size(1022, 132);
            this.grpNewTask.TabIndex = 5;
            this.grpNewTask.TabStop = false;
            this.grpNewTask.Text = "新增行程";
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(834, 82);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(128, 34);
            this.btnAddSchedule.TabIndex = 12;
            this.btnAddSchedule.Text = "新增";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(361, 82);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(423, 34);
            this.txtNotes.TabIndex = 11;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNotes.Location = new System.Drawing.Point(291, 87);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(64, 23);
            this.lblNotes.TabIndex = 10;
            this.lblNotes.Text = "備註：";
            // 
            // txtTransport
            // 
            this.txtTransport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.txtTransport.Location = new System.Drawing.Point(128, 82);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(145, 34);
            this.txtTransport.TabIndex = 9;
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTransport.Location = new System.Drawing.Point(22, 87);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(100, 23);
            this.lblTransport.TabIndex = 8;
            this.lblTransport.Text = "交通方式：";
            // 
            // txtActivity
            // 
            this.txtActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.txtActivity.Location = new System.Drawing.Point(817, 33);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(145, 34);
            this.txtActivity.TabIndex = 7;
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblActivity.Location = new System.Drawing.Point(711, 38);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(100, 23);
            this.lblActivity.TabIndex = 6;
            this.lblActivity.Text = "活動名稱：";
            // 
            // txtLocation
            // 
            this.txtLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.txtLocation.Location = new System.Drawing.Point(548, 33);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(145, 34);
            this.txtLocation.TabIndex = 5;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLocation.Location = new System.Drawing.Point(442, 38);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(100, 23);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "活動地點：";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEndTime.Location = new System.Drawing.Point(232, 38);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(100, 23);
            this.lblEndTime.TabIndex = 3;
            this.lblEndTime.Text = "結束時間：";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CalendarFont = new System.Drawing.Font("微軟正黑體 Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEndTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.dtpEndTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(229)))));
            this.dtpEndTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(163)))));
            this.dtpEndTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.dtpEndTime.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.dtpEndTime.CustomFormat = "HH:mm";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(338, 33);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(84, 34);
            this.dtpEndTime.TabIndex = 2;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStartTime.Location = new System.Drawing.Point(22, 38);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(100, 23);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "開始時間：";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CalendarFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStartTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.dtpStartTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(229)))));
            this.dtpStartTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(163)))));
            this.dtpStartTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.dtpStartTime.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.dtpStartTime.CustomFormat = "HH:mm";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(128, 33);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(84, 34);
            this.dtpStartTime.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(163)))));
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(853, 34);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 46);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "完成/返回主選單";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Frm_Planner_J
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1053, 734);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpNewTask);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.lblDaySelector);
            this.Controls.Add(this.cboDaySelector);
            this.Name = "Frm_Planner_J";
            this.Text = "Frm_Planner_J";
            this.Load += new System.EventHandler(this.Frm_Planner_J_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.grpNewTask.ResumeLayout(false);
            this.grpNewTask.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDaySelector;
        private System.Windows.Forms.ComboBox cboDaySelector;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNotes;
        private System.Windows.Forms.GroupBox grpNewTask;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Button btnClose;
    }
}