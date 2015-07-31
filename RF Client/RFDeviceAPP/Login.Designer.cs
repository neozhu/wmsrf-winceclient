namespace RFDeviceAPP
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.whcodecombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.savechk = new System.Windows.Forms.CheckBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.msglab = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(69, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "WMS RF Client";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "仓库代码";
            // 
            // whcodecombo
            // 
            this.whcodecombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.whcodecombo.Items.Add("FEILI_wmwhse9");
            this.whcodecombo.Items.Add("FEILI_wmwhse10");
            this.whcodecombo.Items.Add("FEILI_wmwhse1");
            this.whcodecombo.Location = new System.Drawing.Point(4, 83);
            this.whcodecombo.Name = "whcodecombo";
            this.whcodecombo.Size = new System.Drawing.Size(231, 23);
            this.whcodecombo.TabIndex = 1;
            this.whcodecombo.SelectedIndexChanged += new System.EventHandler(this.whcodecombo_SelectedIndexChanged);
            this.whcodecombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.whcodecombo_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "用户名";
            // 
            // usernametxt
            // 
            this.usernametxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usernametxt.Location = new System.Drawing.Point(4, 133);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(231, 23);
            this.usernametxt.TabIndex = 2;
            this.usernametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernametxt_KeyDown);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "密码";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordtxt.Location = new System.Drawing.Point(4, 182);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(231, 23);
            this.passwordtxt.TabIndex = 3;
            this.passwordtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordtxt_KeyDown);
            // 
            // savechk
            // 
            this.savechk.Location = new System.Drawing.Point(4, 212);
            this.savechk.Name = "savechk";
            this.savechk.Size = new System.Drawing.Size(100, 20);
            this.savechk.TabIndex = 9;
            this.savechk.Text = "记住用户密码";
            this.savechk.Visible = false;
            this.savechk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.savechk_KeyDown);
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(111, 211);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(124, 39);
            this.loginbtn.TabIndex = 10;
            this.loginbtn.Text = "登录";
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            this.loginbtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginbtn_KeyDown);
            // 
            // msglab
            // 
            this.msglab.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.msglab.ForeColor = System.Drawing.Color.Red;
            this.msglab.Location = new System.Drawing.Point(60, 253);
            this.msglab.Name = "msglab";
            this.msglab.Size = new System.Drawing.Size(118, 20);
            this.msglab.Text = "label5";
            this.msglab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // server
            // 
            this.server.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.server.Items.Add("http://172.20.70.95/WMSWebService");
            this.server.Items.Add("http://172.20.70.54/WMSWebService");
            this.server.Items.Add("http://172.20.70.95/WMSWebServiceTest");
            this.server.Location = new System.Drawing.Point(4, 33);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(231, 23);
            this.server.TabIndex = 15;
            this.server.SelectedIndexChanged += new System.EventHandler(this.server_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 333);
            this.Controls.Add(this.server);
            this.Controls.Add(this.msglab);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.savechk);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.whcodecombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "登录 v1.80.0 正式环境";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox whcodecombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.CheckBox savechk;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label msglab;
        private System.Windows.Forms.ComboBox server;
    }
}

