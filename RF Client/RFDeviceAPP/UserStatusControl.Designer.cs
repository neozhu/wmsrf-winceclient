namespace RFDeviceAPP
{
    partial class UserStatusControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernamelabel = new System.Windows.Forms.Label();
            this.whcodelabel = new System.Windows.Forms.Label();
            this.statuslabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // usernamelabel
            // 
            this.usernamelabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.usernamelabel.Location = new System.Drawing.Point(4, 4);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(73, 20);
            this.usernamelabel.Text = "姓名张三";
            // 
            // whcodelabel
            // 
            this.whcodelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.whcodelabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.whcodelabel.Location = new System.Drawing.Point(113, 4);
            this.whcodelabel.Name = "whcodelabel";
            this.whcodelabel.Size = new System.Drawing.Size(124, 20);
            this.whcodelabel.Text = "infowms-1";
            // 
            // statuslabel
            // 
            this.statuslabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.statuslabel.Location = new System.Drawing.Point(65, 4);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(45, 20);
            this.statuslabel.Text = "登录中";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(4, 22);
            this.progressBar.Maximum = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(233, 20);
            // 
            // UserStatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.whcodelabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.statuslabel);
            this.Name = "UserStatusControl";
            this.Size = new System.Drawing.Size(240, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label whcodelabel;
        private System.Windows.Forms.Label statuslabel;
        public System.Windows.Forms.ProgressBar progressBar;
    }
}
