namespace RFDeviceAPP
{
    partial class RFLottableReciptFrm
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
            this.toppanel = new System.Windows.Forms.Panel();
            this.idtxt = new RFDeviceAPP.Common.rfTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.loctxt = new RFDeviceAPP.Common.rfTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.qtytxt = new RFDeviceAPP.Common.rfTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.packkeytxt = new RFDeviceAPP.Common.rfTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.desctxt = new RFDeviceAPP.Common.rfTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.skutxt = new RFDeviceAPP.Common.rfTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.storerkeytxt = new RFDeviceAPP.Common.rfTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.receiptLineNumbertxt = new RFDeviceAPP.Common.rfTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.receiptkeytxt = new RFDeviceAPP.Common.rfTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bodypanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submitdrid = new RFDeviceAPP.Common.rfButtonCommand();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.toppanel.SuspendLayout();
            this.bodypanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.idtxt);
            this.toppanel.Controls.Add(this.label10);
            this.toppanel.Controls.Add(this.loctxt);
            this.toppanel.Controls.Add(this.label9);
            this.toppanel.Controls.Add(this.qtytxt);
            this.toppanel.Controls.Add(this.label7);
            this.toppanel.Controls.Add(this.packkeytxt);
            this.toppanel.Controls.Add(this.label6);
            this.toppanel.Controls.Add(this.desctxt);
            this.toppanel.Controls.Add(this.label5);
            this.toppanel.Controls.Add(this.skutxt);
            this.toppanel.Controls.Add(this.label4);
            this.toppanel.Controls.Add(this.storerkeytxt);
            this.toppanel.Controls.Add(this.label3);
            this.toppanel.Controls.Add(this.receiptLineNumbertxt);
            this.toppanel.Controls.Add(this.label2);
            this.toppanel.Controls.Add(this.receiptkeytxt);
            this.toppanel.Controls.Add(this.label1);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 26);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(238, 350);
            // 
            // idtxt
            // 
            this.idtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.idtxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.idtxt.Location = new System.Drawing.Point(4, 324);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(231, 21);
            this.idtxt.TabIndex = 27;
            this.idtxt.TextChanged += new System.EventHandler(this.idtxt_TextChanged);
            this.idtxt.LostFocus += new System.EventHandler(this.idtxt_LostFocus);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label10.Location = new System.Drawing.Point(3, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.Text = "LPN";
            // 
            // loctxt
            // 
            this.loctxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.loctxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.loctxt.Location = new System.Drawing.Point(4, 285);
            this.loctxt.Name = "loctxt";
            this.loctxt.Size = new System.Drawing.Size(231, 21);
            this.loctxt.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label9.Location = new System.Drawing.Point(3, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.Text = "库位";
            // 
            // qtytxt
            // 
            this.qtytxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qtytxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.qtytxt.Location = new System.Drawing.Point(4, 247);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(231, 21);
            this.qtytxt.TabIndex = 18;
            this.qtytxt.LostFocus += new System.EventHandler(this.qtytxt_LostFocus);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(3, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.Text = "量";
            // 
            // packkeytxt
            // 
            this.packkeytxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.packkeytxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.packkeytxt.Location = new System.Drawing.Point(4, 209);
            this.packkeytxt.Name = "packkeytxt";
            this.packkeytxt.Size = new System.Drawing.Size(231, 21);
            this.packkeytxt.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(3, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.Text = "包装";
            // 
            // desctxt
            // 
            this.desctxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.desctxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.desctxt.Location = new System.Drawing.Point(4, 171);
            this.desctxt.Name = "desctxt";
            this.desctxt.ReadOnly = true;
            this.desctxt.Size = new System.Drawing.Size(231, 21);
            this.desctxt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(3, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.Text = "说明";
            // 
            // skutxt
            // 
            this.skutxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.skutxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.skutxt.Location = new System.Drawing.Point(4, 133);
            this.skutxt.Name = "skutxt";
            this.skutxt.Size = new System.Drawing.Size(231, 21);
            this.skutxt.TabIndex = 9;
            this.skutxt.LostFocus += new System.EventHandler(this.skutxt_LostFocus);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(3, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.Text = "SKU";
            // 
            // storerkeytxt
            // 
            this.storerkeytxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.storerkeytxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.storerkeytxt.Location = new System.Drawing.Point(4, 95);
            this.storerkeytxt.Name = "storerkeytxt";
            this.storerkeytxt.ReadOnly = true;
            this.storerkeytxt.Size = new System.Drawing.Size(231, 21);
            this.storerkeytxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.Text = "货主";
            // 
            // receiptLineNumbertxt
            // 
            this.receiptLineNumbertxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptLineNumbertxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.receiptLineNumbertxt.Location = new System.Drawing.Point(4, 56);
            this.receiptLineNumbertxt.Name = "receiptLineNumbertxt";
            this.receiptLineNumbertxt.Size = new System.Drawing.Size(231, 21);
            this.receiptLineNumbertxt.TabIndex = 3;
            this.receiptLineNumbertxt.LostFocus += new System.EventHandler(this.receiptLineNumbertxt_LostFocus);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.Text = "行号";
            // 
            // receiptkeytxt
            // 
            this.receiptkeytxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptkeytxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.receiptkeytxt.Location = new System.Drawing.Point(4, 18);
            this.receiptkeytxt.Name = "receiptkeytxt";
            this.receiptkeytxt.Size = new System.Drawing.Size(231, 21);
            this.receiptkeytxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.Text = "ASN";
            // 
            // bodypanel
            // 
            this.bodypanel.Controls.Add(this.panel1);
            this.bodypanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bodypanel.Location = new System.Drawing.Point(0, 376);
            this.bodypanel.Name = "bodypanel";
            this.bodypanel.Size = new System.Drawing.Size(238, 72);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.submitdrid);
            this.panel1.Controls.Add(this.submitbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 66);
            // 
            // submitdrid
            // 
            this.submitdrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitdrid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitdrid.Location = new System.Drawing.Point(84, 4);
            this.submitdrid.Name = "submitdrid";
            this.submitdrid.Size = new System.Drawing.Size(64, 46);
            this.submitdrid.TabIndex = 101;
            this.submitdrid.Text = "提交载具";
            this.submitdrid.Click += new System.EventHandler(this.submitdrid_Click);
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(154, 4);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(81, 46);
            this.submitbtn.TabIndex = 100;
            this.submitbtn.Text = "继续";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // RFLottableReciptFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 517);
            this.Controls.Add(this.bodypanel);
            this.Controls.Add(this.toppanel);
            this.Name = "RFLottableReciptFrm";
            this.Text = "RF批属性收货";
            this.Load += new System.EventHandler(this.RFLottableReciptFrm_Load);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.toppanel, 0);
            this.Controls.SetChildIndex(this.bodypanel, 0);
            this.toppanel.ResumeLayout(false);
            this.bodypanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private RFDeviceAPP.Common.rfTextBox receiptkeytxt;
        private System.Windows.Forms.Label label1;
        private RFDeviceAPP.Common.rfTextBox skutxt;
        private System.Windows.Forms.Label label4;
        private RFDeviceAPP.Common.rfTextBox storerkeytxt;
        private System.Windows.Forms.Label label3;
        private RFDeviceAPP.Common.rfTextBox receiptLineNumbertxt;
        private System.Windows.Forms.Label label2;
        private RFDeviceAPP.Common.rfTextBox desctxt;
        private System.Windows.Forms.Label label5;
        private RFDeviceAPP.Common.rfTextBox qtytxt;
        private System.Windows.Forms.Label label7;
        private RFDeviceAPP.Common.rfTextBox packkeytxt;
        private System.Windows.Forms.Label label6;
        private RFDeviceAPP.Common.rfTextBox idtxt;
        private System.Windows.Forms.Label label10;
        private RFDeviceAPP.Common.rfTextBox loctxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel bodypanel;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
        private System.Windows.Forms.Panel panel1;
        private RFDeviceAPP.Common.rfButtonCommand submitdrid;
    }
}
