namespace RFDeviceAPP
{
    partial class FrmRTRSku1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.receiptkeyText = new RFDeviceAPP.Common.rfTextBox();
            this.receiptkeyLab = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // receiptkeyText
            // 
            this.receiptkeyText.Location = new System.Drawing.Point(4, 81);
            this.receiptkeyText.Name = "receiptkeyText";
            this.receiptkeyText.Size = new System.Drawing.Size(231, 23);
            this.receiptkeyText.TabIndex = 2;
            this.receiptkeyText.LostFocus += new System.EventHandler(this.receiptkeyText_LostFocus);
            // 
            // receiptkeyLab
            // 
            this.receiptkeyLab.Location = new System.Drawing.Point(4, 56);
            this.receiptkeyLab.Name = "receiptkeyLab";
            this.receiptkeyLab.Size = new System.Drawing.Size(100, 20);
            this.receiptkeyLab.Text = "收货单号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "提交";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRTRSku1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 389);
            this.Controls.Add(this.receiptkeyLab);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.receiptkeyText);
            this.Name = "FrmRTRSku1";
            this.Text = "分料";
            this.Controls.SetChildIndex(this.receiptkeyText, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.receiptkeyLab, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfTextBox receiptkeyText;
        private System.Windows.Forms.Label receiptkeyLab;
        private System.Windows.Forms.Button button1;
    }
}