using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using RFDeviceAPP.Proxy;

namespace RFDeviceAPP
{
    public partial class TaskListFrm : RFDeviceAPP.baseForm
    {
        private string storerkey = "";
        private Control focusControl;
        private Dictionary<string, RFDeviceAPP.Common.TaskList.Response.TaskHeader> taskresdic = null;
        public TaskListFrm(UserInfo userinfo):base(userinfo)
        {
            InitializeComponent();
            
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaskListFrm_Load(object sender, EventArgs e)
        {
            call_taskList();
        }
        
        private void call_taskList()
        {
            RFDeviceAPP.Common.TaskList.Request.Task request = RFDeviceAPP.Common.TaskList.Request.Task.Craete(this.LoginUser.UserName);
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Task,
                  enumRequestMethod.list, this.LoginUser,
                  enumSendSysId.EXceed,
                  request);
            RequestWorkItem workitem = new RequestWorkItem(requestmessage, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);

            }
            else
            {
                taskresdic = new Dictionary<string, RFDeviceAPP.Common.TaskList.Response.TaskHeader>();
                List<TaskItem> list = new List<TaskItem>();
                RFDeviceAPP.Common.TaskList.Response.Task tasklist = Response.Deserialize<RFDeviceAPP.Common.TaskList.Response.Task>();
                foreach(RFDeviceAPP.Common.TaskList.Response.TaskHeader task in tasklist.TaskHeaders){
                    taskresdic.Add(task.TaskDetailKey, task);
                    this.storerkey = task.StorerKey;
                    //string line = string.Format("{0} {1} {2} {3}", task.TaskDetailKey,task.Sku,task.Qty,task.FromLoc);
                    //this.tasklist.Items.Add(line);
                    TaskItem item = new TaskItem();
                    item.OrderKey = task.OrderKey;
                    item.Key = task.TaskDetailKey;
                    item.Sku = task.Sku;
                    item.Qty = task.Qty;
                    item.Loc = task.FromLoc;
                    list.Add(item);

                }
                this.datagridbinding(list);
               

            }
        }
        private void datagridbinding(List<TaskItem> list)
        {
            this.dataGridTableStyle1.MappingName = list.GetType().Name;
            this.dataGrid1.DataSource = list;
          
        }
        private void tasklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (this.dataGrid1.CurrentRowIndex <0)
                return;
            string key = dataGrid1[this.dataGrid1.CurrentRowIndex, 4].ToString();
            if (key.Length > 0)
            {

                //string[] temp = line.Split(' ');
                this.sourcekey.Text += key + ";";
            }
         

        }

        private void selectallbtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGrid1.VisibleRowCount;i++ )
            {
                string key = this.dataGrid1[i, 4].ToString();
                if (key.Length > 0)
                {
                    //string[] temp = line.Split(' ');
                    this.sourcekey.Text += key + ";";
                }

            }
        }

        private void cleanallbtn_Click(object sender, EventArgs e)
        {
            this.sourcekey.Clean();
        }

        private void printbt_Click(object sender, EventArgs e)
        {
            call_print();
        }
        private string getcopiesstring(string input,string num)
        {
            string temp = "";
            string[] sp = input.Split(';');
            foreach (string str in sp)
            {
                if(str.Length>0)
                temp += num + ";";
            }
            return temp;
        }
        public void call_print()
        {
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            string cp = getcopiesstring(this.sourcekey.Text, this.copies.Text);
            string print = getcopiesstring(this.sourcekey.Text, this.printers.Text); ;

            RFDeviceAPP.Common.RFCalcSuitLabelData.Request.Utility req =
                RFDeviceAPP.Common.RFCalcSuitLabelData.Request.Utility.CreateInstance(this.sourcekey.Text, this.storerkey, print, cp);
            req.UtilityHeader.userid = this.LoginUser.UserName;
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                enumMessageType.Utility,
                enumRequestMethod.functionOperation, this.LoginUser,
                enumSendSysId.EXceed,
                req);
            //RequestWorkItem workitem = new RequestWorkItem(request, 2);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage response = ThreadHelper.Execute(request);
            RFDeviceAPP.Common.RFCalcSuitLabelData.Response.Utility result = response.Deserialize<RFDeviceAPP.Common.RFCalcSuitLabelData.Response.Utility>();
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
            }
            else
            {
                MessageBox.Show("已发送打印", "提示");

            }

        }
        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.sourcekey.Text.Length == 0)
            {
                focusControl = this.sourcekey;
                errortxt += "打印任务号必填";
            }

            if (this.printers.Text.Length == 0)
            {
                focusControl = this.printers;
                errortxt += "打印机必填";

            }
             

            return errortxt;
        }

        private void canclebt_Click(object sender, EventArgs e)
        {
            //object sel=this.tasklist.SelectedItem;
            if (this.dataGrid1.CurrentRowIndex<0)
            {
                MessageBox.Show("请选择要取消的任务");
                return;
            }
            //string line = sel.ToString();
            //string[] arr = line.Split(' ');
            string taskkey = this.dataGrid1[dataGrid1.CurrentRowIndex,4].ToString();
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
                call_taskList();

            }
        }

        private void dobutton_Click(object sender, EventArgs e)
        {
            if (this.dataGrid1.CurrentRowIndex < 0)
            {
                MessageBox.Show("请选择要执行的任务");
                return;
            }
          
            string taskkey = this.dataGrid1[dataGrid1.CurrentRowIndex, 4].ToString();
            RFDeviceAPP.Common.TaskList.Response.TaskHeader header = this.taskresdic[taskkey];
            RFDeviceAPP.Common.NSPRFTM01.Response.Utility taskutiliyres = new RFDeviceAPP.Common.NSPRFTM01.Response.Utility();
            taskutiliyres.UtilityHeader = new RFDeviceAPP.Common.NSPRFTM01.Response.UtilityHeader();
            taskutiliyres.UtilityHeader.assignmentkey = "";
            taskutiliyres.UtilityHeader.CartonGroup = "";
            taskutiliyres.UtilityHeader.CartonType = "";
            taskutiliyres.UtilityHeader.CaseID = header.CaseID;
            taskutiliyres.UtilityHeader.desc = "";
            taskutiliyres.UtilityHeader.doReplenish = "";
            taskutiliyres.UtilityHeader.ExternalOrderKey2 = "";
            taskutiliyres.UtilityHeader.ExternOrderKey = "";
            taskutiliyres.UtilityHeader.fromchkdigit = "";
            taskutiliyres.UtilityHeader.FromId = header.FromId;
            taskutiliyres.UtilityHeader.FromLoc = header.FromLoc;
            taskutiliyres.UtilityHeader.idqty = "";
            taskutiliyres.UtilityHeader.laborflag = "";
            taskutiliyres.UtilityHeader.locqty = "";
            taskutiliyres.UtilityHeader.Lot = header.Lot;
            taskutiliyres.UtilityHeader.Message01 = header.Message01;
            taskutiliyres.UtilityHeader.Message02 = header.Message02;
            taskutiliyres.UtilityHeader.Message03 = header.Message03;
            taskutiliyres.UtilityHeader.msg01 = "";

        }
        //private void deleteitem(string taskkey)
        //{
        //    for (int i = 0; i < this.tasklist.Items.Count; i++)
        //    {
        //        string str = this.tasklist.Items[i].ToString();
        //        if (str.IndexOf(taskkey) >= 0)
        //        {
        //            this.tasklist.Items.RemoveAt(i);
        //            break;
        //        }
        //    }
        //}

       
    }

    public class TaskItem {
        public TaskItem()
        {

        }
        private string orderKey;

        public string OrderKey
        {
            get { return orderKey; }
            set { orderKey = value; }
        }
        private string key;

        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        private string sku;

        public string Sku
        {
            get { return sku; }
            set { sku = value; }
        }
        private string qty;

        public string Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        private string loc;

        public string Loc
        {
            get { return loc; }
            set { loc = value; }
        }
    }
}

