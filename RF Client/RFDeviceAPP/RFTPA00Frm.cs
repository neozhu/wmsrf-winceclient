using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using task_res = RFDeviceAPP.Common.NSPRFTM01.Response;
using RFDeviceAPP.Proxy;

using tpa00_req = RFDeviceAPP.Common.NSPRFTPA00.Request;
using tpa00_res = RFDeviceAPP.Common.NSPRFTPA00.Response;
using tpa01_req = RFDeviceAPP.Common.NSPRFTPA01.Request;
using tpa01_res = RFDeviceAPP.Common.NSPRFTPA01.Response;

using tpa02_req = RFDeviceAPP.Common.NSPRFTPA02.Request;
using tpa02_res = RFDeviceAPP.Common.NSPRFTPA02.Response;
namespace RFDeviceAPP
{
    public partial class RFTPA00Frm : RFDeviceAPP.baseForm
    {
        private task_res.Utility task_res1;
        private UserInfo loginuser;
        private ThreadHelper threadhelper;
        public bool IsGetTask;
        private Control focusControl;
        private string taskdetailkey;
        private string toloc;
        private Dictionary<string,string> packkeylist;
        private bool isclose = false;
        private int idx;
        private int callcount;
        private string packkey;
        private tpa00_req.Utility tpa00req;
        private tpa00_res.Utility tpa00res;
        private tpa01_req.Utility tpa01req;
        private tpa01_res.Utility tpa01res;
        private tpa02_req.Utility tpa02req;
        private tpa02_res.Utility tpa02res;
        public RFTPA00Frm(UserInfo loginuser, task_res.Utility task_res1)
            : base(loginuser)
        {
            InitializeComponent();
            this.task_res1 = task_res1;
            this.loginuser = loginuser;
            SetValue();
            threadhelper = new ThreadHelper();
            threadhelper.AllWorkItemCompleted += new EventHandler(threadhelper_AllWorkItemCompleted);
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
            threadhelper.WorkItemFailed += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemFailed);
            this.fromloc.Focus();
        }

        #region initdata
        public void SetValue()
        {
            this.fromloc.SetText(this.task_res1.UtilityHeader.FromLoc);
            this.fromid1.SetText(this.task_res1.UtilityHeader.FromId);
            taskdetailkey = this.task_res1.UtilityHeader.TaskDetailKey;
            
        }
        #endregion
        #region threadhelper
        void threadhelper_WorkItemCompleted(object sender, WorkItemEventArgs e)
        {
            int tag = e.WorkItem.Tag;
            WorkItem item = e.WorkItem;
            string errormsg = item.Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                this.Stop();
                MessageBox.Show(errormsg);
                this.tpa00res = null;
                this.tpa01res = null;
            }
            else
            {
                if (tag == 1)
                {
                    this.tpa00res = item.Response.Deserialize<tpa00_res.Utility>();
                    idx=0;
                    packkeylist = new Dictionary<string, string>();
                    foreach (tpa00_res.UtilityHeader header in this.tpa00res.UtilityHeaders)
                    {
                        if (header != null)
                        {
                            //Console.WriteLine(header.Qty);
                            InvokeHelper.Invoke(this, "call_NSPRFTPA01", header.TaskDetailKey, header.FromLoc, header.FromId, idx++);
                        }
                    }
                    //DialogResult result = MessageBox.Show("拣货完成，是否获取新任务？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    //InvokeHelper.Invoke(this, "CloseWindow", result);
                }
                if (tag >= 2 && tag < 2+idx)
                {
                    
                    this.tpa01res=item.Response.Deserialize<tpa01_res.Utility>();
                    if (tag == 2)
                    {
                        toloc = this.tpa01res.UtilityHeader.ToLoc;
                    }
                    string packkey = this.tpa01res.UtilityHeader.PackKey;
                    string fromid=this.tpa01res.UtilityHeader.FromId;
                    packkeylist.Add(fromid, packkey);
                    //Console.WriteLine(toloc);
                    //InvokeHelper.Invoke(this, "OpenRFTPA02", this.loginuser, this.tpa00res,toloc);
                    if (tag == 2 + idx - 1)
                    {
                        InvokeHelper.Invoke(this, "OpenRFTPA02", this.loginuser, this.tpa00res, toloc);
                    }
                }
                else  
                {
                    if (tag == 200 + callcount - 1)
                    {
                        this.submitbtn.SetEnabled(true);
                        this.Stop();
                        isclose = true;
                        DialogResult result = MessageBox.Show(string.Format("[{0}]个板上架完成,是否获取新任务？", callcount), "提示",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        InvokeHelper.Invoke(this, "CloseWindow", result);
                    }
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

        public void CloseWindow(DialogResult result)
        {
            this.Stop();
            if (result == DialogResult.Yes)
            {
                this.IsGetTask = true;
            }
            else
            {
                this.IsGetTask = false;
            }

            this.Close();
        }
        #endregion
       
        #region call api

        public void call_NSPRFTPA00()
        {
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            //this.Start();
            //UserInfo admin = new UserInfo();
            //admin.Password = "sceadmin";
            //admin.UserName = "sceadmin";
            this.tpa00req = tpa00_req.Utility.Create(this.taskdetailkey,
                this.fromloc.Text, this.fromid1.Text, "", "",
                "", "");
            this.tpa00req.UtilityHeader.userid = this.loginuser.UserName;// "sceadmin";
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  this.tpa00req);
            //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);
             string errormsg = Response.GetErrorMessage();
             if (errormsg != string.Empty)
             {
                 //this.Stop();
                 MessageBox.Show(errormsg);
                 this.tpa00res = null;
                 this.tpa01res = null;
             }
             else
             {
                
                     this.tpa00res = Response.Deserialize<tpa00_res.Utility>();
                     idx = 0;
                     packkeylist = new Dictionary<string, string>();
                     string taskdetailkeystring = "";
                     string formlocstring = ""; ;
                     string formidstring = "";
                     foreach (tpa00_res.UtilityHeader header in this.tpa00res.UtilityHeaders)
                     {
                         
                         idx++;
                         if (header != null)
                         {
                             //taskdetailkeystring = taskdetailkeystring + header.TaskDetailKey + ";";
                             //formlocstring = formlocstring + header.FromLoc + ";";
                             //formidstring = formidstring + header.FromId + ";";
                             //Console.WriteLine(header.Qty);
                             //InvokeHelper.Invoke(this, "call_NSPRFTPA01", header.TaskDetailKey, header.FromLoc, header.FromId, idx++);

                         //   if (idx == 1){

                                 call_NSPRFTPA01(header.TaskDetailKey, header.FromLoc, header.FromId);
                                 
                         //   }else{
                         //       call_TaskStore(header.TaskDetailKey,toloc);
                         //       packkeylist.Add(header.FromId, packkey);
                         //       //call_NSPRFTPA01(header.TaskDetailKey, header.FromLoc, header.FromId);

                         //}
                              

                         }
                     }
                        //call_NSPRFTPA01(taskdetailkeystring, formlocstring, formidstring);
                     //foreach (tpa00_res.UtilityHeader header in this.tpa00res.UtilityHeaders)
                     //{

                         
                     //    if (header != null)
                     //    {
                     //        if (!packkeylist.ContainsKey(header.FromId))
                     //            packkeylist.Add(header.FromId, packkey);
                     //    }
                     //}
                     this.OpenRFTPA02(this.loginuser, this.tpa00res, toloc);
                     //InvokeHelper.Invoke(this, "OpenRFTPA02", this.loginuser, this.tpa00res, toloc);
                     //this.OpenRFTPA02(this.loginuser, this.tpa00res, toloc);
                     //DialogResult result = MessageBox.Show("拣货完成，是否获取新任务？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                     //InvokeHelper.Invoke(this, "CloseWindow", result);
                 
             }

        }
        public void call_TaskStore(string taskkey,string toloc)
        {
            RFDeviceAPP.Common.TaskStore.Request.Task req = RFDeviceAPP.Common.TaskStore.Request.Task.Craete(taskkey, toloc);
            this.tpa01req.UtilityHeader.userid = this.loginuser.UserName;
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Task,
                  enumRequestMethod.store, this.loginuser,
                  enumSendSysId.EXceed,
                  req);
            //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 2+ix);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);

            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                //this.Stop();
                MessageBox.Show(errormsg);
                return;
                //this.tpa00res = null;
                //this.tpa01res = null;
            }
        }
        public void call_NSPRFTPA01(string taskkey,string fromloc,string fromid)
        {
            this.tpa01req = tpa01_req.Utility.Create(taskkey,fromloc,fromid);
            this.tpa01req.UtilityHeader.userid = this.loginuser.UserName;
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  this.tpa01req);
            //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 2+ix);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);
      
             string errormsg = Response.GetErrorMessage();
             if (errormsg != string.Empty)
             {
                 //this.Stop();
                 MessageBox.Show(errormsg);
                 //this.tpa00res = null;
                 //this.tpa01res = null;
             }
             else
             {
                 this.tpa01res = Response.Deserialize<tpa01_res.Utility>();
                 toloc = this.tpa01res.UtilityHeader.ToLoc;
               
                 packkey = this.tpa01res.UtilityHeader.PackKey;
                 //string fromid = this.tpa01res.UtilityHeader.FromId;
                 if (!packkeylist.ContainsKey(fromid))
                 packkeylist.Add(fromid, packkey);
             }
        }

        public void call_NSPRFTPA02(Dictionary<string, tpa00_res.UtilityHeader> headerlist,string toloc,string reason)
        {
            callcount = 0;
            foreach (KeyValuePair<string, tpa00_res.UtilityHeader> keyval in headerlist)
            {
                callcount++;
                string packkey = packkeylist[keyval.Key];
                tpa00_res.UtilityHeader header = keyval.Value;
                this.tpa02req = tpa02_req.Utility.Create(this.loginuser.UserName, header.TaskDetailKey, header.FromLoc, header.FromId, toloc, header.FromId, header.Qty, packkey,"EA",reason);

                RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                      enumMessageType.Utility,
                      enumRequestMethod.functionOperation, this.loginuser,
                      enumSendSysId.EXceed,
                      this.tpa02req);
                ResponseMessage Response= ThreadHelper.Execute(requestmessage);
                string errormsg = Response.GetErrorMessage();
                if (errormsg != string.Empty)
                {
                    //this.Stop();
                    MessageBox.Show(errormsg);
                    break;
                }
                //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 200 + callcount++);
                //threadhelper.AddWorkItem(workitem);
            }

            DialogResult result = MessageBox.Show(string.Format("[{0}]个板上架完成,是否获取新任务？", callcount), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            this.CloseWindow(result);
        }
        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.fromloc.Text.Length == 0)
            {
                focusControl = this.fromloc;
                errortxt += "自库位必填";
            }
            if (this.fromid1.Text.Length == 0)
            {
                focusControl = this.fromid1;
                errortxt += "LPN/落放ID必填";
            }
            
            return errortxt;
        }
        #endregion

        #region open RFTPA02
        public void OpenRFTPA02(UserInfo userinfo, tpa00_res.Utility tpa00res, string toloc)
        {
            RFTPA02Frm frm = new RFTPA02Frm(userinfo, tpa00res, toloc,this.packkeylist);
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                string tolocstr = frm.ToLoc;
                string reason = frm.Reason;
                Dictionary<string, tpa00_res.UtilityHeader> headerlist = frm.HeaderList;
                call_NSPRFTPA02( headerlist,tolocstr, reason);
            }
            this.submitbtn.Enabled = true;
        }
        #endregion
        private void submitbtn_Click(object sender, EventArgs e)
        {
            this.submitbtn.Enabled = false;
            this.call_NSPRFTPA00();
        }
    }
}

