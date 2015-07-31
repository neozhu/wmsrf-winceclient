namespace RFDeviceAPP
{
    partial class RFTPA02Frm
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
            this.lpnlist = new System.Windows.Forms.ListBox();
            this.submitsingle = new RFDeviceAPP.Common.rfButtonCommand();
            this.lpn = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.toloc2 = new RFDeviceAPP.Common.rfTextBox();
            this.toloc1 = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.lpncount = new RFDeviceAPP.Common.rfLabel();
            this.SuspendLayout();
            // 
            // lpnlist
            // 
            this.lpnlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lpnlist.Location = new System.Drawing.Point(3, 3);
            this.lpnlist.Name = "lpnlist";
            this.lpnlist.Size = new System.Drawing.Size(232, 114);
            this.lpnlist.TabIndex = 1;
            // 
            // submitsingle
            // 
            this.submitsingle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitsingle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitsingle.Location = new System.Drawing.Point(49, 212);
            this.submitsingle.Name = "submitsingle";
            this.submitsingle.Size = new System.Drawing.Size(90, 45);
            this.submitsingle.TabIndex = 5;
            this.submitsingle.Text = "单板上架";
            this.submitsingle.Click += new System.EventHandler(this.submitsingle_Click);
            // 
            // lpn
            // 
            this.lpn.Location = new System.Drawing.Point(4, 144);
            this.lpn.Name = "lpn";
            this.lpn.Size = new System.Drawing.Size(231, 23);
            this.lpn.TabIndex = 3;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(4, 130);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(123, 14);
            this.rfLabel2.Text = "LPN";
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(145, 212);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(90, 45);
            this.submitbtn.TabIndex = 6;
            this.submitbtn.Text = "整托上架";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // toloc2
            // 
            this.toloc2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toloc2.Location = new System.Drawing.Point(110, 183);
            this.toloc2.Name = "toloc2";
            this.toloc2.Size = new System.Drawing.Size(125, 23);
            this.toloc2.TabIndex = 4;
            this.toloc2.TextChanged += new System.EventHandler(this.toloc2_TextChanged);
            // 
            // toloc1
            // 
            this.toloc1.Location = new System.Drawing.Point(4, 183);
            this.toloc1.Name = "toloc1";
            this.toloc1.ReadOnly = true;
            this.toloc1.Size = new System.Drawing.Size(102, 23);
            this.toloc1.TabIndex = 2;
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(4, 169);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(123, 14);
            this.rfLabel1.Text = "至储位";
            // 
            // lpncount
            // 
            this.lpncount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lpncount.Location = new System.Drawing.Point(112, 117);
            this.lpncount.Name = "lpncount";
            this.lpncount.Size = new System.Drawing.Size(123, 14);
            this.lpncount.Text = "一共有X个LPN";
            this.lpncount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RFTPA02Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 313);
            this.Controls.Add(this.lpncount);
            this.Controls.Add(this.submitsingle);
            this.Controls.Add(this.lpn);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.toloc2);
            this.Controls.Add(this.toloc1);
            this.Controls.Add(this.rfLabel1);
            this.Controls.Add(this.lpnlist);
            this.Name = "RFTPA02Frm";
            this.Text = "执行上架任务";
            this.Load += new System.EventHandler(this.RFTPA02Frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lpnlist;
        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox toloc1;
        private RFDeviceAPP.Common.rfTextBox toloc2;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox lpn;
        private RFDeviceAPP.Common.rfButtonCommand submitsingle;
        private RFDeviceAPP.Common.rfLabel lpncount;
    }
}
