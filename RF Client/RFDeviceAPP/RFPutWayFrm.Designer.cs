namespace RFDeviceAPP
{
    partial class RFPutWayFrm
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
            this.idtxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.skutxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
            this.rfLabel4 = new RFDeviceAPP.Common.rfLabel();
            this.suggestedtoloctxt = new RFDeviceAPP.Common.rfTextBox();
            this.toloctxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfButtonCommand1 = new RFDeviceAPP.Common.rfButtonCommand();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 28);
            // 
            // idtxt
            // 
            this.idtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.idtxt.Location = new System.Drawing.Point(4, 46);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(231, 23);
            this.idtxt.TabIndex = 9;
            this.idtxt.LostFocus += new System.EventHandler(this.idtxt_LostFocus);
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(3, 31);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(100, 17);
            this.rfLabel1.Text = "LPN";
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(3, 71);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(100, 17);
            this.rfLabel2.Text = "SKU";
            // 
            // skutxt
            // 
            this.skutxt.Location = new System.Drawing.Point(4, 87);
            this.skutxt.Name = "skutxt";
            this.skutxt.Size = new System.Drawing.Size(231, 23);
            this.skutxt.TabIndex = 12;
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(3, 112);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(100, 17);
            this.rfLabel3.Text = "建议库位";
            // 
            // rfLabel4
            // 
            this.rfLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel4.Location = new System.Drawing.Point(3, 151);
            this.rfLabel4.Name = "rfLabel4";
            this.rfLabel4.Size = new System.Drawing.Size(100, 17);
            this.rfLabel4.Text = "库位";
            // 
            // suggestedtoloctxt
            // 
            this.suggestedtoloctxt.Location = new System.Drawing.Point(4, 126);
            this.suggestedtoloctxt.Name = "suggestedtoloctxt";
            this.suggestedtoloctxt.Size = new System.Drawing.Size(231, 23);
            this.suggestedtoloctxt.TabIndex = 15;
            // 
            // toloctxt
            // 
            this.toloctxt.Location = new System.Drawing.Point(4, 166);
            this.toloctxt.Name = "toloctxt";
            this.toloctxt.Size = new System.Drawing.Size(231, 23);
            this.toloctxt.TabIndex = 16;
            // 
            // rfButtonCommand1
            // 
            this.rfButtonCommand1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rfButtonCommand1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfButtonCommand1.Location = new System.Drawing.Point(146, 194);
            this.rfButtonCommand1.Name = "rfButtonCommand1";
            this.rfButtonCommand1.Size = new System.Drawing.Size(89, 46);
            this.rfButtonCommand1.TabIndex = 21;
            this.rfButtonCommand1.Text = "OK";
            this.rfButtonCommand1.Click += new System.EventHandler(this.rfButtonCommand1_Click);
            this.rfButtonCommand1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rfButtonCommand1_KeyDown);
            // 
            // RFPutWayFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.suggestedtoloctxt);
            this.Controls.Add(this.toloctxt);
            this.Controls.Add(this.rfLabel4);
            this.Controls.Add(this.rfButtonCommand1);
            this.Controls.Add(this.rfLabel3);
            this.Controls.Add(this.skutxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.rfLabel1);
            this.Controls.Add(this.rfLabel2);
            this.Name = "RFPutWayFrm";
            this.Text = "RF上架";
            this.Load += new System.EventHandler(this.RFPutWayFrm_Load);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.idtxt, 0);
            this.Controls.SetChildIndex(this.skutxt, 0);
            this.Controls.SetChildIndex(this.rfLabel3, 0);
            this.Controls.SetChildIndex(this.rfButtonCommand1, 0);
            this.Controls.SetChildIndex(this.rfLabel4, 0);
            this.Controls.SetChildIndex(this.toloctxt, 0);
            this.Controls.SetChildIndex(this.suggestedtoloctxt, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfTextBox idtxt;
        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox skutxt;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
        private RFDeviceAPP.Common.rfLabel rfLabel4;
        private RFDeviceAPP.Common.rfTextBox suggestedtoloctxt;
        private RFDeviceAPP.Common.rfTextBox toloctxt;
        private RFDeviceAPP.Common.rfButtonCommand rfButtonCommand1;

    }
}
