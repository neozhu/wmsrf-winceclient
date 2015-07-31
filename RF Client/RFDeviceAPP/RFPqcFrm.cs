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
    public partial class RFPqcFrm : Form
    {
        public string currlinenum;
        private UserInfo loginuser;
        private asnlist01_res.AdvancedShipNoticeDetail detail;
        private string qpcnumber;
        private arrival_req.AdvancedShipNotice arrivalreq;
        private arrival_res.AdvancedShipNotice arrivalres;
        private ThreadHelper threadhelper;
        private Control focusControl;
        private Dictionary<string,asnlist01_res.AdvancedShipNoticeDetail> itemlist;
        public RFPqcFrm(UserInfo userinfo,asnlist01_res.AdvancedShipNoticeDetail detail,string number,List<asnlist01_res.AdvancedShipNoticeDetail> detaillist)
        {
            InitializeComponent();
            loginuser = userinfo;
            this.detail = detail;
            itemlist = new Dictionary<string, RFDeviceAPP.Common.asnlist01.Response.AdvancedShipNoticeDetail>();
            foreach (asnlist01_res.AdvancedShipNoticeDetail item in detaillist)
            {
                itemlist.Add(item.ReceiptLineNumber, item);
            }
            if (this.detail != null)
            {
                this.receiptKey.Text = detail.ReceiptKey;
                this.receiptLineNumber.Text = detail.ReceiptLineNumber;
                this.sku.Text = detail.Sku;
                this.qtyExpected.Text = detail.QtyExpected;
                this.pqcqtyinspected.Text = detail.PQCQTYINSPECTED;
                this.pqcqtyrejected.Text = detail.PQCQTYREJECTED;
                this.currlinenum = detail.ReceiptLineNumber;
            }
            else
            {
                this.receiptKey.Text = detaillist[0].ReceiptKey;
            }
            this.receiptLineNumber.SetFocus();
            qpcnumber = number;
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
                    MessageBox.Show("PQC完毕", "提示");
                    InvokeHelper.Set(this, "DialogResult", DialogResult.OK);

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
            if (this.receiptKey.Text.Length == 0)
            {
                focusControl = this.receiptKey;
                errortxt += "ASN必填";
            }
            if (this.receiptLineNumber.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.receiptLineNumber;
                errortxt += "行号必填";

            }
            if (this.sku.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.sku;
                errortxt += "SKU必填";

            }
            if (this.qtyExpected.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.qtyExpected;
                errortxt += "预检数量必填";

            }
            else
            {
                decimal inputqty=decimal.Parse(this.qtyExpected.Text);
                decimal qty=decimal.Parse(this.detail.QtyExpected);
                if (inputqty > qty)
                {
                    if (string.IsNullOrEmpty(errortxt))
                        focusControl = this.qtyExpected;
                    errortxt += "输入预检数量不能大于" + this.detail.QtyExpected;
                }
            }
            if (this.pqcqtyinspected.Text.Length == 0)
            {
                decimal a = 0;
               
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.pqcqtyinspected;
                errortxt += "PQC数量必填";

            }
            else
            {
                try
                {
                    decimal pqc1 = decimal.Parse(this.qtyExpected.Text);
                    decimal pqc2 = decimal.Parse(this.pqcqtyinspected.Text);
                    decimal pqc3 = decimal.Parse(this.pqcqtyrejected.Text);
                     if (pqc1 != pqc2 + pqc3)
                {
                    focusControl = this.pqcqtyinspected;
                    errortxt += "PQC数量+异常数量必须等于预检数量";
                }
                }catch{
                    focusControl = this.pqcqtyinspected;
                    errortxt += "输入的数量有问题";
                }
               
            }
            
            if (this.pqcqtyrejected.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.pqcqtyrejected;
                errortxt += "异常数量必填";

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

            arrivalreq.AdvancedShipNoticeHeader.StorerKey = this.detail.StorerKey;
            arrivalreq.AdvancedShipNoticeHeader.ReceiptKey = this.receiptKey.Text;
            arrivalreq.AdvancedShipNoticeHeader.PqcStatus = "s";
            arrivalreq.AdvancedShipNoticeHeader.AdvancedShipNoticeDetail = new List<RFDeviceAPP.Common.Arrival01.Request.AdvancedShipNoticeDetail>();
            arrival_req.AdvancedShipNoticeDetail item = new RFDeviceAPP.Common.Arrival01.Request.AdvancedShipNoticeDetail();
            item.PqcPeopleNum = this.qpcnumber;
            item.PqcQtyInspected = this.pqcqtyinspected.Text;
            item.PqcQtyRejected = this.pqcqtyrejected.Text;
            item.PqcStatus = "c";
            item.ReceiptKey = this.receiptKey.Text;
            item.ReceiptLineNumber = this.receiptLineNumber.Text;
            item.PqcWho = this.loginuser.UserName;
            arrivalreq.AdvancedShipNoticeHeader.AdvancedShipNoticeDetail.Add(item);
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.AdvancedShipNotice,
                  enumRequestMethod.store, this.loginuser,
                  enumSendSysId.EXceed,
                  arrivalreq);
            //RequestWorkItem workitem = new RequestWorkItem(request, 2);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage response= ThreadHelper.Execute(request);
            arrivalres = response.Deserialize<arrival_res.AdvancedShipNotice>();
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
            }
            else
            {
                MessageBox.Show("PQC完毕", "提示");
                this.DialogResult = DialogResult.OK;
            }


        }
        private void submitbt1_Click(object sender, EventArgs e)
        {
            call_arrival01();
        }

        private void receiptLineNumber_LostFocus(object sender, EventArgs e)
        {
            if (this.receiptLineNumber.Text.Length > 0)
            {
                string linenum = this.receiptLineNumber.Text;
                if (itemlist.ContainsKey(linenum))
                {
                    asnlist01_res.AdvancedShipNoticeDetail detail = itemlist[linenum];
                    this.detail = detail;
                    this.sku.Text = detail.Sku;
                    this.qtyExpected.Text = detail.QtyExpected;
                    this.pqcqtyinspected.Text = detail.PQCQTYINSPECTED;
                    this.pqcqtyrejected.Text = detail.PQCQTYREJECTED;
                    this.currlinenum = detail.ReceiptLineNumber;

                }
                else
                {
                    MessageBox.Show("没有找到该行号", "提示");
                    this.currlinenum = "";
                    this.receiptLineNumber.SetFocus();
                }
            }
        }

        private void dialogbtn_Click(object sender, EventArgs e)
        {
            InputOpenBoxNumFrm frm = new InputOpenBoxNumFrm();
            DialogResult result= frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                updateinputbox(frm.inputBox);
            }
        }

        private void updateinputbox(string box)
        {
           arrival_req.AdvancedShipNotice reqasn = new arrival_req.AdvancedShipNotice();

           reqasn.AdvancedShipNoticeHeader.StorerKey = this.detail.StorerKey;
           reqasn.AdvancedShipNoticeHeader.ReceiptKey = this.receiptKey.Text;
           reqasn.AdvancedShipNoticeHeader.PerformanceData15 = box;
           RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                enumMessageType.AdvancedShipNotice,
                enumRequestMethod.store, this.loginuser,
                enumSendSysId.EXceed,
                reqasn);
           //RequestWorkItem workitem = new RequestWorkItem(request, 2);
           //threadhelper.AddWorkItem(workitem);
           ResponseMessage response = ThreadHelper.Execute(request);
           arrivalres = response.Deserialize<arrival_res.AdvancedShipNotice>();
           string errormsg = response.GetErrorMessage();
           if (errormsg != string.Empty)
           {
               MessageBox.Show(response.GetErrorMessage());
           }
           else
           {
               MessageBox.Show("已更新开箱数", "提示");
               
           }
        }

        private void RFPqcFrm_Load(object sender, EventArgs e)
        {

        }

      
    }
}