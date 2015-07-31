namespace RFDeviceAPP
{
    partial class RFTPA00Frm
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
            this.fromloc = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.fromid1 = new RFDeviceAPP.Common.rfTextBox();
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
            this.rfLabel1.Location = new System.Drawing.Point(4, 33);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(143, 14);
            this.rfLabel1.Text = "自库位";
            // 
            // fromloc
            // 
            this.fromloc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fromloc.Location = new System.Drawing.Point(4, 49);
            this.fromloc.Name = "fromloc";
            this.fromloc.Size = new System.Drawing.Size(231, 23);
            this.fromloc.TabIndex = 1;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(3, 72);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(143, 14);
            this.rfLabel2.Text = "LPN/载具1";
            // 
            // fromid1
            // 
            this.fromid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fromid1.Location = new System.Drawing.Point(3, 88);
            this.fromid1.Name = "fromid1";
            this.fromid1.ReadOnly = true;
            this.fromid1.Size = new System.Drawing.Size(231, 23);
            this.fromid1.TabIndex = 2;
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(124, 117);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(110, 53);
            this.submitbtn.TabIndex = 7;
            this.submitbtn.Text = "开始";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // RFTPA00Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 212);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.fromid1);
            this.Controls.Add(this.rfLabel1);
            this.Controls.Add(this.fromloc);
            this.Name = "RFTPA00Frm";
            this.Text = "开始上架任务";
            this.Controls.SetChildIndex(this.fromloc, 0);
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.fromid1, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.submitbtn, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox fromloc;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox fromid1;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
    }
}
