using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Proxy;

namespace RFDeviceAPP
{
    public partial class FrmRTRSku3 : RFDeviceAPP.baseForm
    {
        private RFDeviceAPP.Common.NSPRFFLRTRSKU01X.Request.Utility request1;
        private RFDeviceAPP.Common.NSPFLRTRSKU02X.Request.Utility request;
        private Control focusControl;
        private String receiptkey;
        private String sku;

        public FrmRTRSku3(RFDeviceAPP.Common.NSPRFFLRTRSKU01X.Response.Utility result, Common.UserInfo loginuser, string receiptkey, string sku, string lottable02)
            : base(loginuser)
        {
            InitializeComponent();
            request = new RFDeviceAPP.Common.NSPFLRTRSKU02X.Request.Utility();
            receiptkey = this.rfTextBox1.Text;
            sku = this.rfTextBox3.Text;
            this.rfTextBox10.Text = lottable02;
            dataBinding();
            this.addToList(result.UtilityHeaders);
            this.rfTextBox8.Text = "1";
            this.rfTextBox8.Focus();
        }

        public FrmRTRSku3() {
        }

        public void dataBinding()
        {
            this.rfTextBox1.DataBinding(this.request, "UtilityHeader.receiptkey");
            this.rfTextBox3.DataBinding(this.request, "UtilityHeader.sku");
            this.rfTextBox5.DataBinding(this.request, "UtilityHeader.lineno");
            this.rfTextBox8.DataBinding(this.request, "UtilityHeader.qcqty");

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
                RFDeviceAPP.Common.NSPFLRTRSKU02X.Response.Utility result = response.Deserialize<RFDeviceAPP.Common.NSPFLRTRSKU02X.Response.Utility>();
                DialogResult dr = MessageBox.Show(result.UtilityHeaders[0].lineqty.ToString(),"提示框", MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                FrmRTRSku2 rtrsku2 = new FrmRTRSku2(this.LoginUser, this.rfTextBox1.Text.ToString());
                rtrsku2.Show();
                
                this.Close();

                //DialogResult dr = MessageBox.Show(result.UtilityHeaders[0].lineqty.ToString(),"提示框", MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                //FrmRTRSku2 rtrsku2 = new FrmRTRSku2(this.LoginUser, this.rfTextBox1.Text.ToString());
                //rtrsku2.call_API(this.rfTextBox1.Text.ToString(), this.rfTextBox3.Text.ToString());
                
            }

        }

        private void addToList(List<RFDeviceAPP.Common.NSPRFFLRTRSKU01X.Response.UtilityHeader> list)
        {

            foreach (RFDeviceAPP.Common.NSPRFFLRTRSKU01X.Response.UtilityHeader header in list)
            {

                this.rfTextBox1.Text = header.ReceiptKey.ToString();
                this.rfTextBox2.Text = header.Notes.ToString();
                this.rfTextBox3.Text = header.Sku.ToString();
                this.rfTextBox4.Text = header.Qty.ToString();
                this.rfTextBox5.Text = header.lineno.ToString();
                this.rfTextBox6.Text = header.wqcqty.ToString();
                this.rfTextBox7.Text = header.qcqty.ToString();

                string[] _altsku = header.AltSku.ToString().Split(';');

                for (int i = 0; i < _altsku.Length; i++)
                {
                    this.comboBox2.Items.Add(_altsku[i]);
                }

                this.rfTextBox9.Text = header.SUsr3.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            call_API();
        }

    }
}