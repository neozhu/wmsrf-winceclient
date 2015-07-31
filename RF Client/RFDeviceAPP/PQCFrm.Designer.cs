namespace RFDeviceAPP
{
    partial class PQCFrm
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
            this.receiptKey = new RFDeviceAPP.Common.rfTextBox();
            this.storerKey = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.pqcpeoplenum = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
            this.asnlist = new System.Windows.Forms.ListBox();
            this.submitbt1 = new RFDeviceAPP.Common.rfButtonCommand();
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
            this.rfLabel1.Size = new System.Drawing.Size(30, 14);
            this.rfLabel1.Text = "ASN";
            // 
            // receiptKey
            // 
            this.receiptKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptKey.Location = new System.Drawing.Point(4, 49);
            this.receiptKey.Name = "receiptKey";
            this.receiptKey.Size = new System.Drawing.Size(231, 23);
            this.receiptKey.TabIndex = 2;
            this.receiptKey.LostFocus += new System.EventHandler(this.receiptKey_LostFocus);
            // 
            // storerKey
            // 
            this.storerKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.storerKey.Location = new System.Drawing.Point(4, 88);
            this.storerKey.Name = "storerKey";
            this.storerKey.Size = new System.Drawing.Size(231, 23);
            this.storerKey.TabIndex = 4;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(4, 72);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(76, 14);
            this.rfLabel2.Text = "货主";
            // 
            // pqcpeoplenum
            // 
            this.pqcpeoplenum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pqcpeoplenum.Location = new System.Drawing.Point(3, 127);
            this.pqcpeoplenum.Name = "pqcpeoplenum";
            this.pqcpeoplenum.Size = new System.Drawing.Size(231, 23);
            this.pqcpeoplenum.TabIndex = 7;
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(3, 111);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(88, 14);
            this.rfLabel3.Text = "人数";
            // 
            // asnlist
            // 
            this.asnlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.asnlist.Location = new System.Drawing.Point(3, 156);
            this.asnlist.Name = "asnlist";
            this.asnlist.Size = new System.Drawing.Size(231, 98);
            this.asnlist.TabIndex = 9;
            this.asnlist.SelectedIndexChanged += new System.EventHandler(this.asnlist_SelectedIndexChanged);
            // 
            // submitbt1
            // 
            this.submitbt1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbt1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbt1.Location = new System.Drawing.Point(146, 260);
            this.submitbt1.Name = "submitbt1";
            this.submitbt1.Size = new System.Drawing.Size(88, 48);
            this.submitbt1.TabIndex = 10;
            this.submitbt1.Text = "开始QC";
            this.submitbt1.Click += new System.EventHandler(this.submitbt1_Click);
            // 
            // PQCFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 327);
            this.Controls.Add(this.submitbt1);
            this.Controls.Add(this.asnlist);
            this.Controls.Add(this.pqcpeoplenum);
            this.Controls.Add(this.rfLabel3);
            this.Controls.Add(this.storerKey);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.receiptKey);
            this.Controls.Add(this.rfLabel1);
            this.Name = "PQCFrm";
            this.Text = "PQC操作";
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.receiptKey, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.storerKey, 0);
            this.Controls.SetChildIndex(this.rfLabel3, 0);
            this.Controls.SetChildIndex(this.pqcpeoplenum, 0);
            this.Controls.SetChildIndex(this.asnlist, 0);
            this.Controls.SetChildIndex(this.submitbt1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox receiptKey;
        private RFDeviceAPP.Common.rfTextBox storerKey;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox pqcpeoplenum;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
        private System.Windows.Forms.ListBox asnlist;
        private RFDeviceAPP.Common.rfButtonCommand submitbt1;

    }
}
