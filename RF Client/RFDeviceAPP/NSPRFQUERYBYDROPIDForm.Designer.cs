namespace RFDeviceAPP
{
    partial class NSPRFQUERYBYDROPIDForm
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
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.dropidtxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.wavekeytxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
            this.orderkeytxt = new RFDeviceAPP.Common.rfTextBox();
            this.label33 = new RFDeviceAPP.Common.rfLabel();
            this.isfullpickedtxt = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel4 = new RFDeviceAPP.Common.rfLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.susr15 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(221, 26);
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(3, 29);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(31, 14);
            this.rfLabel1.Text = "箱ID";
            // 
            // dropidtxt
            // 
            this.dropidtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dropidtxt.Location = new System.Drawing.Point(3, 46);
            this.dropidtxt.Name = "dropidtxt";
            this.dropidtxt.Size = new System.Drawing.Size(215, 23);
            this.dropidtxt.TabIndex = 2;
            this.dropidtxt.LostFocus += new System.EventHandler(this.dropidtxt_LostFocus);
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(3, 71);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(121, 14);
            this.rfLabel2.Text = "波次";
            // 
            // wavekeytxt
            // 
            this.wavekeytxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wavekeytxt.Location = new System.Drawing.Point(3, 88);
            this.wavekeytxt.Name = "wavekeytxt";
            this.wavekeytxt.ReadOnly = true;
            this.wavekeytxt.Size = new System.Drawing.Size(215, 23);
            this.wavekeytxt.TabIndex = 4;
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(3, 111);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(121, 14);
            this.rfLabel3.Text = "订单号";
            // 
            // orderkeytxt
            // 
            this.orderkeytxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.orderkeytxt.Location = new System.Drawing.Point(3, 128);
            this.orderkeytxt.Name = "orderkeytxt";
            this.orderkeytxt.ReadOnly = true;
            this.orderkeytxt.Size = new System.Drawing.Size(215, 23);
            this.orderkeytxt.TabIndex = 7;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label33.Location = new System.Drawing.Point(3, 151);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(121, 14);
            this.label33.Text = "状态";
            // 
            // isfullpickedtxt
            // 
            this.isfullpickedtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.isfullpickedtxt.Location = new System.Drawing.Point(3, 168);
            this.isfullpickedtxt.Name = "isfullpickedtxt";
            this.isfullpickedtxt.ReadOnly = true;
            this.isfullpickedtxt.Size = new System.Drawing.Size(215, 23);
            this.isfullpickedtxt.TabIndex = 10;
            // 
            // rfLabel4
            // 
            this.rfLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel4.Location = new System.Drawing.Point(3, 238);
            this.rfLabel4.Name = "rfLabel4";
            this.rfLabel4.Size = new System.Drawing.Size(121, 14);
            this.rfLabel4.Text = "已拣箱ID";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Location = new System.Drawing.Point(3, 255);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 66);
            this.listBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(3, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.Text = "未拣箱ID";
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(3, 338);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(214, 68);
            this.dataGrid1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(4, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 14);
            this.label2.Text = "装箱时间";
            // 
            // susr15
            // 
            this.susr15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.susr15.Location = new System.Drawing.Point(4, 213);
            this.susr15.Name = "susr15";
            this.susr15.Size = new System.Drawing.Size(214, 23);
            this.susr15.TabIndex = 31;
            // 
            // NSPRFQUERYBYDROPIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 360);
            this.Controls.Add(this.susr15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rfLabel4);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.isfullpickedtxt);
            this.Controls.Add(this.rfLabel3);
            this.Controls.Add(this.orderkeytxt);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.wavekeytxt);
            this.Controls.Add(this.rfLabel1);
            this.Controls.Add(this.dropidtxt);
            this.Name = "NSPRFQUERYBYDROPIDForm";
            this.Text = "一次集货查询";
            this.Controls.SetChildIndex(this.dropidtxt, 0);
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.wavekeytxt, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.orderkeytxt, 0);
            this.Controls.SetChildIndex(this.rfLabel3, 0);
            this.Controls.SetChildIndex(this.isfullpickedtxt, 0);
            this.Controls.SetChildIndex(this.label33, 0);
            this.Controls.SetChildIndex(this.rfLabel4, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dataGrid1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.susr15, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox dropidtxt;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox wavekeytxt;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
        private RFDeviceAPP.Common.rfTextBox orderkeytxt;
        private RFDeviceAPP.Common.rfLabel label33;
        private RFDeviceAPP.Common.rfTextBox isfullpickedtxt;
        private RFDeviceAPP.Common.rfLabel rfLabel4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox susr15;
    }
}
