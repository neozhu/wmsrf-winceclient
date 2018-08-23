namespace KanbanRF
{
    partial class inFrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.kanbantxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(149, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 66);
            this.button1.TabIndex = 5;
            this.button1.Text = "完成";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kanbantxt
            // 
            this.kanbantxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kanbantxt.Location = new System.Drawing.Point(4, 31);
            this.kanbantxt.Name = "kanbantxt";
            this.kanbantxt.Size = new System.Drawing.Size(231, 23);
            this.kanbantxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "看板号";
            // 
            // inFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kanbantxt);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "inFrm";
            this.Text = "总装交接扫描";
            this.Load += new System.EventHandler(this.inFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kanbantxt;
        private System.Windows.Forms.Label label1;
    }
}