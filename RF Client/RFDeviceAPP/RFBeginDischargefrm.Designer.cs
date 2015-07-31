namespace RFDeviceAPP
{
    partial class RFBeginDischargefrm
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
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.portlist = new System.Windows.Forms.ListBox();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.portcodetxt = new RFDeviceAPP.Common.rfTextBox();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(4, 33);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(55, 14);
            this.rfLabel1.Text = "码头编号";
            // 
            // portlist
            // 
            this.portlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.portlist.Location = new System.Drawing.Point(4, 79);
            this.portlist.Name = "portlist";
            this.portlist.Size = new System.Drawing.Size(231, 98);
            this.portlist.TabIndex = 5;
            this.portlist.SelectedIndexChanged += new System.EventHandler(this.portlist_SelectedIndexChanged);
            this.portlist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.portlist_KeyPress);
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(150, 183);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(85, 37);
            this.submitbtn.TabIndex = 6;
            this.submitbtn.Text = "开始卸货";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // portcodetxt
            // 
            this.portcodetxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.portcodetxt.Location = new System.Drawing.Point(3, 50);
            this.portcodetxt.Name = "portcodetxt";
            this.portcodetxt.Size = new System.Drawing.Size(231, 23);
            this.portcodetxt.TabIndex = 7;
            this.portcodetxt.LostFocus += new System.EventHandler(this.portcodetxt_LostFocus);
            // 
            // RFBeginDischargefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.portcodetxt);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.portlist);
            this.Controls.Add(this.rfLabel1);
            this.Name = "RFBeginDischargefrm";
            this.Text = "开始卸货操作";
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.portlist, 0);
            this.Controls.SetChildIndex(this.submitbtn, 0);
            this.Controls.SetChildIndex(this.portcodetxt, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private System.Windows.Forms.ListBox portlist;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
        private RFDeviceAPP.Common.rfTextBox portcodetxt;
    }
}
