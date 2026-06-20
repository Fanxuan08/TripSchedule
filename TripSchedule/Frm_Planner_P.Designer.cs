namespace TripSchedule
{
    partial class Frm_Planner_P
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
            this.cboDaySelector = new System.Windows.Forms.ComboBox();
            this.lblDaySelector = new System.Windows.Forms.Label();
            this.lblAreaName = new System.Windows.Forms.Label();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.lblMorning = new System.Windows.Forms.Label();
            this.flpMorning = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNewTask_Morning = new System.Windows.Forms.TextBox();
            this.btnNewTask_Morning = new System.Windows.Forms.Button();
            this.btnNewTask_Noon = new System.Windows.Forms.Button();
            this.txtNewTask_Noon = new System.Windows.Forms.TextBox();
            this.flpNoon = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoon = new System.Windows.Forms.Label();
            this.btnNewTask_Night = new System.Windows.Forms.Button();
            this.txtNewTask_Night = new System.Windows.Forms.TextBox();
            this.flpNight = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNight = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboDaySelector
            // 
            this.cboDaySelector.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboDaySelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.cboDaySelector.FormattingEnabled = true;
            this.cboDaySelector.Location = new System.Drawing.Point(132, 30);
            this.cboDaySelector.Name = "cboDaySelector";
            this.cboDaySelector.Size = new System.Drawing.Size(160, 33);
            this.cboDaySelector.TabIndex = 0;
            this.cboDaySelector.SelectedIndexChanged += new System.EventHandler(this.cboDaySelector_SelectedIndexChanged);
            // 
            // lblDaySelector
            // 
            this.lblDaySelector.AutoSize = true;
            this.lblDaySelector.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDaySelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.lblDaySelector.Location = new System.Drawing.Point(14, 33);
            this.lblDaySelector.Name = "lblDaySelector";
            this.lblDaySelector.Size = new System.Drawing.Size(112, 25);
            this.lblDaySelector.TabIndex = 1;
            this.lblDaySelector.Text = "選擇天數：";
            // 
            // lblAreaName
            // 
            this.lblAreaName.AutoSize = true;
            this.lblAreaName.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAreaName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.lblAreaName.Location = new System.Drawing.Point(320, 33);
            this.lblAreaName.Name = "lblAreaName";
            this.lblAreaName.Size = new System.Drawing.Size(152, 25);
            this.lblAreaName.TabIndex = 2;
            this.lblAreaName.Text = "今日目標區域：";
            // 
            // txtAreaName
            // 
            this.txtAreaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAreaName.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAreaName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.txtAreaName.Location = new System.Drawing.Point(478, 31);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(221, 34);
            this.txtAreaName.TabIndex = 3;
            // 
            // lblMorning
            // 
            this.lblMorning.AutoSize = true;
            this.lblMorning.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMorning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.lblMorning.Location = new System.Drawing.Point(17, 77);
            this.lblMorning.Name = "lblMorning";
            this.lblMorning.Size = new System.Drawing.Size(62, 31);
            this.lblMorning.TabIndex = 0;
            this.lblMorning.Text = "早上";
            // 
            // flpMorning
            // 
            this.flpMorning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.flpMorning.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flpMorning.Location = new System.Drawing.Point(19, 111);
            this.flpMorning.Name = "flpMorning";
            this.flpMorning.Size = new System.Drawing.Size(331, 475);
            this.flpMorning.TabIndex = 4;
            // 
            // txtNewTask_Morning
            // 
            this.txtNewTask_Morning.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNewTask_Morning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.txtNewTask_Morning.Location = new System.Drawing.Point(101, 605);
            this.txtNewTask_Morning.Multiline = true;
            this.txtNewTask_Morning.Name = "txtNewTask_Morning";
            this.txtNewTask_Morning.Size = new System.Drawing.Size(245, 96);
            this.txtNewTask_Morning.TabIndex = 5;
            this.txtNewTask_Morning.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewTask_Morning_KeyDown);
            // 
            // btnNewTask_Morning
            // 
            this.btnNewTask_Morning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            this.btnNewTask_Morning.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewTask_Morning.ForeColor = System.Drawing.Color.White;
            this.btnNewTask_Morning.Location = new System.Drawing.Point(23, 605);
            this.btnNewTask_Morning.Name = "btnNewTask_Morning";
            this.btnNewTask_Morning.Size = new System.Drawing.Size(65, 96);
            this.btnNewTask_Morning.TabIndex = 6;
            this.btnNewTask_Morning.Text = "新增";
            this.btnNewTask_Morning.UseVisualStyleBackColor = false;
            this.btnNewTask_Morning.Click += new System.EventHandler(this.btnNewTask_Morning_Click);
            // 
            // btnNewTask_Noon
            // 
            this.btnNewTask_Noon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            this.btnNewTask_Noon.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewTask_Noon.ForeColor = System.Drawing.Color.White;
            this.btnNewTask_Noon.Location = new System.Drawing.Point(365, 605);
            this.btnNewTask_Noon.Name = "btnNewTask_Noon";
            this.btnNewTask_Noon.Size = new System.Drawing.Size(65, 96);
            this.btnNewTask_Noon.TabIndex = 9;
            this.btnNewTask_Noon.Text = "新增";
            this.btnNewTask_Noon.UseVisualStyleBackColor = false;
            this.btnNewTask_Noon.Click += new System.EventHandler(this.btnNewTask_Noon_Click);
            // 
            // txtNewTask_Noon
            // 
            this.txtNewTask_Noon.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNewTask_Noon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.txtNewTask_Noon.Location = new System.Drawing.Point(443, 605);
            this.txtNewTask_Noon.Multiline = true;
            this.txtNewTask_Noon.Name = "txtNewTask_Noon";
            this.txtNewTask_Noon.Size = new System.Drawing.Size(245, 96);
            this.txtNewTask_Noon.TabIndex = 8;
            this.txtNewTask_Noon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewTask_Noon_KeyDown);
            // 
            // flpNoon
            // 
            this.flpNoon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.flpNoon.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flpNoon.Location = new System.Drawing.Point(361, 111);
            this.flpNoon.Name = "flpNoon";
            this.flpNoon.Size = new System.Drawing.Size(331, 475);
            this.flpNoon.TabIndex = 7;
            // 
            // lblNoon
            // 
            this.lblNoon.AutoSize = true;
            this.lblNoon.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.lblNoon.Location = new System.Drawing.Point(359, 79);
            this.lblNoon.Name = "lblNoon";
            this.lblNoon.Size = new System.Drawing.Size(121, 31);
            this.lblNoon.TabIndex = 0;
            this.lblNoon.Text = "中午/下午";
            // 
            // btnNewTask_Night
            // 
            this.btnNewTask_Night.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            this.btnNewTask_Night.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewTask_Night.ForeColor = System.Drawing.Color.White;
            this.btnNewTask_Night.Location = new System.Drawing.Point(709, 605);
            this.btnNewTask_Night.Name = "btnNewTask_Night";
            this.btnNewTask_Night.Size = new System.Drawing.Size(65, 96);
            this.btnNewTask_Night.TabIndex = 12;
            this.btnNewTask_Night.Text = "新增";
            this.btnNewTask_Night.UseVisualStyleBackColor = false;
            this.btnNewTask_Night.Click += new System.EventHandler(this.btnNewTask_Night_Click);
            // 
            // txtNewTask_Night
            // 
            this.txtNewTask_Night.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNewTask_Night.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.txtNewTask_Night.Location = new System.Drawing.Point(787, 605);
            this.txtNewTask_Night.Multiline = true;
            this.txtNewTask_Night.Name = "txtNewTask_Night";
            this.txtNewTask_Night.Size = new System.Drawing.Size(245, 96);
            this.txtNewTask_Night.TabIndex = 11;
            this.txtNewTask_Night.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewTask_Night_KeyDown);
            // 
            // flpNight
            // 
            this.flpNight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.flpNight.Location = new System.Drawing.Point(705, 111);
            this.flpNight.Name = "flpNight";
            this.flpNight.Size = new System.Drawing.Size(331, 475);
            this.flpNight.TabIndex = 10;
            // 
            // lblNight
            // 
            this.lblNight.AutoSize = true;
            this.lblNight.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.lblNight.Location = new System.Drawing.Point(703, 77);
            this.lblNight.Name = "lblNight";
            this.lblNight.Size = new System.Drawing.Size(62, 31);
            this.lblNight.TabIndex = 0;
            this.lblNight.Text = "晚上";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(163)))));
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(855, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 46);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "完成/返回主選單";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Frm_Planner_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1053, 734);
            this.Controls.Add(this.lblNight);
            this.Controls.Add(this.lblNoon);
            this.Controls.Add(this.lblMorning);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewTask_Night);
            this.Controls.Add(this.txtNewTask_Night);
            this.Controls.Add(this.flpNight);
            this.Controls.Add(this.btnNewTask_Noon);
            this.Controls.Add(this.txtNewTask_Noon);
            this.Controls.Add(this.flpNoon);
            this.Controls.Add(this.btnNewTask_Morning);
            this.Controls.Add(this.txtNewTask_Morning);
            this.Controls.Add(this.flpMorning);
            this.Controls.Add(this.txtAreaName);
            this.Controls.Add(this.lblAreaName);
            this.Controls.Add(this.lblDaySelector);
            this.Controls.Add(this.cboDaySelector);
            this.Name = "Frm_Planner_P";
            this.Text = "Frm_Planner_P";
            this.Load += new System.EventHandler(this.Frm_Planner_P_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDaySelector;
        private System.Windows.Forms.Label lblDaySelector;
        private System.Windows.Forms.Label lblAreaName;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.Label lblMorning;
        private System.Windows.Forms.FlowLayoutPanel flpMorning;
        private System.Windows.Forms.TextBox txtNewTask_Morning;
        private System.Windows.Forms.Button btnNewTask_Morning;
        private System.Windows.Forms.Button btnNewTask_Noon;
        private System.Windows.Forms.TextBox txtNewTask_Noon;
        private System.Windows.Forms.FlowLayoutPanel flpNoon;
        private System.Windows.Forms.Label lblNoon;
        private System.Windows.Forms.Button btnNewTask_Night;
        private System.Windows.Forms.TextBox txtNewTask_Night;
        private System.Windows.Forms.FlowLayoutPanel flpNight;
        private System.Windows.Forms.Label lblNight;
        private System.Windows.Forms.Button btnClose;
    }
}