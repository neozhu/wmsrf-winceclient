namespace RFDeviceAPP
{
    partial class Inputdridfrm
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
            this.cancelbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.okbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.inputidtxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.SuspendLayout();
            // 
            // cancelbtn
            // 
            this.cancelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.cancelbtn.Location = new System.Drawing.Point(163, 56);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(72, 47);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "取消";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // okbtn
            // 
            this.okbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.okbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.okbtn.Location = new System.Drawing.Point(82, 56);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(72, 47);
            this.okbtn.TabIndex = 2;
            this.okbtn.Text = "完成";
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // inputidtxt
            // 
            this.inputidtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.inputidtxt.Location = new System.Drawing.Point(4, 27);
            this.inputidtxt.Name = "inputidtxt";
            this.inputidtxt.Size = new System.Drawing.Size(231, 23);
            this.inputidtxt.TabIndex = 1;
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(3, 9);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(151, 14);
            this.rfLabel1.Text = "请输入要提交完成的落放ID";
            // 
            // Inputdridfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 285);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.inputidtxt);
            this.Controls.Add(this.rfLabel1);
            this.Name = "Inputdridfrm";
            this.Text = "请输入落放ID";
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfButtonCommand okbtn;
        private RFDeviceAPP.Common.rfButtonCommand cancelbtn;
        public RFDeviceAPP.Common.rfTextBox inputidtxt;
    }
}