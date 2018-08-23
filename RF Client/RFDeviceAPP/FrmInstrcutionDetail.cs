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
    public partial class FrmInstrcutionDetail : RFDeviceAPP.baseForm
    {
        private RFDeviceAPP.Common.NSPRFINSTRUCTION02X.Request.Utility request;
        private Control focusControl;
        private UserInfo loginuser;
        private String orderType;
        private String orderKey;
        private String isEnd;
        public FrmInstrcutionDetail(RFDeviceAPP.Common.NSPRFINSTRUCTION01X.Response.Utility result, Common.UserInfo loginuser, string ordertype, string orderkey)
            : base(loginuser)
        {
            InitializeComponent();
            orderType = ordertype;
            orderKey = orderkey;
            request = new RFDeviceAPP.Common.NSPRFINSTRUCTION02X.Request.Utility();
            dataBinding();
            this.addToList(result.UtilityHeaders);
        }
        public void dataBinding()
        {
            //receiveline.UtilityHeader.receiptkey
            this.InsTextBox1.DataBinding(this.request, "UtilityHeader.elabel1");
            this.InsTextBox2.DataBinding(this.request, "UtilityHeader.elabel2");
            this.InsTextBox3.DataBinding(this.request, "UtilityHeader.elabel3");
            this.InsTextBox4.DataBinding(this.request, "UtilityHeader.elabel4");
            this.InsTextBox5.DataBinding(this.request, "UtilityHeader.elabel5");
            this.InsLineNo1.DataBinding(this.request, "UtilityHeader.sourcelineno1");
            this.InsLineNo2.DataBinding(this.request, "UtilityHeader.sourcelineno2");
            this.InsLineNo3.DataBinding(this.request, "UtilityHeader.sourcelineno3");
            this.InsLineNo4.DataBinding(this.request, "UtilityHeader.sourcelineno4");
            this.InsLineNo5.DataBinding(this.request, "UtilityHeader.sourcelineno5");
            this.InsType1.DataBinding(this.request, "UtilityHeader.type");
            this.SourceKey1.DataBinding(this.request, "UtilityHeader.sourcekey");

        }

        private void addToList(List<RFDeviceAPP.Common.NSPRFINSTRUCTION01X.Response.UtilityHeader> list)
        {
            foreach (RFDeviceAPP.Common.NSPRFINSTRUCTION01X.Response.UtilityHeader header in list)
            {
                isEnd = header.isend;
                this.InsType1.Text = this.orderType;
                this.SourceKey1.Text = this.orderKey;
                if (header.ISSHOW1 == "1")
                {
                    this.InsLabel1.Visible = true;
                    this.InsTextBox1.Visible = true;
                    this.InsLabel1.Text = header.LABLE1.ToString();
                    this.InsLineNo1.Text += header.SOURCELINENO1.ToString();
                }
                else {
                    this.InsLabel1.Visible = false;
                    this.InsTextBox1.Visible = false;
                    this.InsLineNo1.Visible = false;
                }
                if (header.ISSHOW2 == "1")
                {
                    this.InsLabel2.Visible = true;
                    this.InsTextBox2.Visible = true;
                    this.InsLabel2.Text = header.LABLE2.ToString();
                    this.InsLineNo2.Text += header.SOURCELINENO2.ToString();
                }
                else
                {
                    this.InsLabel2.Visible = false;
                    this.InsTextBox2.Visible = false;
                    this.InsLineNo2.Visible = false;
                }
                if (header.ISSHOW3 == "1")
                {
                    this.InsLabel3.Visible = true;
                    this.InsTextBox3.Visible = true;
                    this.InsLabel3.Text = header.LABLE3.ToString();
                    this.InsLineNo3.Text += header.SOURCELINENO3.ToString();
                }
                else
                {
                    this.InsLabel3.Visible = false;
                    this.InsTextBox3.Visible = false;
                    this.InsLineNo3.Visible = false;
                }
                if (header.ISSHOW4 == "1")
                {
                    this.InsLabel4.Visible = true;
                    this.InsTextBox4.Visible = true;
                    this.InsLabel4.Text = header.LABLE4.ToString();
                    this.InsLineNo4.Text += header.SOURCELINENO4.ToString();
                }
                else
                {
                    this.InsLabel4.Visible = false;
                    this.InsTextBox4.Visible = false;
                    this.InsLineNo4.Visible = false;
                }
                if (header.ISSHOW5 == "1")
                {
                    this.InsLabel5.Visible = true;
                    this.InsTextBox5.Visible = true;
                    this.InsLabel5.Text = header.LABLE5.ToString();
                    this.InsLineNo5.Text += header.SOURCELINENO5.ToString();
                }
                else
                {
                    this.InsLabel5.Visible = false;
                    this.InsTextBox5.Visible = false;
                    this.InsLineNo5.Visible = false;
                }
                
            }
        }

        public string Vaildate()
        {
            string errortxt = string.Empty;
            //if (this.msglab.Text.Length == 0)
            //{
            //    focusControl = this.ordertypecombo;
            //    errortxt += "订单类型必填";
            //}
            //if (this.orderkeytext.Text.Length == 0)
            //{
            //    if (string.IsNullOrEmpty(errortxt))
            //        focusControl = this.orderkeytext;
            //    errortxt += "订单必填";

            //}
            return errortxt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            call_API();
        }

        private void call_API()
        {
            this.request.UtilityHeader.userid = this.LoginUser.UserName;
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.LoginUser,
                  enumSendSysId.EXceed,
                  this.request);
            ResponseMessage response = ThreadHelper.Execute(request);
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
                //this.ordertypecombo.SetFocus();
                return;
            }
            else
            {
                RFDeviceAPP.Common.NSPRFINSTRUCTION02X.Response.Utility result = response.Deserialize<RFDeviceAPP.Common.NSPRFINSTRUCTION02X.Response.Utility>();
                if (isEnd == "1")
                {
                    FrmInstrcutions frmins = new FrmInstrcutions(this.LoginUser);
                    frmins.ShowDialog();
                }
                else { 
                    FrmInstrcutions frmins = new FrmInstrcutions(this.LoginUser);
                    frmins.call_API(this.orderType,this.orderKey);
                }
            }

        }
    }
}

