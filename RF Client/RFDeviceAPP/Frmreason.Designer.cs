namespace RFDeviceAPP
{
    partial class Frmreason
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.okbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(3, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 114);
            this.listBox1.TabIndex = 0;
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(163, 121);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(72, 47);
            this.okbtn.TabIndex = 1;
            this.okbtn.Text = "OK";
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // Frmreason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 181);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.listBox1);
            this.Name = "Frmreason";
            this.Text = "请选择原因";
            this.Load += new System.EventHandler(this.Frmreason_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private RFDeviceAPP.Common.rfButtonCommand okbtn;

    }
}