using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common.Orders;
using RFDeviceAPP.Proxy;
using RFDeviceAPP.Common;

namespace RFDeviceAPP
{
    public partial class FrmPODCheck : RFDeviceAPP.baseForm
    {
        private Control focusControl;
        public FrmPODCheck(UserInfo user)
            : base(user)
        {
            InitializeComponent();
        }

        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.orderkey.Text.Length == 0)
            {
                focusControl = this.orderkey;
                errortxt += "订单号必填";
            }
            if (this.checkuser.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.checkuser;
                errortxt += "复检员必填";

            }




            return errortxt;
        }
        private void submitbtn_Click(object sender, EventArgs e)
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

            ShipmentOrder ordre = ShipmentOrder.CreateCheckPOD(this.orderkey.Text, this.checkuser.Text);


            //arrivalreq.AdvancedShipNoticeHeader.TheCube = this.thecube.Text;
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.ShipmentOrder,
                  enumRequestMethod.store, this.LoginUser,
                  enumSendSysId.EXceed,
                  ordre);
            //RequestWorkItem workitem = new RequestWorkItem(request, 1);
            ResponseMessage response = ThreadHelper.Execute(request);
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
                this.orderkey.SetFocus();
                return;
            }
            else
            {
                //DoClassifyFrm frm = new DoClassifyFrm(this.loginuser, this.storerkey.Text, this.receiptkey.Text, linecount);
                //frm.ShowDialog();
                this.orderkey.Clean();
                this.orderkey.SetFocus();
                MessageBox.Show("复检完成");


            }
            //threadhelper.AddWorkItem(workitem);

        }

        private void FrmPODCheck_Load(object sender, EventArgs e)
        {
            this.orderkey.SetFocus();
            this.checkuser.Text = this.LoginUser.UserName;
        }

        private void orderkey_TextChanged(object sender, EventArgs e)
        {

        }

        private void rfLabel2_ParentChanged(object sender, EventArgs e)
        {

        }

        private void checkuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void rfLabel1_ParentChanged(object sender, EventArgs e)
        {

        }

         
    }
}

