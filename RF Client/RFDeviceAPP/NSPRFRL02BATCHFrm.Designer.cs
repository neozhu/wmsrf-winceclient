namespace RFDeviceAPP
{
    partial class NSPRFRL02BATCHFrm
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
            this.fromloc = new RFDeviceAPP.Common.rfTextBox();
            this.toloc = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.droplist = new System.Windows.Forms.ListBox();
            this.countlb = new RFDeviceAPP.Common.rfLabel();
            this.dropid = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
            this.submitbtn2 = new RFDeviceAPP.Common.rfButtonCommand();
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
            this.rfLabel1.Size = new System.Drawing.Size(143, 14);
            this.rfLabel1.Text = "自储位";
            // 
            // fromloc
            // 
            this.fromloc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fromloc.Location = new System.Drawing.Point(4, 49);
            this.fromloc.Name = "fromloc";
            this.fromloc.Size = new System.Drawing.Size(231, 23);
            this.fromloc.TabIndex = 1;
            this.fromloc.LostFocus += new System.EventHandler(this.fromloc_LostFocus);
            // 
            // toloc
            // 
            this.toloc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toloc.Location = new System.Drawing.Point(3, 263);
            this.toloc.Name = "toloc";
            this.toloc.Size = new System.Drawing.Size(231, 23);
            this.toloc.TabIndex = 4;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(3, 247);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(143, 14);
            this.rfLabel2.Text = "至储位";
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(147, 296);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(87, 44);
            this.submitbtn.TabIndex = 6;
            this.submitbtn.Text = "整储位上架";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // droplist
            // 
            this.droplist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.droplist.Location = new System.Drawing.Point(4, 75);
            this.droplist.Name = "droplist";
            this.droplist.Size = new System.Drawing.Size(231, 114);
            this.droplist.TabIndex = 20;
            // 
            // countlb
            // 
            this.countlb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countlb.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.countlb.Location = new System.Drawing.Point(91, 189);
            this.countlb.Name = "countlb";
            this.countlb.Size = new System.Drawing.Size(143, 14);
            this.countlb.Text = "一共有X项";
            this.countlb.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dropid
            // 
            this.dropid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dropid.Location = new System.Drawing.Point(3, 222);
            this.dropid.Name = "dropid";
            this.dropid.Size = new System.Drawing.Size(231, 23);
            this.dropid.TabIndex = 3;
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(3, 206);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(143, 14);
            this.rfLabel3.Text = "箱ID";
            // 
            // submitbtn2
            // 
            this.submitbtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn2.Location = new System.Drawing.Point(54, 296);
            this.submitbtn2.Name = "submitbtn2";
            this.submitbtn2.Size = new System.Drawing.Size(87, 44);
            this.submitbtn2.TabIndex = 5;
            this.submitbtn2.Text = "单个上架";
            this.submitbtn2.Click += new System.EventHandler(this.submitbtn2_Click);
            // 
            // NSPRFRL02BATCHFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 370);
            this.Controls.Add(this.submitbtn2);
            this.Controls.Add(this.dropid);
            this.Controls.Add(this.rfLabel3);
            this.Controls.Add(this.countlb);
            this.Controls.Add(this.droplist);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.toloc);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.fromloc);
            this.Controls.Add(this.rfLabel1);
            this.Name = "NSPRFRL02BATCHFrm";
            this.Text = "二次上架操作";
            this.Load += new System.EventHandler(this.NSPRFRL02BATCHFrm_Load);
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.fromloc, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.toloc, 0);
            this.Controls.SetChildIndex(this.submitbtn, 0);
            this.Controls.SetChildIndex(this.droplist, 0);
            this.Controls.SetChildIndex(this.countlb, 0);
            this.Controls.SetChildIndex(this.rfLabel3, 0);
            this.Controls.SetChildIndex(this.dropid, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.submitbtn2, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox fromloc;
        private RFDeviceAPP.Common.rfTextBox toloc;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
        private System.Windows.Forms.ListBox droplist;
        private RFDeviceAPP.Common.rfLabel countlb;
        private RFDeviceAPP.Common.rfTextBox dropid;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn2;
    }
}
