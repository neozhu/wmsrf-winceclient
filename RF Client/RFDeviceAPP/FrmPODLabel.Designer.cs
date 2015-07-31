namespace RFDeviceAPP
{
    partial class FrmPODLabel
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
            this.qty1 = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.checkuser = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.orderkey = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.qty2 = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel4 = new RFDeviceAPP.Common.rfLabel();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // qty1
            // 
            this.qty1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qty1.Location = new System.Drawing.Point(3, 126);
            this.qty1.Name = "qty1";
            this.qty1.Size = new System.Drawing.Size(231, 23);
            this.qty1.TabIndex = 3;
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(3, 111);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(43, 14);
            this.rfLabel3.Text = "制标数";
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Location = new System.Drawing.Point(150, 195);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(84, 52);
            this.submitbtn.TabIndex = 5;
            this.submitbtn.Text = "OK";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // checkuser
            // 
            this.checkuser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.checkuser.Location = new System.Drawing.Point(3, 86);
            this.checkuser.Name = "checkuser";
            this.checkuser.Size = new System.Drawing.Size(231, 23);
            this.checkuser.TabIndex = 2;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(3, 71);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(43, 14);
            this.rfLabel2.Text = "贴标员";
            // 
            // orderkey
            // 
            this.orderkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.orderkey.Location = new System.Drawing.Point(3, 46);
            this.orderkey.Name = "orderkey";
            this.orderkey.Size = new System.Drawing.Size(231, 23);
            this.orderkey.TabIndex = 1;
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(3, 31);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(43, 14);
            this.rfLabel1.Text = "订单号";
            // 
            // qty2
            // 
            this.qty2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qty2.Location = new System.Drawing.Point(3, 166);
            this.qty2.Name = "qty2";
            this.qty2.Size = new System.Drawing.Size(231, 23);
            this.qty2.TabIndex = 4;
            // 
            // rfLabel4
            // 
            this.rfLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel4.Location = new System.Drawing.Point(3, 151);
            this.rfLabel4.Name = "rfLabel4";
            this.rfLabel4.Size = new System.Drawing.Size(43, 14);
            this.rfLabel4.Text = "贴标数";
            // 
            // FrmPODLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 401);
            this.Controls.Add(this.qty2);
            this.Controls.Add(this.rfLabel4);
            this.Controls.Add(this.qty1);
            this.Controls.Add(this.rfLabel3);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.checkuser);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.orderkey);
            this.Controls.Add(this.rfLabel1);
            this.Name = "FrmPODLabel";
            this.Text = "贴标POD";
            this.Load += new System.EventHandler(this.FrmPODLabel_Load);
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
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfTextBox qty1;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
        private RFDeviceAPP.Common.rfTextBox checkuser;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox orderkey;
        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox qty2;
        private RFDeviceAPP.Common.rfLabel rfLabel4;
    }
}
