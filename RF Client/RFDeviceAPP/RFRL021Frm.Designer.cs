﻿namespace RFDeviceAPP
{
    partial class RFRL021Frm
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
            this.totagtxt = new RFDeviceAPP.Common.rfTextBox();
            this.totag = new RFDeviceAPP.Common.rfLabel();
            this.totagtxtlist = new System.Windows.Forms.ListBox();
            this.lasttoid = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel4 = new RFDeviceAPP.Common.rfLabel();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(256, 26);
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(4, 31);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(106, 14);
            this.rfLabel1.Text = "自周转箱";
            // 
            // movableunit
            // 
            this.movableunit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.movableunit.Location = new System.Drawing.Point(4, 45);
            this.movableunit.Name = "movableunit";
            this.movableunit.Size = new System.Drawing.Size(246, 23);
            this.movableunit.TabIndex = 2;
            this.movableunit.GotFocus += new System.EventHandler(this.movableunit_GotFocus);
            this.movableunit.LostFocus += new System.EventHandler(this.movableunit_LostFocus);
            // 
            // fromloc
            // 
            this.fromloc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fromloc.Location = new System.Drawing.Point(3, 323);
            this.fromloc.Name = "fromloc";
            this.fromloc.ReadOnly = true;
            this.fromloc.Size = new System.Drawing.Size(246, 23);
            this.fromloc.TabIndex = 3;
            this.fromloc.Visible = false;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(3, 309);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(72, 30);
            this.rfLabel2.Text = "自库位";
            this.rfLabel2.Visible = false;
            // 
            // toloc
            // 
            this.toloc.Location = new System.Drawing.Point(4, 122);
            this.toloc.Name = "toloc";
            this.toloc.Size = new System.Drawing.Size(100, 23);
            this.toloc.TabIndex = 4;
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(4, 108);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(89, 14);
            this.rfLabel3.Text = "至集货区库位";
            // 
            // sku
            // 
            this.sku.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sku.Location = new System.Drawing.Point(4, 259);
            this.sku.Name = "sku";
            this.sku.ReadOnly = true;
            this.sku.Size = new System.Drawing.Size(246, 23);
            this.sku.TabIndex = 10;
            this.sku.Visible = false;
            // 
            // s1ku111
            // 
            this.s1ku111.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.s1ku111.Location = new System.Drawing.Point(4, 244);
            this.s1ku111.Name = "s1ku111";
            this.s1ku111.Size = new System.Drawing.Size(200, 30);
            this.s1ku111.Text = "SKU数/已包装箱数/总箱数";
            this.s1ku111.Visible = false;
            // 
            // desc
            // 
            this.desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.desc.Location = new System.Drawing.Point(4, 284);
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Size = new System.Drawing.Size(246, 23);
            this.desc.TabIndex = 12;
            this.desc.Visible = false;
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(158, 190);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(92, 50);
            this.submitbtn.TabIndex = 5;
            this.submitbtn.Text = "集货";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // toloc1
            // 
            this.toloc1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toloc1.Location = new System.Drawing.Point(110, 122);
            this.toloc1.Name = "toloc1";
            this.toloc1.ReadOnly = true;
            this.toloc1.Size = new System.Drawing.Size(140, 23);
            this.toloc1.TabIndex = 17;
            // 
            // totagtxt
            // 
            this.totagtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.totagtxt.Location = new System.Drawing.Point(4, 83);
            this.totagtxt.Name = "totagtxt";
            this.totagtxt.Size = new System.Drawing.Size(246, 23);
            this.totagtxt.TabIndex = 3;
            this.totagtxt.LostFocus += new System.EventHandler(this.totagtxt_LostFocus);
            // 
            // totag
            // 
            this.totag.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.totag.Location = new System.Drawing.Point(4, 69);
            this.totag.Name = "totag";
            this.totag.Size = new System.Drawing.Size(106, 14);
            this.totag.Text = "至周转箱";
            // 
            // totagtxtlist
            // 
            this.totagtxtlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.totagtxtlist.Location = new System.Drawing.Point(5, 190);
            this.totagtxtlist.Name = "totagtxtlist";
            this.totagtxtlist.Size = new System.Drawing.Size(162, 50);
            this.totagtxtlist.TabIndex = 22;
            this.totagtxtlist.SelectedIndexChanged += new System.EventHandler(this.totagtxtlist_OnDoubleClick);
            // 
            // lasttoid
            // 
            this.lasttoid.Location = new System.Drawing.Point(6, 162);
            this.lasttoid.Name = "lasttoid";
            this.lasttoid.ReadOnly = true;
            this.lasttoid.Size = new System.Drawing.Size(243, 23);
            this.lasttoid.TabIndex = 29;
            // 
            // rfLabel4
            // 
            this.rfLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel4.Location = new System.Drawing.Point(6, 147);
            this.rfLabel4.Name = "rfLabel4";
            this.rfLabel4.Size = new System.Drawing.Size(45, 14);
            this.rfLabel4.Text = "落放ID";
            // 
            // RFRL021Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(256, 357);
            this.Controls.Add(this.rfLabel4);
            this.Controls.Add(this.lasttoid);
            this.Controls.Add(this.totagtxtlist);
            this.Controls.Add(this.totagtxt);
            this.Controls.Add(this.totag);
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
            this.Name = "RFRL021Frm";
            this.Text = "一次集货操作";
            this.Load += new System.EventHandler(this.RFRL021Frm_Load);
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.movableunit, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.fromloc, 0);
            this.Controls.SetChildIndex(this.rfLabel3, 0);
            this.Controls.SetChildIndex(this.toloc, 0);
            this.Controls.SetChildIndex(this.s1ku111, 0);
            this.Controls.SetChildIndex(this.sku, 0);
            this.Controls.SetChildIndex(this.desc, 0);
            this.Controls.SetChildIndex(this.submitbtn, 0);
            this.Controls.SetChildIndex(this.toloc1, 0);
            this.Controls.SetChildIndex(this.totag, 0);
            this.Controls.SetChildIndex(this.totagtxt, 0);
            this.Controls.SetChildIndex(this.totagtxtlist, 0);
            this.Controls.SetChildIndex(this.lasttoid, 0);
            this.Controls.SetChildIndex(this.rfLabel4, 0);
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
        private RFDeviceAPP.Common.rfTextBox totagtxt;
        private RFDeviceAPP.Common.rfLabel totag;
        private System.Windows.Forms.ListBox totagtxtlist;
        private RFDeviceAPP.Common.rfTextBox lasttoid;
        private RFDeviceAPP.Common.rfLabel rfLabel4;
    }
}
