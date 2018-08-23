using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RFDeviceAPP
{
    public partial class FrmRTRSku1 : RFDeviceAPP.baseForm
    {

        private Control focusControl;

        public FrmRTRSku1(Common.UserInfo loginuser)
            : base(loginuser)
        {
            InitializeComponent();
            this.receiptkeyText.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string receiptkey = receiptkeyText.Text;
            FrmRTRSku2 resultfrm2 = new FrmRTRSku2(this.LoginUser,receiptkey);
            resultfrm2.Show();
        }

        private void receiptkeyText_LostFocus(object sender, EventArgs e)
        {
            if (this.receiptkeyText.Text.Length > 0)
            {
                string receiptkey = receiptkeyText.Text;
                FrmRTRSku2 resultfrm2 = new FrmRTRSku2(this.LoginUser, receiptkey);
                resultfrm2.Show();
            }
        }
    }
}