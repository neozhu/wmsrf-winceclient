using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Proxy;
using RFDeviceAPP.Common;

namespace RFDeviceAPP
{
    public partial class Frmreason : Form
    {
        private UserInfo LoginUser;
        public Frmreason(UserInfo userinfo)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoginUser = userinfo;
        }
        private string reason;
        public string Reason {
            get {
                return reason;
            }
        }
        private void okbtn_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                this.reason = this.listBox1.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("请选择原因");
                return;
            }
        }

        private void Frmreason_Load(object sender, EventArgs e)
        {
            loadReason();
        }
        private void loadReason()
        {

            RFDeviceAPP.Common.TaskReason.Request.TaskReason request = RFDeviceAPP.Common.TaskReason.Request.TaskReason.Craete(this.LoginUser.UserName);
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.TaskReason,
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
                RFDeviceAPP.Common.TaskReason.Response.TaskReason tasklist = Response.Deserialize<RFDeviceAPP.Common.TaskReason.Response.TaskReason>();
                foreach (RFDeviceAPP.Common.TaskReason.Response.TaskReasonHeader header in tasklist.TaskReasonHeaders)
                {
                    string line = header.TASKMANAGERREASONKEY;
                    this.listBox1.Items.Add(line);
                }
                this.listBox1.SelectedIndex = 0;
               

            }
        
        }
    }
}