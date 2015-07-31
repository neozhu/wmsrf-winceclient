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
    public partial class PQCFrm : RFDeviceAPP.baseForm
    {
        private UserInfo loginuser;
        private asnlist01_res.AdvancedShipNotice asnlist01res;
        private asnlist01_req.AdvancedShipNotice asnlist01req;
        private arrival_req.AdvancedShipNotice arrivalreq;
        private arrival_res.AdvancedShipNotice arrivalres;
        private ThreadHelper threadhelper;
        private Control focusControl;
        public PQCFrm(UserInfo userinfo)
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
            if (tag == 1)
            {
                asnlist01res = e.WorkItem.Response.Deserialize<asnlist01_res.AdvancedShipNotice>();
                if (asnlist01res != null)
                {
                    this.storerKey.SetText(asnlist01res.AdvancedShipNoticeHeaders[0].StorerKey);
                   
                    foreach(asnlist01_res.AdvancedShipNoticeDetail detail in asnlist01res.AdvancedShipNoticeHeaders[0].AdvancedShipNoticeDetail){
                        if (detail.PQCSTATUS.ToLower() != "c")
                        {
                            string itemstring = string.Format("{0} {1} {2}", detail.ReceiptLineNumber, detail.Sku, detail.QtyExpected);

                            InvokeHelper.Invoke(this, "addasnlist", itemstring);
                        }
                    }
                    if (asnlist01res.AdvancedShipNoticeHeaders[0].Status == "106")
                    {
                        InvokeHelper.Set(this.asnlist, "Enabled", true);
                        InvokeHelper.Invoke(this, "openRFPqcFrm", null);
                    }
                }

                //foreach (asnlist01_res.AdvancedShipNoticeHeader body in asnlist01res.AdvancedShipNoticeHeaders)
                //    InvokeHelper.Invoke(this, "addportlist", body.ReceiptKey + " " + body.StorerKey);
            }
            if (tag == 2)
            {
                arrivalres = e.WorkItem.Response.Deserialize<arrival_res.AdvancedShipNotice>();
                InvokeHelper.Set(this.asnlist, "Enabled", true);
                InvokeHelper.Invoke(this, "openRFPqcFrm",null        );
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
        public void addasnlist(string itemstring)
        {
            this.asnlist.Items.Add(itemstring);
            //this.portlist.SelectedIndex = 0;
        }

        private void call_asnlist01(string asn)
        {
            //this.Start();
            this.asnlist.Items.Clear();
            this.asnlist.Enabled = false;
            asnlist01req = asnlist01_req.AdvancedShipNotice.CreateByReceiptKeyPQC(asn);
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.AdvancedShipNotice,
                  enumRequestMethod.list, this.loginuser,
                  enumSendSysId.EXceed,
                  asnlist01req);
            //RequestWorkItem workitem = new RequestWorkItem(request, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(request);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(Response.GetErrorMessage());
                this.receiptKey.SetFocus();
            }
            else
            {
                asnlist01res =  Response.Deserialize<asnlist01_res.AdvancedShipNotice>();
                if (asnlist01res != null)
                {
                    this.storerKey.SetText(asnlist01res.AdvancedShipNoticeHeaders[0].StorerKey);

                    foreach (asnlist01_res.AdvancedShipNoticeDetail detail in asnlist01res.AdvancedShipNoticeHeaders[0].AdvancedShipNoticeDetail)
                    {
                        if (detail.PQCSTATUS.ToLower() != "c" && decimal.Parse(detail.QtyExpected)>0)
                        {
                            string itemstring = string.Format("{0} {1} {2}", detail.ReceiptLineNumber, detail.Sku, detail.QtyExpected);

                            //InvokeHelper.Invoke(this, "addasnlist", itemstring);
                            this.addasnlist(itemstring);
                        }
                    }
                    if (asnlist01res.AdvancedShipNoticeHeaders[0].Status == "106")
                    {
                        this.asnlist.Enabled = true;
                        this.openRFPqcFrm();
                        //InvokeHelper.Set(this.asnlist, "Enabled", true);
                        //InvokeHelper.Invoke(this, "openRFPqcFrm", null);
                    }
                }

                //foreach (asnlist01_res.AdvancedShipNoticeHeader body in asnlist01res.AdvancedShipNoticeHeaders)
                //    InvokeHelper.Invoke(this, "addportlist", body.ReceiptKey + " " + body.StorerKey);
            }
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
            
            foreach (asnlist01_res.AdvancedShipNoticeHeader body in asnlist01res.AdvancedShipNoticeHeaders)
            {
                arrivalreq = new arrival_req.AdvancedShipNotice();

                arrivalreq.AdvancedShipNoticeHeader.StorerKey = body.StorerKey;
                arrivalreq.AdvancedShipNoticeHeader.ReceiptKey = body.ReceiptKey;
                arrivalreq.AdvancedShipNoticeHeader.PqcStatus = "s";
                //foreach (asnlist01_res.AdvancedShipNoticeDetail detail in body.AdvancedShipNoticeDetail)
                //{
                //    arrival_req.AdvancedShipNoticeDetail detailitem = new arrival_req.AdvancedShipNoticeDetail();
                //    detailitem.ReceiptKey = detail.ReceiptKey;
                //    detailitem.ReceiptLineNumber = detail.ReceiptLineNumber;
                //    detailitem.PqcStatus = "n";
                //    detailitem.PqcPeopleNum = this.pqcpeoplenum.Text;
                //    arrivalreq.AdvancedShipNoticeHeader.AdvancedShipNoticeDetail.Add(detailitem);

                //}

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
                    this.receiptKey.SetFocus();
                }
                else
                {
                    //arrivalres = e.WorkItem.Response.Deserialize<arrival_res.AdvancedShipNotice>();
                    //InvokeHelper.Set(this.asnlist, "Enabled", true);
                    //InvokeHelper.Invoke(this, "openRFPqcFrm", null);
                    this.asnlist.Enabled = true;
                    this.openRFPqcFrm();
                }
            }

        }
        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.receiptKey.Text.Length == 0)
            {
                focusControl = this.receiptKey;
                errortxt += "ASN必填";
            }

            if (this.asnlist.Items.Count == 0)
            {
                focusControl = this.receiptKey;
                errortxt += "没有找到收货单表体";

            }
            if (this.pqcpeoplenum.Text.Length == 0)
            {
                focusControl = this.pqcpeoplenum;
                errortxt += "人数必填";

            }

            return errortxt;
        }

        private void asnlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.asnlist.SelectedItem != null)
            {
                string str = this.asnlist.SelectedItem.ToString();
                string[] arr = str.Split(new char[] { ' ' });
                string linenum = arr[0];
                asnlist01_res.AdvancedShipNoticeDetail seleted=null;
                foreach (asnlist01_res.AdvancedShipNoticeDetail detaill in this.asnlist01res.AdvancedShipNoticeHeaders[0].AdvancedShipNoticeDetail)
                {
                    if (linenum == detaill.ReceiptLineNumber)
                    {
                        seleted = detaill;
                        break;
                    }
                }
                RFPqcFrm frm = new RFPqcFrm(this.loginuser, seleted, this.pqcpeoplenum.Text, this.asnlist01res.AdvancedShipNoticeHeaders[0].AdvancedShipNoticeDetail);
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    linenum = frm.currlinenum;
                    if (!string.IsNullOrEmpty(linenum))
                    {
                        for (int i = 0; i < asnlist.Items.Count;i++ )
                        {
                            string l = (string)asnlist.Items[i];
                            if (l.ToString().IndexOf(linenum) >= 0)
                            {
                                this.asnlist.Items.Remove(asnlist.Items[i]);
                                break;
                            }
                        }
                    }
                    if (this.asnlist.Items.Count == 0)
                    {
                        this.inputopenbox();
                    }
                }
            }
        }
        public void openRFPqcFrm()
        {
            RFPqcFrm frm = new RFPqcFrm(this.loginuser, null, this.pqcpeoplenum.Text, this.asnlist01res.AdvancedShipNoticeHeaders[0].AdvancedShipNoticeDetail);
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
               string linenum = frm.currlinenum;
                if (!string.IsNullOrEmpty(linenum))
                {
                    for (int i = 0; i < asnlist.Items.Count; i++)
                    {
                        string l = (string)asnlist.Items[i];
                        if (l.ToString().IndexOf(linenum) >= 0)
                        {
                            this.asnlist.Items.Remove(asnlist.Items[i]);
                            break;
                        }
                    }
                }

                if (this.asnlist.Items.Count == 0)
                {
                    this.inputopenbox();
                }
            }
        }

        private void receiptKey_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.receiptKey.Text))
            {
                call_asnlist01(this.receiptKey.Text);
            }
        }

        private void submitbt1_Click(object sender, EventArgs e)
        {
            call_arrival01();
            
        }


        private void inputopenbox()
        {
            InputOpenBoxNumFrm frm = new InputOpenBoxNumFrm();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                updateinputbox(frm.inputBox);
            }
        }

        private void updateinputbox(string box)
        {
            arrival_req.AdvancedShipNotice reqasn = new arrival_req.AdvancedShipNotice();

            reqasn.AdvancedShipNoticeHeader.StorerKey = this.storerKey.Text;
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

       

        

        

       
    }
}

