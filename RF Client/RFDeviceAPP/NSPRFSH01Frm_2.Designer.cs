namespace RFDeviceAPP
{
    partial class NSPRFSH01Frm_2
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
            this.toid = new RFDeviceAPP.Common.rfTextBox();
            this.parknumtxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel4 = new RFDeviceAPP.Common.rfLabel();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // toid
            // 
            this.toid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toid.Location = new System.Drawing.Point(3, 67);
            this.toid.Name = "toid";
            this.toid.ReadOnly = true;
            this.toid.Size = new System.Drawing.Size(231, 23);
            this.toid.TabIndex = 8;
            // 
            // parknumtxt
            // 
            this.parknumtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.parknumtxt.Location = new System.Drawing.Point(3, 43);
            this.parknumtxt.Name = "parknumtxt";
            this.parknumtxt.Size = new System.Drawing.Size(231, 23);
            this.parknumtxt.TabIndex = 7;
            this.parknumtxt.LostFocus += new System.EventHandler(this.parknumtxt_LostFocus);
            // 
            // rfLabel4
            // 
            this.rfLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel4.Location = new System.Drawing.Point(3, 29);
            this.rfLabel4.Name = "rfLabel4";
            this.rfLabel4.Size = new System.Drawing.Size(100, 14);
            this.rfLabel4.Text = "停车证牌号";
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(143, 96);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(91, 55);
            this.submitbtn.TabIndex = 11;
            this.submitbtn.Text = "发运";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // NSPRFSH01Frm_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 374);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.toid);
            this.Controls.Add(this.parknumtxt);
            this.Controls.Add(this.rfLabel4);
            this.Name = "NSPRFSH01Frm_2";
            this.Text = "发运操作";
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.rfLabel4, 0);
            this.Controls.SetChildIndex(this.parknumtxt, 0);
            this.Controls.SetChildIndex(this.toid, 0);
            this.Controls.SetChildIndex(this.submitbtn, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfTextBox toid;
        private RFDeviceAPP.Common.rfTextBox parknumtxt;
        private RFDeviceAPP.Common.rfLabel rfLabel4;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
    }
}
