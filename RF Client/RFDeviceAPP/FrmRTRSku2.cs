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
    public partial class FrmRTRSku2 : RFDeviceAPP.baseForm
    {
        private RFDeviceAPP.Common.NSPRFFLRTRSKU01X.Request.Utility request;
        private Control focusControl;
        private ThreadHelper threadhelper;
        private String receiptkey;
        private String sku;
        private String lottable02;

        public FrmRTRSku2(Common.UserInfo loginuser,string receiptkey)
            : base(loginuser)
        {
            InitializeComponent();
            request = new RFDeviceAPP.Common.NSPRFFLRTRSKU01X.Request.Utility();
            dataBinding();
            this.receiptkeyText.Text = receiptkey;
            this.skuText.Focus();
        }
        public void dataBinding()
        {
            //receiveline.UtilityHeader.receiptkey
            this.receiptkeyText.DataBinding(this.request, "UtilityHeader.receiptkey");
            this.skuText.DataBinding(this.request, "UtilityHeader.sku");
            this.lottable02Text.DataBinding(this.request, "UtilityHeader.lottable02");
        }

        private void call_API()
        {
            this.request.UtilityHeader.userid = this.LoginUser.UserName;
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.LoginUser,
                  enumSendSysId.EXceed,
                  this.request);
            ResponseMessage response = ThreadHelper.Execute(request);
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
                //this.ordertypecombo.SetFocus();
                return;
            }
            else
            {
                this.skuText.Text = "";
                RFDeviceAPP.Common.NSPRFFLRTRSKU01X.Response.Utility result = response.Deserialize<RFDeviceAPP.Common.NSPRFFLRTRSKU01X.Response.Utility>();
                FrmRTRSku3 resultfrm3 = new FrmRTRSku3(result, this.LoginUser, receiptkey, sku,lottable02);
                resultfrm3.Show();
            }

        }

        public void call_API(string receiptKey, string Sku, string lottable02)
        {
            dataBinding();
            receiptkey = receiptKey;
            sku = Sku;
            this.lottable02 = lottable02;
            this.receiptkeyText.Text = receiptkey;
            this.skuText.Text = sku;
            this.lottable02Text.Text = lottable02;
            this.request.UtilityHeader.userid = this.LoginUser.UserName;
            string loginuser = this.LoginUser.UserName;
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.LoginUser,
                  enumSendSysId.EXceed,
                  this.request);
            ResponseMessage response = ThreadHelper.Execute(request);
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
                return;
            }
            else
            {
                RFDeviceAPP.Common.NSPRFFLRTRSKU01X.Response.Utility result = response.Deserialize<RFDeviceAPP.Common.NSPRFFLRTRSKU01X.Response.Utility>();
                FrmRTRSku3 resultfrm3 = new FrmRTRSku3(result, this.LoginUser, receiptkey, sku, lottable02);
                resultfrm3.Show();
                this.Activate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string receiptkey = this.receiptkeyText.Text.Trim();
            string sku = this.skuText.Text.Trim();
            string lottable02 = this.lottable02Text.Text.Trim();
            if (receiptkey.Length > 0 && sku.Length > 0)
            {
                call_API(receiptkey, sku, lottable02);
                this.Close();
            }
            else
            {
                MessageBox.Show("收货单号和料号必填！");
            }
        }

        private void receiptkeyText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                skuText.Focus();
            }
        }

        private void skuText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lottable02Text.Focus();
            }
        }

        private void lottable02Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }



        //private void skuText_LostFocus(object sender, EventArgs e)
        //{
        //    if (this.skuText.Text.Length > 0)
        //    {
        //        call_API();
        //        this.Close();
        //    }
        //}
    }
}