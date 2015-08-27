using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using RL021_req = RFDeviceAPP.Common.NSPRFRL021.Request;
using RL021_res = RFDeviceAPP.Common.NSPRFRL021.Response;
using RL02_req = RFDeviceAPP.Common.NSPRFRL02.Request;
using RL02_res = RFDeviceAPP.Common.NSPRFRL02.Response;
using RFDeviceAPP.Proxy;

namespace RFDeviceAPP
{
    public partial class RFRL021Frm : RFDeviceAPP.baseForm
    {
        private UserInfo loginuser;
        private ThreadHelper threadhelper;
        private Control focusControl;
        private RL021_req.Utility RL021req;
        private RL021_res.Utility RL021res;
        private RL02_req.Utility RL02req;
        private RL02_res.Utility RL02res;
        string _toloc1 = string.Empty;

        public RFRL021Frm(UserInfo loginuser)
            : base(loginuser)
        {
            InitializeComponent();
            this.loginuser = loginuser;
            threadhelper = new ThreadHelper();
            threadhelper.AllWorkItemCompleted += new EventHandler(threadhelper_AllWorkItemCompleted);
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
            threadhelper.WorkItemFailed += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemFailed);
            //pop_wu
            //this.totagtxt.Focus();
            this.movableunit.Focus();
            //pop_wu
        }
        #region threadhelper
        public void clear()
        {
            this.movableunit.Clean();
            this.movableunit.SetFocus();
            //this.totagtxt.SetFocus();
            this.sku.Clean();
            this.desc.Clean();
            this.fromloc.Clean();
            this.toloc.Clean();
            this.toloc1.Clean();
            this.totagtxt.Clean();
            this.totagtxtlist.Items.Clear();
            this.RL021res = null;
            this.RL02req = null;
        }
        void threadhelper_WorkItemCompleted(object sender, WorkItemEventArgs e)
        {
            int tag = e.WorkItem.Tag;
            WorkItem item = e.WorkItem;
            string errormsg = item.Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                this.RL021res = null;
                this.RL02req = null;
            }
            else
            {
                if (tag == 1)
                {
                    this.RL021res = item.Response.Deserialize<RL021_res.Utility>();
                    //this.sku.SetText(this.RL021res.UtilityHeader.Sku);
                    this.sku.SetText(this.RL021res.UtilityHeader.skusum);
                    this.fromloc.SetText(this.RL021res.UtilityHeader.FromLoc);
                    this.desc.SetText(this.RL021res.UtilityHeader.Descr);
                    this.toloc1.SetText(this.RL021res.UtilityHeader.ToLoc);
                    //DialogResult result = MessageBox.Show("拣货完成，是否获取新任务？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    //InvokeHelper.Invoke(this, "CloseWindow", result);
                }
                if (tag==2)
                {
                    this.RL02res = item.Response.Deserialize<RL02_res.Utility>();
                    if (this.RL02res.UtilityHeader.rectype == "2")
                    {
                        MessageBox.Show("订单集货完成", "提示");
                    }
                    else
                    {
                        MessageBox.Show("已集货", "提示");
                    }
                    this.clear();
                     
                }
                 
            }
        }
        void threadhelper_WorkItemFailed(object sender, WorkItemEventArgs e)
        {
            MessageBox.Show("Failed" + e.WorkItem.Ex.Message);
            this.fromloc.SetFocus();
        }
        void threadhelper_AllWorkItemCompleted(object sender, EventArgs e)
        {
            this.Stop();
        }

        
        #endregion

        #region call api
        public string Vaildate()
        {
            string errortxt = string.Empty;
            //if (this.movableunit.Text.Length == 0)
            //{
            //    focusControl = this.fromloc;
            //    errortxt += "LPN必填";
            //}
            if (this.totagtxtlist.Items.Count == 0)
            {
                focusControl = this.fromloc;
                errortxt += "LPN必填";
            }
            if (this.toloc.Text.Length == 0)
            {
                focusControl = this.toloc;
                errortxt += "至库位必填";
            }
            else
            {
                //if (this.toloc1.Text.Length > 0)
                //{
                //    if (this.toloc1.Text != this.toloc.Text)
                //    {
                //        focusControl = this.toloc;
                //        errortxt += "必须放至在"+this.toloc1.Text;
                //    }
                //}
            }
            //if (this.sku.Text.Length == 0)
            //{
            //    focusControl = this.sku;
            //    errortxt += "Sku必填";
            //}

            return errortxt;
        }

        public void NSPRFRL021(string  dropid,bool tag)
        {
            //this.Start();
            this.RL021req = RL021_req.Utility.Create(dropid);
            
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  this.RL021req);
            //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                if (tag == true)
                {
                    MessageBox.Show(errormsg);
                    this.RL021res = null;
                    this.RL02req = null;
                }
            }
            else
            {
                
                    this.RL021res = Response.Deserialize<RL021_res.Utility>();
                    this.sku.SetText(this.RL021res.UtilityHeader.Sku);
                    this.sku.SetText(this.RL021res.UtilityHeader.skusum);
                    this.fromloc.SetText(this.RL021res.UtilityHeader.FromLoc);
                    this.desc.SetText(this.RL021res.UtilityHeader.Descr);
                    //this.toloc1.SetText(this.RL021res.UtilityHeader.ToLoc);
                    if (tag)
                    {
                        //this.toloc1.SetText(this.RL021res.UtilityHeader.FromLoc);
                        this.toloc1.SetText(this.RL021res.UtilityHeader.ToLoc);
                        movableunitlist(this.movableunit.Text);
                        this.movableunit.Focus();
                    }
                    else
                    {
                        //movableunitlist(this.movableunit.Text);
                    }
                    //this.totagtxt.SetText(this.RL021res.UtilityHeader.totag);
                    //DialogResult result = MessageBox.Show("拣货完成，是否获取新任务？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    //InvokeHelper.Invoke(this, "CloseWindow", result);
                 
            }
        }
        public void NSPRFRL021_1()
        {
            //this.Start();
            this.RL021req = RL021_req.Utility.Create(this.movableunit.Text);

            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  this.RL021req);
            //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                this.RL021res = null;
                this.RL02req = null;
            }
            else
            {

                this.RL021res = Response.Deserialize<RL021_res.Utility>();
                //this.sku.SetText(this.RL021res.UtilityHeader.Sku);
                //this.sku.SetText(this.RL021res.UtilityHeader.skusum);
                //this.fromloc.SetText(this.RL021res.UtilityHeader.FromLoc);
                //this.desc.SetText(this.RL021res.UtilityHeader.Descr);
                this.toloc1.SetText(this.RL021res.UtilityHeader.ToLoc);
                //this.totagtxt.SetText(this.RL021res.UtilityHeader.totag);
                //DialogResult result = MessageBox.Show("拣货完成，是否获取新任务？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                //InvokeHelper.Invoke(this, "CloseWindow", result);

            }
        }
        public void NSPRFRL02()
        {
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            if (RL021res == null)
                return;
            //this.Start();
            //UserInfo admin = new UserInfo();
            //admin.Password = "sceadmin";
            //admin.UserName = "sceadmin";
            RL021_res.UtilityHeader header=RL021res.UtilityHeader;
            RL02req = new RFDeviceAPP.Common.NSPRFRL02.Request.Utility();
            RL02req.UtilityHeader.caseid = header.CaseID;
            RL02req.UtilityHeader.desc = header.Descr;
            RL02req.UtilityHeader.fromloc = header.FromLoc;
            RL02req.UtilityHeader.fromtag = header.fromtag;
            RL02req.UtilityHeader.lotnum = header.lotnum;
            //RL02req.UtilityHeader.MovableUnit = this.movableunit.Text;
            RL02req.UtilityHeader.sku = header.Sku;
            RL02req.UtilityHeader.storer = header.storer;

            RL02req.UtilityHeader.toqty = header.Qty;
            //RL02req.UtilityHeader.totag = header.totag;
            RL02req.UtilityHeader.totag = this.totagtxt.Text;
            RL02req.UtilityHeader.uom = header.UOM;
            RL02req.UtilityHeader.toloc = this.toloc.Text;
            //2015-8-17  wuziqing
            int n = this.totagtxtlist.Items.Count;
            if (n > 0)
            {
                string errormsg = string.Empty;
                for (int i = 0; i < n; i++)
                {
                    RL02req.UtilityHeader.MovableUnit = totagtxtlist.Items[i].ToString();
                    RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                      enumMessageType.Utility,
                      enumRequestMethod.functionOperation, this.loginuser,
                      enumSendSysId.EXceed,
                      this.RL02req);
                        //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 2);
                        //threadhelper.AddWorkItem(workitem);
                    //string ssxml = requestmessage.XmlString;
                    ResponseMessage Response = ThreadHelper.Execute(requestmessage);
                    string sxml = Response.XmlString;
                    errormsg = Response.GetErrorMessage();
                    this.RL02res = Response.Deserialize<RL02_res.Utility>();
                    _toloc1 = this.RL02res.UtilityHeader.allLoc.ToString();
                    
                }
                if (errormsg != string.Empty)
                {
                    MessageBox.Show(errormsg);
                    //this.RL021res = null;
                    //this.RL02req = null;
                }
                else
                {
                    if (this.RL02res.UtilityHeader.rectype == "2")
                    {
                        MessageBox.Show("订单集货完成" + _toloc1, "提示");
                    }
                    else
                    {
                        MessageBox.Show("已集货", "提示");
                    }
                    this.clear();
                }
            }

        }
        #endregion

        private void RFRL021Frm_Load(object sender, EventArgs e)
        {

        }

        private void movableunit_GotFocus(object sender, EventArgs e)
        {
           
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            NSPRFRL02();
        }

        private void movableunit_LostFocus(object sender, EventArgs e)
        {
            if (this.movableunit.Text.Length > 0)
            {
                NSPRFRL021(this.movableunit.Text, true);
                if (this.totagtxt.Text.Length < 0)
                {
                    this.totagtxt.Focus();
                }
                else
                {
                    this.movableunit.Focus();
                }
                this.movableunit.Text = string.Empty;
            }
        }

        private void totagtxt_LostFocus(object sender, EventArgs e)
        {
            if (this.totagtxt.Text.Length > 0)
            {
                NSPRFRL021(this.totagtxt.Text,false);
                //this.movableunit.Focus();
            }
        }

        public void movableunitlist(string movableunittext)
        {
            this.totagtxtlist.Items.Add(movableunittext);
            //this.movableunit.Focus();
        }

        private void totagtxtlist_OnDoubleClick(object sender, EventArgs e)
        {

            int n = this.totagtxtlist.Items.Count;
            if (totagtxtlist.SelectedItem != null && n > 0)
            {
                this.totagtxtlist.Items.Remove(totagtxtlist.SelectedItem);
            }
        }
    }
}

