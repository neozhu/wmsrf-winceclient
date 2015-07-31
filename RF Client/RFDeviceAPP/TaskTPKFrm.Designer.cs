namespace RFDeviceAPP
{
    partial class TaskTPKFrm
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
            this.area01txt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.lasttaskcbo = new RFDeviceAPP.Common.rfComboBox();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
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
            this.rfLabel1.Location = new System.Drawing.Point(3, 32);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(120, 17);
            this.rfLabel1.Text = "区域";
            // 
            // area01txt
            // 
            this.area01txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.area01txt.Location = new System.Drawing.Point(4, 47);
            this.area01txt.Name = "area01txt";
            this.area01txt.Size = new System.Drawing.Size(231, 23);
            this.area01txt.TabIndex = 2;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(4, 72);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(120, 17);
            this.rfLabel2.Text = "任务类型";
            // 
            // lasttaskcbo
            // 
            this.lasttaskcbo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lasttaskcbo.Location = new System.Drawing.Point(4, 90);
            this.lasttaskcbo.Name = "lasttaskcbo";
            this.lasttaskcbo.Size = new System.Drawing.Size(231, 23);
            this.lasttaskcbo.TabIndex = 5;
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(163, 119);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(72, 52);
            this.submitbtn.TabIndex = 8;
            this.submitbtn.Text = "获取任务";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // TaskTPKFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 255);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.lasttaskcbo);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.area01txt);
            this.Controls.Add(this.rfLabel1);
            this.Name = "TaskTPKFrm";
            this.Text = "任务拣货";
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.area01txt, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.lasttaskcbo, 0);
            this.Controls.SetChildIndex(this.submitbtn, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox area01txt;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfComboBox lasttaskcbo;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
    }
}
