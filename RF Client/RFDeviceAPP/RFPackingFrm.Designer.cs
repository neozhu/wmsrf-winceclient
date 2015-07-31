namespace RFDeviceAPP
{
    partial class RFPackingFrm
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
            this.rfPanel1 = new RFDeviceAPP.Common.rfPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.submitbt1 = new RFDeviceAPP.Common.rfButtonCommand();
            this.droploctxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
            this.cartontypetxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.toidtxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.submitbt2 = new RFDeviceAPP.Common.rfButtonCommand();
            this.qtytxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel9 = new RFDeviceAPP.Common.rfLabel();
            this.skutxt = new RFDeviceAPP.Common.rfTextBox();
            this.qtypackedQtyPickedtxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel7 = new RFDeviceAPP.Common.rfLabel();
            this.orderkeytxt = new RFDeviceAPP.Common.rfTextBox();
            this.fromidtxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel5 = new RFDeviceAPP.Common.rfLabel();
            this.toidtxt1 = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel4 = new RFDeviceAPP.Common.rfLabel();
            this.rfLabel6 = new RFDeviceAPP.Common.rfLabel();
            this.rfLabel8 = new RFDeviceAPP.Common.rfLabel();
            this.rfPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // rfPanel1
            // 
            this.rfPanel1.AutoScroll = true;
            this.rfPanel1.Controls.Add(this.tabControl1);
            this.rfPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rfPanel1.Location = new System.Drawing.Point(0, 26);
            this.rfPanel1.Name = "rfPanel1";
            this.rfPanel1.Size = new System.Drawing.Size(238, 317);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(238, 317);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.submitbt1);
            this.tabPage1.Controls.Add(this.droploctxt);
            this.tabPage1.Controls.Add(this.rfLabel3);
            this.tabPage1.Controls.Add(this.cartontypetxt);
            this.tabPage1.Controls.Add(this.rfLabel2);
            this.tabPage1.Controls.Add(this.toidtxt);
            this.tabPage1.Controls.Add(this.rfLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(230, 290);
            this.tabPage1.Text = "包装箱";
            // 
            // submitbt1
            // 
            this.submitbt1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbt1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbt1.Location = new System.Drawing.Point(150, 124);
            this.submitbt1.Name = "submitbt1";
            this.submitbt1.Size = new System.Drawing.Size(77, 44);
            this.submitbt1.TabIndex = 4;
            this.submitbt1.Text = "OK";
            this.submitbt1.Click += new System.EventHandler(this.submitbt1_Click);
            // 
            // droploctxt
            // 
            this.droploctxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.droploctxt.Location = new System.Drawing.Point(4, 95);
            this.droploctxt.Name = "droploctxt";
            this.droploctxt.Size = new System.Drawing.Size(223, 23);
            this.droploctxt.TabIndex = 3;
            this.droploctxt.LostFocus += new System.EventHandler(this.droploctxt_LostFocus);
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(4, 80);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(120, 17);
            this.rfLabel3.Text = "至储位";
            // 
            // cartontypetxt
            // 
            this.cartontypetxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cartontypetxt.Location = new System.Drawing.Point(4, 57);
            this.cartontypetxt.Name = "cartontypetxt";
            this.cartontypetxt.Size = new System.Drawing.Size(223, 23);
            this.cartontypetxt.TabIndex = 2;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(4, 42);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(120, 17);
            this.rfLabel2.Text = "纸箱类型";
            // 
            // toidtxt
            // 
            this.toidtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toidtxt.Location = new System.Drawing.Point(4, 19);
            this.toidtxt.Name = "toidtxt";
            this.toidtxt.Size = new System.Drawing.Size(223, 23);
            this.toidtxt.TabIndex = 1;
            this.toidtxt.LostFocus += new System.EventHandler(this.toidtxt_LostFocus);
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(4, 4);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(120, 17);
            this.rfLabel1.Text = "箱ID";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.submitbt2);
            this.tabPage2.Controls.Add(this.qtytxt);
            this.tabPage2.Controls.Add(this.rfLabel9);
            this.tabPage2.Controls.Add(this.skutxt);
            this.tabPage2.Controls.Add(this.qtypackedQtyPickedtxt);
            this.tabPage2.Controls.Add(this.rfLabel7);
            this.tabPage2.Controls.Add(this.orderkeytxt);
            this.tabPage2.Controls.Add(this.fromidtxt);
            this.tabPage2.Controls.Add(this.rfLabel5);
            this.tabPage2.Controls.Add(this.toidtxt1);
            this.tabPage2.Controls.Add(this.rfLabel4);
            this.tabPage2.Controls.Add(this.rfLabel6);
            this.tabPage2.Controls.Add(this.rfLabel8);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(230, 290);
            this.tabPage2.Text = "包装";
            // 
            // submitbt2
            // 
            this.submitbt2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbt2.Location = new System.Drawing.Point(145, 235);
            this.submitbt2.Name = "submitbt2";
            this.submitbt2.Size = new System.Drawing.Size(82, 41);
            this.submitbt2.TabIndex = 10;
            this.submitbt2.Text = "OK";
            this.submitbt2.Click += new System.EventHandler(this.submitbt2_Click);
            // 
            // qtytxt
            // 
            this.qtytxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qtytxt.Location = new System.Drawing.Point(4, 168);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(223, 23);
            this.qtytxt.TabIndex = 8;
            // 
            // rfLabel9
            // 
            this.rfLabel9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel9.Location = new System.Drawing.Point(4, 154);
            this.rfLabel9.Name = "rfLabel9";
            this.rfLabel9.Size = new System.Drawing.Size(120, 17);
            this.rfLabel9.Text = "量";
            // 
            // skutxt
            // 
            this.skutxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.skutxt.Location = new System.Drawing.Point(4, 131);
            this.skutxt.Name = "skutxt";
            this.skutxt.Size = new System.Drawing.Size(223, 23);
            this.skutxt.TabIndex = 7;
            this.skutxt.LostFocus += new System.EventHandler(this.skutxt_LostFocus);
            // 
            // qtypackedQtyPickedtxt
            // 
            this.qtypackedQtyPickedtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qtypackedQtyPickedtxt.Location = new System.Drawing.Point(4, 205);
            this.qtypackedQtyPickedtxt.Name = "qtypackedQtyPickedtxt";
            this.qtypackedQtyPickedtxt.ReadOnly = true;
            this.qtypackedQtyPickedtxt.Size = new System.Drawing.Size(223, 23);
            this.qtypackedQtyPickedtxt.TabIndex = 9;
            // 
            // rfLabel7
            // 
            this.rfLabel7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel7.Location = new System.Drawing.Point(4, 191);
            this.rfLabel7.Name = "rfLabel7";
            this.rfLabel7.Size = new System.Drawing.Size(120, 17);
            this.rfLabel7.Text = "拣货量/已包装量";
            // 
            // orderkeytxt
            // 
            this.orderkeytxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.orderkeytxt.Location = new System.Drawing.Point(4, 57);
            this.orderkeytxt.Name = "orderkeytxt";
            this.orderkeytxt.Size = new System.Drawing.Size(223, 23);
            this.orderkeytxt.TabIndex = 6;
            // 
            // fromidtxt
            // 
            this.fromidtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fromidtxt.Location = new System.Drawing.Point(5, 95);
            this.fromidtxt.Name = "fromidtxt";
            this.fromidtxt.Size = new System.Drawing.Size(223, 23);
            this.fromidtxt.TabIndex = 5;
            // 
            // rfLabel5
            // 
            this.rfLabel5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel5.Location = new System.Drawing.Point(5, 80);
            this.rfLabel5.Name = "rfLabel5";
            this.rfLabel5.Size = new System.Drawing.Size(120, 17);
            this.rfLabel5.Text = "LPN";
            // 
            // toidtxt1
            // 
            this.toidtxt1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toidtxt1.Location = new System.Drawing.Point(4, 19);
            this.toidtxt1.Name = "toidtxt1";
            this.toidtxt1.ReadOnly = true;
            this.toidtxt1.Size = new System.Drawing.Size(223, 23);
            this.toidtxt1.TabIndex = 4;
            // 
            // rfLabel4
            // 
            this.rfLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel4.Location = new System.Drawing.Point(4, 4);
            this.rfLabel4.Name = "rfLabel4";
            this.rfLabel4.Size = new System.Drawing.Size(120, 17);
            this.rfLabel4.Text = "箱ID";
            // 
            // rfLabel6
            // 
            this.rfLabel6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel6.Location = new System.Drawing.Point(4, 43);
            this.rfLabel6.Name = "rfLabel6";
            this.rfLabel6.Size = new System.Drawing.Size(120, 17);
            this.rfLabel6.Text = "订单号";
            // 
            // rfLabel8
            // 
            this.rfLabel8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel8.Location = new System.Drawing.Point(4, 117);
            this.rfLabel8.Name = "rfLabel8";
            this.rfLabel8.Size = new System.Drawing.Size(120, 17);
            this.rfLabel8.Text = "SKU";
            // 
            // RFPackingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 343);
            this.Controls.Add(this.rfPanel1);
            this.Name = "RFPackingFrm";
            this.Text = "包装操作";
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.rfPanel1, 0);
            this.rfPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfPanel rfPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private RFDeviceAPP.Common.rfTextBox droploctxt;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
        private RFDeviceAPP.Common.rfTextBox cartontypetxt;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox toidtxt;
        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox qtypackedQtyPickedtxt;
        private RFDeviceAPP.Common.rfLabel rfLabel7;
        private RFDeviceAPP.Common.rfTextBox orderkeytxt;
        private RFDeviceAPP.Common.rfTextBox fromidtxt;
        private RFDeviceAPP.Common.rfLabel rfLabel5;
        private RFDeviceAPP.Common.rfTextBox toidtxt1;
        private RFDeviceAPP.Common.rfLabel rfLabel4;
        private RFDeviceAPP.Common.rfLabel rfLabel6;
        private RFDeviceAPP.Common.rfTextBox qtytxt;
        private RFDeviceAPP.Common.rfLabel rfLabel9;
        private RFDeviceAPP.Common.rfTextBox skutxt;
        private RFDeviceAPP.Common.rfLabel rfLabel8;
        private RFDeviceAPP.Common.rfButtonCommand submitbt1;
        private RFDeviceAPP.Common.rfButtonCommand submitbt2;
    }
}
