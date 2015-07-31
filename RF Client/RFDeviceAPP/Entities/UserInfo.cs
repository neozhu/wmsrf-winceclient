using System;

using System.Collections.Generic;
using System.Text;

namespace RFDeviceAPP.Common
{
    public class UserInfo
    {
        public UserInfo()
        {

        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string whcode;

        public string Whcode
        {
            get { return whcode; }
            set { whcode = value; }
        }
        private DateTime logindate;

        public DateTime Logindate
        {
            get { return logindate; }
            set { logindate = value; }
        }
        private DateTime logoutdate;

        public DateTime Logoutdate
        {
            get { return logoutdate; }
            set { logoutdate = value; }
        }

    }
}
