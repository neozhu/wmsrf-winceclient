using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Proxy;
using RFDeviceAPP.Common;

namespace RFDeviceAPP
{
    public partial class FrmScanSN2 : RFDeviceAPP.baseForm
    {
        public FrmScanSN2(Common.UserInfo loginuser, string orderkey,string sku)
            : base(loginuser)
        {
            InitializeComponent();
            //dataBinding();
            this.rfTextBox1.Text = orderkey;
            this.rfTextBox2.Text = sku;
        }

        public void dataBinding()
        {
            //receiveline.UtilityHeader.receiptkey
            //this.rfTextBox1.DataBinding(this.request, "UtilityHeader.receiptkey");
            //this.skuText.DataBinding(this.request, "UtilityHeader.sku");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}