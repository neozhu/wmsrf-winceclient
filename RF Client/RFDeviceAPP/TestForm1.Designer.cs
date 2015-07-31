namespace RFDeviceAPP
{
    partial class TestForm1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rfFieldComboBox1 = new RFDeviceAPP.Common.rfFieldComboBox();
            this.rfFieldTextBox4 = new RFDeviceAPP.Common.rfFieldTextBox();
            this.rfFieldTextBox3 = new RFDeviceAPP.Common.rfFieldTextBox();
            this.rfFieldTextBox2 = new RFDeviceAPP.Common.rfFieldTextBox();
            this.rfFieldTextBox1 = new RFDeviceAPP.Common.rfFieldTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rfButtonCommand1 = new RFDeviceAPP.Common.rfButtonCommand();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rfFieldComboBox1);
            this.panel1.Controls.Add(this.rfFieldTextBox4);
            this.panel1.Controls.Add(this.rfFieldTextBox3);
            this.panel1.Controls.Add(this.rfFieldTextBox2);
            this.panel1.Controls.Add(this.rfFieldTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 198);
            // 
            // rfFieldComboBox1
            // 
            this.rfFieldComboBox1.DataSource = null;
            this.rfFieldComboBox1.DisplayMember = "";
            this.rfFieldComboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rfFieldComboBox1.Location = new System.Drawing.Point(0, 164);
            this.rfFieldComboBox1.Name = "rfFieldComboBox1";
            this.rfFieldComboBox1.Size = new System.Drawing.Size(238, 42);
            this.rfFieldComboBox1.TabIndex = 4;
            this.rfFieldComboBox1.ValueMember = "";
            // 
            // rfFieldTextBox4
            // 
            this.rfFieldTextBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.rfFieldTextBox4.IsRequired = false;
            this.rfFieldTextBox4.Location = new System.Drawing.Point(0, 123);
            this.rfFieldTextBox4.Name = "rfFieldTextBox4";
            this.rfFieldTextBox4.Size = new System.Drawing.Size(238, 41);
            this.rfFieldTextBox4.TabIndex = 3;
            // 
            // rfFieldTextBox3
            // 
            this.rfFieldTextBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.rfFieldTextBox3.IsRequired = false;
            this.rfFieldTextBox3.Location = new System.Drawing.Point(0, 82);
            this.rfFieldTextBox3.Name = "rfFieldTextBox3";
            this.rfFieldTextBox3.Size = new System.Drawing.Size(238, 41);
            this.rfFieldTextBox3.TabIndex = 2;
            // 
            // rfFieldTextBox2
            // 
            this.rfFieldTextBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rfFieldTextBox2.IsRequired = false;
            this.rfFieldTextBox2.Location = new System.Drawing.Point(0, 41);
            this.rfFieldTextBox2.Name = "rfFieldTextBox2";
            this.rfFieldTextBox2.Size = new System.Drawing.Size(238, 41);
            this.rfFieldTextBox2.TabIndex = 1;
            // 
            // rfFieldTextBox1
            // 
            this.rfFieldTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rfFieldTextBox1.IsRequired = false;
            this.rfFieldTextBox1.Location = new System.Drawing.Point(0, 0);
            this.rfFieldTextBox1.Name = "rfFieldTextBox1";
            this.rfFieldTextBox1.Size = new System.Drawing.Size(238, 41);
            this.rfFieldTextBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 53);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rfButtonCommand1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 45);
            // 
            // rfButtonCommand1
            // 
            this.rfButtonCommand1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rfButtonCommand1.Location = new System.Drawing.Point(129, 4);
            this.rfButtonCommand1.Name = "rfButtonCommand1";
            this.rfButtonCommand1.Size = new System.Drawing.Size(106, 38);
            this.rfButtonCommand1.TabIndex = 0;
            this.rfButtonCommand1.Text = "rfButtonCommand1";
            this.rfButtonCommand1.Click += new System.EventHandler(this.rfButtonCommand1_Click);
            // 
            // TestForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "TestForm1";
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RFDeviceAPP.Common.rfFieldTextBox rfFieldTextBox4;
        private RFDeviceAPP.Common.rfFieldTextBox rfFieldTextBox3;
        private RFDeviceAPP.Common.rfFieldTextBox rfFieldTextBox2;
        private RFDeviceAPP.Common.rfFieldTextBox rfFieldTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private RFDeviceAPP.Common.rfButtonCommand rfButtonCommand1;
        private RFDeviceAPP.Common.rfFieldComboBox rfFieldComboBox1;
    }
}
