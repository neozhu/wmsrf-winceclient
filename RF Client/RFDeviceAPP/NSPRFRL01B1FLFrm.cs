using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using req = RFDeviceAPP.Common.NSPRFRL01B1FL.Request;
using res = RFDeviceAPP.Common.NSPRFRL01B1FL.Response;
using RFDeviceAPP.Proxy;
using RFDeviceAPP.Common;

namespace RFDeviceAPP
{
    public partial class NSPRFRL01B1FLFrm : RFDeviceAPP.baseForm
    {
        private UserInfo loginuser;
        private req.Utility reqitem;
        private res.Utility resitem;
        private Control focusControl;
        public NSPRFRL01B1FLFrm(UserInfo userinfo)
            : base(userinfo)
        {
            this.loginuser = userinfo;
            InitializeComponent();
            this.qty.Text = "0";
        }

        public void submitMove(string sku, string fromloc, string fromid, string toid, string qty, string actloc)
        {
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            reqitem = req.Utility.Create( sku,  fromloc,  fromid,  toid,  qty,  actloc);
            reqitem.UtilityHeader.userid = this.loginuser.UserName;
             RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  reqitem);
            //RequestWorkItem workitem = new RequestWorkItem(request, 1);
            ResponseMessage response = ThreadHelper.Execute(request);
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
            }
            else
            {
                MessageBox.Show("移动完成");
                Clean();

            }
        }

        public void Clean()
        {
            this.fromid.SetFocus();
            this.fromid.Clean();
            this.toid.Clean();
            this.sku.Clean();
            this.fromloc.Clean();
            this.qty.Clean();
            this.actloc.Clean();
            this.qty.Text = "0";

        }
        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.fromid.Text.Length == 0)
            {
                focusControl = this.fromid;
                errortxt += "自ID必填";
            }
            //if (this.toid.Text.Length == 0)
            //{
            //    focusControl = this.toid;
            //    errortxt += "至ID必填";
            //}
            if (this.qty.Text.Length == 0)
            {
                focusControl = this.qty;
                errortxt += "量必填";

            }
            else
            {
                try{
                decimal qty1=decimal.Parse(this.qty.Text);
                if (qty1 < 0)
                {
                    focusControl = this.qty;
                    errortxt += "量必填>=0";
                }
                }catch{
                    focusControl = this.qty;
                    errortxt += "量必须是数字";
                }
            }
            if (this.actloc.Text.Length == 0)
            {
                focusControl = this.actloc;
                errortxt += "至库位必填";
            }


            return errortxt;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.submitMove(this.sku.Text, this.fromloc.Text, this.fromid.Text, this.toid.Text, this.qty.Text, this.actloc.Text);
        }

        private void NSPRFRL01B1FLFrm_Load(object sender, EventArgs e)
        {
            this.sku.SetFocus();
        }



    }
}

