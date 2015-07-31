namespace RFDeviceAPP
{
    partial class TestForm11
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
            this.rfButtonCommand1 = new RFDeviceAPP.Common.rfButtonCommand();
            this.rfTextBox2 = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.rfTextBox1 = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.rfPanel1.SuspendLayout();
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
            this.rfPanel1.Controls.Add(this.rfButtonCommand1);
            this.rfPanel1.Controls.Add(this.rfTextBox2);
            this.rfPanel1.Controls.Add(this.rfLabel2);
            this.rfPanel1.Controls.Add(this.rfTextBox1);
            this.rfPanel1.Controls.Add(this.rfLabel1);
            this.rfPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rfPanel1.Location = new System.Drawing.Point(0, 26);
            this.rfPanel1.Name = "rfPanel1";
            this.rfPanel1.Size = new System.Drawing.Size(238, 269);
            // 
            // rfButtonCommand1
            // 
            this.rfButtonCommand1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rfButtonCommand1.Location = new System.Drawing.Point(153, 483);
            this.rfButtonCommand1.Name = "rfButtonCommand1";
            this.rfButtonCommand1.Size = new System.Drawing.Size(31, 66);
            this.rfButtonCommand1.TabIndex = 4;
            this.rfButtonCommand1.Text = "rfButtonCommand1";
            // 
            // rfTextBox2
            // 
            this.rfTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rfTextBox2.Location = new System.Drawing.Point(4, 454);
            this.rfTextBox2.Name = "rfTextBox2";
            this.rfTextBox2.Size = new System.Drawing.Size(180, 23);
            this.rfTextBox2.TabIndex = 3;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Location = new System.Drawing.Point(4, 436);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(50, 14);
            this.rfLabel2.Text = "rfLabel2";
            // 
            // rfTextBox1
            // 
            this.rfTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rfTextBox1.Location = new System.Drawing.Point(3, 46);
            this.rfTextBox1.Name = "rfTextBox1";
            this.rfTextBox1.Size = new System.Drawing.Size(198, 23);
            this.rfTextBox1.TabIndex = 1;
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(3, 29);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(100, 17);
            this.rfLabel1.Text = "rfLabel1";
            // 
            // TestForm11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.rfPanel1);
            this.Name = "TestForm11";
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.rfPanel1, 0);
            this.rfPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfPanel rfPanel1;
        private RFDeviceAPP.Common.rfButtonCommand rfButtonCommand1;
        private RFDeviceAPP.Common.rfTextBox rfTextBox2;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox rfTextBox1;
        private RFDeviceAPP.Common.rfLabel rfLabel1;
    }
}
