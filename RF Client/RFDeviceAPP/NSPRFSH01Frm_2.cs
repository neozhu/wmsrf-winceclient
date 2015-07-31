using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dm01_req = RFDeviceAPP.Common.DM01.Request;
using dm01_res = RFDeviceAPP.Common.DM01.Response;
using sh01_req = RFDeviceAPP.Common.NSPRFSH01.Request;
using RFDeviceAPP.Common;
using RFDeviceAPP.Proxy;
namespace RFDeviceAPP
{
    public partial class NSPRFSH01Frm_2 : RFDeviceAPP.baseForm
    {
        private dm01_req.DoorsManagement dmreq;
        private dm01_res.DoorsManagement dmres;
        private Control focusControl;
        public NSPRFSH01Frm_2(UserInfo userinfo)
            : base(userinfo)
        
        {
            InitializeComponent();
            this.parknumtxt.SetFocus();
        }

        private void parknumtxt_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.parknumtxt.Text))
            {
                if (this.dmres != null && this.dmres.DoorsManagementHeader[0].PARKNUM == this.parknumtxt.Text)
                    return;

                //this.droplist.Items.Clear();
                call_dm01(this.parknumtxt.Text);
            }
        }
        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.toid.Text.Length == 0)
            {
                focusControl = this.parknumtxt;
                errortxt += "停车证牌号必填";
            }
             


            return errortxt;
        }
        private void call_dm01(string platenumber)
        {
           
            dmreq = dm01_req.DoorsManagement.CreateByParkNum(platenumber);
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.DoorsManagement,
                  enumRequestMethod.list, this.LoginUser,
                  enumSendSysId.EXceed,
                  dmreq);
            ResponseMessage response = ThreadHelper.Execute(request);
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
               
            }
            else
            {
                
                    dmres =  response.Deserialize<dm01_res.DoorsManagement>();
                    string str = string.Format("{0} {1}", dmres.DoorsManagementHeader[0].DOORSKEY, dmres.DoorsManagementHeader[0].PLATENUMBER);
                    if (str.Length > 10)
                    {
                        //InvokeHelper.Invoke(this, "addportlist", str);
                        this.toid.SetText(str);

                    }
                    else
                    {
                        dmres = null;
                        MessageBox.Show("没有找到改车的进门记录", "提示");
                        this.parknumtxt.SetFocus();
                    }
                }
            
        }
        public void call_NSPRFSH01()
        {
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            string[] tmp = this.toid.Text.Split(new char[] { ' ' });
            string toidstr = tmp[0];

            sh01_req.Utility sh01req = sh01_req.Utility.CreateSH(toidstr);
            sh01req.UtilityHeader.userid = this.LoginUser.UserName;
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.LoginUser,
                  enumSendSysId.EXceed,
                  sh01req);
            ResponseMessage response = ThreadHelper.Execute(requestmessage);
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());

            }
            else
            {

                MessageBox.Show("发运完成");
            }
        
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            call_NSPRFSH01();
        }

        private void parknumtxt_TextChanged(object sender, EventArgs e)
        {

        }

         
    }
}

