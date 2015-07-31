using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RL02B_req = RFDeviceAPP.Common.NSPRFRL02BATCH.Request;
using RL02B_res = RFDeviceAPP.Common.NSPRFRL02BATCH.Response;
using RFDeviceAPP.Proxy;
using RFDeviceAPP.Common;
namespace RFDeviceAPP
{
    public partial class NSPRFRL02BATCHFrm : RFDeviceAPP.baseForm
    {

        private RL02B_req.Utility RL02Breq;
        private RL02B_res.Utility RL02Bres;
        private ThreadHelper threadhelper;
        private Control focusControl;
        public NSPRFRL02BATCHFrm(UserInfo userinfo)
            : base(userinfo)
        {
            InitializeComponent();
            this.fromloc.Focus();
            this.KeyPreview = true;
        
            threadhelper = new ThreadHelper();

            threadhelper.AllWorkItemCompleted += new EventHandler(threadhelper_AllWorkItemCompleted);
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
            threadhelper.WorkItemFailed += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemFailed);
        }

        #region threadhelper
        void threadhelper_WorkItemCompleted(object sender, WorkItemEventArgs e)
        {
            int tag = e.WorkItem.Tag;
            WorkItem item = e.WorkItem;
            string errormsg = item.Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                this.RL02Breq = null;
                this.RL02Bres = null;
            }
            else
            {
                if (tag == 1)
                {
                    this.RL02Bres = item.Response.Deserialize<RL02B_res.Utility>();
                    MessageBox.Show("上架完成", "提示");
                    //DialogResult result = MessageBox.Show("拣货完成，是否获取新任务？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    //InvokeHelper.Invoke(this, "CloseWindow", result);
                    InvokeHelper.Invoke(this, "clean", null);
                }
                 
            }
        }
        public void clean()
        {
            this.fromloc.Clean();
            this.droplist.Items.Clear();
            this.toloc.Clean();
        }
        void threadhelper_WorkItemFailed(object sender, WorkItemEventArgs e)
        {
            InvokeHelper.Set(this.submitbtn, "Enabled", true);
            MessageBox.Show("Failed" + e.WorkItem.Ex.Message);
            this.fromloc.SetFocus();
        }
        void threadhelper_AllWorkItemCompleted(object sender, EventArgs e)
        {
            InvokeHelper.Set(this.submitbtn, "Enabled", true);
            this.Stop();
        }

        
        #endregion
        #region call api
        public void call_NSPRFTPA02( )
        {
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            //this.Start();
            this.RL02Breq = RL02B_req.Utility.Create(this.fromloc.Text,this.toloc.Text);
            this.RL02Breq.UtilityHeader.userid = this.LoginUser.UserName;
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.LoginUser,
                  enumSendSysId.EXceed,
                  this.RL02Breq);
            //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                this.RL02Breq = null;
                this.RL02Bres = null;
            }
            else
            {
                
                    this.RL02Bres = Response.Deserialize<RL02B_res.Utility>();
                    MessageBox.Show("上架完成", "提示");
                    //DialogResult result = MessageBox.Show("拣货完成，是否获取新任务？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    //InvokeHelper.Invoke(this, "CloseWindow", result);
                    this.clean();
                    this.fromloc.SetFocus();
            }
            //this.submitbtn.Enabled = true;

        }
        #endregion 
        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.fromloc.Text.Length == 0)
            {
                focusControl = this.fromloc;
                errortxt += "自储位必填";
            }
            if (this.toloc.Text.Length == 0)
            {
                focusControl = this.toloc;
                errortxt += "至储位必填";
            }

            return errortxt;
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            //this.submitbtn.Enabled = false;
            call_NSPRFTPA02();
        }

        private void call_NSPRFRL021LOC(string loc)
        {
            this.droplist.Items.Clear();
             RFDeviceAPP.Common.NSPRFRL021LOC.Request.Utility request=RFDeviceAPP.Common.NSPRFRL021LOC.Request.Utility.Create(loc);
             RequestMessage reqmessage = new RequestMessage(enumRequestType.MessageProcessor,
                enumMessageType.Utility,
                enumRequestMethod.functionOperation, this.LoginUser,
                enumSendSysId.EXceed,
                request);

            ResponseMessage response = ThreadHelper.Execute(reqmessage);
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
            }
            else
            {
                RFDeviceAPP.Common.NSPRFRL021LOC.Response.Utility result = response.Deserialize<RFDeviceAPP.Common.NSPRFRL021LOC.Response.Utility>();
                foreach (RFDeviceAPP.Common.NSPRFRL021LOC.Response.UtilityHeader header in result.UtilityHeaders)
                {
                    if (header != null && header.DropID!=null && header.DropID != "")
                    {
                        this.droplist.Items.Add(header.DropID);
                    }
                }
                this.countlb.Text=string.Format("一共有{0}项",this.droplist.Items.Count);
                this.toloc.Text = result.UtilityHeaders[0].DEFAULTTOLOC;
            }
        }

        private void fromloc_LostFocus(object sender, EventArgs e)
        {
            if (this.fromloc.Text.Length > 0)
            {
                this.call_NSPRFRL021LOC(this.fromloc.Text);
            }
        }

        private void NSPRFRL02BATCHFrm_Load(object sender, EventArgs e)
        {
            this.fromloc.SetFocus();
        }

        private void submitbtn2_Click(object sender, EventArgs e)
        {
            if (this.dropid.Text.Length == 0)
            {
                MessageBox.Show("请输入箱ID");
                this.dropid.SetFocus();
                return;
            }
            else if (!this.isExist(this.dropid.Text))
            {
                MessageBox.Show("箱ID不存在");
                this.dropid.SetFocus();
                return;
            }
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }

            call_NSPRFRL021(this.dropid.Text);

        }
        private void call_NSPRFRL021(string dropid)
        {
            RFDeviceAPP.Common.NSPRFRL021.Request.Utility RL021req = RFDeviceAPP.Common.NSPRFRL021.Request.Utility.Create(dropid);

            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.LoginUser,
                  enumSendSysId.EXceed,
                  RL021req);
            //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 2+i);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                this.dropid.SetFocus();

            }
            else
            {
                RFDeviceAPP.Common.NSPRFRL021.Response.Utility R021res = Response.Deserialize<RFDeviceAPP.Common.NSPRFRL021.Response.Utility>();
                this.NSPRFRL02(dropid, R021res.UtilityHeader, 0, this.toloc.Text);
                
            }
           
        }

        public void NSPRFRL02(string movableunit, RFDeviceAPP.Common.NSPRFRL021.Response.UtilityHeader header, int tag, string to)
        {

            RFDeviceAPP.Common.NSPRFRL02.Request.Utility RL02req = new RFDeviceAPP.Common.NSPRFRL02.Request.Utility();
            RL02req.UtilityHeader.caseid = header.CaseID;
            RL02req.UtilityHeader.desc = header.Descr;
            RL02req.UtilityHeader.fromloc = header.FromLoc;
            RL02req.UtilityHeader.fromtag = header.fromtag;
            RL02req.UtilityHeader.lotnum = header.lotnum;
            RL02req.UtilityHeader.MovableUnit = movableunit;
            RL02req.UtilityHeader.sku = header.Sku;
            RL02req.UtilityHeader.storer = header.storer;
            RL02req.UtilityHeader.toloc = to;
            RL02req.UtilityHeader.toqty = header.Qty;
            RL02req.UtilityHeader.totag = header.totag;
            RL02req.UtilityHeader.uom = header.UOM;
            RL02req.UtilityHeader.userid = this.LoginUser.UserName;

            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.LoginUser,
                  enumSendSysId.EXceed,
                  RL02req);
            //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 100+tag);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                return;

            }
            else
            {
                this.dropid.Clean();
                this.dropid.SetFocus();
                MessageBox.Show(string.Format("{0}上架完成", movableunit));
                this.deleteitem(movableunit);
            }
        }

        private void deleteitem(string drid)
        {
            for (int i = 0; i < this.droplist.Items.Count; i++)
            {
                object item = this.droplist.Items[i];
                string line = (string)item;
                if (line.IndexOf(drid) >= 0)
                {
                    this.droplist.Items.Remove(item);
                    break;
                }
            }
        }
        private bool isExist(string drid)
        {
            foreach (object item in this.droplist.Items)
            {
                if (item.ToString().IndexOf(drid) >= 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}

