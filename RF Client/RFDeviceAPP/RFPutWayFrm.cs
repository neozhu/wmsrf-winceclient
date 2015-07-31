using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using putw1_req = RFDeviceAPP.Common.NSPRFPA01.Request;
using putw1_res = RFDeviceAPP.Common.NSPRFPA01.Response;
using putw2_req = RFDeviceAPP.Common.NSPRFPA02.Request;
using putw2_res = RFDeviceAPP.Common.NSPRFPA02.Response;
using RFDeviceAPP.Proxy;
using System.Text.RegularExpressions;
using System.Reflection;

namespace RFDeviceAPP
{
    public partial class RFPutWayFrm : RFDeviceAPP.baseForm
    {

        private UserInfo loginuser;
        private putw1_req.Utility putwskureq;
        private putw1_res.Utility putwskures;
        private putw2_req.Utility submitskureq;
        private putw2_res.Utility submitskures;
        private ThreadHelper threadhelper;

        private Control focusControl;

        public RFPutWayFrm(UserInfo userinfo):base(userinfo)
        {
            InitializeComponent();
            this.KeyPreview = true;
            loginuser = userinfo;
            putwskureq = new putw1_req.Utility();
            putwskureq.UtilityHeader.userid = this.loginuser.UserName;
            threadhelper = new ThreadHelper();

            threadhelper.AllWorkItemCompleted += new EventHandler(threadhelper_AllWorkItemCompleted);
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
            threadhelper.WorkItemFailed += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemFailed);
            submitskureq = new putw2_req.Utility();
            submitskureq.UtilityHeader.userid = this.loginuser.UserName;

            this.dataBinding();
            this.idtxt.Focus();
            this.KeyPreview = true;
        }

        public void dataBinding()
        {
            this.idtxt.DataBinding(this.submitskureq, "UtilityHeader.toid");
            this.skutxt.DataBinding(this.submitskureq, "UtilityHeader.sku");
            this.suggestedtoloctxt.DataBinding(this.submitskureq, "UtilityHeader.suggestedtoloc");
            this.toloctxt.DataBinding(this.submitskureq, "UtilityHeader.toloc");
        }

        void threadhelper_WorkItemCompleted(object sender, WorkItemEventArgs e)
        {
            int tag = e.WorkItem.Tag;
            WorkItem item = e.WorkItem;
            string errormsg = item.Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(item.Response.GetErrorMessage());
                if (tag == 1)
                {
                    this.putwskureq = null;
                    this.putwskures = null;
                    //this.submitskureq = null;
                    this.submitskures = null;

                    this.idtxt.Clean();
                    this.skutxt.Clean();
                    this.suggestedtoloctxt.Clean();
                    this.toloctxt.Clean();

                    this.idtxt.SetFocus();
                }
                if (tag == 2)
                {
                    this.toloctxt.SetFocus();
                }
                return;
            }
            if (tag == 1)
            {
                putwskures = e.WorkItem.Response.Deserialize<putw1_res.Utility>();
                this.skutxt.SetText(putwskures.UtilityHeader.Sku);
                this.submitskureq.UtilityHeader.sku = putwskures.UtilityHeader.Sku;
                this.suggestedtoloctxt.SetText(putwskures.UtilityHeader.ToLoc);
                this.submitskureq.UtilityHeader.suggestedtoloc = putwskures.UtilityHeader.ToLoc;

                this.submitskureq.UtilityHeader.finaltoloc = putwskures.UtilityHeader.FinalToLoc;
                this.submitskureq.UtilityHeader.storerkey = putwskures.UtilityHeader.StorerKey;
                this.submitskureq.UtilityHeader.lot = putwskures.UtilityHeader.Lot;
                this.submitskureq.UtilityHeader.fromid = putwskures.UtilityHeader.ID;
                this.submitskureq.UtilityHeader.toid = putwskures.UtilityHeader.ID;
                this.submitskureq.UtilityHeader.packkey = putwskures.UtilityHeader.PackKey;
                this.submitskureq.UtilityHeader.qty = putwskures.UtilityHeader.qtyconfirm;
                this.submitskureq.UtilityHeader.uom = "EA";
                this.submitskureq.UtilityHeader.fromloc = string.Empty;
                this.toloctxt.SetFocus();
                //this.skutxt.SetText(asnbylineres.UtilityHeader.Sku);
                //this.idtxt.Clean();
                //this.skutxt.Clean();
                //this.suggestedtoloctxt.Clean();
                //this.toloctxt.Clean();
            }
            if (tag == 2)
            {
                submitskures = e.WorkItem.Response.Deserialize<putw2_res.Utility>();
                this.submitskureq = new RFDeviceAPP.Common.NSPRFPA02.Request.Utility();
                this.dataBinding();
                this.putwskureq = null;
                this.putwskures = null;
                this.submitskures = null;
                MessageBox.Show("上架完成");
                this.idtxt.SetFocus();
            }
        }

        void threadhelper_WorkItemFailed(object sender, WorkItemEventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show(e.WorkItem.Ex.Message);
            int tag = e.WorkItem.Tag;
            if (tag == 1)
            {
                this.idtxt.Clean();
                this.skutxt.Clean();
                this.suggestedtoloctxt.Clean();
                this.toloctxt.Clean();

                //this.receiptkeytxt.SetFocus();
                this.putwskureq = null;
                this.putwskures = null;
                this.submitskureq = null;
                this.submitskures = null;
                this.idtxt.SetFocus();
            }
            if (tag == 2)
            {
                this.toloctxt.SetFocus();
            }
        }

        void threadhelper_AllWorkItemCompleted(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.Stop();
        }

        private void RFPutWayFrm_Load(object sender, EventArgs e)
        {

        }

        private void idtxt_LostFocus(object sender, EventArgs e)
        {
            if(this.idtxt.Text.Length > 0)
            {
                if (putwskures != null && putwskureq != null && putwskureq.UtilityHeader.id == this.idtxt.Text)
                    return;

                this.call_Nsprfpa01(this.idtxt.Text);
            }
        }

        private void call_Nsprfpa01(string id)
        {
            //this.Start();
            putwskureq = putw1_req.Utility.CreateById(id);
            putwskureq.UtilityHeader.userid = this.loginuser.UserName;
            RequestMessage getskurequest = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  putwskureq);
            //RequestWorkItem workitem = new RequestWorkItem(getskurequest, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(getskurequest);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(Response.GetErrorMessage());


                this.putwskureq = null;
                this.putwskures = null;
                //this.submitskureq = null;
                this.submitskures = null;

                this.idtxt.Clean();
                this.skutxt.Clean();
                this.suggestedtoloctxt.Clean();
                this.toloctxt.Clean();

                this.idtxt.SetFocus();


            }
            else
            {
                putwskures = Response.Deserialize<putw1_res.Utility>();
                this.skutxt.SetText(putwskures.UtilityHeader.Sku);
                this.submitskureq.UtilityHeader.sku = putwskures.UtilityHeader.Sku;
                this.suggestedtoloctxt.SetText(putwskures.UtilityHeader.ToLoc);
                this.submitskureq.UtilityHeader.suggestedtoloc = putwskures.UtilityHeader.ToLoc;

                this.submitskureq.UtilityHeader.finaltoloc = putwskures.UtilityHeader.FinalToLoc;
                this.submitskureq.UtilityHeader.storerkey = putwskures.UtilityHeader.StorerKey;
                this.submitskureq.UtilityHeader.lot = putwskures.UtilityHeader.Lot;
                this.submitskureq.UtilityHeader.fromid = putwskures.UtilityHeader.ID;
                this.submitskureq.UtilityHeader.toid = putwskures.UtilityHeader.ID;
                this.submitskureq.UtilityHeader.packkey = putwskures.UtilityHeader.PackKey;
                this.submitskureq.UtilityHeader.qty = putwskures.UtilityHeader.qtyconfirm;
                this.submitskureq.UtilityHeader.uom = "EA";
                this.submitskureq.UtilityHeader.fromloc = string.Empty;
                this.toloctxt.SetFocus();
            }
        }

        private void rfButtonCommand1_Click(object sender, EventArgs e)
        {
            call_Nsprfa02();
        }

        private void call_Nsprfa02()
        {

            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            submitskureq.UtilityHeader.userid = this.loginuser.UserName;
            //this.Start();
            RequestMessage submitskurequest = new RequestMessage(enumRequestType.MessageProcessor,
                 enumMessageType.Utility,
                 enumRequestMethod.functionOperation, this.loginuser,
                 enumSendSysId.External,
                 submitskureq);
            //RequestWorkItem workitem = new RequestWorkItem(submitskurequest, 2);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(submitskurequest);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(Response.GetErrorMessage());


                this.toloctxt.SetFocus();

            }
            else
            {
                submitskures =  Response.Deserialize<putw2_res.Utility>();
                this.submitskureq = new RFDeviceAPP.Common.NSPRFPA02.Request.Utility();
                this.dataBinding();
                this.putwskureq = null;
                this.putwskures = null;
                this.submitskures = null;
                MessageBox.Show("上架完成");
                this.idtxt.SetFocus();
            }
        }

        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.idtxt.Text.Length == 0)
            {
                focusControl = this.idtxt;
                errortxt += "LPN必填";
            }
            if (this.skutxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.skutxt;
                errortxt += "sku必填";

            }
            if (this.toloctxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.toloctxt;
                errortxt += "库位必填";

            }
            

            return errortxt;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.LButton | Keys.MButton | Keys.ShiftKey | Keys.Space | Keys.F17))
            {
                call_Nsprfa02();
            }
            base.OnKeyDown(e);

        }

        private void rfButtonCommand1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.idtxt.Focus();
            }
        }
    }
}

