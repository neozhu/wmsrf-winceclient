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
    public partial class FrmScanSN1 : RFDeviceAPP.baseForm
    {
        public FrmScanSN1(Common.UserInfo loginuser)
            : base(loginuser)
        {
            InitializeComponent();
            this.orderkeytext.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string orderkeytext = this.orderkeytext.Text;
            string skutext = this.skutext.Text;


            if (this.labeltext.Text.IndexOf("1") > -1)
            {
                FrmScanSN2 resultfrm2 = new FrmScanSN2(this.LoginUser, orderkeytext, skutext);
                resultfrm2.Show();

            }
            else
            {
                FrmScanSN3 resultfrm3 = new FrmScanSN3(this.LoginUser, orderkeytext, skutext);
                resultfrm3.Show();
            }
        }
    }
}