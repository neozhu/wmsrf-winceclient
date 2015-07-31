namespace RFDeviceAPP
{
    partial class TaskListFrm
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
            this.closebtn = new System.Windows.Forms.Button();
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.sourcekey = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.printers = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
            this.copies = new RFDeviceAPP.Common.rfTextBox();
            this.selectallbtn = new System.Windows.Forms.Button();
            this.cleanallbtn = new System.Windows.Forms.Button();
            this.printbt = new System.Windows.Forms.Button();
            this.canclebt = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.Location = new System.Drawing.Point(153, 402);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(82, 51);
            this.closebtn.TabIndex = 2;
            this.closebtn.Text = "关闭";
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(3, 278);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(91, 14);
            this.rfLabel1.Text = "选择打印任务号";
            // 
            // sourcekey
            // 
            this.sourcekey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sourcekey.Location = new System.Drawing.Point(4, 294);
            this.sourcekey.Name = "sourcekey";
            this.sourcekey.Size = new System.Drawing.Size(231, 23);
            this.sourcekey.TabIndex = 4;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(4, 318);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(91, 14);
            this.rfLabel2.Text = "输出打印机";
            // 
            // printers
            // 
            this.printers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.printers.Location = new System.Drawing.Point(4, 333);
            this.printers.Name = "printers";
            this.printers.Size = new System.Drawing.Size(231, 23);
            this.printers.TabIndex = 5;
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(4, 358);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(91, 14);
            this.rfLabel3.Text = "份数";
            // 
            // copies
            // 
            this.copies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.copies.Location = new System.Drawing.Point(4, 373);
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(231, 23);
            this.copies.TabIndex = 6;
            this.copies.Text = "1";
            // 
            // selectallbtn
            // 
            this.selectallbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectallbtn.Location = new System.Drawing.Point(52, 248);
            this.selectallbtn.Name = "selectallbtn";
            this.selectallbtn.Size = new System.Drawing.Size(51, 27);
            this.selectallbtn.TabIndex = 11;
            this.selectallbtn.Text = "全选";
            this.selectallbtn.Click += new System.EventHandler(this.selectallbtn_Click);
            // 
            // cleanallbtn
            // 
            this.cleanallbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cleanallbtn.Location = new System.Drawing.Point(109, 248);
            this.cleanallbtn.Name = "cleanallbtn";
            this.cleanallbtn.Size = new System.Drawing.Size(51, 27);
            this.cleanallbtn.TabIndex = 12;
            this.cleanallbtn.Text = "清空";
            this.cleanallbtn.Click += new System.EventHandler(this.cleanallbtn_Click);
            // 
            // printbt
            // 
            this.printbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printbt.Location = new System.Drawing.Point(65, 402);
            this.printbt.Name = "printbt";
            this.printbt.Size = new System.Drawing.Size(82, 51);
            this.printbt.TabIndex = 16;
            this.printbt.Text = "打印";
            this.printbt.Click += new System.EventHandler(this.printbt_Click);
            // 
            // canclebt
            // 
            this.canclebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.canclebt.Location = new System.Drawing.Point(166, 248);
            this.canclebt.Name = "canclebt";
            this.canclebt.Size = new System.Drawing.Size(69, 27);
            this.canclebt.TabIndex = 20;
            this.canclebt.Text = "取消任务";
            this.canclebt.Click += new System.EventHandler(this.canclebt_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(3, 32);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(231, 210);
            this.dataGrid1.TabIndex = 24;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            this.dataGrid1.Click += new System.EventHandler(this.tasklist_SelectedIndexChanged);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "储位";
            this.dataGridTextBoxColumn4.MappingName = "Loc";
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "订单号";
            this.dataGridTextBoxColumn5.MappingName = "OrderKey";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "SKU";
            this.dataGridTextBoxColumn2.MappingName = "Sku";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "QTY";
            this.dataGridTextBoxColumn3.MappingName = "Qty";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "任务ID";
            this.dataGridTextBoxColumn1.MappingName = "Key";
            // 
            // dobutton
            // 
            this.dobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dobutton.Location = new System.Drawing.Point(4, 248);
            this.dobutton.Name = "dobutton";
            this.dobutton.Size = new System.Drawing.Size(42, 27);
            this.dobutton.TabIndex = 28;
            this.dobutton.Text = "执行";
            this.dobutton.Click += new System.EventHandler(this.dobutton_Click);
            // 
            // TaskListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 463);
            this.Controls.Add(this.dobutton);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.canclebt);
            this.Controls.Add(this.printbt);
            this.Controls.Add(this.cleanallbtn);
            this.Controls.Add(this.selectallbtn);
            this.Controls.Add(this.copies);
            this.Controls.Add(this.rfLabel3);
            this.Controls.Add(this.printers);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.sourcekey);
            this.Controls.Add(this.rfLabel1);
            this.Controls.Add(this.closebtn);
            this.Name = "TaskListFrm";
            this.Text = "我的拣货任务列表";
            this.Load += new System.EventHandler(this.TaskListFrm_Load);
            this.Controls.SetChildIndex(this.closebtn, 0);
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.sourcekey, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.printers, 0);
            this.Controls.SetChildIndex(this.rfLabel3, 0);
            this.Controls.SetChildIndex(this.copies, 0);
            this.Controls.SetChildIndex(this.selectallbtn, 0);
            this.Controls.SetChildIndex(this.cleanallbtn, 0);
            this.Controls.SetChildIndex(this.printbt, 0);
            this.Controls.SetChildIndex(this.canclebt, 0);
            this.Controls.SetChildIndex(this.dataGrid1, 0);
            this.Controls.SetChildIndex(this.dobutton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closebtn;
        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox sourcekey;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox printers;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
        private RFDeviceAPP.Common.rfTextBox copies;
        private System.Windows.Forms.Button selectallbtn;
        private System.Windows.Forms.Button cleanallbtn;
        private System.Windows.Forms.Button printbt;
        private System.Windows.Forms.Button canclebt;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.Button dobutton;
    }
}
