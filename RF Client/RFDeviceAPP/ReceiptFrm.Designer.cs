namespace RFDeviceAPP
{
    partial class ReceiptFrm
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
            this.receiptkeytxt = new RFDeviceAPP.Common.rfTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linenumtxt = new RFDeviceAPP.Common.rfTextBox();
            this.skutxt = new RFDeviceAPP.Common.rfTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qtyreceivedtxt = new RFDeviceAPP.Common.rfTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toidtxt = new RFDeviceAPP.Common.rfTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toloctxt = new RFDeviceAPP.Common.rfTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.asnlinedetaillabel = new System.Windows.Forms.Label();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.packkeytxt = new RFDeviceAPP.Common.rfTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statelabel = new System.Windows.Forms.Label();
            this.skudetaillabel = new System.Windows.Forms.Label();
            this.asndetaillabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.Text = "ASN";
            // 
            // receiptkeytxt
            // 
            this.receiptkeytxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptkeytxt.Location = new System.Drawing.Point(4, 48);
            this.receiptkeytxt.Name = "receiptkeytxt";
            this.receiptkeytxt.Size = new System.Drawing.Size(231, 23);
            this.receiptkeytxt.TabIndex = 1;
            this.receiptkeytxt.TextChanged += new System.EventHandler(this.receiptkeytxt_TextChanged);
            this.receiptkeytxt.LostFocus += new System.EventHandler(this.receiptkeytxt_LostFocus);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.Text = "行号";
            // 
            // linenumtxt
            // 
            this.linenumtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.linenumtxt.Location = new System.Drawing.Point(4, 89);
            this.linenumtxt.Name = "linenumtxt";
            this.linenumtxt.Size = new System.Drawing.Size(231, 23);
            this.linenumtxt.TabIndex = 2;
            this.linenumtxt.LostFocus += new System.EventHandler(this.linenumtxt_LostFocus);
            // 
            // skutxt
            // 
            this.skutxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.skutxt.Location = new System.Drawing.Point(4, 129);
            this.skutxt.Name = "skutxt";
            this.skutxt.Size = new System.Drawing.Size(231, 23);
            this.skutxt.TabIndex = 3;
            this.skutxt.LostFocus += new System.EventHandler(this.skutxt_LostFocus);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.Text = "SKU";
            // 
            // qtyreceivedtxt
            // 
            this.qtyreceivedtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qtyreceivedtxt.Location = new System.Drawing.Point(4, 169);
            this.qtyreceivedtxt.Name = "qtyreceivedtxt";
            this.qtyreceivedtxt.Size = new System.Drawing.Size(231, 23);
            this.qtyreceivedtxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "收货数量";
            // 
            // toidtxt
            // 
            this.toidtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toidtxt.Location = new System.Drawing.Point(4, 207);
            this.toidtxt.Name = "toidtxt";
            this.toidtxt.Size = new System.Drawing.Size(231, 23);
            this.toidtxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "LPN";
            // 
            // toloctxt
            // 
            this.toloctxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toloctxt.Location = new System.Drawing.Point(4, 247);
            this.toloctxt.Name = "toloctxt";
            this.toloctxt.Size = new System.Drawing.Size(231, 23);
            this.toloctxt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "载具ID";
            // 
            // asnlinedetaillabel
            // 
            this.asnlinedetaillabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.asnlinedetaillabel.Location = new System.Drawing.Point(47, 72);
            this.asnlinedetaillabel.Name = "asnlinedetaillabel";
            this.asnlinedetaillabel.Size = new System.Drawing.Size(187, 20);
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(147, 316);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(88, 43);
            this.submitbtn.TabIndex = 8;
            this.submitbtn.Text = "完成";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // packkeytxt
            // 
            this.packkeytxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.packkeytxt.Location = new System.Drawing.Point(4, 287);
            this.packkeytxt.Name = "packkeytxt";
            this.packkeytxt.Size = new System.Drawing.Size(231, 23);
            this.packkeytxt.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(4, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.Text = "包装方式";
            // 
            // statelabel
            // 
            this.statelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.statelabel.Location = new System.Drawing.Point(209, 33);
            this.statelabel.Name = "statelabel";
            this.statelabel.Size = new System.Drawing.Size(26, 20);
            // 
            // skudetaillabel
            // 
            this.skudetaillabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.skudetaillabel.Location = new System.Drawing.Point(47, 112);
            this.skudetaillabel.Name = "skudetaillabel";
            this.skudetaillabel.Size = new System.Drawing.Size(187, 20);
            // 
            // asndetaillabel
            // 
            this.asndetaillabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.asndetaillabel.Location = new System.Drawing.Point(42, 33);
            this.asndetaillabel.Name = "asndetaillabel";
            this.asndetaillabel.Size = new System.Drawing.Size(187, 20);
            // 
            // ReceiptFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 364);
            this.Controls.Add(this.packkeytxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.toloctxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toidtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qtyreceivedtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.skutxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linenumtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.receiptkeytxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asnlinedetaillabel);
            this.Controls.Add(this.skudetaillabel);
            this.Controls.Add(this.asndetaillabel);
            this.Controls.Add(this.statelabel);
            this.Name = "ReceiptFrm";
            this.Text = "收货操作";
            this.Load += new System.EventHandler(this.ReceiptFrm_Load);
            this.Controls.SetChildIndex(this.statelabel, 0);
            this.Controls.SetChildIndex(this.asndetaillabel, 0);
            this.Controls.SetChildIndex(this.skudetaillabel, 0);
            this.Controls.SetChildIndex(this.asnlinedetaillabel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.receiptkeytxt, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.linenumtxt, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.skutxt, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.qtyreceivedtxt, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.toidtxt, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.toloctxt, 0);
            this.Controls.SetChildIndex(this.submitbtn, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.packkeytxt, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RFDeviceAPP.Common.rfTextBox receiptkeytxt;
        private System.Windows.Forms.Label label2;
        private RFDeviceAPP.Common.rfTextBox linenumtxt;
        private RFDeviceAPP.Common.rfTextBox skutxt;
        private System.Windows.Forms.Label label3;
        private RFDeviceAPP.Common.rfTextBox qtyreceivedtxt;
        private System.Windows.Forms.Label label4;
        private RFDeviceAPP.Common.rfTextBox toidtxt;
        private System.Windows.Forms.Label label5;
        private RFDeviceAPP.Common.rfTextBox toloctxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label asnlinedetaillabel;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
        private RFDeviceAPP.Common.rfTextBox packkeytxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label statelabel;
        private System.Windows.Forms.Label skudetaillabel;
        private System.Windows.Forms.Label asndetaillabel;
    }
}
