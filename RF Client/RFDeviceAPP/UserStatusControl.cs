using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RFDeviceAPP
{
    public partial class UserStatusControl : UserControl
    {
       
        private Common.UserInfo _user;
        private bool isRuning;

        public bool IsRuning
        {
            get { return isRuning; }
            set { isRuning = value; }
        }
        public Common.UserInfo LoginUser
        {
            get { return _user; }
            set { _user = value; }
        }
        public delegate void UpdateValueHandler(int value);
        public UserStatusControl()
        {
            InitializeComponent();
            
            
        }

        void timer_Tick()
        {
            while (isRuning)
            {
                for (int i = 0; i <= 10; i++)
                {
                    if (!isRuning)
                        break;
                    this.UpdateProcess(i);
                    System.Threading.Thread.Sleep(300);
                }
            }
      
        }
        public void SetUser(Common.UserInfo loginuser)
        {
            _user = loginuser;
            this.usernamelabel.Text = _user.UserName;
            this.whcodelabel.Text = _user.Whcode;
            this.statuslabel.Text = _user.Status;
        }

        public void UpdateProcess(int value)
        {
            if (this.progressBar.InvokeRequired)
            {
                UpdateValueHandler updatehandle = updateValue;
                this.BeginInvoke(updatehandle, value);


            }
            else
            {
                this.progressBar.Value = value;
            }
        }
        private void updateValue(int value)
        {
            this.progressBar.Value = value;
        }


        public void Start()
        {
            if (isRuning == false)
            {
                isRuning = true;
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(timer_Tick));
                thread.IsBackground = true;
                thread.Start();
            }
            
        }
        public void Stop()
        {
            isRuning = false;
            
        }

    }
}
