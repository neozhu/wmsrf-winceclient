namespace RFDeviceAPP
{
    partial class FrmExpressPrint
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mailnumText = new RFDeviceAPP.Common.rfTextBox();
            this.mailtypeCombo = new RFDeviceAPP.Common.rfComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mailtypetext = new RFDeviceAPP.Common.rfTextBox();
            this.labelNameCombo = new RFDeviceAPP.Common.rfComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.printerCombo = new RFDeviceAPP.Common.rfComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ordersText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(236, 26);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "单号:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "面单数:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "面单类型:";
            this.label3.Visible = false;
            // 
            // mailnumText
            // 
            this.mailnumText.Location = new System.Drawing.Point(84, 138);
            this.mailnumText.Name = "mailnumText";
            this.mailnumText.Size = new System.Drawing.Size(130, 23);
            this.mailnumText.TabIndex = 10;
            // 
            // mailtypeCombo
            // 
            this.mailtypeCombo.Location = new System.Drawing.Point(84, 170);
            this.mailtypeCombo.Name = "mailtypeCombo";
            this.mailtypeCombo.Size = new System.Drawing.Size(130, 23);
            this.mailtypeCombo.TabIndex = 11;
            this.mailtypeCombo.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 52);
            this.button1.TabIndex = 12;
            this.button1.Text = "提交";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mailtypetext
            // 
            this.mailtypetext.Location = new System.Drawing.Point(94, 199);
            this.mailtypetext.Name = "mailtypetext";
            this.mailtypetext.Size = new System.Drawing.Size(100, 23);
            this.mailtypetext.TabIndex = 16;
            this.mailtypetext.Visible = false;
            // 
            // labelNameCombo
            // 
            this.labelNameCombo.Location = new System.Drawing.Point(84, 235);
            this.labelNameCombo.Name = "labelNameCombo";
            this.labelNameCombo.Size = new System.Drawing.Size(130, 23);
            this.labelNameCombo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "标签名:";
            // 
            // printerCombo
            // 
            this.printerCombo.Location = new System.Drawing.Point(84, 271);
            this.printerCombo.Name = "printerCombo";
            this.printerCombo.Size = new System.Drawing.Size(130, 23);
            this.printerCombo.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "打印机:";
            // 
            // ordersText
            // 
            this.ordersText.Location = new System.Drawing.Point(84, 57);
            this.ordersText.Multiline = true;
            this.ordersText.Name = "ordersText";
            this.ordersText.Size = new System.Drawing.Size(133, 75);
            this.ordersText.TabIndex = 37;
            // 
            // FrmExpressPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(236, 374);
            this.Controls.Add(this.ordersText);
            this.Controls.Add(this.printerCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNameCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mailtypetext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mailtypeCombo);
            this.Controls.Add(this.mailnumText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmExpressPrint";
            this.Text = "FrmExpressPrint";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.mailnumText, 0);
            this.Controls.SetChildIndex(this.mailtypeCombo, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.mailtypetext, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.labelNameCombo, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.printerCombo, 0);
            this.Controls.SetChildIndex(this.ordersText, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RFDeviceAPP.Common.rfTextBox mailnumText;
        private RFDeviceAPP.Common.rfComboBox mailtypeCombo;
        private System.Windows.Forms.Button button1;
        private RFDeviceAPP.Common.rfTextBox mailtypetext;
        private RFDeviceAPP.Common.rfComboBox labelNameCombo;
        private System.Windows.Forms.Label label4;
        private RFDeviceAPP.Common.rfComboBox printerCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ordersText;
    }
}