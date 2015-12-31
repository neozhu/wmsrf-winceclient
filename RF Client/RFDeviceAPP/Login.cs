using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using fllg_req = RFDeviceAPP.Common.NSPRFOT08.Request;
using fllg_res = RFDeviceAPP.Common.NSPRFOT08.Response;
using RFDeviceAPP.Proxy;
using System.IO;
using System.Reflection;
using RFDeviceAPP.Entities;

namespace RFDeviceAPP
{
    public partial class Login : Form
    {
        private fllg_req.Utility userinforeq;
        private fllg_res.Utility userinfores;
        private Common.UserInfo _user = new RFDeviceAPP.Common.UserInfo();

        private ThreadHelper threadhelper;
        private string[] screen;

        public string[] Screen
        {
            get { return screen; }
            set { screen = value; }
        }

        public Common.UserInfo LoginUser
        {
            get { return _user; }
            set { _user = value; }
        }

        public Login()
        {
            InitializeComponent();
            threadhelper = new ThreadHelper();
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
            threadhelper.WorkItemFailed +=new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemFailed);

            this.whcodecombo.SelectedIndex = 0;
            this.server.SelectedIndex = 0;
            this.Text = "登录 Ver " + this.getVer();
            //this.usernametxt.Text = "neo_zhu";
            //this.passwordtxt.Text = "neo_zhu";
        }
        private string getVer()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        void threadhelper_WorkItemFailed(object sender, WorkItemEventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show(e.WorkItem.Ex.Message);
            InvokeHelper.Invoke(this.usernametxt, "Focus", null);// this.usernametxt.Focus();
        }

        void threadhelper_WorkItemCompleted(object sender, WorkItemEventArgs e)
        {
            int tag = e.WorkItem.Tag;
            WorkItem item = e.WorkItem;
            if (item.Response.GetErrorMessage() != string.Empty)
            {
                MessageBox.Show(item.Response.GetErrorMessage());
                return;
            }
            if (tag == 1)
            {

                this.userinfores = e.WorkItem.Response.Deserialize<fllg_res.Utility>();

                //this.userinforeq.UtilityHeader.userid = userinfores.UtilityHeader.

                if (this._user.UserName == string.Empty)
                {
                    MessageBox.Show("用户名不存在");
                    InvokeHelper.Invoke(this.usernametxt, "Focus", null);
                }
                else
                {
                    this.screen = this.userinfores.UtilityHeader[0].Screen.Split(new char[]{';'});
                    InvokeHelper.Set(this, "DialogResult", DialogResult.OK);
                    //DialogResult = DialogResult.OK;
                    
                }

            }
        }

        void threadhelper_AllWorkItemCompleted(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_user.UserName) && !string.IsNullOrEmpty(_user.Password))
            {
                this.usernametxt.Text = this._user.UserName;
                this.passwordtxt.Text = this._user.Password;
                this.call_UserData(this._user.UserName, this._user.Password);
            }
        }

        private void call_UserData(string username, string password)
        {
            userinforeq = fllg_req.Utility.Create(username, password);
            RequestMessage searchrequest = new RequestMessage(enumRequestType.MessageProcessor,
                enumMessageType.Utility,
                enumRequestMethod.functionOperation, this._user,
                enumSendSysId.EXceed,
                userinforeq);
            RequestWorkItem workitem = new RequestWorkItem(searchrequest, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(searchrequest);
            if (Response.GetErrorMessage() != string.Empty)
            {
                MessageBox.Show(Response.GetErrorMessage());
                this.usernametxt.Focus();
            }
            else
            {
                this.userinfores = Response.Deserialize<fllg_res.Utility>();
                if (this._user.UserName == string.Empty)
                {
                    MessageBox.Show("用户名不存在");
                    this.usernametxt.Focus();
                }
                else
                {
                    this.screen = this.userinfores.UtilityHeader[0].Screen.Split(new char[] { ';' });
                    //InvokeHelper.Set(this, "DialogResult", DialogResult.OK);
                    DialogResult = DialogResult.OK;

                }
            }


        }



        private void usernametxt_KeyDown(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.usernametxt.Text))
            {
                this._user.UserName = this.usernametxt.Text;
                int num = Convert.ToInt32(this.usernametxt.Text);
                if (num > 0)
                {
                    this.call_UserData(this.usernametxt.Text, this.passwordtxt.Text);
                }
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            _user.UserName = this.usernametxt.Text;
            _user.Whcode = this.whcodecombo.Text;
            _user.Password = this.passwordtxt.Text;
            _user.Logindate = DateTime.Now;

            if (!string.IsNullOrEmpty(_user.UserName) && !string.IsNullOrEmpty(_user.Password))
            {
                this.call_UserData(this._user.UserName, this._user.Password);
            }
          

            //DialogResult = DialogResult.OK;

        }

        private void whcodecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.whcodecombo.Text == "FEILI_wmwhse10")
            {
                this.msglab.Text = "模拟库";
            }
            else if (this.whcodecombo.Text == "FEILI_wmwhse9")
            {
                this.msglab.Text = "华硕备件库";
            }
            else if (this.whcodecombo.Text == "FEILI_wmwhse21")
            {
                this.msglab.Text = "禧玛诺";
            }
            else
            {
                this.msglab.Text = "测试环境";
            }
        }

        private void whcodecombo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.usernametxt.Focus();
                this.usernametxt.SelectAll();
                e.Handled = true;
            }
        }

        private void usernametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.passwordtxt.Focus();
                this.passwordtxt.SelectAll();
                e.Handled = true;
            }
        }

        private void passwordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.savechk.Focus();
                e.Handled = true;
            }
        }

        private void savechk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.loginbtn.Focus();
                e.Handled = true;
            }

        }

        private void loginbtn_KeyDown(object sender, KeyEventArgs e)
        {
            loginbtn_Click(sender, e);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            #if !DEBUG
            if (chkupdate())
            {
                Application.Exit();

            }
            #endif
        }


        private bool chkupdate()
        {
            if (getupdateversion() > getVersion())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private decimal getVersion()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            string filename = path.Replace("RFDeviceAPP.exe", "Ver.txt");
            if (!File.Exists(filename))
            {
                File.Create(filename);

            }
            System.Threading.Thread.Sleep(10);
            StreamReader sr = new StreamReader(filename);
            string line = sr.ReadToEnd();
            sr.Close();
            if (string.IsNullOrEmpty(line))
            {
                return 0;

            }
            else
            {
                return decimal.Parse(line);
            }

        }

        private decimal getupdateversion()
        {
            updateservice.LiveUpdate update = new RFDeviceAPP.updateservice.LiveUpdate();
            return update.GetVersion();
        }

        private void server_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.Parameters.Remove("url");
            Global.Parameters.Add("url", this.server.SelectedItem.ToString());
        }

    }
}