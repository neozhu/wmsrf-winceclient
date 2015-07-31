using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Proxy;
using arrival_req = RFDeviceAPP.Common.Arrival01.Request;
using arrival_res = RFDeviceAPP.Common.Arrival01.Response;
using asnlist01_res = RFDeviceAPP.Common.asnlist01.Response;
using asnlist01_req = RFDeviceAPP.Common.asnlist01.Request;
using RFDeviceAPP.Common;
namespace RFDeviceAPP
{
    public partial class DoClassifyFrm : Form
    {
        private UserInfo loginuser;
        private Control focusControl;
        private arrival_req.AdvancedShipNotice arrivalreq;
        private arrival_res.AdvancedShipNotice arrivalres;
        public DoClassifyFrm(UserInfo user,string storerkey,string receiptkey,int num)
        {
            InitializeComponent();
            this.storerkey.Text = storerkey;
            this.receiptkey.Text = receiptkey;
            this.linecount.Text = num.ToString();
            this.loginuser = user;
        }

        private void submit2_Click(object sender, EventArgs e)
        {
            string errortxt = this.Vaildate("2");
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
         

            arrivalreq = new arrival_req.AdvancedShipNotice();

            arrivalreq.AdvancedShipNoticeHeader.StorerKey = this.storerkey.Text;
            arrivalreq.AdvancedShipNoticeHeader.ReceiptKey = this.receiptkey.Text;
            arrivalreq.AdvancedShipNoticeHeader.ArrangeStatus = "s";
            arrivalreq.AdvancedShipNoticeHeader.TheCube = this.thecube.Text;
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.AdvancedShipNotice,
                  enumRequestMethod.store, this.loginuser,
                  enumSendSysId.EXceed,
                  arrivalreq);
            RequestWorkItem workitem = new RequestWorkItem(request, 2);
            ResponseMessage response=  ThreadHelper.Execute(request);
             string errormsg = response.GetErrorMessage();
             if (errormsg != string.Empty)
             {
                 MessageBox.Show(response.GetErrorMessage());
             }
             else
             {
               DialogResult res=  MessageBox.Show("是否结束分料", "提示",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
               if (res == DialogResult.Yes)
               {
                   arrivalreq = new arrival_req.AdvancedShipNotice();

                   arrivalreq.AdvancedShipNoticeHeader.StorerKey = this.storerkey.Text;
                   arrivalreq.AdvancedShipNoticeHeader.ReceiptKey = this.receiptkey.Text;
                   arrivalreq.AdvancedShipNoticeHeader.ArrangeStatus = "c";
                   arrivalreq.AdvancedShipNoticeHeader.TheCube = this.thecube.Text;
                   RequestMessage request1 = new RequestMessage(enumRequestType.MessageProcessor,
                         enumMessageType.AdvancedShipNotice,
                         enumRequestMethod.store, this.loginuser,
                         enumSendSysId.EXceed,
                         arrivalreq);
                  
                   ResponseMessage response1 = ThreadHelper.Execute(request1);
               }
                 this.Close();
             }

        }


        public string Vaildate(string tag)
        {
            string errortxt = string.Empty;
            if (this.receiptkey.Text.Length == 0)
            {
                focusControl = this.receiptkey;
                errortxt += "ASN必填";
            }
            if (this.storerkey.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.storerkey;
                errortxt += "货主必填";

            }
            if (tag == "2")
            {
                if (this.thecube.Text.Length == 0)
                {
                    if (string.IsNullOrEmpty(errortxt))
                        focusControl = this.thecube;
                    errortxt += "体积必填";

                }
            }



            return errortxt;
        }

      
    }
}