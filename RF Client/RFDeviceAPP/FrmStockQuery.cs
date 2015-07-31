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
    public partial class FrmStockQuery : RFDeviceAPP.baseForm
    {
        private RFDeviceAPP.Common.NSPRFIQ01.Request.Utility request;

        public FrmStockQuery(Common.UserInfo loginuser):base(loginuser)
        {
            InitializeComponent();
            request = new RFDeviceAPP.Common.NSPRFIQ01.Request.Utility();

            dataBinding();
        }
        public void dataBinding()
        {
            //receiveline.UtilityHeader.receiptkey
            this.storerkey.DataBinding(this.request, "UtilityHeader.storerkey");
            this.sku.DataBinding(this.request, "UtilityHeader.sku");
            this.loc.DataBinding(this.request, "UtilityHeader.loc");
            this.id.DataBinding(this.request, "UtilityHeader.id");
            this.lot.DataBinding(this.request, "UtilityHeader.lot");
            this.caseid.DataBinding(this.request, "UtilityHeader.caseid");
            //this.storerkey.DataBinding(this.request, "UtilityHeader.storerkey");

        }
        private void FrmStockQuery_Load(object sender, EventArgs e)
        {
            this.storerkey.SetFocus();
        }

        private void submitbt_Click(object sender, EventArgs e)
        {
            call_NSPRFIQ01();
        }
        private void call_NSPRFIQ01()
        {
            this.request.UtilityHeader.userid = this.LoginUser.UserName;
            RequestMessage query = new RequestMessage(enumRequestType.MessageProcessor,
                enumMessageType.Utility,
                enumRequestMethod.functionOperation, this.LoginUser,
                enumSendSysId.EXceed,
                this.request);

            ResponseMessage response = ThreadHelper.Execute(query);
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
            }
            else
            {
                RFDeviceAPP.Common.NSPRFIQ01.Response.Utility result = response.Deserialize<RFDeviceAPP.Common.NSPRFIQ01.Response.Utility>();
                //Console.Write(result);
                //FrmStockResult resultfrm = new FrmStockResult(result);
                FrmStockResultDetail resultfrm = new FrmStockResultDetail(result);
                resultfrm.ShowDialog();
                this.Activate();
                this.storerkey.SetFocus();
            }

        }

        private void FrmStockQuery_Activated(object sender, EventArgs e)
        {
            this.storerkey.SetFocus();
        }
    }
}

