namespace RFDeviceAPP
{
    partial class DischargeFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.thecase = new RFDeviceAPP.Common.rfTextBox();
            this.thepallet = new RFDeviceAPP.Common.rfTextBox();
            this.storerkey = new RFDeviceAPP.Common.rfTextBox();
            this.receiptkey = new RFDeviceAPP.Common.rfTextBox();
            this.submit3 = new RFDeviceAPP.Common.rfButtonCommand();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "ASN";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "货主";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "托数";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "箱数";
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(53, 170);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(87, 39);
            this.submitbtn.TabIndex = 6;
            this.submitbtn.Text = "完成卸货";
            this.submitbtn.Visible = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // thecase
            // 
            this.thecase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.thecase.Location = new System.Drawing.Point(4, 141);
            this.thecase.Name = "thecase";
            this.thecase.Size = new System.Drawing.Size(231, 23);
            this.thecase.TabIndex = 4;
            // 
            // thepallet
            // 
            this.thepallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.thepallet.Location = new System.Drawing.Point(4, 100);
            this.thepallet.Name = "thepallet";
            this.thepallet.Size = new System.Drawing.Size(231, 23);
            this.thepallet.TabIndex = 3;
            // 
            // storerkey
            // 
            this.storerkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.storerkey.Location = new System.Drawing.Point(4, 59);
            this.storerkey.Name = "storerkey";
            this.storerkey.Size = new System.Drawing.Size(231, 23);
            this.storerkey.TabIndex = 2;
            // 
            // receiptkey
            // 
            this.receiptkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptkey.Location = new System.Drawing.Point(4, 19);
            this.receiptkey.Name = "receiptkey";
            this.receiptkey.Size = new System.Drawing.Size(231, 23);
            this.receiptkey.TabIndex = 1;
            // 
            // submit3
            // 
            this.submit3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submit3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submit3.Location = new System.Drawing.Point(146, 170);
            this.submit3.Name = "submit3";
            this.submit3.Size = new System.Drawing.Size(87, 39);
            this.submit3.TabIndex = 11;
            this.submit3.Text = "卸货";
            this.submit3.Click += new System.EventHandler(this.submit3_Click);
            // 
            // DischargeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.submit3);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.thecase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.thepallet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.storerkey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.receiptkey);
            this.Controls.Add(this.label1);
            this.Name = "DischargeFrm";
            this.Text = "卸货操作";
            this.Load += new System.EventHandler(this.DischargeFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RFDeviceAPP.Common.rfTextBox receiptkey;
        private System.Windows.Forms.Label label2;
        private RFDeviceAPP.Common.rfTextBox storerkey;
        private System.Windows.Forms.Label label3;
        private RFDeviceAPP.Common.rfTextBox thepallet;
        private System.Windows.Forms.Label label4;
        private RFDeviceAPP.Common.rfTextBox thecase;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
        private RFDeviceAPP.Common.rfButtonCommand submit3;
    }
}
