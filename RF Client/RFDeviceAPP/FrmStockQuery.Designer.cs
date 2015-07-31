namespace RFDeviceAPP
{
    partial class FrmStockQuery
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
            this.storerkey = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel1 = new RFDeviceAPP.Common.rfLabel();
            this.skulabel = new RFDeviceAPP.Common.rfLabel();
            this.sku = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel2 = new RFDeviceAPP.Common.rfLabel();
            this.loc = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel3 = new RFDeviceAPP.Common.rfLabel();
            this.id = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel4 = new RFDeviceAPP.Common.rfLabel();
            this.lot = new RFDeviceAPP.Common.rfTextBox();
            this.rfLabel5 = new RFDeviceAPP.Common.rfLabel();
            this.caseid = new RFDeviceAPP.Common.rfTextBox();
            this.submitbt = new RFDeviceAPP.Common.rfButtonCommand();
            this.SuspendLayout();
            // 
            // userStatusControl1
            // 
            this.userStatusControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.userStatusControl1.Size = new System.Drawing.Size(238, 26);
            // 
            // storerkey
            // 
            this.storerkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.storerkey.Location = new System.Drawing.Point(4, 48);
            this.storerkey.Name = "storerkey";
            this.storerkey.Size = new System.Drawing.Size(231, 23);
            this.storerkey.TabIndex = 1;
            // 
            // rfLabel1
            // 
            this.rfLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel1.Location = new System.Drawing.Point(4, 33);
            this.rfLabel1.Name = "rfLabel1";
            this.rfLabel1.Size = new System.Drawing.Size(131, 14);
            this.rfLabel1.Text = "货主";
            // 
            // skulabel
            // 
            this.skulabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.skulabel.Location = new System.Drawing.Point(4, 72);
            this.skulabel.Name = "skulabel";
            this.skulabel.Size = new System.Drawing.Size(131, 14);
            this.skulabel.Text = "sku";
            // 
            // sku
            // 
            this.sku.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sku.Location = new System.Drawing.Point(4, 87);
            this.sku.Name = "sku";
            this.sku.Size = new System.Drawing.Size(231, 23);
            this.sku.TabIndex = 3;
            // 
            // rfLabel2
            // 
            this.rfLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel2.Location = new System.Drawing.Point(4, 111);
            this.rfLabel2.Name = "rfLabel2";
            this.rfLabel2.Size = new System.Drawing.Size(131, 14);
            this.rfLabel2.Text = "loc";
            // 
            // loc
            // 
            this.loc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.loc.Location = new System.Drawing.Point(4, 126);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(231, 23);
            this.loc.TabIndex = 6;
            // 
            // rfLabel3
            // 
            this.rfLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel3.Location = new System.Drawing.Point(4, 150);
            this.rfLabel3.Name = "rfLabel3";
            this.rfLabel3.Size = new System.Drawing.Size(131, 14);
            this.rfLabel3.Text = "LPN";
            // 
            // id
            // 
            this.id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.id.Location = new System.Drawing.Point(4, 165);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(231, 23);
            this.id.TabIndex = 9;
            // 
            // rfLabel4
            // 
            this.rfLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel4.Location = new System.Drawing.Point(4, 190);
            this.rfLabel4.Name = "rfLabel4";
            this.rfLabel4.Size = new System.Drawing.Size(131, 14);
            this.rfLabel4.Text = "LOT";
            // 
            // lot
            // 
            this.lot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lot.Location = new System.Drawing.Point(4, 205);
            this.lot.Name = "lot";
            this.lot.Size = new System.Drawing.Size(231, 23);
            this.lot.TabIndex = 12;
            // 
            // rfLabel5
            // 
            this.rfLabel5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rfLabel5.Location = new System.Drawing.Point(4, 228);
            this.rfLabel5.Name = "rfLabel5";
            this.rfLabel5.Size = new System.Drawing.Size(131, 14);
            this.rfLabel5.Text = "箱ID";
            // 
            // caseid
            // 
            this.caseid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.caseid.Location = new System.Drawing.Point(4, 243);
            this.caseid.Name = "caseid";
            this.caseid.Size = new System.Drawing.Size(231, 23);
            this.caseid.TabIndex = 15;
            // 
            // submitbt
            // 
            this.submitbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbt.Location = new System.Drawing.Point(135, 272);
            this.submitbt.Name = "submitbt";
            this.submitbt.Size = new System.Drawing.Size(100, 57);
            this.submitbt.TabIndex = 17;
            this.submitbt.Text = "查询";
            this.submitbt.Click += new System.EventHandler(this.submitbt_Click);
            // 
            // FrmStockQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 344);
            this.Controls.Add(this.submitbt);
            this.Controls.Add(this.rfLabel5);
            this.Controls.Add(this.caseid);
            this.Controls.Add(this.rfLabel4);
            this.Controls.Add(this.lot);
            this.Controls.Add(this.rfLabel3);
            this.Controls.Add(this.id);
            this.Controls.Add(this.rfLabel2);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.skulabel);
            this.Controls.Add(this.sku);
            this.Controls.Add(this.rfLabel1);
            this.Controls.Add(this.storerkey);
            this.Name = "FrmStockQuery";
            this.Text = "库存查询";
            this.Load += new System.EventHandler(this.FrmStockQuery_Load);
            this.Activated += new System.EventHandler(this.FrmStockQuery_Activated);
            this.Controls.SetChildIndex(this.storerkey, 0);
            this.Controls.SetChildIndex(this.rfLabel1, 0);
            this.Controls.SetChildIndex(this.userStatusControl1, 0);
            this.Controls.SetChildIndex(this.sku, 0);
            this.Controls.SetChildIndex(this.skulabel, 0);
            this.Controls.SetChildIndex(this.loc, 0);
            this.Controls.SetChildIndex(this.rfLabel2, 0);
            this.Controls.SetChildIndex(this.id, 0);
            this.Controls.SetChildIndex(this.rfLabel3, 0);
            this.Controls.SetChildIndex(this.lot, 0);
            this.Controls.SetChildIndex(this.rfLabel4, 0);
            this.Controls.SetChildIndex(this.caseid, 0);
            this.Controls.SetChildIndex(this.rfLabel5, 0);
            this.Controls.SetChildIndex(this.submitbt, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RFDeviceAPP.Common.rfTextBox storerkey;
        private RFDeviceAPP.Common.rfLabel rfLabel1;
        private RFDeviceAPP.Common.rfLabel skulabel;
        private RFDeviceAPP.Common.rfTextBox sku;
        private RFDeviceAPP.Common.rfLabel rfLabel2;
        private RFDeviceAPP.Common.rfTextBox loc;
        private RFDeviceAPP.Common.rfLabel rfLabel3;
        private RFDeviceAPP.Common.rfTextBox id;
        private RFDeviceAPP.Common.rfLabel rfLabel4;
        private RFDeviceAPP.Common.rfTextBox lot;
        private RFDeviceAPP.Common.rfLabel rfLabel5;
        private RFDeviceAPP.Common.rfTextBox caseid;
        private RFDeviceAPP.Common.rfButtonCommand submitbt;
    }
}
