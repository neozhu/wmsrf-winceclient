using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using pack1_req = RFDeviceAPP.Common.NSPRFP1A01.Request;
using pack1_res = RFDeviceAPP.Common.NSPRFP1A01.Response;
using pack2_req = RFDeviceAPP.Common.NSPRFP1B01.Request;
using pack2_res = RFDeviceAPP.Common.NSPRFP1B01.Response;
using pack3_req = RFDeviceAPP.Common.NSPRFP301.Request;
using pack3_res = RFDeviceAPP.Common.NSPRFP301.Response;
using pack4_req = RFDeviceAPP.Common.NSPRFP401S.Request;
using pack4_res = RFDeviceAPP.Common.NSPRFP401S.Response;
using pack5_req = RFDeviceAPP.Common.NSPRFP401.Request;
using pack5_res = RFDeviceAPP.Common.NSPRFP401.Response;
using RFDeviceAPP.Proxy;
namespace RFDeviceAPP
{
    public partial class RFPackingFrm : RFDeviceAPP.baseForm
    {
        private UserInfo loginuser;

        pack1_req.Utility pack_req1=null;
        pack1_res.Utility pack_res1 = null;

        pack2_req.Utility pack_req2 = null;
        pack2_res.Utility pack_res2 = null;

        pack3_req.Utility pack_req3 = null;
        pack3_res.Utility pack_res3 = null;

        pack4_req.Utility pack_req4 = null;
        pack4_res.Utility pack_res4 = null;

        pack5_req.Utility pack_req5 = null;
        pack5_res.Utility pack_res5 = null;

        private ThreadHelper threadhelper;
        private Control focusControl;

        public RFPackingFrm(UserInfo userinfo):base(userinfo)
        {
            InitializeComponent();
            this.loginuser = userinfo;
            threadhelper = new ThreadHelper();
            threadhelper.AllWorkItemCompleted += new EventHandler(threadhelper_AllWorkItemCompleted);
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
            threadhelper.WorkItemFailed += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemFailed);
            this.tabControl1.SelectedIndex = 0;
        }
        #region threadhelper
        void threadhelper_WorkItemFailed(object sender, WorkItemEventArgs e)
        {
            MessageBox.Show("Failed" + e.WorkItem.Ex.Message);
            this.toidtxt.SetFocus();
        }
        void threadhelper_WorkItemCompleted(object sender, WorkItemEventArgs e)
        {
               int tag = e.WorkItem.Tag;
            WorkItem item = e.WorkItem;
            string errormsg = item.Response.GetErrorMessage();
            #region error
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                if (tag == 1)
                {
                    
                }
                if (tag == 2)
                {
                    if (errormsg.IndexOf("CartonType") >= 0)
                    {
                        this.cartontypetxt.SetFocus();
                    }
                    if (errormsg.IndexOf("Location") >= 0)
                    {
                        this.droploctxt.SetFocus();
                    }
                    pack_res1 = null;
                    pack_res2 = null;
                }
                if (tag == 4)
                {
                    this.orderkeytxt.SetFocus();
                    pack_res4 = null;
                    pack_res5 = null;
                }
                if (tag == 5)
                {
                    if (errormsg.IndexOf("than picked quantity") >= 0)
                    {
                        this.fromidtxt.SetFocus();
                    }
                    else
                    {
                        this.orderkeytxt.SetFocus();
                    }
                    pack_res5 = null;
                }
            }
            #endregion
            #region res
            else
            {
                if (tag == 1)
                {
                    pack_res1 = e.WorkItem.Response.Deserialize<pack1_res.Utility>();
                    call_NSPRFP1B01(this.toidtxt.GetText(), this.cartontypetxt.GetText(), this.droploctxt.GetText(), pack_res1.UtilityHeader.flag,this.loginuser.UserName);


                }
                if (tag == 2)
                {
                    pack_res2 = e.WorkItem.Response.Deserialize<pack2_res.Utility>();
                    InvokeHelper.Invoke(this, "ChangeTabIndex", 1);

                }
                if (tag == 4)
                {
                    pack_res4 = e.WorkItem.Response.Deserialize<pack4_res.Utility>();
                    this.qtypackedQtyPickedtxt.SetText(string.Format("{0}/{1}", pack_res4.UtilityHeader.QtyPicked, pack_res4.UtilityHeader.qtypacked));
                    if (pack_res4.UtilityHeader.packoneflag == "1")
                    {
                        this.qtytxt.SetText( "1");
                        this.qtytxt.SetReadOnly(true);
                        this.submitbt2.SetEnabled(false);
                        this.call_NSPRFP401(this.toidtxt1.GetText(),
                                            this.fromidtxt.GetText(),
                                            this.orderkeytxt.GetText(),
                                            this.skutxt.GetText(),
                                            this.qtytxt.GetText());
                        this.skutxt.SetFocus();
                    }
                    else if (pack_res4.UtilityHeader.packoneflag == "0")
                    {
                        this.qtytxt.SetText("");
                        this.qtytxt.SetReadOnly(false);
                        this.submitbt2.SetEnabled(true);
                        this.qtytxt.SetFocus();
                    }
                }
                if (tag == 5)
                {
                    pack_res5 = e.WorkItem.Response.Deserialize<pack5_res.Utility>();
                    this.qtypackedQtyPickedtxt.SetText(string.Format("{0}/{1}", pack_res5.UtilityHeader.QtyPicked, pack_res5.UtilityHeader.qtypacked));

                    if (pack_res5.UtilityHeader.QtyPicked == "0.0")
                    {
                        MessageBox.Show("包装完成");
                        this.fromidtxt.SetText("");
                        this.orderkeytxt.SetText("");
                        this.skutxt.SetText("");
                        this.qtytxt.SetText("");
                        this.fromidtxt.SetFocus();
                        pack_res5 = null;
                        pack_req4 = null;
                        pack_res4 = null;
                        pack_req5 = null;
                        return;
                    }
                    if (pack_res5.UtilityHeader.packoneflag == "1")
                    {
                        this.qtytxt.SetText("1");
                        this.qtytxt.SetReadOnly(true);
                        this.submitbt2.SetEnabled(false);
                        //this.call_NSPRFP401(this.toidtxt1.GetText(),
                        //                    this.fromidtxt.GetText(),
                        //                    this.orderkeytxt.GetText(),
                        //                    this.skutxt.GetText(),
                        //                    this.qtytxt.GetText());
                        this.skutxt.SetText("");
                        this.skutxt.SetFocus();
                    }
                    else if (pack_res5.UtilityHeader.packoneflag == "0")
                    {
                        this.qtytxt.SetText("");
                        this.qtytxt.SetReadOnly(false);
                        this.submitbt2.SetEnabled(true);
                    }
                }

            }
            #endregion
        }
        void threadhelper_AllWorkItemCompleted(object sender, EventArgs e)
        {
            this.Stop();
        }
        #endregion

        public void ChangeTabIndex(int idx)
        {
            
            if (idx == 1)
            {
                if (pack_res1 == null || pack_res2 == null)
                {
                    MessageBox.Show("先选择包装纸箱");
                    this.tabControl1.SelectedIndex = 0;
                    this.toidtxt.Focus();
                    return;
                }

                this.tabControl1.SelectedIndex = idx;
                this.toidtxt1.Text = this.toidtxt.Text;
                this.toidtxt1.Focus();
            }
            if (idx == 0)
            {

            }
        }
        #region call_wmsapi
        private void call_NSPRFP1A01(string toid)
        {
            string errortxt = this.Vaildate1();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }

            this.Start();
            pack_req1 = pack1_req.Utility.CreateById(toid);
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  pack_req1);
            RequestWorkItem workitem = new RequestWorkItem(requestmessage, 1);
            threadhelper.AddWorkItem(workitem);
        }

        private void call_NSPRFP1B01(string toid, string cartontype, string droploc, string flag, string userid)
        {
            pack_req2 = pack2_req.Utility.CreateByRes1(toid, cartontype, droploc, flag, userid);
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  pack_req2);
            RequestWorkItem workitem = new RequestWorkItem(requestmessage, 2);
            threadhelper.AddWorkItem(workitem);
        }
        private void call_NSPRFP401S(string toid,string fromid,string orderkey,string sku)
        {
            this.Start();
            pack_req4 = pack4_req.Utility.Create(toid, fromid, orderkey, sku);
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  pack_req4);
            RequestWorkItem workitem = new RequestWorkItem(requestmessage, 4);
            threadhelper.AddWorkItem(workitem);
        }

        private void call_NSPRFP401(string toid, string fromid, string orderkey, string sku,string qty)
        {
            string errortxt = this.Vaildate2();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            this.Start();
            pack_req5 = pack5_req.Utility.Create(toid, fromid, orderkey, sku, qty,this.loginuser.UserName);
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  pack_req5);
            RequestWorkItem workitem = new RequestWorkItem(requestmessage, 5);
            threadhelper.AddWorkItem(workitem);
        }

        #endregion
        //
        private void toidtxt_LostFocus(object sender, EventArgs e)
        {
            if (this.toidtxt.Text.Length > 0)
            {
                //call_NSPRFP1A01(this.toidtxt.Text);
                this.droploctxt.Text = "PACK";
            }
        }

        private void droploctxt_LostFocus(object sender, EventArgs e)
        {
            if (this.toidtxt.Text.Length > 0)
            {

                //call_NSPRFP1A01(this.toidtxt.Text);
            }
        }

        public string Vaildate1()
        {
            string errortxt = string.Empty;
            if (this.toidtxt.Text.Length == 0)
            {
                focusControl = this.toidtxt;
                errortxt += "箱ID必填";
            }
            if (this.cartontypetxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.cartontypetxt;
                errortxt += "箱类型必填";

            }
            if (this.droploctxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.droploctxt;
                errortxt += "至库位必填";

            }
            return errortxt;
        }
        public string Vaildate2()
        {
            string errortxt = string.Empty;
            if (this.toidtxt1.Text.Length == 0)
            {
                focusControl = this.toidtxt1;
                errortxt += "箱ID必填";
            }
            if (this.fromidtxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.fromidtxt;
                errortxt += "LPN必填";

            }
            if (this.orderkeytxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.orderkeytxt;
                errortxt += "订单号必填";

            }
            if (this.skutxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.skutxt;
                errortxt += "SKU必填";

            }
            if (this.qtytxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.qtytxt;
                errortxt += "量必填";

            }
            else
            {
                decimal qty = decimal.Parse(this.qtytxt.Text);
                if (qty <= 0)
                {
                    if (string.IsNullOrEmpty(errortxt))
                        focusControl = this.qtytxt;
                    errortxt += "量必须>0";
                }
            }
            return errortxt;
        }
        private void submitbt1_Click(object sender, EventArgs e)
        {
            call_NSPRFP1A01(this.toidtxt.Text);
          
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 1)
            {
                if (pack_res1 == null || pack_res2 == null)
                {
                    MessageBox.Show("先选择包装纸箱");
                    this.tabControl1.SelectedIndex = 0;
                    this.toidtxt.Focus();
                    return;
                }
            }
        }

        private void skutxt_LostFocus(object sender, EventArgs e)
        {
            if (this.toidtxt1.Text.Length > 0
                && this.fromidtxt.Text.Length > 0
                && this.orderkeytxt.Text.Length > 0
                && this.skutxt.Text.Length > 0)
            {
                if (pack_res4 == null || (pack_req4 != null && pack_req4.UtilityHeader.sku!=this.skutxt.Text))
                {
                    call_NSPRFP401S(this.toidtxt.Text, this.fromidtxt.Text, this.orderkeytxt.Text, this.skutxt.Text);
                }
                else if (pack_res4.UtilityHeader.packoneflag == "1")
                {
                    if (pack_res5 != null && pack_res5.UtilityHeader.packoneflag == "1")
                    {
                        string sku = this.skutxt.Text;
                        call_NSPRFP401(this.toidtxt.Text, this.fromidtxt.Text, this.orderkeytxt.Text, sku,this.qtytxt.Text);
                        this.skutxt.Text = "";
                    }
                }
            }
        }

        private void submitbt2_Click(object sender, EventArgs e)
        {
            if (pack_res4 != null && pack_res4.UtilityHeader.packoneflag == "0")
            {
                string sku = this.skutxt.Text;
                call_NSPRFP401(this.toidtxt.Text, this.fromidtxt.Text, this.orderkeytxt.Text, sku, this.qtytxt.Text);
                this.skutxt.Text = "";
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.LButton | Keys.MButton | Keys.ShiftKey | Keys.Space | Keys.F17))
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    call_NSPRFP1A01(this.toidtxt.Text);
                }
                else
                {
                    if (pack_res4 != null && pack_res4.UtilityHeader.packoneflag == "0" && this.submitbt2.Enabled==true)
                    {
                        string sku = this.skutxt.Text;
                        call_NSPRFP401(this.toidtxt.Text, this.fromidtxt.Text, this.orderkeytxt.Text, sku, this.qtytxt.Text);
                        this.skutxt.Text = "";
                    };
                }
            }
            base.OnKeyDown(e);

        }
    }
}

