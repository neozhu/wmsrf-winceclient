namespace RFDeviceAPP
{
    partial class NSPRFRL021SOFrm
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
            this.orderkey = new RFDeviceAPP.Common.rfTextBox();
            this.countlable = new RFDeviceAPP.Common.rfLabel();
            this.toloc = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.submitbtn = new RFDeviceAPP.Common.rfButtonCommand();
            this.dropid = new RFDeviceAPP.Common.rfTextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
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
            this.rfLabel1.Text = "订单号/关务号";
            // 
            // orderkey
            // 
            this.orderkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.orderkey.Location = new System.Drawing.Point(4, 49);
            this.orderkey.Name = "orderkey";
            this.orderkey.Size = new System.Drawing.Size(231, 23);
            this.orderkey.TabIndex = 2;
            this.orderkey.LostFocus += new System.EventHandler(this.orderkey_LostFocus);
            // 
            // countlable
            // 
            this.countlable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.countlable.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.countlable.Location = new System.Drawing.Point(117, 240);
            this.countlable.Name = "countlable";
            this.countlable.Size = new System.Drawing.Size(100, 14);
            this.countlable.Text = "总数";
            // 
            // toloc
            // 
            this.toloc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toloc.Location = new System.Drawing.Point(4, 256);
            this.toloc.Name = "toloc";
            this.toloc.Size = new System.Drawing.Size(231, 23);
            this.toloc.TabIndex = 4;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(4, 240);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(107, 14);
            this.rfLabel2.Text = "至储位";
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.submitbtn.Location = new System.Drawing.Point(144, 285);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(91, 55);
            this.submitbtn.TabIndex = 8;
            this.submitbtn.Text = "拣货";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // dropid
            // 
            this.dropid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dropid.Location = new System.Drawing.Point(4, 214);
            this.dropid.Name = "dropid";
            this.dropid.Size = new System.Drawing.Size(231, 23);
            this.dropid.TabIndex = 3;
            this.dropid.LostFocus += new System.EventHandler(this.dropid_LostFocus);
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(4, 74);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(231, 121);
            this.dataGrid1.TabIndex = 12;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "订单号";
            this.dataGridTextBoxColumn1.MappingName = "Orderkey";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "箱ID";
            this.dataGridTextBoxColumn2.MappingName = "Dropid";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "储位";
            this.dataGridTextBoxColumn3.MappingName = "Loc";
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(4, 198);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(107, 14);
            this.rfLabel3.Text = "自储位";
            // 
            // NSPRFRL021SOFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 359);
            this.Controls.Add(this.rfLabel3);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.dropid);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.toloc);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.countlable);
            this.Controls.Add(this.orderkey);
            this.Controls.Add(this.rfLabel1);
            this.Name = "NSPRFRL021SOFrm";
            this.Text = "二次拣货操作";
            this.Load += new System.EventHandler(this.NSPRFRL021SOFrm_Load);
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.orderkey, 0);
            this.Controls.SetChildIndex(this.countlable, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.toloc, 0);
            this.Controls.SetChildIndex(this.submitbtn, 0);
            this.Controls.SetChildIndex(this.dropid, 0);
            this.Controls.SetChildIndex(this.dataGrid1, 0);
            this.Controls.SetChildIndex(this.rfLabel3, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfTextBox orderkey;
        private RFDeviceAPP.Common.rfLabel countlable;
        private RFDeviceAPP.Common.rfTextBox toloc;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfButtonCommand submitbtn;
        private RFDeviceAPP.Common.rfTextBox dropid;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
    }
}
