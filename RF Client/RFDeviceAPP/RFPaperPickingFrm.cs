using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using pick_req = RFDeviceAPP.Common.NSPRFOP01.Request;
using pick_res = RFDeviceAPP.Common.NSPRFOP01.Response;
using RFDeviceAPP.Common;
using RFDeviceAPP.Proxy;
namespace RFDeviceAPP
{
    public partial class RFPaperPickingFrm : RFDeviceAPP.baseForm
    {
        private UserInfo loginuser;
        private pick_req.Utility pickreq;
        private pick_res.Utility pickres;
        private ThreadHelper threadhelper;

        private Control focusControl;

        public RFPaperPickingFrm(UserInfo userinfo):base(userinfo)
        {
            InitializeComponent();
            this.loginuser = userinfo;
            this.pickreq = new pick_req.Utility();
            this.pickreq.UtilityHeader.userid = this.loginuser.UserName;
            threadhelper = new ThreadHelper();

            threadhelper.AllWorkItemCompleted += new EventHandler(threadhelper_AllWorkItemCompleted);
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
            threadhelper.WorkItemFailed += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemFailed);
            this.storerkeytxt.Focus();
            dataBinding();
        }
        public void dataBinding()
        {
            this.storerkeytxt.DataBinding(this.pickreq, "UtilityHeader.storerkey");
            this.fromloctxt.DataBinding(this.pickreq, "UtilityHeader.fromloc");
            this.skutxt.DataBinding(this.pickreq, "UtilityHeader.sku");
            this.fromidtxt.DataBinding(this.pickreq, "UtilityHeader.fromid");
            this.qtytxt.DataBinding(this.pickreq, "UtilityHeader.qty");
            this.shiplabeltxt.DataBinding(this.pickreq, "UtilityHeader.shiplabel");
            this.loadcasetxt.DataBinding(this.pickreq, "UtilityHeader.loadcase");
            this.dropidtxt.DataBinding(this.pickreq, "UtilityHeader.dropid");
            this.toloctxt.DataBinding(this.pickreq, "UtilityHeader.toloc");
            this.shorttxt.DataBinding(this.pickreq, "UtilityHeader.short");
        }
        void threadhelper_WorkItemCompleted(object sender, WorkItemEventArgs e)
        {
             int tag = e.WorkItem.Tag;
            WorkItem item = e.WorkItem;
            string errormsg = item.Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                if (errormsg.IndexOf("Drop ID") >= 0)
                {
                    this.dropidtxt.SetFocus();
                }
                else if (errormsg.IndexOf("loc") >= 0)
                {
                    this.fromloctxt.SetFocus();
                }
                else if (errormsg.IndexOf("SKU/ID") >= 0)
                {
                    this.skutxt.SetFocus();
                }
                else if (errormsg.IndexOf("Qty") >= 0)
                {
                    this.qtytxt.SetFocus();
                }
                else
                {
                    this.storerkeytxt.SetFocus();
                }
                return;
            }
            else
            {
                this.pickres = e.WorkItem.Response.Deserialize<pick_res.Utility>();
                MessageBox.Show("捡货完成");
                this.pickreq = new pick_req.Utility();
                this.dataBinding();
                this.storerkeytxt.SetFocus();
            }
        }
        void threadhelper_WorkItemFailed(object sender, WorkItemEventArgs e)
        {
            MessageBox.Show("Failed"+e.WorkItem.Ex.Message);
            this.storerkeytxt.SetFocus();
        }

        void threadhelper_AllWorkItemCompleted(object sender, EventArgs e)
        {
            this.Stop();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            call_NSPRFOP01();
        }
        private void call_NSPRFOP01()
        {
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }

            //this.Start();
            this.pickreq.UtilityHeader.cartontype = this.cartontype.SelectedItem.ToString();
            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  this.pickreq);
            RequestWorkItem workitem = new RequestWorkItem(requestmessage, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);

          
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                if (errormsg.IndexOf("Drop ID") >= 0)
                {
                    this.dropidtxt.SetFocus();
                }
                else if (errormsg.IndexOf("loc") >= 0)
                {
                    this.fromloctxt.SetFocus();
                }
                else if (errormsg.IndexOf("SKU/ID") >= 0)
                {
                    this.skutxt.SetFocus();
                }
                else if (errormsg.IndexOf("Qty") >= 0)
                {
                    this.qtytxt.SetFocus();
                }
                else
                {
                    this.storerkeytxt.SetFocus();
                }
                return;
            }
            else
            {
                this.pickres = Response.Deserialize<pick_res.Utility>();
                MessageBox.Show("捡货完成");
                this.pickreq = new pick_req.Utility();
                this.dataBinding();
                this.storerkeytxt.SetFocus();
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.LButton | Keys.MButton | Keys.ShiftKey | Keys.Space | Keys.F17))
            {
                call_NSPRFOP01();
            }
            base.OnKeyDown(e);

        }

        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.storerkeytxt.Text.Length == 0)
            {
                focusControl = this.storerkeytxt;
                errortxt += "货主必填";
            }
            if (this.fromloctxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.fromloctxt;
                errortxt += "库位必填";

            }
            if (this.skutxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.skutxt;
                errortxt += "sku必填";

            }
            if (this.fromidtxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.fromidtxt;
                errortxt += "LPN必填";
            }
            if (this.qtytxt.Text.Length == 0 || Convert.ToInt32(this.qtytxt.Text) == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.qtytxt;
                errortxt += "收货数量必须大于0";

            }
            if (this.shiplabeltxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.shiplabeltxt;
                errortxt += "箱ID必填";

            }

            if (this.toloctxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.toloctxt;
                errortxt += "库位必填";

            }


            return errortxt;
        }

        private void submitbtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.storerkeytxt.Focus();
            }
        }

        private void RFPaperPickingFrm_Load(object sender, EventArgs e)
        {
            this.cartontype.SelectedIndex = 0;
        }
    }
}

