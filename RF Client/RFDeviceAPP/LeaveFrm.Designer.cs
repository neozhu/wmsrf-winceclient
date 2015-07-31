namespace RFDeviceAPP
{
    partial class LeaveFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.portcodetxt = new RFDeviceAPP.Common.rfTextBox();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.parknumtxt = new RFDeviceAPP.Common.rfTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.asnlist = new System.Windows.Forms.ListBox();
            this.portlist = new RFDeviceAPP.Common.rfTextBox();
            this.chkio = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "停车证编号";
            // 
            // portcodetxt
            // 
            this.portcodetxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.portcodetxt.Location = new System.Drawing.Point(4, 114);
            this.portcodetxt.Name = "portcodetxt";
            this.portcodetxt.Size = new System.Drawing.Size(231, 23);
            this.portcodetxt.TabIndex = 2;
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(163, 232);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(72, 41);
            this.submitbtn.TabIndex = 3;
            this.submitbtn.Text = "离开码头";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // parknumtxt
            // 
            this.parknumtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.parknumtxt.Location = new System.Drawing.Point(4, 48);
            this.parknumtxt.Name = "parknumtxt";
            this.parknumtxt.Size = new System.Drawing.Size(231, 23);
            this.parknumtxt.TabIndex = 1;
            this.parknumtxt.LostFocus += new System.EventHandler(this.parknumtxt_LostFocus);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(4, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "码头编号";
            // 
            // asnlist
            // 
            this.asnlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.asnlist.Location = new System.Drawing.Point(4, 144);
            this.asnlist.Name = "asnlist";
            this.asnlist.Size = new System.Drawing.Size(231, 82);
            this.asnlist.TabIndex = 19;
            // 
            // portlist
            // 
            this.portlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.portlist.Location = new System.Drawing.Point(4, 73);
            this.portlist.Name = "portlist";
            this.portlist.ReadOnly = true;
            this.portlist.Size = new System.Drawing.Size(231, 23);
            this.portlist.TabIndex = 22;
            // 
            // chkio
            // 
            this.chkio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkio.Location = new System.Drawing.Point(135, 30);
            this.chkio.Name = "chkio";
            this.chkio.Size = new System.Drawing.Size(100, 20);
            this.chkio.TabIndex = 23;
            this.chkio.Text = "提货操作";
            this.chkio.CheckStateChanged += new System.EventHandler(this.chkio_CheckStateChanged);
            // 
            // LeaveFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.portlist);
            this.Controls.Add(this.asnlist);
            this.Controls.Add(this.parknumtxt);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.portcodetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkio);
            this.Name = "LeaveFrm";
            this.Text = "车辆离港操作";
            this.Load += new System.EventHandler(this.LeaveFrm_Load);
            this.Controls.SetChildIndex(this.chkio, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.portcodetxt, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.submitbtn, 0);
            this.Controls.SetChildIndex(this.parknumtxt, 0);
            this.Controls.SetChildIndex(this.asnlist, 0);
            this.Controls.SetChildIndex(this.portlist, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RFDeviceAPP.Common.rfTextBox portcodetxt;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
        private RFDeviceAPP.Common.rfTextBox parknumtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox asnlist;
        private RFDeviceAPP.Common.rfTextBox portlist;
        private System.Windows.Forms.CheckBox chkio;

    }
}