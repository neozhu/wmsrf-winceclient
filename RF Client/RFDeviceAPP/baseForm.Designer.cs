namespace RFDeviceAPP
{
    partial class baseForm
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
            this.userStatusControl1 = new RFDeviceAPP.UserStatusControl();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userStatusControl1.Location = new System.Drawing.Point(0, 0);
            this.userStatusControl1.LoginUser = null;
            this.userStatusControl1.Name = "userStatusControl1";
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            this.userStatusControl1.TabIndex = 0;
            // 
            // baseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.userStatusControl1);
            this.Controls.SetChildIndex(this.userStatusControl1,100);
            this.Name = "baseForm";
            this.Text = "baseForm";
            this.Load += new System.EventHandler(this.baseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public UserStatusControl userStatusControl1;

    }
}