namespace RFDeviceAPP
{
    partial class FrmScanSN1
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
            this.orderkeytext = new RFDeviceAPP.Common.rfTextBox();
            this.skutext = new RFDeviceAPP.Common.rfTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labeltext = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.Text = "出货单号";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.Text = "SKU";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.Text = "标签格式";
            // 
            // orderkeytext
            // 
            this.orderkeytext.Location = new System.Drawing.Point(81, 55);
            this.orderkeytext.Name = "orderkeytext";
            this.orderkeytext.Size = new System.Drawing.Size(136, 23);
            this.orderkeytext.TabIndex = 6;
            // 
            // skutext
            // 
            this.skutext.Location = new System.Drawing.Point(81, 105);
            this.skutext.Name = "skutext";
            this.skutext.Size = new System.Drawing.Size(136, 23);
            this.skutext.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 61);
            this.button1.TabIndex = 9;
            this.button1.Text = "提交";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeltext
            // 
            this.labeltext.Items.Add("1-区间扫描");
            this.labeltext.Items.Add("2-其它扫描");
            this.labeltext.Location = new System.Drawing.Point(81, 156);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(136, 23);
            this.labeltext.TabIndex = 10;
            // 
            // FrmScanSN1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 330);
            this.Controls.Add(this.labeltext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skutext);
            this.Controls.Add(this.orderkeytext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmScanSN1";
            this.Text = "FrmScanSN1";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.orderkeytext, 0);
            this.Controls.SetChildIndex(this.skutext, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.labeltext, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RFDeviceAPP.Common.rfTextBox orderkeytext;
        private RFDeviceAPP.Common.rfTextBox skutext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox labeltext;
    }
}