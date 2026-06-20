namespace TripSchedule
{
    partial class Frm_Init
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadTrip = new System.Windows.Forms.Button();
            this.btnCreateTrip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadTrip
            // 
            this.btnLoadTrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            this.btnLoadTrip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLoadTrip.FlatAppearance.BorderSize = 0;
            this.btnLoadTrip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoadTrip.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLoadTrip.ForeColor = System.Drawing.Color.White;
            this.btnLoadTrip.Location = new System.Drawing.Point(129, 163);
            this.btnLoadTrip.Name = "btnLoadTrip";
            this.btnLoadTrip.Size = new System.Drawing.Size(173, 99);
            this.btnLoadTrip.TabIndex = 0;
            this.btnLoadTrip.Text = "載入舊旅程";
            this.btnLoadTrip.UseVisualStyleBackColor = false;
            this.btnLoadTrip.Click += new System.EventHandler(this.btnLoadTrip_Click);
            // 
            // btnCreateTrip
            // 
            this.btnCreateTrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            this.btnCreateTrip.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateTrip.ForeColor = System.Drawing.Color.White;
            this.btnCreateTrip.Location = new System.Drawing.Point(459, 163);
            this.btnCreateTrip.Name = "btnCreateTrip";
            this.btnCreateTrip.Size = new System.Drawing.Size(173, 99);
            this.btnCreateTrip.TabIndex = 1;
            this.btnCreateTrip.Text = "建立新旅程";
            this.btnCreateTrip.UseVisualStyleBackColor = false;
            this.btnCreateTrip.Click += new System.EventHandler(this.btnCreateTrip_Click);
            // 
            // Frm_Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateTrip);
            this.Controls.Add(this.btnLoadTrip);
            this.Name = "Frm_Init";
            this.Text = "Frm_Init";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadTrip;
        private System.Windows.Forms.Button btnCreateTrip;
    }
}

