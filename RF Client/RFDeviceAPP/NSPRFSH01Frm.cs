using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dm01_req = RFDeviceAPP.Common.DM01.Request;
using dm01_res = RFDeviceAPP.Common.DM01.Response;
using sh01_req=RFDeviceAPP.Common.NSPRFSH01.Request;
using RL02S_req = RFDeviceAPP.Common.NSPRFRL021SO.Request;
using RL02S_res = RFDeviceAPP.Common.NSPRFRL021SO.Response;

using RFDeviceAPP.Common;
using RFDeviceAPP.Proxy;
namespace RFDeviceAPP
{
    public partial class NSPRFSH01Frm : RFDeviceAPP.baseForm
    {
        private dm01_req.DoorsManagement dmreq;
        private dm01_res.DoorsManagement dmres;
        private RL02S_req.Utility RL02Sreq;
        private RL02S_res.Utility RL02Sres;
        private ThreadHelper threadhelper;
        private Control focusControl;
        private bool issumbit = false;
        public NSPRFSH01Frm(UserInfo userinfo)
            : base(userinfo)
        {
            InitializeComponent();
            this.KeyPreview = true;
             
            threadhelper = new ThreadHelper();

            threadhelper.AllWorkItemCompleted += new EventHandler(threadhelper_AllWorkItemCompleted);
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
            threadhelper.WorkItemFailed += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemFailed);
            this.parknumtxt.SetFocus();
        }
        #region thread
        void threadhelper_WorkItemCompleted(object sender, WorkItemEventArgs e)
        {
            int tag = e.WorkItem.Tag;
            WorkItem item = e.WorkItem;
            string errormsg = item.Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(item.Response.GetErrorMessage());
                this.submitbtn.SetEnabled(true);
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
                        this.toid.SetText(str);
                       
                    }
                    else
                    {
                        dmres = null;
                        MessageBox.Show("没有找到改车的进门记录", "提示");
                        this.parknumtxt.SetFocus();
                    }
                }
                if (tag == 3)
                {
                }
               
                
            }
        }
        void threadhelper_WorkItemFailed(object sender, WorkItemEventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show(e.WorkItem.Ex.Message);
            int tag = e.WorkItem.Tag;
            this.submitbtn.SetEnabled(true);
        }
        void threadhelper_AllWorkItemCompleted(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.Stop();
            this.submitbtn.SetEnabled(true);
            if (issumbit == true)
            {
                MessageBox.Show("装载完毕", "提示");
                this.parknumtxt.Clean();
                //this.storerkeytxt.Clean();
                //this.isselfchk.Checked = false;
                this.toid.Clean();
                this.fromid.Clean();
              
                InvokeHelper.Invoke(this, "cleanlist", null);
                issumbit = false;
            }
        }
        #endregion
        private void call_dm01(string platenumber)
        {
            this.Start();
            dmreq = dm01_req.DoorsManagement.CreateByParkNum(platenumber);
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.DoorsManagement,
                  enumRequestMethod.list, this.LoginUser,
                  enumSendSysId.EXceed,
                  dmreq);
            RequestWorkItem workitem = new RequestWorkItem(request, 1);
            threadhelper.AddWorkItem(workitem);
        }
        public void call_NSPRFSH01()
        {
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            //this.submitbtn.Enabled = false;
            this.issumbit = true;
            bool error = false;
            //this.Start();
            for (int i = 0; i < this.droplist.Items.Count; i++)
            {
                string[] tmp = this.toid.Text.Split(new char[] { ' ' });
                string toidstr = tmp[0];
                string fromidstr = (string)this.droplist.Items[i];
                sh01_req.Utility sh01req = sh01_req.Utility.Create(fromidstr, toidstr);
                sh01req.UtilityHeader.userid = this.LoginUser.UserName;
                RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                      enumMessageType.Utility,
                      enumRequestMethod.functionOperation, this.LoginUser,
                      enumSendSysId.EXceed,
                      sh01req);
                ResponseMessage Response = ThreadHelper.Execute(requestmessage);
                string errormsg = Response.GetErrorMessage();
                if (errormsg != string.Empty)
                {
                    MessageBox.Show(Response.GetErrorMessage());
                    error = true;
                    //this.submitbtn.SetEnabled(true);
                }
                else
                {
                }
                //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 2);
                //threadhelper.AddWorkItem(workitem);
            }
            if (!error)
            {
                MessageBox.Show("装载完毕", "提示");
                //this.parknumtxt.Clean();
                this.orderkey.Clean();
                //this.isselfchk.Checked = false;
                //this.toid.Clean();
                this.fromid.Clean();
                this.cleanlist();
            }

        }
        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.toid.Text.Length == 0)
            {
                focusControl = this.parknumtxt;
                errortxt += "停车证牌号必填";
            }
            if (this.droplist.Items.Count == 0)
            {
                focusControl = this.fromid;
                errortxt += "箱ID必须";
            }
            

            return errortxt;
        }
        public void cleanlist()
        {
            this.droplist.Items.Clear();
            this.orderlist.Items.Clear();
        }
        public void adddroplist(string line)
        {
            this.droplist.Items.Add(line);
            //this.portlist.SelectedIndex = 0;
        }
        private void parknumtxt_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.parknumtxt.Text))
            {
                if (this.dmres != null && this.dmres.DoorsManagementHeader[0].PARKNUM == this.parknumtxt.Text)
                    return;
                
                this.droplist.Items.Clear();
                call_dm01(this.parknumtxt.Text);
            }
        }

        public void submitbtn_Click(object sender, EventArgs e)
        {
            call_NSPRFSH01();
        }

        private void fromid_LostFocus(object sender, EventArgs e)
        {
            if (this.fromid.Text.Length > 0)
            {

                if (isExistIn(this.fromid.Text))
                {
                    this.adddroplist(fromid.Text);
                    this.fromid.Clean();
                    this.fromid.SetFocus();
                }
                else
                {
                    MessageBox.Show("该箱ID不存在");
                    this.fromid.SetFocus();
                }
            }
            
        }
        private bool isExistIn(string fromid)
        {
            bool exist = false;
            for (int i = 0; i < this.orderlist.Items.Count; i++)
            {
                string line = (string)this.orderlist.Items[i];
                if (line.IndexOf(fromid) > 0)
                {
                    exist = true;
                    this.orderlist.Items.RemoveAt(i);
                    break;
                }
            }

            return exist;
        }

        private void droplist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.droplist.SelectedItem!=null)
            this.droplist.Items.Remove(this.droplist.SelectedItem);
        }

        private void orderkey_LostFocus(object sender, EventArgs e)
        {
            if (this.orderkey.Text.Length > 0)
            {
                this.orderlist.Items.Clear();
                this.droplist.Items.Clear();
                this.fromid.Clean();
                call_NSPRFRL021SO();
            }

        }

        public void call_NSPRFRL021SO()
        {
            //this.Start();
            this.RL02Sreq = RL02S_req.Utility.Create(this.orderkey.Text);

            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.LoginUser,
                  enumSendSysId.EXceed,
                  this.RL02Sreq);
            //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage response = ThreadHelper.Execute(requestmessage);
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                this.RL02Sreq = null;
                this.RL02Sres = null;
            }
            else
            {

                this.RL02Sres = response.Deserialize<RL02S_res.Utility>();
                if (RL02Sres != null)
                {
                    foreach (RL02S_res.UtilityHeader header in RL02Sres.UtilityHeaders)
                    {
                        string itemstring = string.Format("{2} {0} {1}", header.DropID, header.Loc, header.OrderKey);
                        if (itemstring.Length > 5)
                        {
                            this.orderlist.Items.Add(itemstring);
                        }
                    }
                    this.fromid.SetFocus();
                }
            }
                

        }



       

         
    }
}

