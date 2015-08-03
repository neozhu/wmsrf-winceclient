using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Proxy;
using RFDeviceAPP.Common;
using pick1_req = RFDeviceAPP.Common.NSPRFFLREMQTY.Request;
using pick1_res = RFDeviceAPP.Common.NSPRFFLREMQTY.Response;
using pick2_req = RFDeviceAPP.Common.NSPRFFLOP01.Request;
using pick2_res = RFDeviceAPP.Common.NSPRFFLOP01.Response;

namespace RFDeviceAPP
{
    public partial class RFFLPickingFrm : RFDeviceAPP.baseForm
    {
        private UserInfo loginuser;
        private pick1_req.Utility pick_req1;
        private pick1_res.Utility pick_res1;
        private pick2_req.Utility pick_req2;
        private pick2_res.Utility pick_res2;
        private ThreadHelper threadhelper;
        private bool isrequiredid = false;
        private Control focusControl;

        public RFFLPickingFrm(UserInfo userinfo,bool isrequiredid)
            : base(userinfo)
        {
            InitializeComponent();
            this.isrequiredid = isrequiredid;
            this.loginuser = userinfo;
            this.pick_req2 = new pick2_req.Utility();
            this.pick_req2.UtilityHeader.userid = this.loginuser.UserName;
            threadhelper = new ThreadHelper();
            threadhelper.AllWorkItemCompleted += new EventHandler(threadhelper_AllWorkItemCompleted);
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
            threadhelper.WorkItemFailed += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemFailed);
            this.sotxt.Focus();
            dataBinding();

            if (this.isrequiredid)
            {
                this.Text = "区域拣货";
            }
            else {
                this.Text = "简易拣货";
            }
        }
        public void dataBinding()
        {
            this.fromidtxt.DataBinding(this.pick_req2, "UtilityHeader.fromid");
            this.skutxt.DataBinding(this.pick_req2, "UtilityHeader.sku");
            this.qtytxt.DataBinding(this.pick_req2, "UtilityHeader.qty");
            this.dropidtxt.DataBinding(this.pick_req2, "UtilityHeader.dropid");
            this.loadcasetxt.DataBinding(this.pick_req2, "UtilityHeader.loadcase");
        }
        #region threadhelper
        void threadhelper_WorkItemCompleted(object sender, WorkItemEventArgs e)
        {
            int tag = e.WorkItem.Tag;
            WorkItem item = e.WorkItem;
            string errormsg = item.Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                this.sotxt.SetFocus();
                this.pick_req1 = null;
                //this.pick_req2 = null;
                this.pick_res1 = null;
                this.pick_res2 = null;
            }
            else
            {
                if (tag == 1)
                {
                    this.pick_res1 = e.WorkItem.Response.Deserialize<pick1_res.Utility>();
                    this.pick_req2.UtilityHeader.toloc = this.pick_res1.UtilityHeader.ToLoc;
                    this.pick_req2.UtilityHeader.pickdetailkey = this.pick_res1.UtilityHeader.PickDetailKey;
                    this.pick_req2.UtilityHeader.shiplabel = this.pick_res1.UtilityHeader.shiplabel;
                    this.pick_req2.UtilityHeader.storerkey = this.pick_res1.UtilityHeader.StorerKey;
                    this.pick_req2.UtilityHeader.lot = this.pick_res1.UtilityHeader.Lot;
                    this.pick_req2.UtilityHeader.fromloc = this.pick_res1.UtilityHeader.FromLoc;
                    this.pick_req2.UtilityHeader.qty = this.pick_res1.UtilityHeader.nothadpicked;
                    this.qtytxt.SetText(this.pick_res1.UtilityHeader.nothadpicked);
                    InvokeHelper.Invoke(this, "SetLabel", this.pick_res1);
                    this.qtytxt.SetFocus();
                }
                if (tag == 2)
                {
                    this.pick_res2 = e.WorkItem.Response.Deserialize<pick2_res.Utility>();
                    if (this.pick_res2.UtilityHeader.rectype == "3")
                    {
                        pick_req2 = new pick2_req.Utility();
                        this.pick_req2.UtilityHeader.userid = this.loginuser.UserName;
                        this.pick_req2.UtilityHeader.toloc = this.pick_res1.UtilityHeader.ToLoc;
                        this.pick_req2.UtilityHeader.pickdetailkey = this.pick_res1.UtilityHeader.PickDetailKey;
                        this.pick_req2.UtilityHeader.shiplabel = this.pick_res1.UtilityHeader.shiplabel;
                        this.pick_req2.UtilityHeader.storerkey = this.pick_res1.UtilityHeader.StorerKey;
                        this.pick_req2.UtilityHeader.lot = this.pick_res1.UtilityHeader.Lot;
                        this.pick_req2.UtilityHeader.fromloc = this.pick_res1.UtilityHeader.FromLoc;
                        this.pick_req2.UtilityHeader.qty = this.pick_res1.UtilityHeader.nothadpicked;
                        this.pick_req2.UtilityHeader.fromid = this.fromidtxt.GetText();
                        this.pick_req2.UtilityHeader.sku = this.skutxt.GetText();
                        this.pick_req2.UtilityHeader.dropid = this.dropidtxt.GetText();
                        this.pick_req2.UtilityHeader.loadcase = this.loadcasetxt.GetText();
                        
                        InvokeHelper.Invoke(this, "dataBinding", null);
                        call_NSPRFFLREMQTY(this.sotxt.GetText(), this.fromidtxt.GetText(), this.skutxt.GetText());
                       
                    }
                    else
                    {
                        MessageBox.Show("拣货完成");
                        this.pick_req2 = new pick2_req.Utility();
                        this.pick_req2.UtilityHeader.userid = this.loginuser.UserName;
                        this.sotxt.SetText("");
                        InvokeHelper.Invoke(this, "dataBinding", null);
                        this.sotxt.SetFocus();
                        InvokeHelper.Invoke(this, "RestLabel", 0);
                        
                    }
                }
            }
        }
        void threadhelper_WorkItemFailed(object sender, WorkItemEventArgs e)
        {
            MessageBox.Show("Failed" + e.WorkItem.Ex.Message);
            this.sotxt.SetFocus();
        }
        void threadhelper_AllWorkItemCompleted(object sender, EventArgs e)
        {
            this.Stop();
        }
        #endregion
        public void SetLabel(pick1_res.Utility res)
        {
            this.lb1.Text = string.Format("ID现有库存 {0}", res.UtilityHeader.idqty);
            this.lb2.Text = string.Format("ID拣后库存 {0}", res.UtilityHeader.idremqty);

            this.lb3.Text = string.Format("储位现有库存 {0}", res.UtilityHeader.locqty);
            this.lb4.Text = string.Format("储位拣后库存 {0}", res.UtilityHeader.remqty);
        }
        public void RestLabel(int val)
        {
            this.lb1.Text = string.Format("ID现有库存 {0}", val);
            this.lb2.Text = string.Format("ID拣后库存 {0}", val);

            this.lb3.Text = string.Format("储位现有库存 {0}", val);
            this.lb4.Text = string.Format("储位拣后库存 {0}", val);
        }
        #region call_API
        public void call_NSPRFFLREMQTY(string so,string fromid,string sku)
        {
            
            //this.Start();
            pick_req1 = pick1_req.Utility.Create(so, fromid, sku);
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  this.pick_req1);
            //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                this.sotxt.SetFocus();
                this.pick_req1 = null;
                //this.pick_req2 = null;
                this.pick_res1 = null;
                this.pick_res2 = null;
            }
            else
            {

                this.pick_res1 = Response.Deserialize<pick1_res.Utility>();
                this.pick_req2.UtilityHeader.toloc = this.pick_res1.UtilityHeader.ToLoc;
                this.pick_req2.UtilityHeader.pickdetailkey = this.pick_res1.UtilityHeader.PickDetailKey;
                this.pick_req2.UtilityHeader.shiplabel = this.pick_res1.UtilityHeader.shiplabel;
                this.pick_req2.UtilityHeader.storerkey = this.pick_res1.UtilityHeader.StorerKey;
                this.pick_req2.UtilityHeader.lot = this.pick_res1.UtilityHeader.Lot;
                this.pick_req2.UtilityHeader.fromloc = this.pick_res1.UtilityHeader.FromLoc;
                this.pick_req2.UtilityHeader.qty = this.pick_res1.UtilityHeader.nothadpicked;
                this.qtytxt.SetText(this.pick_res1.UtilityHeader.nothadpicked);
                //InvokeHelper.Invoke(this, "SetLabel", this.pick_res1);
                this.SetLabel(this.pick_res1);
                this.qtytxt.SetFocus();
            }
        }
        public void call_NSPRFFLOP01()
        {
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            //this.Start();
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  this.pick_req2);
            //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 2);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                this.sotxt.SetFocus();
                this.pick_req1 = null;
                //this.pick_req2 = null;
                this.pick_res1 = null;
                this.pick_res2 = null;
            }
            else
            {
                this.pick_res2 = Response.Deserialize<pick2_res.Utility>();
                if (this.pick_res2.UtilityHeader.rectype == "3")
                {
                    pick_req2 = new pick2_req.Utility();
                    this.pick_req2.UtilityHeader.userid = this.loginuser.UserName;
                    this.pick_req2.UtilityHeader.toloc = this.pick_res1.UtilityHeader.ToLoc;
                    this.pick_req2.UtilityHeader.pickdetailkey = this.pick_res1.UtilityHeader.PickDetailKey;
                    this.pick_req2.UtilityHeader.shiplabel = this.pick_res1.UtilityHeader.shiplabel;
                    this.pick_req2.UtilityHeader.storerkey = this.pick_res1.UtilityHeader.StorerKey;
                    this.pick_req2.UtilityHeader.lot = this.pick_res1.UtilityHeader.Lot;
                    this.pick_req2.UtilityHeader.fromloc = this.pick_res1.UtilityHeader.FromLoc;
                    this.pick_req2.UtilityHeader.qty = this.pick_res1.UtilityHeader.nothadpicked;
                    this.pick_req2.UtilityHeader.fromid = this.fromidtxt.GetText();
                    this.pick_req2.UtilityHeader.sku = this.skutxt.GetText();
                    this.pick_req2.UtilityHeader.dropid = this.dropidtxt.GetText();
                    this.pick_req2.UtilityHeader.loadcase = this.loadcasetxt.GetText();

                    //InvokeHelper.Invoke(this, "dataBinding", null);
                    this.dataBinding();
                    call_NSPRFFLREMQTY(this.sotxt.GetText(), this.fromidtxt.GetText(), this.skutxt.GetText());

                }
                else
                {
                    MessageBox.Show("拣货完成");
                    this.pick_req2 = new pick2_req.Utility();
                    this.pick_req2.UtilityHeader.userid = this.loginuser.UserName;
                    this.sotxt.SetText("");
                    InvokeHelper.Invoke(this, "dataBinding", null);
                    this.sotxt.SetFocus();
                    InvokeHelper.Invoke(this, "RestLabel", 0);

                }
            }
        }
        #endregion


        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.sotxt.Text.Length == 0)
            {
                focusControl = this.sotxt;
                errortxt += "订单号必填";
            }
            if (this.fromidtxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.fromidtxt;
                errortxt += "LPN必填";

            }
            if (this.skutxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.skutxt;
                errortxt += "sku必填";

            }
            if (this.isrequiredid && string.IsNullOrEmpty(dropidtxt.Text.Trim()))
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.dropidtxt;
                errortxt += "区域拣货中必须输入ID";
                 
            }
            else if (this.isrequiredid && dropidtxt.Text.Length != 10)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.dropidtxt;
                errortxt += "区域拣货中必须输入ID";
                 
            }

            return errortxt;
        }
        private void skutxt_LostFocus(object sender, EventArgs e)
        {
            if (skutxt.Text.Length > 0)
            {
                //string errortxt = this.Vaildate();
                //if (errortxt != string.Empty)
                //{
                //    MessageBox.Show(errortxt);
                //    this.focusControl.Focus();
                //    return;
                //}

                this.call_NSPRFFLREMQTY(this.sotxt.Text, this.fromidtxt.Text, this.skutxt.Text);
            }
        }

        private void submitbt_Click(object sender, EventArgs e)
        {
            this.call_NSPRFFLOP01();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.LButton | Keys.MButton | Keys.ShiftKey | Keys.Space | Keys.F17))
            {
                call_NSPRFFLOP01();
            }
            base.OnKeyDown(e);

        }

        private void dropidtxt_LostFocus(object sender, EventArgs e)
        {
            if (this.isrequiredid && string.IsNullOrEmpty(dropidtxt.Text.Trim())) {
                MessageBox.Show("区域拣货中必须输入ID");
                dropidtxt.SetFocus();
            }
            else if (this.isrequiredid && dropidtxt.Text.Length!=10)
            {
                MessageBox.Show("落放ID必须是10位");
                dropidtxt.SetFocus();
            }
        }

        private void sotxt_LostFocus(object sender, EventArgs e)
        {
            if (this.isrequiredid && string.IsNullOrEmpty(sotxt.Text.Trim()))
            {
                MessageBox.Show("订单号必须输入");
                sotxt.SetFocus();
            }
            
        }

        private void fromidtxt_LostFocus(object sender, EventArgs e)
        {
            if (this.isrequiredid && string.IsNullOrEmpty(fromidtxt.Text.Trim()))
            {
                MessageBox.Show("LPN必须输入");
                fromidtxt.SetFocus();
            }
        }

        private void qtytxt_LostFocus(object sender, EventArgs e)
        {
            if (this.isrequiredid && string.IsNullOrEmpty(qtytxt.Text.Trim()))
            {
                MessageBox.Show("数量必须输入");
                qtytxt.SetFocus();
            }
        }
    }
}

