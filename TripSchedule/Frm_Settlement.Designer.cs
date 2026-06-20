namespace TripSchedule
{
    partial class Frm_Settlement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpSpent = new System.Windows.Forms.GroupBox();
            this.lblPendingAmount = new System.Windows.Forms.Label();
            this.lblTotalSpent1 = new System.Windows.Forms.Label();
            this.lblCurrentUser1 = new System.Windows.Forms.Label();
            this.lblPendingAmount1 = new System.Windows.Forms.Label();
            this.lblTotalSpent = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.gbxAdmin = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColPayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPayee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.btnExportTxt = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpSpent.SuspendLayout();
            this.gbxAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSpent
            // 
            this.grpSpent.Controls.Add(this.lblPendingAmount);
            this.grpSpent.Controls.Add(this.lblTotalSpent1);
            this.grpSpent.Controls.Add(this.lblCurrentUser1);
            this.grpSpent.Controls.Add(this.lblPendingAmount1);
            this.grpSpent.Controls.Add(this.lblTotalSpent);
            this.grpSpent.Controls.Add(this.lblCurrentUser);
            this.grpSpent.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.grpSpent.Location = new System.Drawing.Point(12, 12);
            this.grpSpent.Name = "grpSpent";
            this.grpSpent.Size = new System.Drawing.Size(670, 200);
            this.grpSpent.TabIndex = 0;
            this.grpSpent.TabStop = false;
            this.grpSpent.Text = "個人帳務概況區";
            // 
            // lblPendingAmount
            // 
            this.lblPendingAmount.AutoSize = true;
            this.lblPendingAmount.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPendingAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.lblPendingAmount.Location = new System.Drawing.Point(300, 142);
            this.lblPendingAmount.Name = "lblPendingAmount";
            this.lblPendingAmount.Size = new System.Drawing.Size(63, 23);
            this.lblPendingAmount.TabIndex = 5;
            this.lblPendingAmount.Text = "label2";
            // 
            // lblTotalSpent1
            // 
            this.lblTotalSpent1.AutoSize = true;
            this.lblTotalSpent1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalSpent1.Location = new System.Drawing.Point(32, 97);
            this.lblTotalSpent1.Name = "lblTotalSpent1";
            this.lblTotalSpent1.Size = new System.Drawing.Size(244, 23);
            this.lblTotalSpent1.TabIndex = 4;
            this.lblTotalSpent1.Text = "這趟旅程你總共參與的花費：";
            // 
            // lblCurrentUser1
            // 
            this.lblCurrentUser1.AutoSize = true;
            this.lblCurrentUser1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCurrentUser1.Location = new System.Drawing.Point(32, 52);
            this.lblCurrentUser1.Name = "lblCurrentUser1";
            this.lblCurrentUser1.Size = new System.Drawing.Size(100, 23);
            this.lblCurrentUser1.TabIndex = 3;
            this.lblCurrentUser1.Text = "目前身份：";
            // 
            // lblPendingAmount1
            // 
            this.lblPendingAmount1.AutoSize = true;
            this.lblPendingAmount1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPendingAmount1.Location = new System.Drawing.Point(32, 142);
            this.lblPendingAmount1.Name = "lblPendingAmount1";
            this.lblPendingAmount1.Size = new System.Drawing.Size(262, 23);
            this.lblPendingAmount1.TabIndex = 2;
            this.lblPendingAmount1.Text = "你目前需轉帳給其他人的總額：";
            // 
            // lblTotalSpent
            // 
            this.lblTotalSpent.AutoSize = true;
            this.lblTotalSpent.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.lblTotalSpent.Location = new System.Drawing.Point(282, 97);
            this.lblTotalSpent.Name = "lblTotalSpent";
            this.lblTotalSpent.Size = new System.Drawing.Size(63, 23);
            this.lblTotalSpent.TabIndex = 1;
            this.lblTotalSpent.Text = "label1";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCurrentUser.Location = new System.Drawing.Point(138, 52);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(63, 23);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "label1";
            // 
            // gbxAdmin
            // 
            this.gbxAdmin.Controls.Add(this.dataGridView1);
            this.gbxAdmin.Controls.Add(this.btnCalculate);
            this.gbxAdmin.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.gbxAdmin.Location = new System.Drawing.Point(13, 218);
            this.gbxAdmin.Name = "gbxAdmin";
            this.gbxAdmin.Size = new System.Drawing.Size(669, 195);
            this.gbxAdmin.TabIndex = 1;
            this.gbxAdmin.TabStop = false;
            this.gbxAdmin.Text = "結算與轉帳建議";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPayer,
            this.ColPayee,
            this.ColTotalAmount});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dataGridView1.Location = new System.Drawing.Point(6, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(577, 146);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColPayer
            // 
            this.ColPayer.HeaderText = "付款方";
            this.ColPayer.MinimumWidth = 8;
            this.ColPayer.Name = "ColPayer";
            // 
            // ColPayee
            // 
            this.ColPayee.HeaderText = "收款方";
            this.ColPayee.MinimumWidth = 8;
            this.ColPayee.Name = "ColPayee";
            // 
            // ColTotalAmount
            // 
            this.ColTotalAmount.HeaderText = "轉帳金額";
            this.ColTotalAmount.MinimumWidth = 8;
            this.ColTotalAmount.Name = "ColTotalAmount";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(589, 137);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(74, 42);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "結算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportCsv);
            this.groupBox1.Controls.Add(this.btnExportTxt);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "檔案匯出";
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Location = new System.Drawing.Point(29, 93);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(247, 34);
            this.btnExportCsv.TabIndex = 1;
            this.btnExportCsv.Text = "匯出對帳明細 (.csv)";
            this.btnExportCsv.UseVisualStyleBackColor = true;
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            // 
            // btnExportTxt
            // 
            this.btnExportTxt.Location = new System.Drawing.Point(29, 43);
            this.btnExportTxt.Name = "btnExportTxt";
            this.btnExportTxt.Size = new System.Drawing.Size(247, 34);
            this.btnExportTxt.TabIndex = 0;
            this.btnExportTxt.Text = "匯出旅遊手冊 (.txt)";
            this.btnExportTxt.UseVisualStyleBackColor = true;
            this.btnExportTxt.Click += new System.EventHandler(this.btnExportTxt_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(163)))));
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(255, 600);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 46);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "完成/返回主選單";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Frm_Settlement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(693, 679);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxAdmin);
            this.Controls.Add(this.grpSpent);
            this.Name = "Frm_Settlement";
            this.Text = "Frm_Settlement";
            this.Load += new System.EventHandler(this.Frm_Settlement_Load);
            this.grpSpent.ResumeLayout(false);
            this.grpSpent.PerformLayout();
            this.gbxAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSpent;
        private System.Windows.Forms.Label lblCurrentUser1;
        private System.Windows.Forms.Label lblPendingAmount1;
        private System.Windows.Forms.Label lblTotalSpent;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblTotalSpent1;
        private System.Windows.Forms.Label lblPendingAmount;
        private System.Windows.Forms.GroupBox gbxAdmin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPayee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Button btnExportTxt;
        private System.Windows.Forms.Button btnClose;
    }
}