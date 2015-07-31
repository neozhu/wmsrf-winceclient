using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using task_res = RFDeviceAPP.Common.NSPRFTM01.Response;
using tpk01c_req= RFDeviceAPP.Common.NSPRFTPK01C.Request;
using tpk01c_res= RFDeviceAPP.Common.NSPRFTPK01C.Response;
using RFDeviceAPP.Proxy;
namespace RFDeviceAPP
{
    public partial class RFTPK01CFrm : RFDeviceAPP.baseForm
    {
        private task_res.Utility task_res1;
        private tpk01c_req.Utility tpk_req;
        private tpk01c_res.Utility tpk_res;
        private UserInfo loginuser;
        private ThreadHelper threadhelper;
        private Control focusControl;
        private string taskKey;
        public bool IsGetTask;
        public RFTPK01CFrm(UserInfo loginuser,task_res.Utility task_res1):base(loginuser)
        {
            InitializeComponent();

            this.task_res1 = task_res1;
            this.loginuser = loginuser;
            SetValue();
            Create(task_res1);
            dataBinding();
            threadhelper = new ThreadHelper();
            threadhelper.AllWorkItemCompleted += new EventHandler(threadhelper_AllWorkItemCompleted);
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
            threadhelper.WorkItemFailed += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemFailed);
            this.fromidtxt.Focus();
            this.cartontype.SelectedIndex = 1;
            this.taskKey = task_res1.UtilityHeader.TaskDetailKey;
            this.idlabel.Text = string.Format("ID库存/拣货后库存:{0}/{1}", task_res1.UtilityHeader.idqty, task_res1.UtilityHeader.theoryidqty);
            this.loclabel.Text = string.Format("LOC库存/拣货后库存:{0}/{1}", task_res1.UtilityHeader.locqty, task_res1.UtilityHeader.theorylocqty);
        }
        #region initdata
        public void SetValue()
        {
            this.sotxt.SetText(this.task_res1.UtilityHeader.Message01);
            this.ExternalOrderKey2.SetText(this.task_res1.UtilityHeader.ExternalOrderKey2 + "-" + this.task_res1.UtilityHeader.ODSUSR3);
            this.LOTTABLE26.SetText(this.task_res1.UtilityHeader.LOTTABLE26);
            this.fromloctxt1.SetText(this.task_res1.UtilityHeader.FromLoc);
            this.fromloctxt.SetText(this.task_res1.UtilityHeader.FromLoc);
            this.skutxt1.SetText(this.task_res1.UtilityHeader.Sku);
            this.fromidtxt1.SetText(this.task_res1.UtilityHeader.FromId);
            this.qtytxt1.SetText(this.task_res1.UtilityHeader.Qty);
            this.desctxt.SetText(this.task_res1.UtilityHeader.desc);
            this.endesctxt.SetText(this.task_res1.UtilityHeader.msg01);
        }
        public tpk01c_req.Utility Create(task_res.Utility task_res1)
        {
            tpk_req = new tpk01c_req.Utility();
            tpk_req.UtilityHeader.caseid = task_res1.UtilityHeader.CaseID;
            tpk_req.UtilityHeader.fromid = task_res1.UtilityHeader.FromId;
            tpk_req.UtilityHeader.fromloc = task_res1.UtilityHeader.FromLoc;
            tpk_req.UtilityHeader.fromchkdigit = task_res1.UtilityHeader.fromchkdigit;
            tpk_req.UtilityHeader.cartongroup = task_res1.UtilityHeader.CartonGroup;
            tpk_req.UtilityHeader.cartontype = task_res1.UtilityHeader.CartonType;
            this.cartontype.Text = task_res1.UtilityHeader.CartonType;
            
            tpk_req.UtilityHeader.lot = task_res1.UtilityHeader.Lot;
            tpk_req.UtilityHeader.packkey = task_res1.UtilityHeader.PackKey;
            tpk_req.UtilityHeader.qty = task_res1.UtilityHeader.Qty;
            tpk_req.UtilityHeader.reason = "";
            tpk_req.UtilityHeader.sku = task_res1.UtilityHeader.Sku;
            tpk_req.UtilityHeader.storerkey = task_res1.UtilityHeader.StorerKey;
            tpk_req.UtilityHeader.taskdetailkey = task_res1.UtilityHeader.TaskDetailKey;
            tpk_req.UtilityHeader.taskId = task_res1.UtilityHeader.taskkey;
            tpk_req.UtilityHeader.tochkdigit = task_res1.UtilityHeader.tochkdigit;
            tpk_req.UtilityHeader.toid = task_res1.UtilityHeader.ToId;
            this.reftoidtxt.Text = task_res1.UtilityHeader.ToId;
            tpk_req.UtilityHeader.toloc = task_res1.UtilityHeader.ToLoc;
            tpk_req.UtilityHeader.uom = task_res1.UtilityHeader.UOM;
            tpk_req.UtilityHeader.userid = this.loginuser.UserName;


            return tpk_req;
        }

        public void dataBinding()
        {
            this.fromidtxt.DataBinding(this.tpk_req, "UtilityHeader.fromid");
            this.skutxt.DataBinding(this.tpk_req, "UtilityHeader.sku");
            this.fromloctxt.DataBinding(this.tpk_req, "UtilityHeader.fromloc");
            this.toidtxt.DataBinding(this.tpk_req, "UtilityHeader.toid");
            this.toidtxt.Clean();
            this.toloctxt.DataBinding(this.tpk_req, "UtilityHeader.toloc");
            this.qtytxt.DataBinding(this.tpk_req, "UtilityHeader.qty");
          
            this.fromidtxt.SetText("");
            this.fromloctxt.SetText("");
            this.skutxt.SetText("");
            this.qtytxt.SetText("");

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
                MessageBox.Show(errormsg);
                
            }
            else
            {
                if (tag == 1)
                {
                    DialogResult result = MessageBox.Show("拣货完成，是否获取新任务？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    InvokeHelper.Invoke(this, "CloseWindow", result);
                }
            }
        }
        void threadhelper_WorkItemFailed(object sender, WorkItemEventArgs e)
        {
            MessageBox.Show("Failed" + e.WorkItem.Ex.Message);
            this.sotxt.SetFocus();
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
        public void call_NSPRFTPK01C()
        {
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(this.reftoidtxt.Text) && !string.IsNullOrEmpty(this.toidtxt.Text))
            {
                if (this.reftoidtxt.Text != this.toidtxt.Text)
                {
                    DialogResult result=  MessageBox.Show("输入的落放ID与参考落放ID不一致是否继续", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result != DialogResult.Yes)
                    {
                        return;
                    }
                }
            }
            //this.Start();
            //UserInfo admin = new UserInfo();
            //admin.Password = "sceadmin";
            //admin.UserName = "sceadmin";
            this.tpk_req.UtilityHeader.cartontype=this.cartontype.Text;
               this.tpk_req.UtilityHeader.userid=this.loginuser.UserName;
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  this.tpk_req);
            RequestWorkItem workitem = new RequestWorkItem(requestmessage, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                this.toidtxt.SetFocus();
            }
            else
            {
                
                    DialogResult result = MessageBox.Show("拣货完成，是否获取新任务？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    //InvokeHelper.Invoke(this, "CloseWindow", result);
                    this.CloseWindow(result);
                
            }
        }

        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.sotxt.Text.Length == 0)
            {
                focusControl = this.sotxt;
                errortxt += "订单号必填";
            }
            if (this.fromidtxt.Text.Length == 0)
            {
                focusControl = this.fromidtxt;
                errortxt += "原LPN必填";
            }
            else if (this.fromidtxt1.Text != this.fromidtxt.Text)
            {
                focusControl = this.fromidtxt;
                errortxt += "LPN输入不符";
            }
            if (this.fromloctxt.Text.Length == 0)
            {
                focusControl = this.fromloctxt;
                errortxt += "原库位必填";
            }
            else if (this.fromloctxt1.Text != this.fromloctxt.Text)
            {
                focusControl = this.fromloctxt;
                errortxt += "原库位输入不符";
            }
            if (this.qtytxt.Text.Length == 0)
            {
                focusControl = this.qtytxt;
                errortxt += "拣货数量必填";
            }
            else if (!string.IsNullOrEmpty(this.qtytxt1.Text) )
            {
                decimal qty1 = decimal.Parse(this.qtytxt.Text);
                decimal qty2 = decimal.Parse(this.qtytxt1.Text);
                if (qty1 > qty2)
                {
                    focusControl = this.qtytxt;
                    errortxt += "拣货数量输入不符";
                }
            }

            if (this.toidtxt.Text.Length == 0)
            {
                focusControl = this.toidtxt;
                errortxt += "至落放ID必填";
            }
            if (this.toloctxt.Text.Length == 0)
            {
                focusControl = this.toloctxt;
                errortxt += "至库位必填";
            }
            return errortxt;
        }
        #endregion

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (fromloctxt.Text.Length == 0)
            {
                fromloctxt.Text = fromloctxt1.Text;
            }
            call_NSPRFTPK01C();
        }

        private void RFTPK01CFrm_Load(object sender, EventArgs e)
        {
            this.fromidtxt.SetFocus();
        }

        private void tasklistbtn_Click(object sender, EventArgs e)
        {
            TaskListFrm frm = new TaskListFrm(this.loginuser);
            frm.Show();
        }

        private void cancelbt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.taskKey))
                return;
            string taskkey = this.taskKey;
            Frmreason frm = new Frmreason(this.LoginUser);
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                string reason = frm.Reason;

                this.callNSPRFTM03(taskkey, reason);
            }
        }

        private void callNSPRFTM03(string taskkey, string reason)
        {
            RFDeviceAPP.Common.NSPRFTM03.Request.Utility req =
                RFDeviceAPP.Common.NSPRFTM03.Request.Utility.CreateInstance(taskkey, reason);
            req.UtilityHeader.userid = this.LoginUser.UserName;
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                enumMessageType.Utility,
                enumRequestMethod.functionOperation, this.LoginUser,
                enumSendSysId.EXceed,
                req);
            //RequestWorkItem workitem = new RequestWorkItem(request, 2);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage response = ThreadHelper.Execute(request);
            RFDeviceAPP.Common.NSPRFTM03.Response.Utility result = response.Deserialize<RFDeviceAPP.Common.NSPRFTM03.Response.Utility>();
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
            }
            else
            {
                MessageBox.Show(taskkey + "任务被取消", "提示");
                //deleteitem(taskkey);
                this.Close();

            }
        }

        private void toidtxt_LostFocus(object sender, EventArgs e)
        {
            this.toidtxt.Text = this.toidtxt.Text.ToUpper();
            if (this.toidtxt.Text.Length>0 && this.toidtxt.Text.Substring(0, 1) == "C")
            {
                this.cartontype.SelectedIndex = 1;
            }
            else if (this.toidtxt.Text.Length > 0 && this.toidtxt.Text.Substring(0, 1) == "P")
            {
                this.cartontype.SelectedIndex = 0;
            }
            else if (this.toidtxt.Text.Length > 0)
            {
                MessageBox.Show("输入的目标落放ID有误");
                this.toidtxt.SetFocus();
            }
        }
    }
}

