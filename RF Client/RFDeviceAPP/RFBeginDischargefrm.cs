using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using asnlist01_res = RFDeviceAPP.Common.asnlist01.Response;
using asnlist01_req = RFDeviceAPP.Common.asnlist01.Request;
using arrival_req = RFDeviceAPP.Common.Arrival01.Request;
using arrival_res = RFDeviceAPP.Common.Arrival01.Response;
using RFDeviceAPP.Proxy;
using RFDeviceAPP.Common;
namespace RFDeviceAPP
{
    public partial class RFBeginDischargefrm : RFDeviceAPP.baseForm
    {
        private UserInfo loginuser;
        private asnlist01_res.AdvancedShipNotice asnlist01res;
        private asnlist01_req.AdvancedShipNotice asnlist01req;
        private arrival_req.AdvancedShipNotice arrivalreq;
        private arrival_res.AdvancedShipNotice arrivalres;
        private ThreadHelper threadhelper;
        private Control focusControl;
        public RFBeginDischargefrm(UserInfo userinfo)
            : base(userinfo)
        {
            InitializeComponent();
            this.KeyPreview = true;
            loginuser = userinfo;
            threadhelper = new ThreadHelper();

            threadhelper.AllWorkItemCompleted += new EventHandler(threadhelper_AllWorkItemCompleted);
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
            threadhelper.WorkItemFailed += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemFailed);

        }
        void threadhelper_WorkItemCompleted(object sender, WorkItemEventArgs e)
        {
            int tag = e.WorkItem.Tag;
            WorkItem item = e.WorkItem;
            string errormsg = item.Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(item.Response.GetErrorMessage());
            }
            else
            {
                if (tag == 1)
                {
                    asnlist01res = e.WorkItem.Response.Deserialize<asnlist01_res.AdvancedShipNotice>();
                    foreach (asnlist01_res.AdvancedShipNoticeHeader body in asnlist01res.AdvancedShipNoticeHeaders)
                        InvokeHelper.Invoke(this, "addportlist", body.ReceiptKey + " " + body.StorerKey);
                }
                if (tag == 2)
                {
                    arrivalres = e.WorkItem.Response.Deserialize<arrival_res.AdvancedShipNotice>();
                    InvokeHelper.Set(this.portlist, "Enabled", true);
                }
            }
            
        }
        void threadhelper_WorkItemFailed(object sender, WorkItemEventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show(e.WorkItem.Ex.Message);
            int tag = e.WorkItem.Tag;
        }
        void threadhelper_AllWorkItemCompleted(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.Stop();
        }
        private void call_asnlist01(string pier)
        {
            //this.Start();
            this.portlist.Items.Clear();
            this.portlist.Enabled = false;
            asnlist01req = asnlist01_req.AdvancedShipNotice.Create(pier);

            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.AdvancedShipNotice,
                  enumRequestMethod.listHead, this.loginuser,
                  enumSendSysId.EXceed,
                  asnlist01req);
            //RequestWorkItem workitem = new RequestWorkItem(request, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(request);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(Response.GetErrorMessage());
                this.portcodetxt.SetFocus();
            }
            else
            {

                asnlist01res = Response.Deserialize<asnlist01_res.AdvancedShipNotice>();
                foreach (asnlist01_res.AdvancedShipNoticeHeader body in asnlist01res.AdvancedShipNoticeHeaders)
                {
                    this.addportlist(body.ReceiptKey + " " + body.StorerKey);
                }
                //InvokeHelper.Invoke(this, "addportlist", body.ReceiptKey + " " + body.StorerKey);
            }    
        }
        public void addportlist(string code)
        {
            this.portlist.Items.Add(code);
            //this.portlist.SelectedIndex = 0;
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
            call_arrival01();
            //this.portlist.Enabled = true;
        }
        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.portcodetxt.Text.Length == 0)
            {
                focusControl = this.portcodetxt;
                errortxt += "码头编号必填";
            }
             
            if (this.portlist.Items.Count == 0)
            {
                focusControl = this.portcodetxt;
                errortxt += "没有找到收货单号";

            }


            return errortxt;
        }
        private void call_arrival01()
        {
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            this.Start();
            foreach (asnlist01_res.AdvancedShipNoticeHeader body in asnlist01res.AdvancedShipNoticeHeaders)
            {
                arrivalreq = new arrival_req.AdvancedShipNotice();

                arrivalreq.AdvancedShipNoticeHeader.StorerKey = body.StorerKey;
                arrivalreq.AdvancedShipNoticeHeader.ReceiptKey = body.ReceiptKey;
                arrivalreq.AdvancedShipNoticeHeader.DischargeStatus = "s";
                
                RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                      enumMessageType.AdvancedShipNotice,
                      enumRequestMethod.store, this.loginuser,
                      enumSendSysId.EXceed,
                      arrivalreq);
                //RequestWorkItem workitem = new RequestWorkItem(request, 2);
                //threadhelper.AddWorkItem(workitem);
                ResponseMessage Response = ThreadHelper.Execute(request);
                string errormsg = Response.GetErrorMessage();
                if (errormsg != string.Empty)
                {
                    MessageBox.Show(Response.GetErrorMessage());
                    this.portcodetxt.SetFocus();
                    return;
                }
            }
            this.portlist.Enabled = true;

        }
        private void portcodetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void portcodetxt_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.portcodetxt.Text))
            {
                if(this.asnlist01req==null || this.asnlist01req.AdvancedShipNoticeHeader.Pier!=this.portcodetxt.Text)
                    call_asnlist01(this.portcodetxt.Text);
            }
        }

        private void portlist_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = this.portlist.SelectedItem.ToString();
            Console.WriteLine(str);
        }

        private void portlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.portlist.SelectedItem != null)
            {
                string str = this.portlist.SelectedItem.ToString();
                string[] arr = str.Split(new char[] { ' ' });
                string receiptKey = arr[0];
                string storerKey = arr[1];
                DischargeFrm frm = new DischargeFrm(this.loginuser, receiptKey, storerKey);
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.portlist.Items.Remove(this.portlist.SelectedItem);
                }
            }

        }

         
    }
}

