namespace RFDeviceAPP
{
    partial class ArrivalFrm
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
            this.portlist = new System.Windows.Forms.ListBox();
            this.portcodetxt = new RFDeviceAPP.Common.rfTextBox();
            this.asntxt = new RFDeviceAPP.Common.rfTextBox();
            this.isselfchk = new System.Windows.Forms.CheckBox();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.parknumtxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel4 = new RFDeviceAPP.Common.rfLabel();
            this.asnlist = new System.Windows.Forms.ListBox();
            this.chkio = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // portlist
            // 
            this.portlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.portlist.Location = new System.Drawing.Point(4, 69);
            this.portlist.Name = "portlist";
            this.portlist.Size = new System.Drawing.Size(231, 18);
            this.portlist.TabIndex = 4;
            // 
            // portcodetxt
            // 
            this.portcodetxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.portcodetxt.Location = new System.Drawing.Point(4, 103);
            this.portcodetxt.Name = "portcodetxt";
            this.portcodetxt.Size = new System.Drawing.Size(231, 23);
            this.portcodetxt.TabIndex = 2;
            // 
            // asntxt
            // 
            this.asntxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.asntxt.Location = new System.Drawing.Point(4, 144);
            this.asntxt.Name = "asntxt";
            this.asntxt.Size = new System.Drawing.Size(231, 23);
            this.asntxt.TabIndex = 3;
            this.asntxt.LostFocus += new System.EventHandler(this.asntxt_LostFocus);
            // 
            // isselfchk
            // 
            this.isselfchk.Location = new System.Drawing.Point(4, 167);
            this.isselfchk.Name = "isselfchk";
            this.isselfchk.Size = new System.Drawing.Size(100, 20);
            this.isselfchk.TabIndex = 4;
            this.isselfchk.Text = "是否自卸";
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(150, 257);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(85, 37);
            this.submitbtn.TabIndex = 5;
            this.submitbtn.Text = "确认";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(4, 89);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(55, 14);
            this.rfLabel1.Text = "码头编号";
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(4, 129);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(42, 14);
            this.rfLabel2.Text = "ASN号";
            // 
            // parknumtxt
            // 
            this.parknumtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.parknumtxt.Location = new System.Drawing.Point(4, 44);
            this.parknumtxt.Name = "parknumtxt";
            this.parknumtxt.Size = new System.Drawing.Size(231, 23);
            this.parknumtxt.TabIndex = 1;
            this.parknumtxt.LostFocus += new System.EventHandler(this.parknumtxt_LostFocus);
            // 
            // rfLabel4
            // 
            this.rfLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel4.Location = new System.Drawing.Point(4, 30);
            this.rfLabel4.Name = "rfLabel4";
            this.rfLabel4.Size = new System.Drawing.Size(100, 14);
            this.rfLabel4.Text = "停车证牌号";
            // 
            // asnlist
            // 
            this.asnlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.asnlist.Location = new System.Drawing.Point(4, 185);
            this.asnlist.Name = "asnlist";
            this.asnlist.Size = new System.Drawing.Size(231, 66);
            this.asnlist.TabIndex = 10;
            // 
            // chkio
            // 
            this.chkio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkio.Location = new System.Drawing.Point(135, 26);
            this.chkio.Name = "chkio";
            this.chkio.Size = new System.Drawing.Size(100, 20);
            this.chkio.TabIndex = 14;
            this.chkio.Text = "提货操作";
            this.chkio.CheckStateChanged += new System.EventHandler(this.chkio_CheckStateChanged);
            // 
            // ArrivalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 334);
            this.Controls.Add(this.asnlist);
            this.Controls.Add(this.parknumtxt);
            this.Controls.Add(this.rfLabel4);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.isselfchk);
            this.Controls.Add(this.asntxt);
            this.Controls.Add(this.portcodetxt);
            this.Controls.Add(this.portlist);
            this.Controls.Add(this.rfLabel1);
            this.Controls.Add(this.chkio);
            this.Name = "ArrivalFrm";
            this.Text = "车辆到港操作";
            this.Load += new System.EventHandler(this.ArrivalFrm_Load);
            this.Controls.SetChildIndex(this.chkio, 0);
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.portlist, 0);
            this.Controls.SetChildIndex(this.portcodetxt, 0);
            this.Controls.SetChildIndex(this.asntxt, 0);
            this.Controls.SetChildIndex(this.isselfchk, 0);
            this.Controls.SetChildIndex(this.submitbtn, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.rfLabel4, 0);
            this.Controls.SetChildIndex(this.parknumtxt, 0);
            this.Controls.SetChildIndex(this.asnlist, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox portlist;
        private RFDeviceAPP.Common.rfTextBox portcodetxt;
        private RFDeviceAPP.Common.rfTextBox asntxt;
        private System.Windows.Forms.CheckBox isselfchk;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox parknumtxt;
        private RFDeviceAPP.Common.rfLabel rfLabel4;
        private System.Windows.Forms.ListBox asnlist;
        private System.Windows.Forms.CheckBox chkio;
    }
}
