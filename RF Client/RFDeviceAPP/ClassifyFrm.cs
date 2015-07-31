using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using arrival_req = RFDeviceAPP.Common.Arrival01.Request;
using arrival_res = RFDeviceAPP.Common.Arrival01.Response;
using asnlist01_res = RFDeviceAPP.Common.asnlist01.Response;
using asnlist01_req = RFDeviceAPP.Common.asnlist01.Request;
using RFDeviceAPP.Proxy;
namespace RFDeviceAPP
{
    public partial class ClassifyFrm : RFDeviceAPP.baseForm
    {
        private UserInfo loginuser;
        private arrival_req.AdvancedShipNotice arrivalreq;
        private arrival_res.AdvancedShipNotice arrivalres;
        private asnlist01_res.AdvancedShipNotice asnlist01res;
        private asnlist01_req.AdvancedShipNotice asnlist01req;
        private ThreadHelper threadhelper;
        private int linecount;

        private Control focusControl;
        public ClassifyFrm(UserInfo userinfo):base(userinfo)
        {
            InitializeComponent();
            loginuser = userinfo;
            this.KeyPreview = true;

            
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
                    arrivalres = e.WorkItem.Response.Deserialize<arrival_res.AdvancedShipNotice>();
                  
                    MessageBox.Show("分料开始", "提示");
                    //InvokeHelper.Set(this, "DialogResult", DialogResult.OK);
                    this.submit2.SetEnabled(true);

                }

                if (tag == 2)
                {
                    arrivalres = e.WorkItem.Response.Deserialize<arrival_res.AdvancedShipNotice>();
                    MessageBox.Show("分料完毕", "提示");
                    this.submit2.SetEnabled(false);
                    //InvokeHelper.Set(this, "DialogResult", DialogResult.OK);


                }
                if (tag == 3)
                {
                    asnlist01res = e.WorkItem.Response.Deserialize<asnlist01_res.AdvancedShipNotice>();
                    if (asnlist01res != null)
                    {
                        if (string.IsNullOrEmpty(asnlist01res.AdvancedShipNoticeHeaders[0].StorerKey))
                        {
                            MessageBox.Show("没有找到ASN", "提示");
                            this.receiptkey.SetFocus();
                        }
                        else
                        {
                            this.storerkey.SetText(asnlist01res.AdvancedShipNoticeHeaders[0].StorerKey);
                            this.linecount = asnlist01res.AdvancedShipNoticeHeaders[0].AdvancedShipNoticeDetail.Count;
                        }
                        
                    }

                    //foreach (asnlist01_res.AdvancedShipNoticeHeader body in asnlist01res.AdvancedShipNoticeHeaders)
                    //    InvokeHelper.Invoke(this, "addportlist", body.ReceiptKey + " " + body.StorerKey);
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
                else
                {
                    if (decimal.Parse(this.thecube.Text) <= 0)
                    {
                        focusControl = this.thecube;
                        errortxt += "体积必须>0";
                    }
                }
            }
            


            return errortxt;
        }
        private void submit1_Click(object sender, EventArgs e)
        {
            call_arrival01();
        }

        private void call_arrival01()
        {
            string errortxt = this.Vaildate("1");
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            //this.Start();

            arrivalreq = new arrival_req.AdvancedShipNotice();

            arrivalreq.AdvancedShipNoticeHeader.StorerKey = this.storerkey.Text;
            arrivalreq.AdvancedShipNoticeHeader.ReceiptKey = this.receiptkey.Text;
            arrivalreq.AdvancedShipNoticeHeader.ArrangeStatus = "s";
            //arrivalreq.AdvancedShipNoticeHeader.TheCube = this.thecube.Text;
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.AdvancedShipNotice,
                  enumRequestMethod.store, this.loginuser,
                  enumSendSysId.EXceed,
                  arrivalreq);
            //RequestWorkItem workitem = new RequestWorkItem(request, 1);
            ResponseMessage response = ThreadHelper.Execute(request);
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
            }
            else
            {
                DoClassifyFrm frm = new DoClassifyFrm(this.loginuser, this.storerkey.Text, this.receiptkey.Text, linecount);
                frm.ShowDialog();

            }
            //threadhelper.AddWorkItem(workitem);

        }
         private void call_arrival02()
        {
            string errortxt = this.Vaildate("2");
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            this.Start();

            arrivalreq = new arrival_req.AdvancedShipNotice();

            arrivalreq.AdvancedShipNoticeHeader.StorerKey = this.storerkey.Text;
            arrivalreq.AdvancedShipNoticeHeader.ReceiptKey = this.receiptkey.Text;
            arrivalreq.AdvancedShipNoticeHeader.ArrangeStatus = "c";
            arrivalreq.AdvancedShipNoticeHeader.TheCube = this.thecube.Text;
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.AdvancedShipNotice,
                  enumRequestMethod.store, this.loginuser,
                  enumSendSysId.EXceed,
                  arrivalreq);
            RequestWorkItem workitem = new RequestWorkItem(request, 2);
            threadhelper.AddWorkItem(workitem);

        }
        private void submit2_Click(object sender, EventArgs e)
        {
            call_arrival02();
        }

        private void receiptkey_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.receiptkey.Text))
            {
                call_asnlist01(this.receiptkey.Text);
            }
        }

        private void call_asnlist01(string asn)
        {
            this.Start();
            //this.asnlist.Items.Clear();
            //this.asnlist.Enabled = false;
            asnlist01req = asnlist01_req.AdvancedShipNotice.CreateByReceiptKey(asn,"");
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.AdvancedShipNotice,
                  enumRequestMethod.list, this.loginuser,
                  enumSendSysId.EXceed,
                  asnlist01req);
            RequestWorkItem workitem = new RequestWorkItem(request, 3);
            threadhelper.AddWorkItem(workitem);

        }

        private void ClassifyFrm_Load(object sender, EventArgs e)
        {

        }

    }
}

