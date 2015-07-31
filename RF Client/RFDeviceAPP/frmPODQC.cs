using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using RFDeviceAPP.Common.Orders;
using RFDeviceAPP.Proxy;

namespace RFDeviceAPP
{
    public partial class frmPODQC : RFDeviceAPP.baseForm
    {
        private Control focusControl;
        public frmPODQC(UserInfo user):base(user)
        {
            InitializeComponent();
        }

        private void frmPODQC_Load(object sender, EventArgs e)
        {
            this.orderkey.SetFocus();
            //this.qcuser.Text = this.LoginUser.UserName;
        }
        public string Vaildate( )
        {
            string errortxt = string.Empty;
            if (this.orderkey.Text.Length == 0)
            {
                focusControl = this.orderkey;
                errortxt += "订单号必填";
            }
            if (this.qcuser.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.qcuser;
                errortxt += "QC员必填";

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

            ShipmentOrder ordre = ShipmentOrder.CreateQCPOD(this.orderkey.Text, this.qcuser.Text);

             
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
                MessageBox.Show("QC完成");
                

            }
            //threadhelper.AddWorkItem(workitem);

        }

    }
}

