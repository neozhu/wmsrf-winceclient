using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dm01_req = RFDeviceAPP.Common.DM01.Request;
using dm01_res = RFDeviceAPP.Common.DM01.Response;
using dm02_req = RFDeviceAPP.Common.DM02.Request;
using asnlist01_res = RFDeviceAPP.Common.asnlist01.Response;
using asnlist01_req = RFDeviceAPP.Common.asnlist01.Request;
using RFDeviceAPP.Proxy;
using RFDeviceAPP.Common;
namespace RFDeviceAPP
{
    public partial class LeaveFrm : baseForm
    {
        private UserInfo loginuser;
        private dm01_req.DoorsManagement dmreq;
        private dm01_res.DoorsManagement dmres;
        private dm02_req.DoorsManagement dmreq02;
        private asnlist01_res.AdvancedShipNotice asnlist01res;
        private asnlist01_req.AdvancedShipNotice asnlist01req;
        private ThreadHelper threadhelper;

        private Control focusControl;
        public LeaveFrm(UserInfo userinfo)
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
                    dmres = e.WorkItem.Response.Deserialize<dm01_res.DoorsManagement>();
                    string str = string.Format("{0} {1}", dmres.DoorsManagementHeader[0].DOORSKEY, dmres.DoorsManagementHeader[0].PLATENUMBER);
                    if (str.Length > 10)
                    {
                        //InvokeHelper.Invoke(this, "addportlist", str);
                        dm01_res.DoorsManagementHeader hd = dmres.DoorsManagementHeader[0];
                        dmreq02 = new dm02_req.DoorsManagement();
                        dmreq02.DoorsManagementHeader.AddWho = hd.AddWho;
                        dmreq02.DoorsManagementHeader.DoorsKey = hd.DOORSKEY;
                        dmreq02.DoorsManagementHeader.DriverCompany = hd.DRIVERCOMPANY;
                        dmreq02.DoorsManagementHeader.DriverName = hd.DriverName;
                        dmreq02.DoorsManagementHeader.DriverPhone = hd.DRIVERPHONE;
                        dmreq02.DoorsManagementHeader.EditWho = hd.EditWho;
                        dmreq02.DoorsManagementHeader.IOGoods = hd.IOGOODS;
                        dmreq02.DoorsManagementHeader.ParkNum = hd.PARKNUM;
                        dmreq02.DoorsManagementHeader.PlateNumber = hd.PLATENUMBER;
                        dmreq02.DoorsManagementHeader.SerialKey = hd.SerialKey;
                        dmreq02.DoorsManagementHeader.Status = hd.Status;
                        dmreq02.DoorsManagementHeader.WhseId = hd.WhseId;
                        foreach (dm01_res.DoorsManagementDetail detail in hd.DoorsManagementDetail)
                        {
                            if (detail.Status == "0")
                            {
                                dm02_req.DoorsManagementDetail newitem = new dm02_req.DoorsManagementDetail();
                                newitem.ParkNum = detail.PARKNUM;
                                newitem.DoorsKey = detail.DOORSKEY;
                                newitem.DoorsLineNumber = detail.DOORSLINENUMBER;
                                newitem.Pier = detail.PIER;
                                newitem.SerialKey = detail.SerialKey;
                                this.portcodetxt.SetText(detail.PIER);
                                dmreq02.DoorsManagementHeader.DoorsManagementDetail.Add(newitem);
                                InvokeHelper.Invoke(this, "call_asnlist01", detail.PIER);
                                break;

                            }
                        }
                    }
                    else
                    {
                        dmres = null;
                        MessageBox.Show("没有找到改车的进门记录", "提示");
                        this.parknumtxt.SetFocus();
                    }
                }
                if (tag == 2)
                {

                    asnlist01res = e.WorkItem.Response.Deserialize<asnlist01_res.AdvancedShipNotice>();
                    foreach (asnlist01_res.AdvancedShipNoticeHeader body in asnlist01res.AdvancedShipNoticeHeaders)
                    {
                        InvokeHelper.Invoke(this, "addasnlist", body.ReceiptKey + " " + body.StorerKey + " " + body.Status);
                    }
                }
                if (tag == 3)
                {
                    asnlist01res = e.WorkItem.Response.Deserialize<asnlist01_res.AdvancedShipNotice>();
                    
                        //this.storerkeytxt.SetText(asnlist01res.AdvancedShipNoticeHeaders[0].StorerKey);
                  

                    //foreach (asnlist01_res.AdvancedShipNoticeHeader body in asnlist01res.AdvancedShipNoticeHeaders)
                    //    InvokeHelper.Invoke(this, "addportlist", body.ReceiptKey + " " + body.StorerKey);
                }
                if (tag == 4)
                {
                    MessageBox.Show("车辆已离开码头", "提示");
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
        private void submitbtn_Click(object sender, EventArgs e)
        {

            call_dm02();
        }
        private void clean()
        {
            this.parknumtxt.Clean();
            this.portlist.Clean();
            this.portcodetxt.Clean();
            this.asnlist.Items.Clear();
        }
        public void addasnlist(string line)
        {
            this.asnlist.Items.Add(line);
        }
        

        private void LeaveFrm_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void parknumtxt_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.parknumtxt.Text))
            {
                if (this.dmres != null && this.dmres.DoorsManagementHeader[0].PARKNUM == this.parknumtxt.Text)
                    return;
                //this.portlist.Items.Clear();
                this.asnlist.Items.Clear();
                call_dm01(this.parknumtxt.Text);
            }
        }
        private void call_dm01(string platenumber)
        {
            //this.Start();
            dmreq = dm01_req.DoorsManagement.CreateByParkNum(platenumber);
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.DoorsManagement,
                  enumRequestMethod.list, this.loginuser,
                  enumSendSysId.EXceed,
                  dmreq);
            //RequestWorkItem workitem = new RequestWorkItem(request, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(request);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(Response.GetErrorMessage());
            }
            else
            {
                dmres = Response.Deserialize<dm01_res.DoorsManagement>();
                string str = string.Format("{0} {1}", dmres.DoorsManagementHeader[0].DOORSKEY, dmres.DoorsManagementHeader[0].PLATENUMBER);
                if (str.Length > 10)
                {
                    //InvokeHelper.Invoke(this, "addportlist", str);
                    this.portlist.Text = str;
                    dm01_res.DoorsManagementHeader hd = dmres.DoorsManagementHeader[0];
                    dmreq02 = new dm02_req.DoorsManagement();
                    dmreq02.DoorsManagementHeader.AddWho = hd.AddWho;
                    dmreq02.DoorsManagementHeader.DoorsKey = hd.DOORSKEY;
                    dmreq02.DoorsManagementHeader.DriverCompany = hd.DRIVERCOMPANY;
                    dmreq02.DoorsManagementHeader.DriverName = hd.DriverName;
                    dmreq02.DoorsManagementHeader.DriverPhone = hd.DRIVERPHONE;
                    dmreq02.DoorsManagementHeader.EditWho = hd.EditWho;
                    dmreq02.DoorsManagementHeader.IOGoods = hd.IOGOODS;
                    dmreq02.DoorsManagementHeader.ParkNum = hd.PARKNUM;
                    dmreq02.DoorsManagementHeader.PlateNumber = hd.PLATENUMBER;
                    dmreq02.DoorsManagementHeader.SerialKey = hd.SerialKey;
                    dmreq02.DoorsManagementHeader.Status = hd.Status;
                    dmreq02.DoorsManagementHeader.WhseId = hd.WhseId;
                    if (hd.IOGOODS == "1")
                    {
                        this.chkio.Checked = true;
                    }
                    else
                    {
                        this.chkio.Checked = false;
                        int count=hd.DoorsManagementDetail.Count;
                        this.portcodetxt.SetText(hd.DoorsManagementDetail[count-1].PIER);
                        foreach (dm01_res.DoorsManagementDetail detail in hd.DoorsManagementDetail)
                        {
                            if (detail.Status == "0")
                            {
                                dm02_req.DoorsManagementDetail newitem = new dm02_req.DoorsManagementDetail();
                                newitem.ParkNum = detail.PARKNUM;
                                newitem.DoorsKey = detail.DOORSKEY;
                                newitem.DoorsLineNumber = detail.DOORSLINENUMBER;
                                newitem.Pier = detail.PIER;
                                newitem.SerialKey = detail.SerialKey;
                                //this.portcodetxt.SetText(detail.PIER);
                                dmreq02.DoorsManagementHeader.DoorsManagementDetail.Add(newitem);
                                //InvokeHelper.Invoke(this, "call_asnlist01", detail.PIER);
                                this.call_asnlist01(detail.PIER);
                                break;

                            }
                        }
                    }

                    
                }
                else
                {
                    dmres = null;
                    MessageBox.Show("没有找到该车的进门记录", "提示");
                    this.parknumtxt.SetFocus();
                }

            }
        }
        public void call_asnlist01(string pier)
        {
            //this.Start();
            //this.portlist.Items.Clear();
            //this.portlist.Enabled = false;
            asnlist01req = asnlist01_req.AdvancedShipNotice.Create(pier);

            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.AdvancedShipNotice,
                  enumRequestMethod.listHead, this.loginuser,
                  enumSendSysId.EXceed,
                  asnlist01req);
            //RequestWorkItem workitem = new RequestWorkItem(request, 2);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(request);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(Response.GetErrorMessage());
            }
            else
            {
                asnlist01res = Response.Deserialize<asnlist01_res.AdvancedShipNotice>();
                foreach (asnlist01_res.AdvancedShipNoticeHeader body in asnlist01res.AdvancedShipNoticeHeaders)
                {
                    if (!string.IsNullOrEmpty(body.ReceiptKey))
                    {
                        this.addasnlist(body.ReceiptKey + " " + body.StorerKey + " " + body.Status);
                    }
                    //InvokeHelper.Invoke(this, "addasnlist", body.ReceiptKey + " " + body.StorerKey + " " + body.Status);
                }
            }

        }
        private void call_dm02()
        {
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            //dmreq02.DoorsManagementHeader.Status = "1";
            dm02_req.DoorsManagementDetail item = new dm02_req.DoorsManagementDetail();
            item.DoorsKey = dmreq02.DoorsManagementHeader.DoorsKey;
            item.ParkNum = dmreq02.DoorsManagementHeader.ParkNum;
            item.Pier = this.portcodetxt.Text;
            item.AddWho = this.loginuser.UserName;
            item.Status = "1";
            dmreq02.DoorsManagementHeader.DoorsManagementDetail.Clear();
            dmreq02.DoorsManagementHeader.DoorsManagementDetail.Add(item);

            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.DoorsManagement,
                  enumRequestMethod.store, this.loginuser,
                  enumSendSysId.EXceed,
                  dmreq02);
            //RequestWorkItem workitem = new RequestWorkItem(request, 4);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(request);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(Response.GetErrorMessage());
            }
            else
            {
                if (chkio.Checked)
                {
                    MessageBox.Show("车离开码头");
                }
                else
                {
                    
                    MessageBox.Show("车离开码头");
                }

                clean();
                this.parknumtxt.SetFocus();
            }
            ////if (dmreq02.DoorsManagementHeader.DoorsManagementDetail.Count > 0)
            //{
            //    this.Start();
            //    dmreq02.DoorsManagementHeader.DoorsManagementDetail[0].Status = "1";

            //    RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
            //          enumMessageType.DoorsManagement,
            //          enumRequestMethod.store, this.loginuser,
            //          enumSendSysId.EXceed,
            //          dmreq02);
            //    RequestWorkItem workitem = new RequestWorkItem(request, 4);
            //    threadhelper.AddWorkItem(workitem);
            //}
        }

        public string Vaildate( )
        {
            string errortxt = string.Empty;
             
            if (this.portcodetxt.Text.Length == 0)
            {
                focusControl = this.portcodetxt;
                errortxt += "码头编号必填";
            }

            if (this.parknumtxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.parknumtxt;
                errortxt += "停车证编号必填";

            }


            return errortxt;
        }

        private void chkio_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.chkio.Checked)
            {
                this.asnlist.Enabled = false;
            }
            else
            {
                this.asnlist.Enabled = true;
            }
        }

    }
}