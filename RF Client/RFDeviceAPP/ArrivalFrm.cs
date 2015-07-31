using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using dm01_req = RFDeviceAPP.Common.DM01.Request;
using dm01_res = RFDeviceAPP.Common.DM01.Response;
using dm02_req = RFDeviceAPP.Common.DM02.Request;
using arrival_req = RFDeviceAPP.Common.Arrival01.Request;
using arrival_res = RFDeviceAPP.Common.Arrival01.Response;
using asnlist01_res = RFDeviceAPP.Common.asnlist01.Response;
using asnlist01_req = RFDeviceAPP.Common.asnlist01.Request;
using RFDeviceAPP.Proxy;
namespace RFDeviceAPP
{
    public partial class ArrivalFrm : RFDeviceAPP.baseForm
    {
        private UserInfo loginuser;
        private dm01_req.DoorsManagement dmreq;
        private dm01_res.DoorsManagement dmres;
        private dm02_req.DoorsManagement dmreq02;
        private arrival_req.AdvancedShipNotice arrivalreq;
        private arrival_res.AdvancedShipNotice arrivalres;
        private asnlist01_res.AdvancedShipNotice asnlist01res;
        private asnlist01_req.AdvancedShipNotice asnlist01req;
        private ThreadHelper threadhelper;
        private bool issumbit = false;
        private Control focusControl;
        public ArrivalFrm(UserInfo userinfo):base(userinfo)
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
                        InvokeHelper.Invoke(this, "addportlist", str);
                        dm01_res.DoorsManagementHeader hd=dmres.DoorsManagementHeader[0];
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
                    arrivalres = e.WorkItem.Response.Deserialize<arrival_res.AdvancedShipNotice>();
                  

                }
                if (tag == 3)
                {
                    asnlist01res = e.WorkItem.Response.Deserialize<asnlist01_res.AdvancedShipNotice>();
                    if (asnlist01res != null)
                    {
                        string str = string.Format("{0} {1}", asnlist01res.AdvancedShipNoticeHeaders[0].ReceiptKey, asnlist01res.AdvancedShipNoticeHeaders[0].StorerKey);
                        if (str.Length > 10)
                        {
                            InvokeHelper.Invoke(this, "addasnlist", str);
                            this.asntxt.SetText("");
                            this.asntxt.SetFocus();
                        }
                        else
                        {
                            asnlist01res = null;
                            MessageBox.Show("没有找到ASN", "提示");
                            this.asntxt.SetFocus();
                        }
                        //this.storerkeytxt.SetText(asnlist01res.AdvancedShipNoticeHeaders[0].StorerKey);
                    }

                    //foreach (asnlist01_res.AdvancedShipNoticeHeader body in asnlist01res.AdvancedShipNoticeHeaders)
                    //    InvokeHelper.Invoke(this, "addportlist", body.ReceiptKey + " " + body.StorerKey);
                }
                if (tag == 4)
                {
                    if (!this.chkio.Checked)
                    {
                        InvokeHelper.Invoke(this, "call_arrival01", null);
                    }
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
            if (issumbit == true)
            {
                MessageBox.Show("关联完毕", "提示");
                this.asntxt.Clean();
                //this.storerkeytxt.Clean();
                //this.isselfchk.Checked = false;
                this.portcodetxt.Clean();
                this.parknumtxt.Clean();
                this.asntxt.SetFocus();
                InvokeHelper.Invoke(this, "cleanlist", null);
                issumbit = false;
            }
        }
        public void cleanlist()
        {
            this.portlist.Items.Clear();
            this.asnlist.Items.Clear();
        }
        public void addportlist(string line)
        {
            this.portlist.Items.Add(line);
            //this.portlist.SelectedIndex = 0;
        }
        public void addasnlist(string line)
        {
            if (this.asnlist.Items.IndexOf(line) >= 0)
                return;
            this.asnlist.Items.Add(line);
            //this.portlist.SelectedIndex = 0;
        }
        private void parknumtxt_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.parknumtxt.Text))
            {
                if (this.dmres != null && this.dmres.DoorsManagementHeader[0].PARKNUM == this.parknumtxt.Text)
                    return;
                this.portlist.Items.Clear();
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
                dmres =  Response.Deserialize<dm01_res.DoorsManagement>();
                string str = string.Format("{0} {1}", dmres.DoorsManagementHeader[0].DOORSKEY, dmres.DoorsManagementHeader[0].PLATENUMBER);
                if (str.Length > 10)
                {
                    //InvokeHelper.Invoke(this, "addportlist", str);
                    this.addportlist(str);
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
                    }
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
        }
        private void call_dm02()
        {
            string errortxt = this.Vaildate(this.chkio.Checked);
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            //this.Start();
            if (dmreq02.DoorsManagementHeader.Status == "0" || dmreq02.DoorsManagementHeader.Status == "3")
            {
                dm02_req.DoorsManagementDetail item = new dm02_req.DoorsManagementDetail();
                item.DoorsKey = dmreq02.DoorsManagementHeader.DoorsKey;
                item.ParkNum = dmreq02.DoorsManagementHeader.ParkNum;
                item.Pier = this.portcodetxt.Text;
                item.AddWho = this.loginuser.UserName;
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
                        MessageBox.Show("车已到码头");
                    }
                    else
                    {
                        call_arrival01();
                        MessageBox.Show("车到码头关联完毕");
                        clean();
                    }
                }
            }
            else
            {
                call_arrival01();
                MessageBox.Show("车到码头关联完毕");
                clean();
            }

        }
        public void call_arrival01()
        {
            //string errortxt = this.Vaildate();
            //if (errortxt != string.Empty)
            //{
            //    MessageBox.Show(errortxt);
            //    this.focusControl.Focus();
            //    return;
            //}
            //this.Start();
            string[] strarr=this.portlist.Items[0].ToString().Split(new char[]{' '});

            string doorkey = strarr[0];
            foreach (string line in this.asnlist.Items)
            {
                string[] linearr=line.Split(new char[]{' '});

                arrivalreq = new arrival_req.AdvancedShipNotice();
                arrivalreq.AdvancedShipNoticeHeader.DoorsKey = doorkey;
                arrivalreq.AdvancedShipNoticeHeader.Pier = this.portcodetxt.Text;
                arrivalreq.AdvancedShipNoticeHeader.StorerKey = linearr[1]; // this.storerkeytxt.Text;
                arrivalreq.AdvancedShipNoticeHeader.ReceiptKey = linearr[0];
             
                if (this.isselfchk.Checked)
                {
                    arrivalreq.AdvancedShipNoticeHeader.PerformanceData24 = "1";
                }
                else
                {
                    arrivalreq.AdvancedShipNoticeHeader.PerformanceData24 = "0";
                }
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
                }
                else
                {
                }
            }

        }
        private void ArrivalFrm_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        private void clean()
        {
            this.parknumtxt.Clean();
            this.portlist.Items.Clear();
            this.asntxt.Clean();
            this.asnlist.Items.Clear();
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
            issumbit = true;
            call_dm02();
            //call_arrival01();
        }

        //private void portcodetxt_LostFocus(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(this.portcodetxt.Text))
        //    {
        //        this.portlist.Items.Clear();
        //        call_dm01(this.portcodetxt.Text);
        //    }
            
        //}
        public string Vaildate(bool chk)
        {
            string errortxt = string.Empty;
            if (this.portlist.Items.Count == 0)
            {
                focusControl = this.parknumtxt;
                errortxt += "没有找到停车证编号";
            }
            if (this.portcodetxt.Text.Length == 0)
            {
                focusControl = this.portcodetxt;
                errortxt += "码头编号必填";
            }
            if (!chk)
            {
                if (this.asnlist.Items.Count == 0)
                {
                    if (string.IsNullOrEmpty(errortxt))
                        focusControl = this.asntxt;
                    errortxt += "ASN必填";

                }
            }
            //if (this.storerkeytxt.Text.Length == 0)
            //{
            //    if (string.IsNullOrEmpty(errortxt))
            //        focusControl = this.storerkeytxt;
            //    errortxt += "货主必填";

            //}


            return errortxt;
        }

     

        private void asntxt_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.asntxt.Text))
                this.call_asnlist01(this.asntxt.Text);
        }
        private void call_asnlist01(string asn)
        {
            //this.Start();
            //this.asnlist.Items.Clear();
            this.asnlist.Enabled = false;
            asnlist01req = asnlist01_req.AdvancedShipNotice.CreateByReceiptKey(asn);
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.AdvancedShipNotice,
                  enumRequestMethod.listHead, this.loginuser,
                  enumSendSysId.EXceed,
                  asnlist01req);
            //RequestWorkItem workitem = new RequestWorkItem(request, 3);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(request);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(Response.GetErrorMessage());
                this.asntxt.SetFocus();
            }
            else
            {
                asnlist01res = Response.Deserialize<asnlist01_res.AdvancedShipNotice>();
                if (asnlist01res != null)
                {
                    string str = string.Format("{0} {1}", asnlist01res.AdvancedShipNoticeHeaders[0].ReceiptKey, asnlist01res.AdvancedShipNoticeHeaders[0].StorerKey);
                    if (str.Length > 10)
                    {
                        //InvokeHelper.Invoke(this, "addasnlist", str);
                        this.addasnlist(str);
                        this.asntxt.SetText("");
                        this.asntxt.SetFocus();
                    }
                    else
                    {
                        asnlist01res = null;
                        MessageBox.Show("没有找到ASN", "提示");
                        this.asntxt.SetFocus();
                    }
                    //this.storerkeytxt.SetText(asnlist01res.AdvancedShipNoticeHeaders[0].StorerKey);
                }
            }
        }

        private void chkio_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkio.Checked)
            {
                this.asntxt.Enabled = false;
                this.asnlist.Enabled = false;
                this.isselfchk.Enabled = false;
            }
            else
            {
                this.asntxt.Enabled = true;
                this.asnlist.Enabled = true;
                this.isselfchk.Enabled = true;
            }
        }

        

       

       

       
    }
}

