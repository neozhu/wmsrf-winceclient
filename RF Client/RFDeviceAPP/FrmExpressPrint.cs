using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Proxy;
using RFDeviceAPP.Common;
using System.Xml;

namespace RFDeviceAPP
{
    public partial class FrmExpressPrint : RFDeviceAPP.baseForm
    {

        private RFDeviceAPP.Common.NSPRFDPMAILNO01.Request.Utility request;
        private ThreadHelper threadhelper;
        XmlDocument xml = new XmlDocument();
        string labelName = "";
        string printer = "";
        string orders = "";

        public FrmExpressPrint(Common.UserInfo loginuser)
            : base(loginuser)
        {
            InitializeComponent();
            request = new RFDeviceAPP.Common.NSPRFDPMAILNO01.Request.Utility();

            String path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            path = path.Substring(0, path.LastIndexOf(@"\"));
            path = path + "\\app.config";

            xml.Load(path);
            XmlNode node = xml.SelectSingleNode("configuration");
            node = node.FirstChild;
            XmlNodeList nodeList = node.SelectNodes("add");
            foreach (XmlNode n in nodeList)
            {
                string key = n.Attributes["key"].Value;
                if (key.Equals("FrmExpressPrint_label"))
                {
                    string[] labelNameArray = n.Attributes["value"].Value.Split(';');
                    foreach (string labelName in labelNameArray)
                    {
                        this.labelNameCombo.Items.Add(labelName);
                    }
                    this.labelNameCombo.Text = labelNameArray[0];
                }
                if (key.Equals("FrmExpressPrint_print"))
                {
                    string[] printerArray = n.Attributes["value"].Value.Split(';');
                    foreach (string printer in printerArray)
                    {
                        this.printerCombo.Items.Add(printer);
                    }
                    this.printerCombo.Text = printerArray[0];
                }
            }

            this.ordersText.Focus();

            dataBinding();
        }

        public void dataBinding()
        {
            //receiveline.UtilityHeader.receiptkey
            this.mailtypetext.DataBinding(this.request, "UtilityHeader.type");
            this.mailnumText.DataBinding(this.request, "UtilityHeader.qty");
        }

        private void call_API()
        {
            labelName = this.labelNameCombo.Text;
            printer = this.printerCombo.Text;
            this.request.UtilityHeader.label = labelName;
            this.request.UtilityHeader.print = printer;
            orders = this.ordersText.Text.Replace("\n","").Replace("\r","");
            //orders = addSemicolon(orders);
            this.request.UtilityHeader.orderkeys = orders;
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
                return;
            }
            else
            {
                MessageBox.Show("打印成功");
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            call_API();
        }


        private string addSemicolon(string orders)
        {

            string s1 = ";";

            string temp = "";

            int size1 = orders.Length;

            for (int i = 0; i < size1; i += 10)
            {

                if (i + 10 < size1)

                    temp += orders.Substring(i, 10) + s1;

                else

                    temp += orders.Substring(i);

            }

            orders = temp;

            return orders;

        }

    }
}