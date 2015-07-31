namespace RFDeviceAPP
{
    partial class RFFLPickingFrm
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
            this.sotxt = new RFDeviceAPP.Common.rfTextBox();
            this.fromidtxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.skutxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
            this.qtytxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel4 = new RFDeviceAPP.Common.rfLabel();
            this.dropidtxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel5 = new RFDeviceAPP.Common.rfLabel();
            this.loadcasetxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel6 = new RFDeviceAPP.Common.rfLabel();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.submitbt = new RFDeviceAPP.Common.rfButtonCommand();
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
            this.rfLabel1.Location = new System.Drawing.Point(4, 36);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(120, 17);
            this.rfLabel1.Text = "订单号";
            // 
            // sotxt
            // 
            this.sotxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sotxt.Location = new System.Drawing.Point(4, 50);
            this.sotxt.Name = "sotxt";
            this.sotxt.Size = new System.Drawing.Size(231, 23);
            this.sotxt.TabIndex = 0;
            // 
            // fromidtxt
            // 
            this.fromidtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fromidtxt.Location = new System.Drawing.Point(4, 87);
            this.fromidtxt.Name = "fromidtxt";
            this.fromidtxt.Size = new System.Drawing.Size(231, 23);
            this.fromidtxt.TabIndex = 2;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(4, 73);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(120, 17);
            this.rfLabel2.Text = "LPN";
            // 
            // skutxt
            // 
            this.skutxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.skutxt.Location = new System.Drawing.Point(4, 124);
            this.skutxt.Name = "skutxt";
            this.skutxt.Size = new System.Drawing.Size(231, 23);
            this.skutxt.TabIndex = 3;
            this.skutxt.LostFocus += new System.EventHandler(this.skutxt_LostFocus);
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(4, 110);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(120, 17);
            this.rfLabel3.Text = "SKU";
            // 
            // qtytxt
            // 
            this.qtytxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qtytxt.Location = new System.Drawing.Point(4, 161);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(231, 23);
            this.qtytxt.TabIndex = 4;
            // 
            // rfLabel4
            // 
            this.rfLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel4.Location = new System.Drawing.Point(4, 147);
            this.rfLabel4.Name = "rfLabel4";
            this.rfLabel4.Size = new System.Drawing.Size(120, 17);
            this.rfLabel4.Text = "拣货量";
            // 
            // dropidtxt
            // 
            this.dropidtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dropidtxt.Location = new System.Drawing.Point(4, 198);
            this.dropidtxt.Name = "dropidtxt";
            this.dropidtxt.Size = new System.Drawing.Size(231, 23);
            this.dropidtxt.TabIndex = 5;
            this.dropidtxt.LostFocus += new System.EventHandler(this.dropidtxt_LostFocus);
            // 
            // rfLabel5
            // 
            this.rfLabel5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel5.Location = new System.Drawing.Point(4, 184);
            this.rfLabel5.Name = "rfLabel5";
            this.rfLabel5.Size = new System.Drawing.Size(120, 17);
            this.rfLabel5.Text = "落放ID";
            // 
            // loadcasetxt
            // 
            this.loadcasetxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.loadcasetxt.Location = new System.Drawing.Point(4, 235);
            this.loadcasetxt.Name = "loadcasetxt";
            this.loadcasetxt.Size = new System.Drawing.Size(231, 23);
            this.loadcasetxt.TabIndex = 6;
            // 
            // rfLabel6
            // 
            this.rfLabel6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel6.Location = new System.Drawing.Point(4, 221);
            this.rfLabel6.Name = "rfLabel6";
            this.rfLabel6.Size = new System.Drawing.Size(120, 17);
            this.rfLabel6.Text = "纸箱";
            // 
            // lb1
            // 
            this.lb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lb1.Location = new System.Drawing.Point(4, 265);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(231, 20);
            this.lb1.Text = "ID现有库存{0.0}";
            // 
            // lb2
            // 
            this.lb2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lb2.Location = new System.Drawing.Point(4, 285);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(231, 20);
            this.lb2.Text = "ID拣后库存{0.0}";
            // 
            // lb3
            // 
            this.lb3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lb3.Location = new System.Drawing.Point(4, 311);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(231, 20);
            this.lb3.Text = "储位现有库存{0.0}";
            // 
            // lb4
            // 
            this.lb4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lb4.Location = new System.Drawing.Point(4, 330);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(231, 20);
            this.lb4.Text = "储位拣后库存{0.0}";
            // 
            // submitbt
            // 
            this.submitbt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbt.Location = new System.Drawing.Point(135, 358);
            this.submitbt.Name = "submitbt";
            this.submitbt.Size = new System.Drawing.Size(100, 48);
            this.submitbt.TabIndex = 7;
            this.submitbt.Text = "OK";
            this.submitbt.Click += new System.EventHandler(this.submitbt_Click);
            // 
            // RFFLPickingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 409);
            this.Controls.Add(this.submitbt);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.loadcasetxt);
            this.Controls.Add(this.rfLabel6);
            this.Controls.Add(this.dropidtxt);
            this.Controls.Add(this.rfLabel5);
            this.Controls.Add(this.qtytxt);
            this.Controls.Add(this.rfLabel4);
            this.Controls.Add(this.skutxt);
            this.Controls.Add(this.rfLabel3);
            this.Controls.Add(this.fromidtxt);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.sotxt);
            this.Controls.Add(this.rfLabel1);
            this.Name = "RFFLPickingFrm";
            this.Text = "简易拣货";
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.sotxt, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.fromidtxt, 0);
            this.Controls.SetChildIndex(this.rfLabel3, 0);
            this.Controls.SetChildIndex(this.skutxt, 0);
            this.Controls.SetChildIndex(this.rfLabel4, 0);
            this.Controls.SetChildIndex(this.qtytxt, 0);
            this.Controls.SetChildIndex(this.rfLabel5, 0);
            this.Controls.SetChildIndex(this.dropidtxt, 0);
            this.Controls.SetChildIndex(this.rfLabel6, 0);
            this.Controls.SetChildIndex(this.loadcasetxt, 0);
            this.Controls.SetChildIndex(this.lb1, 0);
            this.Controls.SetChildIndex(this.lb2, 0);
            this.Controls.SetChildIndex(this.lb3, 0);
            this.Controls.SetChildIndex(this.lb4, 0);
            this.Controls.SetChildIndex(this.submitbt, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox sotxt;
        private RFDeviceAPP.Common.rfTextBox fromidtxt;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox skutxt;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
        private RFDeviceAPP.Common.rfTextBox qtytxt;
        private RFDeviceAPP.Common.rfLabel rfLabel4;
        private RFDeviceAPP.Common.rfTextBox dropidtxt;
        private RFDeviceAPP.Common.rfLabel rfLabel5;
        private RFDeviceAPP.Common.rfTextBox loadcasetxt;
        private RFDeviceAPP.Common.rfLabel rfLabel6;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private RFDeviceAPP.Common.rfButtonCommand submitbt;
    }
}
