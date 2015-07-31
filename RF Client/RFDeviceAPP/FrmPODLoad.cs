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
    public partial class FrmPODLoad : RFDeviceAPP.baseForm
    {
        private Control focusControl;
        public FrmPODLoad(UserInfo user)
            : base(user)
        {
            InitializeComponent();
        }

        private void FrmPODLoad_Load(object sender, EventArgs e)
        {
            this.orderkey.SetFocus();
            this.checkuser.Text = this.LoginUser.UserName;
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
                errortxt += "装车员必填";

            }
            if (this.qty1.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.qty1;
                errortxt += "整箱数必填";

            }
            if (this.qty2.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.qty1;
                errortxt += "托盘数必填";

            }
            if (this.qty3.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.qty1;
                errortxt += "散箱数必填";

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

            ShipmentOrder ordre = ShipmentOrder.CreateLoadPOD(this.orderkey.Text, this.checkuser.Text, this.qty1.Text, this.qty2.Text, this.qty3.Text);


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
                this.qty1.Clean();
                this.qty2.Clean();
                this.qty3.Clean();
                this.qty3.Text = "0";
                MessageBox.Show("装车完成");


            }
            //threadhelper.AddWorkItem(workitem);

        }

        private void qty2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

