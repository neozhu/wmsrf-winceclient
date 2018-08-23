using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using RFDeviceAPP.Entities.WorkInstruction;
using RFDeviceAPP.Proxy;

namespace RFDeviceAPP
{
    public partial class FrmInstrcutions : RFDeviceAPP.baseForm
    {

        private RFDeviceAPP.Common.NSPRFINSTRUCTION01X.Request.Utility request;
        private Control focusControl;
        private String ordertype;
        private String orderkey;
        public FrmInstrcutions(Common.UserInfo loginuser): base(loginuser)
        {
            InitializeComponent();
            request = new RFDeviceAPP.Common.NSPRFINSTRUCTION01X.Request.Utility();
            dataBinding();
        }
        public void dataBinding()
        {
            //receiveline.UtilityHeader.receiptkey
            this.sourcetypetext.DataBinding(this.request, "UtilityHeader.type");
            this.orderkeytext.DataBinding(this.request, "UtilityHeader.sourcekey");

        }

        private void ordertypecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ordertypecombo.Text == "ASN")
            {
                this.msglab.Text = "收货单";
            }
            else if (this.ordertypecombo.Text == "ORDER")
            {
                this.msglab.Text = "出货单";
            }
            else if (this.ordertypecombo.Text == "WORK")
            {
                this.msglab.Text = "工作单";
            }
            else
            {
                this.msglab.Text = "内部转移单";
            }
            sourcetypetext.Text = this.ordertypecombo.Text;
        }

        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.msglab.Text.Length == 0)
            {
                focusControl = this.ordertypecombo;
                errortxt += "订单类型必填";
            }
            if (this.orderkeytext.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.orderkeytext;
                errortxt += "订单必填";

            }
            return errortxt;
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            call_API();
        }

        private void call_API()
        {
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            //this.Start();
            ordertype = this.ordertypecombo.Text;
            orderkey = this.orderkeytext.Text;

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
                this.orderkeytext.SetFocus();
                return;
            }
            else
            {
                RFDeviceAPP.Common.NSPRFINSTRUCTION01X.Response.Utility result = response.Deserialize<RFDeviceAPP.Common.NSPRFINSTRUCTION01X.Response.Utility>();
                FrmInstrcutionDetail resultfrm = new FrmInstrcutionDetail(result, this.LoginUser, ordertype, orderkey);
                resultfrm.ShowDialog();
            }
        }

        public void call_API(string orderType,string orderKey)
        {
            dataBinding();
            ordertype = orderType;
            orderkey = orderKey;
            this.ordertypecombo.Text = ordertype;
            this.orderkeytext.Text = orderKey;
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
                RFDeviceAPP.Common.NSPRFINSTRUCTION01X.Response.Utility result = response.Deserialize<RFDeviceAPP.Common.NSPRFINSTRUCTION01X.Response.Utility>();
                FrmInstrcutionDetail resultfrm = new FrmInstrcutionDetail(result, this.LoginUser, ordertype, orderkey);
                resultfrm.ShowDialog();
            }
        }
    }
}

