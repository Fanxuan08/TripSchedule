namespace TripSchedule
{
    partial class Frm_Expense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvExpenseList = new System.Windows.Forms.DataGridView();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpNewExpanse = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.clbMembers = new System.Windows.Forms.CheckedListBox();
            this.rdoSplitCustom = new System.Windows.Forms.RadioButton();
            this.rdoSplitEqual = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.lblExchangeRate = new System.Windows.Forms.Label();
            this.cboCurrency = new System.Windows.Forms.ComboBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPayer = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseList)).BeginInit();
            this.grpNewExpanse.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExpenseList
            // 
            this.dgvExpenseList.AllowUserToAddRows = false;
            this.dgvExpenseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenseList.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpenseList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpenseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDate,
            this.ColPayer,
            this.ColItem,
            this.ColCurrency,
            this.ColMoney,
            this.ColTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenseList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpenseList.EnableHeadersVisualStyles = false;
            this.dgvExpenseList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvExpenseList.Location = new System.Drawing.Point(12, 12);
            this.dgvExpenseList.Name = "dgvExpenseList";
            this.dgvExpenseList.RowHeadersWidth = 62;
            this.dgvExpenseList.RowTemplate.Height = 31;
            this.dgvExpenseList.Size = new System.Drawing.Size(1022, 411);
            this.dgvExpenseList.TabIndex = 0;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "消費日期";
            this.ColDate.MinimumWidth = 8;
            this.ColDate.Name = "ColDate";
            // 
            // ColPayer
            // 
            this.ColPayer.HeaderText = "付款人";
            this.ColPayer.MinimumWidth = 8;
            this.ColPayer.Name = "ColPayer";
            // 
            // ColItem
            // 
            this.ColItem.HeaderText = "消費項目";
            this.ColItem.MinimumWidth = 8;
            this.ColItem.Name = "ColItem";
            // 
            // ColCurrency
            // 
            this.ColCurrency.HeaderText = "幣別";
            this.ColCurrency.MinimumWidth = 8;
            this.ColCurrency.Name = "ColCurrency";
            // 
            // ColMoney
            // 
            this.ColMoney.HeaderText = "外幣金額";
            this.ColMoney.MinimumWidth = 8;
            this.ColMoney.Name = "ColMoney";
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "台幣總額";
            this.ColTotal.MinimumWidth = 8;
            this.ColTotal.Name = "ColTotal";
            // 
            // grpNewExpanse
            // 
            this.grpNewExpanse.Controls.Add(this.btnClose);
            this.grpNewExpanse.Controls.Add(this.btnAddExpense);
            this.grpNewExpanse.Controls.Add(this.clbMembers);
            this.grpNewExpanse.Controls.Add(this.rdoSplitCustom);
            this.grpNewExpanse.Controls.Add(this.rdoSplitEqual);
            this.grpNewExpanse.Controls.Add(this.txtAmount);
            this.grpNewExpanse.Controls.Add(this.lblAmount);
            this.grpNewExpanse.Controls.Add(this.txtExchangeRate);
            this.grpNewExpanse.Controls.Add(this.lblExchangeRate);
            this.grpNewExpanse.Controls.Add(this.cboCurrency);
            this.grpNewExpanse.Controls.Add(this.lblCurrency);
            this.grpNewExpanse.Controls.Add(this.txtItemName);
            this.grpNewExpanse.Controls.Add(this.lblItemName);
            this.grpNewExpanse.Controls.Add(this.comboBox1);
            this.grpNewExpanse.Controls.Add(this.lblPayer);
            this.grpNewExpanse.Controls.Add(this.lblStartTime);
            this.grpNewExpanse.Controls.Add(this.dateTimePicker1);
            this.grpNewExpanse.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpNewExpanse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.grpNewExpanse.Location = new System.Drawing.Point(12, 438);
            this.grpNewExpanse.Name = "grpNewExpanse";
            this.grpNewExpanse.Size = new System.Drawing.Size(1022, 263);
            this.grpNewExpanse.TabIndex = 1;
            this.grpNewExpanse.TabStop = false;
            this.grpNewExpanse.Text = "新增記帳";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(163)))));
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(26, 188);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 46);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "返回主選單";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            this.btnAddExpense.ForeColor = System.Drawing.Color.White;
            this.btnAddExpense.Location = new System.Drawing.Point(226, 188);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(130, 47);
            this.btnAddExpense.TabIndex = 16;
            this.btnAddExpense.Text = "確認記帳";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // clbMembers
            // 
            this.clbMembers.Enabled = false;
            this.clbMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.clbMembers.FormattingEnabled = true;
            this.clbMembers.Location = new System.Drawing.Point(616, 137);
            this.clbMembers.Name = "clbMembers";
            this.clbMembers.Size = new System.Drawing.Size(384, 97);
            this.clbMembers.TabIndex = 15;
            // 
            // rdoSplitCustom
            // 
            this.rdoSplitCustom.AutoSize = true;
            this.rdoSplitCustom.Location = new System.Drawing.Point(759, 87);
            this.rdoSplitCustom.Name = "rdoSplitCustom";
            this.rdoSplitCustom.Size = new System.Drawing.Size(117, 29);
            this.rdoSplitCustom.TabIndex = 14;
            this.rdoSplitCustom.Text = "自訂分攤";
            this.rdoSplitCustom.UseVisualStyleBackColor = true;
            this.rdoSplitCustom.CheckedChanged += new System.EventHandler(this.rdoSplitCustom_CheckedChanged);
            // 
            // rdoSplitEqual
            // 
            this.rdoSplitEqual.AutoSize = true;
            this.rdoSplitEqual.Checked = true;
            this.rdoSplitEqual.Location = new System.Drawing.Point(616, 87);
            this.rdoSplitEqual.Name = "rdoSplitEqual";
            this.rdoSplitEqual.Size = new System.Drawing.Size(117, 29);
            this.rdoSplitEqual.TabIndex = 13;
            this.rdoSplitEqual.TabStop = true;
            this.rdoSplitEqual.Text = "全體平分";
            this.rdoSplitEqual.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.txtAmount.Location = new System.Drawing.Point(494, 82);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(105, 34);
            this.txtAmount.TabIndex = 12;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAmount.Location = new System.Drawing.Point(424, 86);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(64, 23);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "金額：";
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.txtExchangeRate.Location = new System.Drawing.Point(328, 82);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(90, 34);
            this.txtExchangeRate.TabIndex = 10;
            // 
            // lblExchangeRate
            // 
            this.lblExchangeRate.AutoSize = true;
            this.lblExchangeRate.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblExchangeRate.Location = new System.Drawing.Point(258, 86);
            this.lblExchangeRate.Name = "lblExchangeRate";
            this.lblExchangeRate.Size = new System.Drawing.Size(64, 23);
            this.lblExchangeRate.TabIndex = 9;
            this.lblExchangeRate.Text = "匯率：";
            // 
            // cboCurrency
            // 
            this.cboCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.Items.AddRange(new object[] {
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
            this.cboCurrency.Location = new System.Drawing.Point(92, 83);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(155, 33);
            this.cboCurrency.TabIndex = 8;
            this.cboCurrency.SelectedIndexChanged += new System.EventHandler(this.cboCurrency_SelectedIndexChanged);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCurrency.Location = new System.Drawing.Point(22, 88);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(64, 23);
            this.lblCurrency.TabIndex = 7;
            this.lblCurrency.Text = "幣別：";
            // 
            // txtItemName
            // 
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.txtItemName.Location = new System.Drawing.Point(688, 33);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(215, 34);
            this.txtItemName.TabIndex = 6;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblItemName.Location = new System.Drawing.Point(582, 38);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(100, 23);
            this.lblItemName.TabIndex = 5;
            this.lblItemName.Text = "消費項目：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(385, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // lblPayer
            // 
            this.lblPayer.AutoSize = true;
            this.lblPayer.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPayer.Location = new System.Drawing.Point(297, 38);
            this.lblPayer.Name = "lblPayer";
            this.lblPayer.Size = new System.Drawing.Size(82, 23);
            this.lblPayer.TabIndex = 3;
            this.lblPayer.Text = "付款人：";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStartTime.Location = new System.Drawing.Point(22, 38);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(100, 23);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "開始時間：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 34);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Frm_Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1053, 734);
            this.Controls.Add(this.grpNewExpanse);
            this.Controls.Add(this.dgvExpenseList);
            this.Name = "Frm_Expense";
            this.Text = "Frm_Expense";
            this.Load += new System.EventHandler(this.Frm_Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseList)).EndInit();
            this.grpNewExpanse.ResumeLayout(false);
            this.grpNewExpanse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExpenseList;
        private System.Windows.Forms.GroupBox grpNewExpanse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.Label lblExchangeRate;
        private System.Windows.Forms.ComboBox cboCurrency;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPayer;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.CheckedListBox clbMembers;
        private System.Windows.Forms.RadioButton rdoSplitCustom;
        private System.Windows.Forms.RadioButton rdoSplitEqual;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnClose;
    }
}