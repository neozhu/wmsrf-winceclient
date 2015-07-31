using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using RFDeviceAPP.Proxy;
using task_req = RFDeviceAPP.Common.NSPRFTM01.Request;
using task_res = RFDeviceAPP.Common.NSPRFTM01.Response;
namespace RFDeviceAPP
{
    public partial class TaskTPKFrm : RFDeviceAPP.baseForm
    {
        private UserInfo loginuser;
        private ThreadHelper threadhelper;
        private task_req.Utility task_req1;
        private task_res.Utility task_res1;
        //public TaskTPKFrm()
        //{
            
            
        //}
        public TaskTPKFrm(UserInfo loginuser)
            : base(loginuser)
        {
            InitializeComponent();
            LoadTaskType();
            this.userStatusControl1.LoginUser = loginuser;
            this.loginuser = loginuser;

            threadhelper = new ThreadHelper();
            threadhelper.AllWorkItemCompleted += new EventHandler(threadhelper_AllWorkItemCompleted);
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
            threadhelper.WorkItemFailed += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemFailed);
            this.area01txt.Focus();


        }
        #region threadhelper
        void threadhelper_WorkItemCompleted(object sender, WorkItemEventArgs e)
        {
            int tag = e.WorkItem.Tag;
            WorkItem item = e.WorkItem;
            string errormsg = item.Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                this.submitbtn.SetEnabled(true);
                this.Stop();
                MessageBox.Show(errormsg);
                this.area01txt.SetFocus();
                this.task_req1 = null;
               
            }
            else
            {
                if (tag == 1)
                {
                    this.Stop();
                    this.task_res1 = e.WorkItem.Response.Deserialize<task_res.Utility>();
                    //Console.WriteLine(task_res1);
                    //6上架4拣货
                    if (task_res1.UtilityHeader.rectype == "6")
                    {

                        InvokeHelper.Invoke(this, "OpenRFTPA00Frm", this.loginuser, this.task_res1);
                    }
                    else if (task_res1.UtilityHeader.rectype == "4")
                    {
                        InvokeHelper.Invoke(this, "OpenRFTPK01C", this.loginuser, this.task_res1);
                    }
                    else
                    {

                    }
                }
            }
        }
        void threadhelper_WorkItemFailed(object sender, WorkItemEventArgs e)
        {
            this.submitbtn.SetEnabled(true);
        }
        void threadhelper_AllWorkItemCompleted(object sender, EventArgs e)
        {
            this.Stop();
            this.submitbtn.SetEnabled(true);
        }
        #endregion

        #region call API
        public void call_NSPRFTM01(string area, string taskcode)
        {
            this.Start();
            this.task_req1 = task_req.Utility.CreateInstance(area, taskcode);
            this.task_req1.UtilityHeader.userid =   this.loginuser.UserName;
            //UserInfo admin = new UserInfo();
            //admin.UserName = "sceadmin";
            //admin.Password = "sceadmin";
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  this.task_req1);
            RequestWorkItem workitem = new RequestWorkItem(requestmessage, 1);
            threadhelper.AddWorkItem(workitem);

        }
        public void NSPRFTM01(string area, string taskcode)
        {
            //this.Start();
            this.task_req1 = task_req.Utility.CreateInstance(area, taskcode);
            this.task_req1.UtilityHeader.userid = this.loginuser.UserName;
            //UserInfo admin = new UserInfo();
            //admin.UserName = "sceadmin";
            //admin.Password = "sceadmin";
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  this.task_req1);
            //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);
           string errormsg = Response.GetErrorMessage();
           if (errormsg != string.Empty)
           {
               this.submitbtn.SetEnabled(true);
                
               MessageBox.Show(errormsg);
               this.area01txt.SetFocus();
               this.task_req1 = null;

           }
           else
           {
              
                   this.task_res1 = Response.Deserialize<task_res.Utility>();
                   //Console.WriteLine(task_res1);
                   //6上架4拣货
                   if (task_res1.UtilityHeader.rectype == "6")
                   {

                       this.OpenRFTPA00Frm(this.loginuser, this.task_res1);
                   }
                   else if (task_res1.UtilityHeader.rectype == "4")
                   {
                        this.OpenRFTPK01C( this.loginuser, this.task_res1);
                   }
                   else
                   {

                   }
               
           }

        }

        #endregion
        private void LoadTaskType()
        {
            List<TaskType> list = TaskType.InitData();
            this.lasttaskcbo.DataSource = list;
            this.lasttaskcbo.DisplayMember = "Name";
            this.lasttaskcbo.ValueMember = "Code";


        }
        public void OpenRFTPK01C(UserInfo loginuser, task_res.Utility task_res1)
        {
            RFTPK01CFrm frm = new RFTPK01CFrm(loginuser, task_res1);
            frm.Closed += new EventHandler(frm_Closed);
            frm.Show();
            frm.Activate();
           
        }

        public void OpenRFTPA00Frm(UserInfo loginuser, task_res.Utility task_res1)
        {
            RFTPA00Frm frm = new RFTPA00Frm(loginuser, task_res1);
            frm.Closed += new EventHandler(frm_Closed);
            frm.Show();
            frm.Activate();

        }


        void frm_Closed(object sender, EventArgs e)
        {
            if (sender is RFTPK01CFrm)
            {
                RFTPK01CFrm closewin = (RFTPK01CFrm)sender;
                if (closewin.IsGetTask)
                {
                    string taskcode = this.lasttaskcbo.SelectedValue.ToString();
                    //this.call_NSPRFTM01(this.area01txt.Text, taskcode);
                    NSPRFTM01(this.area01txt.Text, taskcode);
                }
            }
            else if (sender is RFTPA00Frm)
            {
                RFTPA00Frm closewin = (RFTPA00Frm)sender;
                if (closewin.IsGetTask)
                {
                    string taskcode = this.lasttaskcbo.SelectedValue.ToString();
                    //this.call_NSPRFTM01(this.area01txt.Text, taskcode);
                    NSPRFTM01(this.area01txt.Text, taskcode);
                }
            }
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
            //this.submitbtn.Enabled = false;
            string taskcode = this.lasttaskcbo.SelectedValue.ToString();
            //this.call_NSPRFTM01(this.area01txt.Text, taskcode);
            NSPRFTM01(this.area01txt.Text, taskcode);
        }
    }

    public class TaskType
    {
        public TaskType()
        {

        }
        public static List<TaskType> InitData()
        {
            List<TaskType> list = new List<TaskType>();
            list.Add(new TaskType() { Code = "", Name = "系统默认" });
            //list.Add(new TaskType() { Code = "AJ", Name = "调整" });
            //list.Add(new TaskType() { Code = "CC", Name = "周期盘点" });
            //list.Add(new TaskType() { Code = "CO", Name = "合并项" });
            //list.Add(new TaskType() { Code = "CR", Name = "首次分拣补货" });
            //list.Add(new TaskType() { Code = "DP", Name = "动态拣货" });
            //list.Add(new TaskType() { Code = "FR", Name = "越库配送回转收货" });
            //list.Add(new TaskType() { Code = "GM", Name = "常规消息" });
            //list.Add(new TaskType() { Code = "LD", Name = "正在加载" });
            //list.Add(new TaskType() { Code = "MV", Name = "搬运" });
            //list.Add(new TaskType() { Code = "OM", Name = "优化移动" });
            //list.Add(new TaskType() { Code = "PA", Name = "上架" });
            //list.Add(new TaskType() { Code = "PC", Name = "产品周期盘点" });
            //list.Add(new TaskType() { Code = "PIA", Name = "实际库存 A 计数" });
            //list.Add(new TaskType() { Code = "PIB", Name = "实际库存 B 计数" });
            //list.Add(new TaskType() { Code = "PK", Name = "提货项" });
            //list.Add(new TaskType() { Code = "PP", Name = "书面上架" });
            //list.Add(new TaskType() { Code = "QC", Name = "质量控制/检验" });
            //list.Add(new TaskType() { Code = "RC", Name = "收货" });
            //list.Add(new TaskType() { Code = "RP", Name = "补货" });
            //list.Add(new TaskType() { Code = "SC", Name = "主管计数" });
            return list;

        }
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}

