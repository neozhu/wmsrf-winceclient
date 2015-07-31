namespace RFDeviceAPP
{
    partial class NSPRFSH01Frm
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
            this.parknumtxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel4 = new RFDeviceAPP.Common.rfLabel();
            this.toid = new RFDeviceAPP.Common.rfTextBox();
            this.fromid = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.droplist = new System.Windows.Forms.ListBox();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.orderkey = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.orderlist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // parknumtxt
            // 
            this.parknumtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.parknumtxt.Location = new System.Drawing.Point(3, 43);
            this.parknumtxt.Name = "parknumtxt";
            this.parknumtxt.Size = new System.Drawing.Size(231, 23);
            this.parknumtxt.TabIndex = 3;
            this.parknumtxt.LostFocus += new System.EventHandler(this.parknumtxt_LostFocus);
            // 
            // rfLabel4
            // 
            this.rfLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel4.Location = new System.Drawing.Point(3, 29);
            this.rfLabel4.Name = "rfLabel4";
            this.rfLabel4.Size = new System.Drawing.Size(100, 14);
            this.rfLabel4.Text = "停车证牌号";
            // 
            // toid
            // 
            this.toid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toid.Location = new System.Drawing.Point(3, 67);
            this.toid.Name = "toid";
            this.toid.ReadOnly = true;
            this.toid.Size = new System.Drawing.Size(231, 23);
            this.toid.TabIndex = 5;
            // 
            // fromid
            // 
            this.fromid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fromid.Location = new System.Drawing.Point(3, 248);
            this.fromid.Name = "fromid";
            this.fromid.Size = new System.Drawing.Size(231, 23);
            this.fromid.TabIndex = 7;
            this.fromid.LostFocus += new System.EventHandler(this.fromid_LostFocus);
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(3, 232);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(100, 14);
            this.rfLabel1.Text = "装载箱ID";
            // 
            // droplist
            // 
            this.droplist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.droplist.Location = new System.Drawing.Point(3, 273);
            this.droplist.Name = "droplist";
            this.droplist.Size = new System.Drawing.Size(230, 98);
            this.droplist.TabIndex = 9;
            this.droplist.SelectedIndexChanged += new System.EventHandler(this.droplist_SelectedIndexChanged);
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(143, 377);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(91, 55);
            this.submitbtn.TabIndex = 10;
            this.submitbtn.Text = "装载";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // orderkey
            // 
            this.orderkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.orderkey.Location = new System.Drawing.Point(3, 106);
            this.orderkey.Name = "orderkey";
            this.orderkey.Size = new System.Drawing.Size(231, 23);
            this.orderkey.TabIndex = 6;
            this.orderkey.LostFocus += new System.EventHandler(this.orderkey_LostFocus);
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(3, 91);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(100, 14);
            this.rfLabel2.Text = "订单号/关务号";
            // 
            // orderlist
            // 
            this.orderlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.orderlist.Location = new System.Drawing.Point(3, 130);
            this.orderlist.Name = "orderlist";
            this.orderlist.Size = new System.Drawing.Size(230, 98);
            this.orderlist.TabIndex = 13;
            // 
            // NSPRFSH01Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 469);
            this.Controls.Add(this.orderlist);
            this.Controls.Add(this.orderkey);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.droplist);
            this.Controls.Add(this.fromid);
            this.Controls.Add(this.rfLabel1);
            this.Controls.Add(this.toid);
            this.Controls.Add(this.parknumtxt);
            this.Controls.Add(this.rfLabel4);
            this.Name = "NSPRFSH01Frm";
            this.Text = "装载操作";
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.rfLabel4, 0);
            this.Controls.SetChildIndex(this.parknumtxt, 0);
            this.Controls.SetChildIndex(this.toid, 0);
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.fromid, 0);
            this.Controls.SetChildIndex(this.droplist, 0);
            this.Controls.SetChildIndex(this.submitbtn, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.orderkey, 0);
            this.Controls.SetChildIndex(this.orderlist, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfTextBox parknumtxt;
        private RFDeviceAPP.Common.rfLabel rfLabel4;
        private RFDeviceAPP.Common.rfTextBox toid;
        private RFDeviceAPP.Common.rfTextBox fromid;
        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private System.Windows.Forms.ListBox droplist;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
        private RFDeviceAPP.Common.rfTextBox orderkey;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private System.Windows.Forms.ListBox orderlist;
    }
}
