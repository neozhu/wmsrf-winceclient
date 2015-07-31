namespace RFDeviceAPP
{
    partial class InputOpenBoxNumFrm
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
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.qtytxt = new RFDeviceAPP.Common.rfTextBox();
            this.okbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(4, 4);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(166, 14);
            this.rfLabel1.Text = "PQC开箱数";
            // 
            // qtytxt
            // 
            this.qtytxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qtytxt.Location = new System.Drawing.Point(4, 22);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(231, 23);
            this.qtytxt.TabIndex = 1;
            // 
            // okbtn
            // 
            this.okbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okbtn.Location = new System.Drawing.Point(144, 51);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(91, 54);
            this.okbtn.TabIndex = 2;
            this.okbtn.Text = "确认";
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelbtn.Location = new System.Drawing.Point(66, 51);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(72, 54);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "取消";
            this.cancelbtn.Visible = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // InputOpenBoxNumFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 378);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.qtytxt);
            this.Controls.Add(this.rfLabel1);
            this.Name = "InputOpenBoxNumFrm";
            this.Text = "输入开箱数";
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox qtytxt;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}