namespace TripSchedule
{
    partial class Frm_CreateTrip
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
            this.txtTripName = new System.Windows.Forms.TextBox();
            this.lblTripName = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cboMainCurrency = new System.Windows.Forms.ComboBox();
            this.lblMainCurrency = new System.Windows.Forms.Label();
            this.rdoModeP = new System.Windows.Forms.RadioButton();
            this.rdoModeJ = new System.Windows.Forms.RadioButton();
            this.txtMembers = new System.Windows.Forms.TextBox();
            this.lblMembers = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTripName
            // 
            this.txtTripName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTripName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTripName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTripName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.txtTripName.Location = new System.Drawing.Point(142, 31);
            this.txtTripName.Name = "txtTripName";
            this.txtTripName.Size = new System.Drawing.Size(247, 31);
            this.txtTripName.TabIndex = 1;
            this.txtTripName.Text = "例：2026東京旅遊";
            this.txtTripName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTripName
            // 
            this.lblTripName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTripName.AutoSize = true;
            this.lblTripName.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTripName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.lblTripName.Location = new System.Drawing.Point(24, 34);
            this.lblTripName.Name = "lblTripName";
            this.lblTripName.Size = new System.Drawing.Size(112, 25);
            this.lblTripName.TabIndex = 1;
            this.lblTripName.Text = "旅程名稱：";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpStartDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.dtpStartDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(163)))));
            this.dtpStartDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.dtpStartDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.dtpStartDate.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStartDate.Location = new System.Drawing.Point(142, 81);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(247, 31);
            this.dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.dtpEndDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(163)))));
            this.dtpEndDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.dtpEndDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.dtpEndDate.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEndDate.Location = new System.Drawing.Point(142, 131);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(247, 31);
            this.dtpEndDate.TabIndex = 3;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.lblStartDate.Location = new System.Drawing.Point(24, 83);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(112, 25);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "開始日期：";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.lblEndDate.Location = new System.Drawing.Point(24, 132);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(112, 25);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "結束日期：";
            // 
            // cboMainCurrency
            // 
            this.cboMainCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMainCurrency.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboMainCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.cboMainCurrency.FormattingEnabled = true;
            this.cboMainCurrency.Items.AddRange(new object[] {
            "USD（美元）",
            "TWD（新台幣）",
            "EUR（歐元）",
            "GBP（英鎊）",
            "JPY（日圓）",
            "KRW（韓元）",
            "CNY（人民幣）",
            "HKD（港幣）",
            "SGD（新加坡幣）",
            "AUD（澳幣）",
            "NZD（紐西蘭幣）",
            "CAD（加拿大幣）",
            "CHF（瑞士法郎）",
            "THB（泰銖）",
            "VND（越南盾）",
            "MYR（馬來西亞令吉）",
            "IDR（印尼盾）",
            "PHP（菲律賓披索）",
            "INR（印度盧比）",
            "AED（阿聯酋迪拉姆）"});
            this.cboMainCurrency.Location = new System.Drawing.Point(142, 181);
            this.cboMainCurrency.Name = "cboMainCurrency";
            this.cboMainCurrency.Size = new System.Drawing.Size(247, 31);
            this.cboMainCurrency.TabIndex = 4;
            // 
            // lblMainCurrency
            // 
            this.lblMainCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMainCurrency.AutoSize = true;
            this.lblMainCurrency.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMainCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.lblMainCurrency.Location = new System.Drawing.Point(24, 182);
            this.lblMainCurrency.Name = "lblMainCurrency";
            this.lblMainCurrency.Size = new System.Drawing.Size(112, 25);
            this.lblMainCurrency.TabIndex = 7;
            this.lblMainCurrency.Text = "結算外幣：";
            // 
            // rdoModeP
            // 
            this.rdoModeP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoModeP.AutoSize = true;
            this.rdoModeP.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoModeP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.rdoModeP.Location = new System.Drawing.Point(29, 232);
            this.rdoModeP.Name = "rdoModeP";
            this.rdoModeP.Size = new System.Drawing.Size(330, 29);
            this.rdoModeP.TabIndex = 5;
            this.rdoModeP.TabStop = true;
            this.rdoModeP.Text = "P人模式（較為輕鬆自由的行程）";
            this.rdoModeP.UseVisualStyleBackColor = true;
            // 
            // rdoModeJ
            // 
            this.rdoModeJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoModeJ.AutoSize = true;
            this.rdoModeJ.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoModeJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.rdoModeJ.Location = new System.Drawing.Point(29, 267);
            this.rdoModeJ.Name = "rdoModeJ";
            this.rdoModeJ.Size = new System.Drawing.Size(325, 29);
            this.rdoModeJ.TabIndex = 6;
            this.rdoModeJ.TabStop = true;
            this.rdoModeJ.Text = "J人模式（較為精細規劃的行程）";
            this.rdoModeJ.UseVisualStyleBackColor = true;
            // 
            // txtMembers
            // 
            this.txtMembers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMembers.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.txtMembers.Location = new System.Drawing.Point(416, 69);
            this.txtMembers.Multiline = true;
            this.txtMembers.Name = "txtMembers";
            this.txtMembers.Size = new System.Drawing.Size(389, 217);
            this.txtMembers.TabIndex = 7;
            // 
            // lblMembers
            // 
            this.lblMembers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMembers.AutoSize = true;
            this.lblMembers.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.lblMembers.Location = new System.Drawing.Point(411, 31);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(346, 25);
            this.lblMembers.TabIndex = 9;
            this.lblMembers.Text = "同行成員名單(名字之間以逗號分隔)：";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(553, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 44);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消返回";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            this.btnConfirm.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(682, 330);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(123, 44);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "確認建立";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Frm_CreateTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(824, 410);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.txtMembers);
            this.Controls.Add(this.rdoModeJ);
            this.Controls.Add(this.rdoModeP);
            this.Controls.Add(this.lblMainCurrency);
            this.Controls.Add(this.cboMainCurrency);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblTripName);
            this.Controls.Add(this.txtTripName);
            this.Name = "Frm_CreateTrip";
            this.Text = "建立新旅程";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTripName;
        private System.Windows.Forms.Label lblTripName;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ComboBox cboMainCurrency;
        private System.Windows.Forms.Label lblMainCurrency;
        private System.Windows.Forms.RadioButton rdoModeP;
        private System.Windows.Forms.RadioButton rdoModeJ;
        private System.Windows.Forms.TextBox txtMembers;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
    }
}