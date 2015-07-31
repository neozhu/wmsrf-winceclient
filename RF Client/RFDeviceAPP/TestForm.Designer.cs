namespace RFDeviceAPP
{
    partial class TestForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rfButtonCommand2 = new RFDeviceAPP.Common.rfButtonCommand();
            this.userStatusControl1 = new RFDeviceAPP.UserStatusControl();
            this.rfButtonCommand1 = new RFDeviceAPP.Common.rfButtonCommand();
            this.recedqty = new RFDeviceAPP.Common.rfTextBox();
            this.recqtytxt = new RFDeviceAPP.Common.rfTextBox();
            this.owntxt = new RFDeviceAPP.Common.rfTextBox();
            this.asntxt = new RFDeviceAPP.Common.rfTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 20);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(4, 148);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(230, 100);
            this.dataGrid1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(4, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 70);
            // 
            // rfButtonCommand2
            // 
            this.rfButtonCommand2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rfButtonCommand2.Location = new System.Drawing.Point(143, 3);
            this.rfButtonCommand2.Name = "rfButtonCommand2";
            this.rfButtonCommand2.Size = new System.Drawing.Size(91, 30);
            this.rfButtonCommand2.TabIndex = 0;
            this.rfButtonCommand2.Text = "rfButtonCommand2";
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userStatusControl1.Location = new System.Drawing.Point(0, 0);
            this.userStatusControl1.LoginUser = null;
            this.userStatusControl1.Name = "userStatusControl1";
            this.userStatusControl1.Size = new System.Drawing.Size(239, 26);
            this.userStatusControl1.TabIndex = 11;
            // 
            // rfButtonCommand1
            // 
            this.rfButtonCommand1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rfButtonCommand1.Location = new System.Drawing.Point(109, 95);
            this.rfButtonCommand1.Name = "rfButtonCommand1";
            this.rfButtonCommand1.Size = new System.Drawing.Size(126, 36);
            this.rfButtonCommand1.TabIndex = 10;
            this.rfButtonCommand1.Text = "rfButtonCommand1";
            this.rfButtonCommand1.Click += new System.EventHandler(this.rfButtonCommand1_Click);
            // 
            // recedqty
            // 
            this.recedqty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recedqty.Location = new System.Drawing.Point(109, 66);
            this.recedqty.Name = "recedqty";
            this.recedqty.Size = new System.Drawing.Size(127, 23);
            this.recedqty.TabIndex = 4;
            // 
            // recqtytxt
            // 
            this.recqtytxt.Location = new System.Drawing.Point(3, 66);
            this.recqtytxt.Name = "recqtytxt";
            this.recqtytxt.Size = new System.Drawing.Size(100, 23);
            this.recqtytxt.TabIndex = 3;
            // 
            // owntxt
            // 
            this.owntxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.owntxt.Location = new System.Drawing.Point(110, 37);
            this.owntxt.Name = "owntxt";
            this.owntxt.Size = new System.Drawing.Size(126, 23);
            this.owntxt.TabIndex = 1;
            // 
            // asntxt
            // 
            this.asntxt.Location = new System.Drawing.Point(3, 37);
            this.asntxt.Name = "asntxt";
            this.asntxt.Size = new System.Drawing.Size(100, 23);
            this.asntxt.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rfButtonCommand2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 30);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(239, 355);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userStatusControl1);
            this.Controls.Add(this.rfButtonCommand1);
            this.Controls.Add(this.recedqty);
            this.Controls.Add(this.recqtytxt);
            this.Controls.Add(this.owntxt);
            this.Controls.Add(this.asntxt);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfTextBox asntxt;
        private RFDeviceAPP.Common.rfTextBox owntxt;
        private RFDeviceAPP.Common.rfTextBox recqtytxt;
        private RFDeviceAPP.Common.rfTextBox recedqty;
        private RFDeviceAPP.Common.rfButtonCommand rfButtonCommand1;
        private UserStatusControl userStatusControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Panel panel1;
        private RFDeviceAPP.Common.rfButtonCommand rfButtonCommand2;
        private System.Windows.Forms.Panel panel2;
    }
}