using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common.ASN;
using RFDeviceAPP.Proxy;
using RFDeviceAPP.Common;

namespace RFDeviceAPP
{
    public partial class ReceiptFrm : RFDeviceAPP.baseForm
    {
        private string receiptKey;

        public string ReceiptKey
        {
            get { return receiptKey; }
            set { receiptKey = value; }
        }
        private UserInfo loginuser;

        private AdvancedShipNotice asnData;
        private AdvancedShipNoticeDetail currentDetail;

        private ThreadHelper threadhelper;
        public ReceiptFrm()
        {
            InitializeComponent();
            threadhelper = new ThreadHelper();
            threadhelper.AllWorkItemCompleted += new EventHandler(threadhelper_AllWorkItemCompleted);
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
        }
        public ReceiptFrm(UserInfo loginuser):this()
        {
            this.userStatusControl1.LoginUser = loginuser;
            this.loginuser = loginuser;
        }

        private void ReceiptFrm_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(receiptKey) )
            {
                this.receiptkeytxt.Text = this.receiptKey;
                this.LoadAsnData(this.receiptKey);
            }
        }
        private void LoadAsnData(string receiptkey)
        {
            this.Start();
            this.EnableControl(this.Controls,false);
            RequestMessage searchrequest = new RequestMessage(enumRequestType.MessageProcessor,
                enumMessageType.AdvancedShipNotice, 
                enumRequestMethod.list, this.loginuser, 
                enumSendSysId.EXceed, 
                AdvancedShipNotice.CreateSearchByKey(this.receiptKey));
            RequestWorkItem workitem = new RequestWorkItem(searchrequest,1);
            threadhelper.AddWorkItem(workitem);

        }
        private void LoadAsnData(string receiptkey,string linenum)
        {
            this.Start();
            this.EnableControl(this.Controls, false);
            RequestMessage searchrequest = new RequestMessage(enumRequestType.MessageProcessor,
                enumMessageType.AdvancedShipNotice,
                enumRequestMethod.list, this.loginuser,
                enumSendSysId.EXceed,
                AdvancedShipNotice.CreateSearchByLineNum(this.receiptKey,linenum));
            RequestWorkItem workitem = new RequestWorkItem(searchrequest, 1);
            threadhelper.AddWorkItem(workitem);

        }

        private void DataBinding(AdvancedShipNoticeDetail detail)
        {
            decimal expqty = Convert.ToDecimal(detail.QtyExpected);
            decimal recqty = Convert.ToDecimal(detail.QtyReceived);
            decimal rejqty = Convert.ToDecimal(detail.QtyRejected);

            string detailmsg = string.Format("预收:{0}已收:{1}", expqty, recqty);

            InvokeHelper.Set(this.asnlinedetaillabel, "Text", detailmsg);
            InvokeHelper.Set(this.skudetaillabel, "Text", "");
            InvokeHelper.Set(this.packkeytxt, "Text", detail.PackKey);
            if (recqty > 0)
            {
                this.skutxt.Text = detail.Sku;
                this.qtyreceivedtxt.Text = detail.QtyReceived;
                this.toloctxt.Text = detail.ToLoc;
                this.toidtxt.Text = detail.ToId;
            }
            else
            {
                this.skutxt.Text = string.Empty;
                this.qtyreceivedtxt.Text = string.Empty;
                this.toloctxt.Text = string.Empty;
                this.toidtxt.Text = string.Empty;
            }

        }

        void threadhelper_WorkItemCompleted(object sender, WorkItemEventArgs e)
        {
            InvokeHelper.Invoke(this, "EnableControl", this.Controls, true);
            int tag = e.WorkItem.Tag;
            WorkItem item = e.WorkItem;
            if (item.Response.GetErrorMessage() != string.Empty)
            {
                MessageBox.Show(item.Response.GetErrorMessage());
                return;
            }
            if (tag == 1)
            {

                this.asnData = item.Response.Deserialize<AdvancedShipNotice>();

                InvokeHelper.Set(this.linenumtxt, "Text", "");
                InvokeHelper.Set(this.skutxt, "Text", "");
                InvokeHelper.Set(this.qtyreceivedtxt, "Text", "");
                InvokeHelper.Set(this.toidtxt, "Text", "");
                InvokeHelper.Set(this.toloctxt, "Text", "");
                InvokeHelper.Set(this.packkeytxt, "Text", "");
                InvokeHelper.Set(this.asnlinedetaillabel, "Text", "");
                InvokeHelper.Set(this.skudetaillabel, "Text", "");

                if (this.asnData.AdvancedShipNoticeHeader.ReceiptKey == string.Empty)
                {
                    MessageBox.Show("没有找到收货单数据");
                    InvokeHelper.Invoke(this.receiptkeytxt, "Focus", null);
                    InvokeHelper.Set(this.asndetaillabel, "Text", string.Format("{1}/{0}", 0, 0));
                }
                else
                {
                    InvokeHelper.Set(this.asndetaillabel, "Text", string.Format("{1}/{0}", this.asnData.AdvancedShipNoticeHeader.OpenQty, this.getasnrecqtybysku("")));
                    InvokeHelper.Invoke(this.linenumtxt, "Focus", null);
                }
                //this.DataBinding();
                //this.statelabel.Text = this.asnData.AdvancedShipNoticeHeader.Status;
                
            }
            else
            {
                //this.receiptkeytxt.Text = "";
                MessageBox.Show("收货成功");
                InvokeHelper.Invoke(this.linenumtxt, "Focus", null);
                InvokeHelper.Set(this.linenumtxt, "Text", "");
                InvokeHelper.Set(this.skutxt, "Text", "");
                InvokeHelper.Set(this.qtyreceivedtxt, "Text", "");
                InvokeHelper.Set(this.toidtxt, "Text", "");
                InvokeHelper.Set(this.toloctxt, "Text", "");
                InvokeHelper.Set(this.packkeytxt, "Text", "");
                InvokeHelper.Set(this.asnlinedetaillabel, "Text", "");
                InvokeHelper.Set(this.skudetaillabel, "Text", "");
                InvokeHelper.Set(this.asndetaillabel, "Text", string.Format("{1}/{0}", this.asnData.AdvancedShipNoticeHeader.OpenQty, this.getasnrecqtybysku("")));



            }
        }

        private decimal getasnrecqtybysku(string sku)
        {
            decimal totalqty = 0;
            foreach (AdvancedShipNoticeDetail item in this.asnData.AdvancedShipNoticeHeader.AdvancedShipNoticeDetail)
            {
                if (string.IsNullOrEmpty(sku))
                {
                    decimal qty = Convert.ToDecimal(item.QtyReceived);
                    totalqty += qty;
                }
                else
                {
                    if (item.Sku == sku)
                    {
                        decimal qty = Convert.ToDecimal(item.QtyReceived);
                        totalqty += qty;
                    }
                }
            }
            return totalqty;
        }
        private decimal getasnexpqtybysku(string sku)
        {
            decimal totalqty = 0;
            foreach (AdvancedShipNoticeDetail item in this.asnData.AdvancedShipNoticeHeader.AdvancedShipNoticeDetail)
            {
                if (string.IsNullOrEmpty(sku))
                {
                    decimal qty = Convert.ToDecimal(item.QtyExpected);
                    totalqty += qty;
                }
                else
                {
                    if (item.Sku == sku)
                    {
                        decimal qty = Convert.ToDecimal(item.QtyExpected);
                        totalqty += qty;
                    }
                }
            }
            return totalqty;
        }

        void threadhelper_AllWorkItemCompleted(object sender, EventArgs e)
        {
           this.Stop();
           //InvokeHelper.Invoke(this, "EnableControl", this.Controls, true);
           //this.EnableControl(this.Controls,true);
        }

        private void receiptkeytxt_LostFocus(object sender, EventArgs e)
        {
            if (   receiptkeytxt.Text.Length == 10)
            {
                this.receiptKey = this.receiptkeytxt.Text;
                if (this.asnData == null || this.receiptKey != this.asnData.AdvancedShipNoticeHeader.ReceiptKey)
                {
                    this.LoadAsnData(this.receiptkeytxt.Text);
                }

            }
            else if (receiptkeytxt.Text.Length > 0)
            {
                MessageBox.Show("输入的ASN号有误");
                this.receiptkeytxt.Focus();
            }
        }

        private void linenumtxt_LostFocus(object sender, EventArgs e)
        {
            if (this.linenumtxt.Text.Length > 0 && this.linenumtxt.Text.Length!=5)
            {
                MessageBox.Show("输入的行号无效");
                this.linenumtxt.Focus();
                this.linenumtxt.SelectAll();
                return;
            }
            if (this.asnData != null && this.linenumtxt.Text.Length ==5)
            {
                this.LoadAsnData(this.receiptkeytxt.Text, this.linenumtxt.Text);
                AdvancedShipNoticeDetail detail = GetByLinenum(this.linenumtxt.Text);
                if (detail != null)
                {
                    DataBinding(detail);
                }
                else
                {
                    MessageBox.Show("ASN没有该行,请重新输入");
                    this.linenumtxt.Focus();
                    this.linenumtxt.SelectAll();
                }
            }
            
        }

        private AdvancedShipNoticeDetail GetByLinenum(string linenum)
        {
            foreach (AdvancedShipNoticeDetail item in this.asnData.AdvancedShipNoticeHeader.AdvancedShipNoticeDetail)
            {
                if (item.ReceiptLineNumber == linenum)
                {
                    this.currentDetail = item;
                    return item;
                }
            }
            this.currentDetail = null;
            return null;
        }

        private void skutxt_LostFocus(object sender, EventArgs e)
        {
            if (skutxt.Text.Length>0 && skutxt.Text != this.currentDetail.Sku)
            {
                MessageBox.Show(string.Format("正确的SKU为{0}",this.currentDetail.Sku));
                this.skutxt.Focus();
                this.skutxt.SelectAll();
            }
            else if (skutxt.Text.Length > 0)
            {
                decimal skuqty = this.getasnrecqtybysku(this.skutxt.Text);

                this.skudetaillabel.Text = string.Format("预收:{0}已收:{1}", this.currentDetail.QtyExpected, skuqty);
            }
        }
        private bool validate(out string message)
        {
            //string message = string.Empty;
            message = "";
            bool iserror = false;
            if (asnData == null)
            {
                message += "无法获取收货单数据";
            }
            if (currentDetail == null)
            {
                message += "无法获取收货单明细数据";
            }
            if (this.receiptkeytxt.Text.Trim() == string.Empty || this.receiptkeytxt.Text.Trim().Length!=10)
            {
                message += "收货单号有误";
                
            }
            if(this.linenumtxt.Text.Trim()==string.Empty || this.linenumtxt.Text.Trim().Length!=5){
                message += "行号有误";
            }
            if (this.skutxt.Text.Trim() == string.Empty || this.skutxt.Text!=currentDetail.Sku)
            {
                message += "sku有误";
            }
            if (this.qtyreceivedtxt.Text.Trim() == string.Empty)
            {
                message += "收货数量不能为空";
            }
            if (this.qtyreceivedtxt.Text.Trim().Length> 0)
            {
                decimal qty = Convert.ToDecimal(this.qtyreceivedtxt.Text);
                if (qty > Convert.ToDecimal(currentDetail.QtyExpected))
                {
                    message += "收货数量不能超过预收数量";
                }
            }
            if(message!=string.Empty)
                iserror=true;

            return iserror;
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            if (this.validate(out message))
            {
                MessageBox.Show(message);
                this.receiptkeytxt.Focus();
                return;
            }

            this.SetValues();

            this.Start();
            RequestMessage searchrequest = new RequestMessage(enumRequestType.MessageProcessor,
                enumMessageType.AdvancedShipNotice,
                enumRequestMethod.store, this.loginuser,
                enumSendSysId.EXceed,
                this.asnData);
            RequestWorkItem workitem = new RequestWorkItem(searchrequest, 2);
          
            threadhelper.AddWorkItem(workitem);


        }
        private void SetValues()
        {
            this.currentDetail.QtyReceived = this.qtyreceivedtxt.Text;
            this.currentDetail.PackKey = this.packkeytxt.Text;
            this.currentDetail.Sku = this.skutxt.Text;
            this.currentDetail.ToId = this.toidtxt.Text;
            this.currentDetail.ToLoc = this.toloctxt.Text;

        }

        private void receiptkeytxt_TextChanged(object sender, EventArgs e)
        {

        }

        


    }
}

