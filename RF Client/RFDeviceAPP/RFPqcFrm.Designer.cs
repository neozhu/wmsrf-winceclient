namespace RFDeviceAPP
{
    partial class RFPqcFrm
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
            this.dialogbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.submitbt1 = new RFDeviceAPP.Common.rfButtonCommand();
            this.pqcqtyrejected = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel6 = new RFDeviceAPP.Common.rfLabel();
            this.pqcqtyinspected = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel5 = new RFDeviceAPP.Common.rfLabel();
            this.qtyExpected = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel4 = new RFDeviceAPP.Common.rfLabel();
            this.sku = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
            this.receiptLineNumber = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.receiptKey = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.SuspendLayout();
            // 
            // dialogbtn
            // 
            this.dialogbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.dialogbtn.Location = new System.Drawing.Point(85, 239);
            this.dialogbtn.Name = "dialogbtn";
            this.dialogbtn.Size = new System.Drawing.Size(72, 48);
            this.dialogbtn.TabIndex = 24;
            this.dialogbtn.Text = "输入开箱数";
            this.dialogbtn.Click += new System.EventHandler(this.dialogbtn_Click);
            // 
            // submitbt1
            // 
            this.submitbt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbt1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbt1.Location = new System.Drawing.Point(163, 239);
            this.submitbt1.Name = "submitbt1";
            this.submitbt1.Size = new System.Drawing.Size(72, 48);
            this.submitbt1.TabIndex = 17;
            this.submitbt1.Text = "完成";
            this.submitbt1.Click += new System.EventHandler(this.submitbt1_Click);
            // 
            // pqcqtyrejected
            // 
            this.pqcqtyrejected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pqcqtyrejected.Location = new System.Drawing.Point(4, 210);
            this.pqcqtyrejected.Name = "pqcqtyrejected";
            this.pqcqtyrejected.Size = new System.Drawing.Size(231, 23);
            this.pqcqtyrejected.TabIndex = 15;
            // 
            // rfLabel6
            // 
            this.rfLabel6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel6.Location = new System.Drawing.Point(4, 195);
            this.rfLabel6.Name = "rfLabel6";
            this.rfLabel6.Size = new System.Drawing.Size(73, 14);
            this.rfLabel6.Text = "异常数量";
            // 
            // pqcqtyinspected
            // 
            this.pqcqtyinspected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pqcqtyinspected.Location = new System.Drawing.Point(4, 172);
            this.pqcqtyinspected.Name = "pqcqtyinspected";
            this.pqcqtyinspected.Size = new System.Drawing.Size(231, 23);
            this.pqcqtyinspected.TabIndex = 12;
            // 
            // rfLabel5
            // 
            this.rfLabel5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel5.Location = new System.Drawing.Point(4, 157);
            this.rfLabel5.Name = "rfLabel5";
            this.rfLabel5.Size = new System.Drawing.Size(61, 14);
            this.rfLabel5.Text = "QC数量";
            // 
            // qtyExpected
            // 
            this.qtyExpected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qtyExpected.Location = new System.Drawing.Point(4, 134);
            this.qtyExpected.Name = "qtyExpected";
            this.qtyExpected.Size = new System.Drawing.Size(231, 23);
            this.qtyExpected.TabIndex = 9;
            // 
            // rfLabel4
            // 
            this.rfLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel4.Location = new System.Drawing.Point(4, 119);
            this.rfLabel4.Name = "rfLabel4";
            this.rfLabel4.Size = new System.Drawing.Size(121, 14);
            this.rfLabel4.Text = "预检数";
            // 
            // sku
            // 
            this.sku.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sku.Location = new System.Drawing.Point(4, 96);
            this.sku.Name = "sku";
            this.sku.Size = new System.Drawing.Size(231, 23);
            this.sku.TabIndex = 3;
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(4, 81);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(30, 14);
            this.rfLabel3.Text = "SKU";
            // 
            // receiptLineNumber
            // 
            this.receiptLineNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptLineNumber.Location = new System.Drawing.Point(4, 57);
            this.receiptLineNumber.Name = "receiptLineNumber";
            this.receiptLineNumber.Size = new System.Drawing.Size(231, 23);
            this.receiptLineNumber.TabIndex = 2;
            this.receiptLineNumber.LostFocus += new System.EventHandler(this.receiptLineNumber_LostFocus);
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(4, 42);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(85, 14);
            this.rfLabel2.Text = "行号";
            // 
            // receiptKey
            // 
            this.receiptKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptKey.Location = new System.Drawing.Point(4, 19);
            this.receiptKey.Name = "receiptKey";
            this.receiptKey.ReadOnly = true;
            this.receiptKey.Size = new System.Drawing.Size(231, 23);
            this.receiptKey.TabIndex = 1;
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(4, 4);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(30, 14);
            this.rfLabel1.Text = "ASN";
            // 
            // RFPqcFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.dialogbtn);
            this.Controls.Add(this.submitbt1);
            this.Controls.Add(this.pqcqtyrejected);
            this.Controls.Add(this.rfLabel6);
            this.Controls.Add(this.pqcqtyinspected);
            this.Controls.Add(this.rfLabel5);
            this.Controls.Add(this.qtyExpected);
            this.Controls.Add(this.rfLabel4);
            this.Controls.Add(this.sku);
            this.Controls.Add(this.rfLabel3);
            this.Controls.Add(this.receiptLineNumber);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.receiptKey);
            this.Controls.Add(this.rfLabel1);
            this.Name = "RFPqcFrm";
            this.Text = "执行PQC";
            this.Load += new System.EventHandler(this.RFPqcFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox receiptKey;
        private RFDeviceAPP.Common.rfTextBox receiptLineNumber;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox sku;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
        private RFDeviceAPP.Common.rfTextBox qtyExpected;
        private RFDeviceAPP.Common.rfLabel rfLabel4;
        private RFDeviceAPP.Common.rfTextBox pqcqtyinspected;
        private RFDeviceAPP.Common.rfLabel rfLabel5;
        private RFDeviceAPP.Common.rfTextBox pqcqtyrejected;
        private RFDeviceAPP.Common.rfLabel rfLabel6;
        private RFDeviceAPP.Common.rfButtonCommand submitbt1;
        private RFDeviceAPP.Common.rfButtonCommand dialogbtn;
    }
}