namespace GPS_TEST
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.title_lb = new System.Windows.Forms.Label();
            this.GPSval_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.title_lb.Location = new System.Drawing.Point(116, 90);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(117, 27);
            this.title_lb.TabIndex = 0;
            this.title_lb.Text = "GPS情報";
            // 
            // GPSval_txt
            // 
            this.GPSval_txt.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GPSval_txt.Location = new System.Drawing.Point(239, 87);
            this.GPSval_txt.Name = "GPSval_txt";
            this.GPSval_txt.Size = new System.Drawing.Size(155, 34);
            this.GPSval_txt.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 215);
            this.Controls.Add(this.GPSval_txt);
            this.Controls.Add(this.title_lb);
            this.Name = "Form1";
            this.Text = "GPSテスト";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.TextBox GPSval_txt;
    }
}

