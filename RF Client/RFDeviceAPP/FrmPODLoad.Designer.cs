namespace RFDeviceAPP
{
    partial class FrmPODLoad
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.qty2 = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel4 = new RFDeviceAPP.Common.rfLabel();
            this.qty1 = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.checkuser = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.orderkey = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.qty3 = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel5 = new RFDeviceAPP.Common.rfLabel();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // qty2
            // 
            this.qty2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qty2.Location = new System.Drawing.Point(3, 165);
            this.qty2.Name = "qty2";
            this.qty2.Size = new System.Drawing.Size(231, 23);
            this.qty2.TabIndex = 4;
            this.qty2.TextChanged += new System.EventHandler(this.qty2_TextChanged);
            // 
            // rfLabel4
            // 
            this.rfLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel4.Location = new System.Drawing.Point(3, 150);
            this.rfLabel4.Name = "rfLabel4";
            this.rfLabel4.Size = new System.Drawing.Size(43, 14);
            this.rfLabel4.Text = "托盘数";
            // 
            // qty1
            // 
            this.qty1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qty1.Location = new System.Drawing.Point(3, 125);
            this.qty1.Name = "qty1";
            this.qty1.Size = new System.Drawing.Size(231, 23);
            this.qty1.TabIndex = 3;
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(3, 110);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(43, 14);
            this.rfLabel3.Text = "整箱数";
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Location = new System.Drawing.Point(150, 234);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(84, 52);
            this.submitbtn.TabIndex = 6;
            this.submitbtn.Text = "OK";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // checkuser
            // 
            this.checkuser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.checkuser.Location = new System.Drawing.Point(3, 85);
            this.checkuser.Name = "checkuser";
            this.checkuser.Size = new System.Drawing.Size(231, 23);
            this.checkuser.TabIndex = 2;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(3, 70);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(43, 14);
            this.rfLabel2.Text = "装车员";
            // 
            // orderkey
            // 
            this.orderkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.orderkey.Location = new System.Drawing.Point(3, 45);
            this.orderkey.Name = "orderkey";
            this.orderkey.Size = new System.Drawing.Size(231, 23);
            this.orderkey.TabIndex = 1;
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(3, 30);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(43, 14);
            this.rfLabel1.Text = "订单号";
            // 
            // qty3
            // 
            this.qty3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qty3.Location = new System.Drawing.Point(4, 205);
            this.qty3.Name = "qty3";
            this.qty3.Size = new System.Drawing.Size(231, 23);
            this.qty3.TabIndex = 5;
            this.qty3.Text = "0";
            // 
            // rfLabel5
            // 
            this.rfLabel5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel5.Location = new System.Drawing.Point(4, 190);
            this.rfLabel5.Name = "rfLabel5";
            this.rfLabel5.Size = new System.Drawing.Size(43, 14);
            this.rfLabel5.Text = "散箱数";
            // 
            // FrmPODLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 401);
            this.Controls.Add(this.qty3);
            this.Controls.Add(this.rfLabel5);
            this.Controls.Add(this.qty2);
            this.Controls.Add(this.rfLabel4);
            this.Controls.Add(this.qty1);
            this.Controls.Add(this.rfLabel3);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.checkuser);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.orderkey);
            this.Controls.Add(this.rfLabel1);
            this.Name = "FrmPODLoad";
            this.Text = "装车POD";
            this.Load += new System.EventHandler(this.FrmPODLoad_Load);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.orderkey, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.checkuser, 0);
            this.Controls.SetChildIndex(this.submitbtn, 0);
            this.Controls.SetChildIndex(this.rfLabel3, 0);
            this.Controls.SetChildIndex(this.qty1, 0);
            this.Controls.SetChildIndex(this.rfLabel4, 0);
            this.Controls.SetChildIndex(this.qty2, 0);
            this.Controls.SetChildIndex(this.rfLabel5, 0);
            this.Controls.SetChildIndex(this.qty3, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfTextBox qty2;
        private RFDeviceAPP.Common.rfLabel rfLabel4;
        private RFDeviceAPP.Common.rfTextBox qty1;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
        private RFDeviceAPP.Common.rfTextBox checkuser;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox orderkey;
        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox qty3;
        private RFDeviceAPP.Common.rfLabel rfLabel5;
    }
}
