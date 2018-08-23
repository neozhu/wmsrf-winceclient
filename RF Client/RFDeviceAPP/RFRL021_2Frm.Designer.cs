namespace RFDeviceAPP
{
    partial class RFRL021_2Frm
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
            this.movableunit = new RFDeviceAPP.Common.rfTextBox();
            this.fromloc = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.toloc = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
            this.sku = new RFDeviceAPP.Common.rfTextBox();
            this.s1ku111 = new RFDeviceAPP.Common.rfLabel();
            this.desc = new RFDeviceAPP.Common.rfTextBox();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.toloc1 = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel5 = new RFDeviceAPP.Common.rfLabel();
            this.allloc = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel4 = new RFDeviceAPP.Common.rfLabel();
            this.dropidlist = new System.Windows.Forms.ListBox();
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
            this.rfLabel1.Size = new System.Drawing.Size(106, 14);
            this.rfLabel1.Text = "箱ID";
            // 
            // movableunit
            // 
            this.movableunit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.movableunit.Location = new System.Drawing.Point(4, 47);
            this.movableunit.Name = "movableunit";
            this.movableunit.Size = new System.Drawing.Size(227, 23);
            this.movableunit.TabIndex = 2;
            this.movableunit.GotFocus += new System.EventHandler(this.movableunit_GotFocus);
            this.movableunit.LostFocus += new System.EventHandler(this.movableunit_LostFocus);
            // 
            // fromloc
            // 
            this.fromloc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fromloc.Location = new System.Drawing.Point(4, 157);
            this.fromloc.Name = "fromloc";
            this.fromloc.ReadOnly = true;
            this.fromloc.Size = new System.Drawing.Size(228, 23);
            this.fromloc.TabIndex = 30;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(4, 143);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(72, 14);
            this.rfLabel2.Text = "自库位";
            // 
            // toloc
            // 
            this.toloc.Location = new System.Drawing.Point(3, 195);
            this.toloc.Name = "toloc";
            this.toloc.Size = new System.Drawing.Size(100, 23);
            this.toloc.TabIndex = 3;
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(3, 181);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(89, 14);
            this.rfLabel3.Text = "至集货区库位";
            // 
            // sku
            // 
            this.sku.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sku.Location = new System.Drawing.Point(4, 273);
            this.sku.Name = "sku";
            this.sku.ReadOnly = true;
            this.sku.Size = new System.Drawing.Size(228, 23);
            this.sku.TabIndex = 10;
            // 
            // s1ku111
            // 
            this.s1ku111.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.s1ku111.Location = new System.Drawing.Point(4, 259);
            this.s1ku111.Name = "s1ku111";
            this.s1ku111.Size = new System.Drawing.Size(203, 14);
            this.s1ku111.Text = "SKU数/已包装箱数/总箱数";
            // 
            // desc
            // 
            this.desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.desc.Location = new System.Drawing.Point(4, 297);
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Size = new System.Drawing.Size(228, 23);
            this.desc.TabIndex = 12;
            this.desc.Visible = false;
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(154, 326);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(78, 57);
            this.submitbtn.TabIndex = 5;
            this.submitbtn.Text = "集货";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // toloc1
            // 
            this.toloc1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toloc1.Location = new System.Drawing.Point(109, 195);
            this.toloc1.Name = "toloc1";
            this.toloc1.Size = new System.Drawing.Size(122, 23);
            this.toloc1.TabIndex = 17;
            // 
            // rfLabel5
            // 
            this.rfLabel5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel5.Location = new System.Drawing.Point(3, 220);
            this.rfLabel5.Name = "rfLabel5";
            this.rfLabel5.Size = new System.Drawing.Size(106, 14);
            this.rfLabel5.Text = "所有库位";
            // 
            // allloc
            // 
            this.allloc.Location = new System.Drawing.Point(4, 234);
            this.allloc.Name = "allloc";
            this.allloc.Size = new System.Drawing.Size(227, 23);
            this.allloc.TabIndex = 38;
            // 
            // rfLabel4
            // 
            this.rfLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel4.Location = new System.Drawing.Point(4, 73);
            this.rfLabel4.Name = "rfLabel4";
            this.rfLabel4.Size = new System.Drawing.Size(106, 14);
            this.rfLabel4.Text = "扫描明细";
            // 
            // dropidlist
            // 
            this.dropidlist.Location = new System.Drawing.Point(4, 90);
            this.dropidlist.Name = "dropidlist";
            this.dropidlist.Size = new System.Drawing.Size(227, 50);
            this.dropidlist.TabIndex = 45;
            this.dropidlist.SelectedIndexChanged += new System.EventHandler(this.dropidlist_OnDoubleClick);
            // 
            // RFRL021_2Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 389);
            this.Controls.Add(this.dropidlist);
            this.Controls.Add(this.rfLabel4);
            this.Controls.Add(this.rfLabel5);
            this.Controls.Add(this.allloc);
            this.Controls.Add(this.toloc1);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.sku);
            this.Controls.Add(this.s1ku111);
            this.Controls.Add(this.toloc);
            this.Controls.Add(this.rfLabel3);
            this.Controls.Add(this.fromloc);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.movableunit);
            this.Controls.Add(this.rfLabel1);
            this.Name = "RFRL021_2Frm";
            this.Text = "二次集货操作";
            this.Load += new System.EventHandler(this.RFRL021Frm_Load);
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.movableunit, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.fromloc, 0);
            this.Controls.SetChildIndex(this.rfLabel3, 0);
            this.Controls.SetChildIndex(this.toloc, 0);
            this.Controls.SetChildIndex(this.s1ku111, 0);
            this.Controls.SetChildIndex(this.sku, 0);
            this.Controls.SetChildIndex(this.desc, 0);
            this.Controls.SetChildIndex(this.submitbtn, 0);
            this.Controls.SetChildIndex(this.toloc1, 0);
            this.Controls.SetChildIndex(this.allloc, 0);
            this.Controls.SetChildIndex(this.rfLabel5, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.rfLabel4, 0);
            this.Controls.SetChildIndex(this.dropidlist, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox movableunit;
        private RFDeviceAPP.Common.rfTextBox fromloc;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox toloc;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
        private RFDeviceAPP.Common.rfTextBox sku;
        private RFDeviceAPP.Common.rfLabel s1ku111;
        private RFDeviceAPP.Common.rfTextBox desc;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
        private RFDeviceAPP.Common.rfTextBox toloc1;
        private RFDeviceAPP.Common.rfLabel rfLabel5;
        private RFDeviceAPP.Common.rfTextBox allloc;
        private RFDeviceAPP.Common.rfLabel rfLabel4;
        private System.Windows.Forms.ListBox dropidlist;
    }
}
