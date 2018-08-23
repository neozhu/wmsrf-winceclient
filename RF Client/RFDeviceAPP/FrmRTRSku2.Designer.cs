namespace RFDeviceAPP
{
    partial class FrmRTRSku2
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.receiptkeyLab = new System.Windows.Forms.Label();
            this.receiptkeyText = new RFDeviceAPP.Common.rfTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.skuText = new RFDeviceAPP.Common.rfTextBox();
            this.lottable02Text = new RFDeviceAPP.Common.rfTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // receiptkeyLab
            // 
            this.receiptkeyLab.Location = new System.Drawing.Point(4, 49);
            this.receiptkeyLab.Name = "receiptkeyLab";
            this.receiptkeyLab.Size = new System.Drawing.Size(100, 20);
            this.receiptkeyLab.Text = "收货单号";
            // 
            // receiptkeyText
            // 
            this.receiptkeyText.Location = new System.Drawing.Point(4, 74);
            this.receiptkeyText.Name = "receiptkeyText";
            this.receiptkeyText.Size = new System.Drawing.Size(231, 23);
            this.receiptkeyText.TabIndex = 6;
            this.receiptkeyText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.receiptkeyText_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "料号";
            // 
            // skuText
            // 
            this.skuText.Location = new System.Drawing.Point(4, 136);
            this.skuText.Name = "skuText";
            this.skuText.Size = new System.Drawing.Size(231, 23);
            this.skuText.TabIndex = 1;
            this.skuText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skuText_KeyDown);
            // 
            // lottable02Text
            // 
            this.lottable02Text.Location = new System.Drawing.Point(4, 202);
            this.lottable02Text.Name = "lottable02Text";
            this.lottable02Text.Size = new System.Drawing.Size(231, 23);
            this.lottable02Text.TabIndex = 7;
            this.lottable02Text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lottable02Text_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "发票号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "提交";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRTRSku2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lottable02Text);
            this.Controls.Add(this.skuText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiptkeyLab);
            this.Controls.Add(this.receiptkeyText);
            this.Name = "FrmRTRSku2";
            this.Controls.SetChildIndex(this.receiptkeyText, 0);
            this.Controls.SetChildIndex(this.receiptkeyLab, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.skuText, 0);
            this.Controls.SetChildIndex(this.lottable02Text, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label receiptkeyLab;
        private RFDeviceAPP.Common.rfTextBox receiptkeyText;
        private System.Windows.Forms.Label label1;
        private RFDeviceAPP.Common.rfTextBox skuText;
        private RFDeviceAPP.Common.rfTextBox lottable02Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}