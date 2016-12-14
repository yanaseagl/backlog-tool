namespace backlogToolMain
{
    partial class ticketForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.getStartBtn = new System.Windows.Forms.Button();
            this.ticketArea = new System.Windows.Forms.Panel();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.ticketArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // getStartBtn
            // 
            this.getStartBtn.Location = new System.Drawing.Point(12, 12);
            this.getStartBtn.Name = "getStartBtn";
            this.getStartBtn.Size = new System.Drawing.Size(75, 23);
            this.getStartBtn.TabIndex = 0;
            this.getStartBtn.Text = "チケット取得";
            this.getStartBtn.UseVisualStyleBackColor = true;
            this.getStartBtn.Click += new System.EventHandler(this.getStartBtn_Click);
            // 
            // ticketArea
            // 
            this.ticketArea.Controls.Add(this.ticketLabel);
            this.ticketArea.Location = new System.Drawing.Point(12, 41);
            this.ticketArea.Name = "ticketArea";
            this.ticketArea.Size = new System.Drawing.Size(641, 469);
            this.ticketArea.TabIndex = 1;
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Location = new System.Drawing.Point(3, 15);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(35, 12);
            this.ticketLabel.TabIndex = 0;
            this.ticketLabel.Text = "label1";
            // 
            // ticketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 522);
            this.Controls.Add(this.ticketArea);
            this.Controls.Add(this.getStartBtn);
            this.Name = "ticketForm";
            this.Text = "チケット画面";
            this.ticketArea.ResumeLayout(false);
            this.ticketArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getStartBtn;
        private System.Windows.Forms.Panel ticketArea;
        private System.Windows.Forms.Label ticketLabel;
    }
}

