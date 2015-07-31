using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;

namespace RFDeviceAPP
{
    public partial class baseForm : Form
    {
        public UserInfo LoginUser;
        public baseForm(UserInfo loginuser):this()
        {
            this.userStatusControl1.SetUser( loginuser);
            this.LoginUser = loginuser;
        }
        public baseForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public void Start()
        {
            if(this.userStatusControl1.IsRuning==false)
                this.userStatusControl1.Start();
        }
        public void Stop()
        {
            this.userStatusControl1.Stop();
        }

        public void EnableControl(Control.ControlCollection controls, bool isenable)
        {
            EnableControl(controls, isenable, null);
        }

        public void EnableControl(Control.ControlCollection controls, bool isenable, params object[] args)
        {
            foreach (Control item in controls)
            {
                if (item is rfButtonCommand || item is rfComboBox || item is rfTextBox || item is TextBox || item is Button)
                {
                    //item.Enabled = isenable;
                    if (args == null)
                    {
                        Proxy.InvokeHelper.Set(item, "Enabled", isenable);
                    }
                    else
                    {
                        foreach (object name in args)
                        {
                            if (item.Name == name)
                            {
                                Proxy.InvokeHelper.Set(item, "Enabled", isenable);
                                //break;
                            }
                        }
                    }
                }
                if (item.Controls.Count > 0)
                {
                    EnableControl(item.Controls, isenable);
                }
               
            }
        }

        private void baseForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
           
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.Dispose(true);
        }

        public void UpdateUser(UserInfo userinfo)
        {
            this.userStatusControl1.SetUser(userinfo);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        
    }
}