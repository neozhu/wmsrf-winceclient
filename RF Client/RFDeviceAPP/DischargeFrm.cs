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
using RFDeviceAPP.Proxy;
namespace RFDeviceAPP
{
    public partial class DischargeFrm : Form
    {
        private UserInfo loginuser;
        private arrival_req.AdvancedShipNotice arrivalreq;
        private arrival_res.AdvancedShipNotice arrivalres;
        private ThreadHelper threadhelper;

        private Control focusControl;

        public DischargeFrm(UserInfo userinfo, string receiptkey, string storerkey) 
        {
            loginuser = userinfo;
            InitializeComponent();
            this.KeyPreview = true;

            this.receiptkey.Text = receiptkey;
            this.storerkey.Text = storerkey;
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

                if (tag == 2)
                {
                    arrivalres = e.WorkItem.Response.Deserialize<arrival_res.AdvancedShipNotice>();
                    MessageBox.Show("全部卸货完毕", "提示");
                    InvokeHelper.Set(this, "DialogResult", DialogResult.OK);


                }

                if (tag == 3)
                {
                    arrivalres = e.WorkItem.Response.Deserialize<arrival_res.AdvancedShipNotice>();
                    MessageBox.Show("卸货完毕", "提示");
                    //InvokeHelper.Set(this, "DialogResult", DialogResult.OK);


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
            //this.Stop();
        }
        public string Vaildate()
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
            if (this.thepallet.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.thepallet;
                errortxt += "托数必填";

            }
            if (this.thecase.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.thecase;
                errortxt += "箱数必填";

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
            //this.Start();

            arrivalreq = new arrival_req.AdvancedShipNotice();
            
            arrivalreq.AdvancedShipNoticeHeader.StorerKey = this.storerkey.Text;
            arrivalreq.AdvancedShipNoticeHeader.ReceiptKey = this.receiptkey.Text;
            arrivalreq.AdvancedShipNoticeHeader.TheCase = this.thecase.Text;
            arrivalreq.AdvancedShipNoticeHeader.ThePallet = this.thepallet.Text;
            arrivalreq.AdvancedShipNoticeHeader.DischargeStatus = "c";
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.AdvancedShipNotice,
                  enumRequestMethod.store, this.loginuser,
                  enumSendSysId.EXceed,
                  arrivalreq);
            RequestWorkItem workitem = new RequestWorkItem(request, 2);
            threadhelper.AddWorkItem(workitem);

        }
        private void call_arrival02()
        {
            string errortxt = this.Vaildate();
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
            arrivalreq.AdvancedShipNoticeHeader.TheCase = this.thecase.Text;
            arrivalreq.AdvancedShipNoticeHeader.ThePallet = this.thepallet.Text;
            arrivalreq.AdvancedShipNoticeHeader.DischargeStatus = "s";
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.AdvancedShipNotice,
                  enumRequestMethod.store, this.loginuser,
                  enumSendSysId.EXceed,
                  arrivalreq);
            //RequestWorkItem workitem = new RequestWorkItem(request, 3);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage response = ThreadHelper.Execute(request);
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
            }
            else
            {
                DialogResult res = MessageBox.Show("是否结束卸货", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (res == DialogResult.Yes)
                {
                    arrivalreq = new arrival_req.AdvancedShipNotice();

                    arrivalreq.AdvancedShipNoticeHeader.StorerKey = this.storerkey.Text;
                    arrivalreq.AdvancedShipNoticeHeader.ReceiptKey = this.receiptkey.Text;
                    arrivalreq.AdvancedShipNoticeHeader.TheCase = this.thecase.Text;
                    arrivalreq.AdvancedShipNoticeHeader.ThePallet = this.thepallet.Text;
                    arrivalreq.AdvancedShipNoticeHeader.DischargeStatus = "c";
                    RequestMessage request1 = new RequestMessage(enumRequestType.MessageProcessor,
                          enumMessageType.AdvancedShipNotice,
                          enumRequestMethod.store, this.loginuser,
                          enumSendSysId.EXceed,
                          arrivalreq);
                    ResponseMessage response1 = ThreadHelper.Execute(request1);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.Close();
                }


            }

        }


        private void DischargeFrm_Load(object sender, EventArgs e)
        {
              this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            call_arrival01();
        }

        private void submit3_Click(object sender, EventArgs e)
        {
            call_arrival02();
        }

         
        
    }
}

