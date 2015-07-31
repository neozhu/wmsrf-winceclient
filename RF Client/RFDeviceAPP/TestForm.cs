using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using RFDeviceAPP.Common;

namespace RFDeviceAPP
{
    public partial class TestForm : Form
    {
        public TestForm(UserInfo loginuser)
        {
            
            InitializeComponent();
            this.userStatusControl1.SetUser(loginuser);
        }


        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void rfButtonCommand1_Click(object sender, EventArgs e)
        {
            this.userStatusControl1.Start();
            Proxy.ThreadHelper thread = new RFDeviceAPP.Proxy.ThreadHelper();
            string asnno = this.asntxt.Text;
            Common.ASN.AdvancedShipNotice asn = new RFDeviceAPP.Common.ASN.AdvancedShipNotice();
            Common.ASN.AdvancedShipNoticeHeader asnhead=new RFDeviceAPP.Common.ASN.AdvancedShipNoticeHeader();
            asnhead.ReceiptKey = asnno;
            asn.AdvancedShipNoticeHeader = asnhead;
            //Proxy.RequestGenerator<Entities.ASN.AdvancedShipNotice> requestgenerator = new RFDeviceAPP.Proxy.RequestGenerator<RFDeviceAPP.Entities.ASN.AdvancedShipNotice>("AdvancedShipNotice", "neo_zhu", "neo_zhu", "EXceed", "FEILI_wmwhse1", asn);

            Proxy.RequestWorkItem request = new RFDeviceAPP.Proxy.RequestWorkItem();
            Proxy.RequestMessage requestmsg=new RFDeviceAPP.Proxy.RequestMessage(RFDeviceAPP.Proxy.enumRequestType.MessageProcessor, RFDeviceAPP.Proxy.enumMessageType.AdvancedShipNotice, RFDeviceAPP.Proxy.enumRequestMethod.list,this.userStatusControl1.LoginUser, RFDeviceAPP.Proxy.enumSendSysId.EXceed,asn);
            //requestmsg.RequestType=Proxy.enumRequestType.MessageProcessor;
            //requestmsg.RequestCategory=Proxy.enumRequestCategory.AdvancedShipNotice;
            //requestmsg.RequestMethod=Proxy.enumRequestMethod.list;
            //requestmsg.XmlString=requestgenerator.CreateNativeMessage();
            request.Request = requestmsg;


            thread.AllWorkItemCompleted += new EventHandler(thread_AllWorkItemCompleted);
            thread.WorkItemCompleted += new EventHandler<RFDeviceAPP.Proxy.WorkItemEventArgs>(thread_WorkItemCompleted);
            thread.AddWorkItem(request);
        }

       
        private void doaction()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int l = 0; l < 10; l++)
                {
                    this.userStatusControl1.UpdateProcess(l);
                    System.Threading.Thread.Sleep(100);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.userStatusControl1.Start();
            Proxy.MyWorkItem item1 = new RFDeviceAPP.Proxy.MyWorkItem(1);
            Proxy.MyWorkItem item2 = new RFDeviceAPP.Proxy.MyWorkItem(2);

            Proxy.ThreadHelper thread = new RFDeviceAPP.Proxy.ThreadHelper();
            thread.AllWorkItemCompleted += new EventHandler(thread_AllWorkItemCompleted);
            thread.WorkItemCompleted += new EventHandler<RFDeviceAPP.Proxy.WorkItemEventArgs>(thread_WorkItemCompleted);
            thread.AddWorkItem(item1);
            thread.AddWorkItem(item2);

        }

        void thread_WorkItemCompleted(object sender, RFDeviceAPP.Proxy.WorkItemEventArgs e)
        {
            Console.WriteLine(e.WorkItem.Response);
            if (string.IsNullOrEmpty(e.WorkItem.Response.GetErrorMessage()))
            {
                Common.ASN.AdvancedShipNotice responseasn = e.WorkItem.Response.Deserialize<Common.ASN.AdvancedShipNotice>();
                Proxy.InvokeHelper.Set(this.asntxt, "Text", responseasn.AdvancedShipNoticeHeader.ReceiptKey);
                Proxy.InvokeHelper.Set(this.owntxt, "Text", responseasn.AdvancedShipNoticeHeader.ReceiptDate);
                Proxy.InvokeHelper.Set(this.recqtytxt, "Text", responseasn.AdvancedShipNoticeHeader.OpenQty);
                Proxy.InvokeHelper.Set(this.recedqty, "Text", calTotalQty(responseasn.AdvancedShipNoticeHeader.AdvancedShipNoticeDetail).ToString());
                //this.owntxt.Text = responseasn.AdvancedShipNoticeHeader.ReceiptDate;
                //this.recedqty.Text = responseasn.AdvancedShipNoticeHeader.OpenQty;

                BindingList<Common.ASN.AdvancedShipNoticeDetail> detail = new BindingList<RFDeviceAPP.Common.ASN.AdvancedShipNoticeDetail>(responseasn.AdvancedShipNoticeHeader.AdvancedShipNoticeDetail);
                //this.dataGrid1.DataSource = detail;
                Proxy.InvokeHelper.Set(this.dataGrid1, "DataSource", detail);
            }
            else
            {
                MessageBox.Show(e.WorkItem.Response.GetErrorMessage(),"错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }
        private decimal calTotalQty(List<Common.ASN.AdvancedShipNoticeDetail> list)
        {
            decimal result = 0;
            foreach (Common.ASN.AdvancedShipNoticeDetail item in list)
            {
                result += Convert.ToDecimal(item.QtyReceived);
            }
            return result;
        }

        void thread_AllWorkItemCompleted(object sender, EventArgs e)
        {
            this.userStatusControl1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rfFieldTextBox f1 = new rfFieldTextBox();
            f1.Dock = DockStyle.Top;
            this.panel1.Controls.Add(f1);
            this.panel1.Height += 41;
            this.Height += 41;
        }
    }
}