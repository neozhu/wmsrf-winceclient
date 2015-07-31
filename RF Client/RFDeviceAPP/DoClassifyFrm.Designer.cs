namespace RFDeviceAPP
{
    partial class DoClassifyFrm
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
            this.linecount = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel4 = new RFDeviceAPP.Common.rfLabel();
            this.submit2 = new RFDeviceAPP.Common.rfButtonCommand();
            this.thecube = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
            this.storerkey = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.receiptkey = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.SuspendLayout();
            // 
            // linecount
            // 
            this.linecount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.linecount.Location = new System.Drawing.Point(4, 130);
            this.linecount.Name = "linecount";
            this.linecount.Size = new System.Drawing.Size(231, 23);
            this.linecount.TabIndex = 22;
            // 
            // rfLabel4
            // 
            this.rfLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel4.Location = new System.Drawing.Point(4, 116);
            this.rfLabel4.Name = "rfLabel4";
            this.rfLabel4.Size = new System.Drawing.Size(62, 14);
            this.rfLabel4.Text = "明细行数";
            // 
            // submit2
            // 
            this.submit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submit2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submit2.Location = new System.Drawing.Point(163, 159);
            this.submit2.Name = "submit2";
            this.submit2.Size = new System.Drawing.Size(72, 45);
            this.submit2.TabIndex = 17;
            this.submit2.Text = "分料完成";
            this.submit2.Click += new System.EventHandler(this.submit2_Click);
            // 
            // thecube
            // 
            this.thecube.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.thecube.Location = new System.Drawing.Point(4, 91);
            this.thecube.Name = "thecube";
            this.thecube.Size = new System.Drawing.Size(231, 23);
            this.thecube.TabIndex = 16;
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(4, 77);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(62, 14);
            this.rfLabel3.Text = "体积";
            // 
            // storerkey
            // 
            this.storerkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.storerkey.Location = new System.Drawing.Point(4, 52);
            this.storerkey.Name = "storerkey";
            this.storerkey.ReadOnly = true;
            this.storerkey.Size = new System.Drawing.Size(231, 23);
            this.storerkey.TabIndex = 15;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(4, 38);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(62, 14);
            this.rfLabel2.Text = "货主";
            // 
            // receiptkey
            // 
            this.receiptkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptkey.Location = new System.Drawing.Point(4, 15);
            this.receiptkey.Name = "receiptkey";
            this.receiptkey.Size = new System.Drawing.Size(231, 23);
            this.receiptkey.TabIndex = 14;
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(4, 1);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(30, 14);
            this.rfLabel1.Text = "ASN";
            // 
            // DoClassifyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 281);
            this.Controls.Add(this.linecount);
            this.Controls.Add(this.rfLabel4);
            this.Controls.Add(this.submit2);
            this.Controls.Add(this.thecube);
            this.Controls.Add(this.rfLabel3);
            this.Controls.Add(this.storerkey);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.receiptkey);
            this.Controls.Add(this.rfLabel1);
            this.Name = "DoClassifyFrm";
            this.Text = "分料中";
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfButtonCommand submit2;
        private RFDeviceAPP.Common.rfTextBox thecube;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
        private RFDeviceAPP.Common.rfTextBox storerkey;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox receiptkey;
        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox linecount;
        private RFDeviceAPP.Common.rfLabel rfLabel4;
    }
}