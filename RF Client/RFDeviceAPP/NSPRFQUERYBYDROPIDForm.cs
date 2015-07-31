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
    public partial class NSPRFQUERYBYDROPIDForm : RFDeviceAPP.baseForm
    {
        public NSPRFQUERYBYDROPIDForm(UserInfo loginuser)
            : base(loginuser)
        {
            InitializeComponent();
        }

        private void dropidtxt_LostFocus(object sender, EventArgs e)
        {
            if (this.dropidtxt.Text.Length > 0)
            {
                Call_NSPRFQUERYBYDROPID(this.dropidtxt.Text);
            }
        }
        public void Call_NSPRFQUERYBYDROPID(string dropid)
        {
            RFDeviceAPP.Common.NSPRFQUERYBYDROPID.Request.Utility req = RFDeviceAPP.Common.NSPRFQUERYBYDROPID.Request.Utility.Create(dropid);
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
              enumMessageType.Utility,
              enumRequestMethod.functionOperation, this.LoginUser,
              enumSendSysId.EXceed,
              req);
            
            ResponseMessage response = ThreadHelper.Execute(request);
            RFDeviceAPP.Common.NSPRFQUERYBYDROPID.Response.Utility result = response.Deserialize<RFDeviceAPP.Common.NSPRFQUERYBYDROPID.Response.Utility>();
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
            }
            else
            {
                this.wavekeytxt.Text = result.UtilityHeader.WaveKey;
                this.orderkeytxt.Text = result.UtilityHeader.OrderKey;
                this.isfullpickedtxt.Text = setState(result.UtilityHeader.ISFULLPICKED);
                this.setlist(result.UtilityHeader.ALLDROPID);
                if (result.UtilityHeader.ISFULLPICKED == "0" && result.UtilityHeader.OrderKey.Length > 0)
                {
                    MessageBox.Show("该订单拣货完成");
                    this.dropidtxt.SetFocus();
                }
            }
        }
        private string setState(string ISFULLPICKED)
        {
            if (ISFULLPICKED == "0")
            {
                return "拣货完成";
            }
            else
            {
                return "还有" + ISFULLPICKED + "任务未拣";
            }
        }
        private void setlist(string ALLDROPID)
        {
            this.listBox1.Items.Clear();
            string[] dropids = ALLDROPID.Split(new char[] { ';' });
            foreach (string id in dropids)
            {
                this.listBox1.Items.Add(id);
            }
        }
    }
}

