namespace TripSchedule
{
    partial class TaskItemControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.chkIsDone = new System.Windows.Forms.CheckBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.txtTaskNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkIsDone
            // 
            this.chkIsDone.AutoSize = true;
            this.chkIsDone.Location = new System.Drawing.Point(14, 23);
            this.chkIsDone.Name = "chkIsDone";
            this.chkIsDone.Size = new System.Drawing.Size(22, 21);
            this.chkIsDone.TabIndex = 0;
            this.chkIsDone.UseVisualStyleBackColor = true;
            this.chkIsDone.CheckedChanged += new System.EventHandler(this.chkIsDone_CheckedChanged);
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTaskName.Location = new System.Drawing.Point(42, 23);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(82, 23);
            this.lblTaskName.TabIndex = 1;
            this.lblTaskName.Text = "任務名稱";
            this.lblTaskName.Click += new System.EventHandler(this.lblTaskName_Click);
            // 
            // txtTaskNote
            // 
            this.txtTaskNote.Location = new System.Drawing.Point(130, 20);
            this.txtTaskNote.Multiline = true;
            this.txtTaskNote.Name = "txtTaskNote";
            this.txtTaskNote.Size = new System.Drawing.Size(100, 29);
            this.txtTaskNote.TabIndex = 2;
            this.txtTaskNote.Visible = false;
            this.txtTaskNote.TextChanged += new System.EventHandler(this.txtTaskNote_TextChanged);
            // 
            // TaskItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTaskNote);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.chkIsDone);
            this.Name = "TaskItemControl";
            this.Size = new System.Drawing.Size(281, 285);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkIsDone;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.TextBox txtTaskNote;
    }
}
