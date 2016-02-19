using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using RFDeviceAPP.Proxy;
using RFDeviceAPP.Common.Orders;

namespace RFDeviceAPP
{
    public partial class NSPRFQUERYBYDROPIDForm : RFDeviceAPP.baseForm
    {

        private List<LocandID> locandidslist;
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
            string xmls = response.XmlString;
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
                if (!this.orderkeytxt.Text.Equals(""))
                {
                    ShipmentOrder spod = ShipmentOrder.CreatePOD(this.orderkeytxt.Text);
                    RequestMessage searchrequest = new RequestMessage(enumRequestType.MessageProcessor,
                      enumMessageType.ShipmentOrder,
                      enumRequestMethod.list, this.LoginUser,
                      enumSendSysId.EXceed,
                      spod);

                    ResponseMessage response1 = ThreadHelper.Execute(searchrequest);
                    if (response1.GetErrorMessage() != string.Empty)
                    {
                        MessageBox.Show(response1.GetErrorMessage());
                        this.dropidtxt.Focus();
                    }
                    else
                    {
                        RFDeviceAPP.Common.Orders.ShipmentOrder result1 = response1.Deserialize<RFDeviceAPP.Common.Orders.ShipmentOrder>();
                        this.susr15.Text = result1.ShipmentOrderHeader.SUSR15;
                    }
                }


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

        private void setlist1(string ALLLOCANDID) 
        {
            if (!string.IsNullOrEmpty(ALLLOCANDID)) {
                this.locandidslist = new List<LocandID>();
                string[] locandid = ALLLOCANDID.Split(new char[] {';'});
                foreach (string tid in locandid)
                {
                    LocandID _locandid = new LocandID();
                    string[] tloc = tid.Split(new char[] { ',' });
                    _locandid.loc = tloc[0];
                    _locandid.id = tloc[1];
                    this.locandidslist.Add(_locandid);
                }
                this.gridbinding(this.locandidslist);
            }
        }

        private void gridbinding(List<LocandID> datalist)
        {
            this.dataGrid1.DataSource = datalist;
        }

        private class LocandID
        {
            string locfield;
            string idfield;
            public string loc
            {
                get
                {
                    return this.locfield;
                }
                set
                {
                    this.locfield = value;
                }
            }

            public string id
            {
                get
                {
                    return this.idfield;
                }
                set
                {
                    this.idfield = value;
                }
            }
        }

    }
}

