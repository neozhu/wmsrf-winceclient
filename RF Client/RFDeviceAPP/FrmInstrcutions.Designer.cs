namespace RFDeviceAPP
{
    partial class FrmInstrcutions
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ordertypelabel = new System.Windows.Forms.Label();
            this.msglab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitbutton = new System.Windows.Forms.Button();
            this.ordertypecombo = new RFDeviceAPP.Common.rfComboBox();
            this.orderkeytext = new RFDeviceAPP.Common.rfTextBox();
            this.sourcetypetext = new RFDeviceAPP.Common.rfTextBox();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // ordertypelabel
            // 
            this.ordertypelabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.ordertypelabel.Location = new System.Drawing.Point(3, 29);
            this.ordertypelabel.Name = "ordertypelabel";
            this.ordertypelabel.Size = new System.Drawing.Size(100, 20);
            this.ordertypelabel.Text = "订单类型";
            // 
            // msglab
            // 
            this.msglab.Location = new System.Drawing.Point(123, 51);
            this.msglab.Name = "msglab";
            this.msglab.Size = new System.Drawing.Size(100, 20);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.Text = "订单";
            // 
            // submitbutton
            // 
            this.submitbutton.Location = new System.Drawing.Point(136, 118);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(87, 59);
            this.submitbutton.TabIndex = 6;
            this.submitbutton.Text = "保存";
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // ordertypecombo
            // 
            this.ordertypecombo.Items.Add("ASN");
            this.ordertypecombo.Items.Add("ORDER");
            this.ordertypecombo.Items.Add("WORK");
            this.ordertypecombo.Items.Add("TRANSFER");
            this.ordertypecombo.Location = new System.Drawing.Point(3, 48);
            this.ordertypecombo.Name = "ordertypecombo";
            this.ordertypecombo.Size = new System.Drawing.Size(114, 23);
            this.ordertypecombo.TabIndex = 9;
            this.ordertypecombo.SelectedIndexChanged += new System.EventHandler(this.ordertypecombo_SelectedIndexChanged);
            // 
            // orderkeytext
            // 
            this.orderkeytext.Location = new System.Drawing.Point(3, 93);
            this.orderkeytext.Name = "orderkeytext";
            this.orderkeytext.Size = new System.Drawing.Size(232, 23);
            this.orderkeytext.TabIndex = 10;
            // 
            // sourcetypetext
            // 
            this.sourcetypetext.Location = new System.Drawing.Point(4, 123);
            this.sourcetypetext.Name = "sourcetypetext";
            this.sourcetypetext.Size = new System.Drawing.Size(100, 23);
            this.sourcetypetext.TabIndex = 11;
            this.sourcetypetext.Visible = false;
            // 
            // FrmInstrcutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 335);
            this.Controls.Add(this.sourcetypetext);
            this.Controls.Add(this.ordertypelabel);
            this.Controls.Add(this.orderkeytext);
            this.Controls.Add(this.ordertypecombo);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.msglab);
            this.Controls.Add(this.label3);
            this.Name = "FrmInstrcutions";
            this.Text = "服务指令";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.msglab, 0);
            this.Controls.SetChildIndex(this.submitbutton, 0);
            this.Controls.SetChildIndex(this.ordertypecombo, 0);
            this.Controls.SetChildIndex(this.orderkeytext, 0);
            this.Controls.SetChildIndex(this.ordertypelabel, 0);
            this.Controls.SetChildIndex(this.sourcetypetext, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ordertypelabel;
        private System.Windows.Forms.Label msglab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitbutton;
        private RFDeviceAPP.Common.rfComboBox ordertypecombo;
        private RFDeviceAPP.Common.rfTextBox orderkeytext;
        private RFDeviceAPP.Common.rfTextBox sourcetypetext;
    }
}
