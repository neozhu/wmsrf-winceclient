namespace RFDeviceAPP
{
    partial class ClassifyFrm
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
            this.receiptkey = new RFDeviceAPP.Common.rfTextBox();
            this.storerkey = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.thecube = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
            this.submit1 = new RFDeviceAPP.Common.rfButtonCommand();
            this.submit2 = new RFDeviceAPP.Common.rfButtonCommand();
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
            // receiptkey
            // 
            this.receiptkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptkey.Location = new System.Drawing.Point(4, 47);
            this.receiptkey.Name = "receiptkey";
            this.receiptkey.Size = new System.Drawing.Size(231, 23);
            this.receiptkey.TabIndex = 2;
            this.receiptkey.LostFocus += new System.EventHandler(this.receiptkey_LostFocus);
            // 
            // storerkey
            // 
            this.storerkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.storerkey.Location = new System.Drawing.Point(4, 84);
            this.storerkey.Name = "storerkey";
            this.storerkey.ReadOnly = true;
            this.storerkey.Size = new System.Drawing.Size(231, 23);
            this.storerkey.TabIndex = 4;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(4, 70);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(62, 14);
            this.rfLabel2.Text = "货主";
            // 
            // thecube
            // 
            this.thecube.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.thecube.Location = new System.Drawing.Point(4, 123);
            this.thecube.Name = "thecube";
            this.thecube.Size = new System.Drawing.Size(231, 23);
            this.thecube.TabIndex = 7;
            this.thecube.Visible = false;
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(4, 109);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(62, 14);
            this.rfLabel3.Text = "体积";
            this.rfLabel3.Visible = false;
            // 
            // submit1
            // 
            this.submit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submit1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submit1.Location = new System.Drawing.Point(163, 152);
            this.submit1.Name = "submit1";
            this.submit1.Size = new System.Drawing.Size(72, 45);
            this.submit1.TabIndex = 9;
            this.submit1.Text = "开始分料";
            this.submit1.Click += new System.EventHandler(this.submit1_Click);
            // 
            // submit2
            // 
            this.submit2.Enabled = false;
            this.submit2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submit2.Location = new System.Drawing.Point(85, 152);
            this.submit2.Name = "submit2";
            this.submit2.Size = new System.Drawing.Size(72, 45);
            this.submit2.TabIndex = 10;
            this.submit2.Text = "分料完成";
            this.submit2.Visible = false;
            this.submit2.Click += new System.EventHandler(this.submit2_Click);
            // 
            // ClassifyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.submit1);
            this.Controls.Add(this.submit2);
            this.Controls.Add(this.thecube);
            this.Controls.Add(this.rfLabel3);
            this.Controls.Add(this.storerkey);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.receiptkey);
            this.Controls.Add(this.rfLabel1);
            this.Name = "ClassifyFrm";
            this.Text = "分料操作";
            this.Load += new System.EventHandler(this.ClassifyFrm_Load);
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.receiptkey, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.storerkey, 0);
            this.Controls.SetChildIndex(this.rfLabel3, 0);
            this.Controls.SetChildIndex(this.thecube, 0);
            this.Controls.SetChildIndex(this.submit2, 0);
            this.Controls.SetChildIndex(this.submit1, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox receiptkey;
        private RFDeviceAPP.Common.rfTextBox storerkey;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox thecube;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
        private RFDeviceAPP.Common.rfButtonCommand submit1;
        private RFDeviceAPP.Common.rfButtonCommand submit2;

    }
}
