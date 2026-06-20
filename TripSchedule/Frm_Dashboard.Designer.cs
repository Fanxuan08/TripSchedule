namespace TripSchedule
{
    partial class Frm_Dashboard
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
            this.lblTripTitle = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnOpenPlanner = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenExpense = new System.Windows.Forms.Button();
            this.btnOpenSettlement = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTripTitle
            // 
            this.lblTripTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTripTitle.AutoSize = true;
            this.lblTripTitle.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTripTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.lblTripTitle.Location = new System.Drawing.Point(22, 25);
            this.lblTripTitle.Name = "lblTripTitle";
            this.lblTripTitle.Size = new System.Drawing.Size(262, 50);
            this.lblTripTitle.TabIndex = 0;
            this.lblTripTitle.Text = "目前旅程名稱";
            // 
            // cboRole
            // 
            this.cboRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboRole.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(656, 35);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(121, 31);
            this.cboRole.TabIndex = 1;
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.cboRole_SelectedIndexChanged);
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.lblRole.Location = new System.Drawing.Point(568, 38);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(82, 23);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "身份權限";
            // 
            // btnOpenPlanner
            // 
            this.btnOpenPlanner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenPlanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            this.btnOpenPlanner.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOpenPlanner.ForeColor = System.Drawing.Color.White;
            this.btnOpenPlanner.Location = new System.Drawing.Point(192, 157);
            this.btnOpenPlanner.Name = "btnOpenPlanner";
            this.btnOpenPlanner.Size = new System.Drawing.Size(156, 48);
            this.btnOpenPlanner.TabIndex = 3;
            this.btnOpenPlanner.Text = "開始行程規劃";
            this.btnOpenPlanner.UseVisualStyleBackColor = false;
            this.btnOpenPlanner.Click += new System.EventHandler(this.btnOpenPlanner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(36, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 4;
            // 
            // btnOpenExpense
            // 
            this.btnOpenExpense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            this.btnOpenExpense.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOpenExpense.ForeColor = System.Drawing.Color.White;
            this.btnOpenExpense.Location = new System.Drawing.Point(445, 157);
            this.btnOpenExpense.Name = "btnOpenExpense";
            this.btnOpenExpense.Size = new System.Drawing.Size(156, 48);
            this.btnOpenExpense.TabIndex = 5;
            this.btnOpenExpense.Text = "開始記帳";
            this.btnOpenExpense.UseVisualStyleBackColor = false;
            this.btnOpenExpense.Click += new System.EventHandler(this.btnOpenExpense_Click);
            // 
            // btnOpenSettlement
            // 
            this.btnOpenSettlement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenSettlement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            this.btnOpenSettlement.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOpenSettlement.ForeColor = System.Drawing.Color.White;
            this.btnOpenSettlement.Location = new System.Drawing.Point(192, 265);
            this.btnOpenSettlement.Name = "btnOpenSettlement";
            this.btnOpenSettlement.Size = new System.Drawing.Size(156, 48);
            this.btnOpenSettlement.TabIndex = 6;
            this.btnOpenSettlement.Text = "分帳結算";
            this.btnOpenSettlement.UseVisualStyleBackColor = false;
            this.btnOpenSettlement.Click += new System.EventHandler(this.btnOpenSettlement_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(163)))));
            this.btnSaveAll.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveAll.ForeColor = System.Drawing.Color.White;
            this.btnSaveAll.Location = new System.Drawing.Point(445, 265);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(156, 48);
            this.btnSaveAll.TabIndex = 7;
            this.btnSaveAll.Text = "儲存檔案";
            this.btnSaveAll.UseVisualStyleBackColor = false;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.btnOpenSettlement);
            this.Controls.Add(this.btnOpenExpense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenPlanner);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.lblTripTitle);
            this.Name = "Frm_Dashboard";
            this.Text = "主頁";
            this.Load += new System.EventHandler(this.Frm_Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTripTitle;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnOpenPlanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenExpense;
        private System.Windows.Forms.Button btnOpenSettlement;
        private System.Windows.Forms.Button btnSaveAll;
    }
}