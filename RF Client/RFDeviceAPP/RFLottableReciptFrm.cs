using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using flrs1_req = RFDeviceAPP.Common.FLGetASNByLine.Request;
using flrs1_res = RFDeviceAPP.Common.FLGetASNByLine.Response;
using flrs2_req = RFDeviceAPP.Common.FLGETSKUINFOP1S1.Request;
using flrs2_res = RFDeviceAPP.Common.FLGETSKUINFOP1S1.Response;
using flrs3_req = RFDeviceAPP.Common.FLRFRECEIVEByLine.Request;
using flrs3_res = RFDeviceAPP.Common.FLRFRECEIVEByLine.Response;

using drid_req = RFDeviceAPP.Common.NSPRFRCC01E.Request;
using drid_res = RFDeviceAPP.Common.NSPRFRCC01E.Response;
using drid_req1 = RFDeviceAPP.Common.NSPRFRC01E.Request;
using drid_res1 = RFDeviceAPP.Common.NSPRFRC01E.Response;

using asnlist_req=RFDeviceAPP.Common.asnlist01.Request;
using asnlist_res=RFDeviceAPP.Common.asnlist01.Response;
using RFDeviceAPP.Proxy;
using System.Text.RegularExpressions;
using System.Reflection;

namespace RFDeviceAPP
{
    public partial class RFLottableReciptFrm : RFDeviceAPP.baseForm
    {
        private UserInfo loginuser;
        private flrs3_req.Utility receivelinereq;
        private flrs3_res.Utility receivelineres;
        private flrs1_req.Utility asnbylinereq;
        private flrs1_res.Utility asnbylineres;
        private flrs2_req.Utility asnskureq;
        private flrs2_res.Utility asnskures;
        private asnlist_req.AdvancedShipNotice asnlistreq;
        private asnlist_res.AdvancedShipNotice asnlistres;
        private ThreadHelper threadhelper;
        private string dropid = string.Empty;
        private Control focusControl;
        
        public RFLottableReciptFrm(UserInfo userinfo):base(userinfo) 
        {
            InitializeComponent();
            loginuser = userinfo;
            receivelinereq = new flrs3_req.Utility();
            receivelinereq.UtilityHeader.userid = this.loginuser.UserName;
            threadhelper = new ThreadHelper();

            threadhelper.AllWorkItemCompleted += new EventHandler(threadhelper_AllWorkItemCompleted);
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
            threadhelper.WorkItemFailed += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemFailed);
            this.dataBinding();
            this.receiptkeytxt.Focus();
            this.KeyPreview = true;
        }
        public void dataBinding()
        {
            //receiveline.UtilityHeader.receiptkey
            this.receiptkeytxt.DataBinding(this.receivelinereq, "UtilityHeader.prokey");
            //receiveline.UtilityHeader.receiptLineNumber
            this.receiptLineNumbertxt.DataBinding(this.receivelinereq, "UtilityHeader.receiptLineNumber");
            //receiveline.UtilityHeader.storerkey
            this.storerkeytxt.DataBinding(this.receivelinereq, "UtilityHeader.storerkey");
            //receiveline.UtilityHeader.sku
            this.skutxt.DataBinding(this.receivelinereq, "UtilityHeader.sku");
            //receiveline.UtilityHeader.packkey
            this.packkeytxt.DataBinding(this.receivelinereq, "UtilityHeader.packkey");
            //receiveline.UtilityHeader.qty
            this.qtytxt.DataBinding(this.receivelinereq, "UtilityHeader.qty");
            //receiveline.UtilityHeader.uom
            //this.uomtxt.DataBinding(this.receivelinereq, "UtilityHeader.uom");
            //receiveline.UtilityHeader.loc
            this.receivelinereq.UtilityHeader.loc = "";
            this.loctxt.DataBinding(this.receivelinereq, "UtilityHeader.loc");
            //receiveline.UtilityHeader.id
            this.idtxt.DataBinding(this.receivelinereq, "UtilityHeader.id");
            foreach (Control item in this.bodypanel.Controls)
            {   
                if(item is rfFieldTextBox)
                    this.bodypanel.Controls.Remove(item);
            }
            this.bodypanel.Height=72;

        }

        #region threadhelper event
        void threadhelper_WorkItemFailed(object sender, WorkItemEventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show(e.WorkItem.Ex.Message);
            int tag=e.WorkItem.Tag;
            if (tag == 1)
            {
                this.storerkeytxt.Clean();
                this.skutxt.Clean();
                this.desctxt.Clean();
                this.packkeytxt.Clean();
                
                //this.receiptkeytxt.SetFocus();
                this.asnbylinereq = null;
                this.asnskureq = null;
                this.asnskures = null;
                this.receiptLineNumbertxt.SetFocus();
            }
            if (tag == 2)
            {
                this.skutxt.SetFocus();
            }
            if (tag == 3)
            {
                this.receiptkeytxt.SetFocus();
            }
        }

        void threadhelper_WorkItemCompleted(object sender, WorkItemEventArgs e)
        {
             int tag = e.WorkItem.Tag;
            WorkItem item = e.WorkItem;
            string errormsg = item.Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(item.Response.GetErrorMessage());
                if (tag == 1)
                {
                    this.asnbylinereq = null;
                    this.asnskureq = null;
                    this.asnskures = null;
                    this.storerkeytxt.Clean();
                    this.skutxt.Clean();
                    this.receiptkeytxt.SetFocus();
                }
                if (tag == 2)
                {
                    this.skutxt.SetFocus();
                }
                if (tag == 3)
                {
                    if (errormsg.IndexOf("ID has already been used") >= 0)
                    {
                        this.idtxt.SetFocus();
                    }
                    else if (errormsg.IndexOf("Received Qty > Expected Qty") > 0)
                    {
                        this.qtytxt.SetFocus();
                    }
                    else
                    {
                        this.receiptkeytxt.SetFocus();
                    }
                }
                if (tag == 4)
                {
                    this.receiptkeytxt.SetFocus();
                }
                return;
            }
            if (tag == 1)
            {
                asnbylineres = e.WorkItem.Response.Deserialize<flrs1_res.Utility>();
                this.storerkeytxt.SetText(asnbylineres.UtilityHeader.StorerKey);
                this.receivelinereq.UtilityHeader.storerkey = asnbylineres.UtilityHeader.StorerKey;
                this.receivelinereq.UtilityHeader.sku = asnbylineres.UtilityHeader.Sku;
                this.receivelinereq.UtilityHeader.uom = "EA";
                //this.skutxt.SetText(asnbylineres.UtilityHeader.Sku);
                this.skutxt.Clean();
                this.desctxt.Clean();
                this.packkeytxt.Clean();
                this.idtxt.Clean();
                this.qtytxt.SetText("0");
            }
            if (tag == 2)
            {
                asnskures = e.WorkItem.Response.Deserialize<flrs2_res.Utility>();
                this.desctxt.SetText(asnskures.UtilityHeader.desc);
                this.packkeytxt.SetText(asnskures.UtilityHeader.pack);
                //this.qtytxt.SetText("");
                //this.uomtxt.SetText(asnskures.UtilityHeader.UOM);

                setLottableValue(asnskures.UtilityHeader);
                
                createLottableControl(asnskures.UtilityHeader);
                 
            }
            if (tag == 3)
            {
                receivelineres = e.WorkItem.Response.Deserialize<flrs3_res.Utility>();
                string receiptkey = receivelineres.UtilityHeader.prokey;
                this.receivelinereq = new flrs3_req.Utility();

                this.receivelinereq.UtilityHeader.prokey = receivelineres.UtilityHeader.prokey;
                this.receivelinereq.UtilityHeader.receiptkey = receivelineres.UtilityHeader.prokey;
                this.receivelinereq.UtilityHeader.drid = this.dropid;
                this.asnbylinereq = null;
                this.asnbylineres = null;
                this.asnskureq = null;
                this.asnskures = null;
                this.receivelineres = null;
                this.desctxt.Clean();
                InvokeHelper.Invoke(this, "dataBinding", null);
                //MessageBox.Show("收货完成");
                this.receiptkeytxt.SetFocus();
                InvokeHelper.Invoke(this, "call_asnlist01", receiptkey);
                
            }
            if (tag == 4)
            {
                drid_res.Utility dridres = e.WorkItem.Response.Deserialize<drid_res.Utility>();
                this.call_NSPRFRC01E(dridres.UtilityHeader.tag, dridres.UtilityHeader.storer,dridres.UtilityHeader.Sku);
                
            }
            if (tag == 5)
            {
                drid_res1.Utility dridres1 = e.WorkItem.Response.Deserialize<drid_res1.Utility>();
                MessageBox.Show("载具已经提交.");
                this.receiptkeytxt.SetFocus();
            }
            if (tag == 10)
            {
                //status=9,11,15 表示收货全部完成
                asnlistres = e.WorkItem.Response.Deserialize<asnlist_res.AdvancedShipNotice>();
                if(asnlistres.AdvancedShipNoticeHeaders.Count>0){
                string status=asnlistres.AdvancedShipNoticeHeaders[0].Status;
                if (status == "9" || status == "11" || status == "15")
                {
                    MessageBox.Show("该ASN已经收货完成.");
                    this.receiptkeytxt.Clean();
                }
                else
                {
                    MessageBox.Show("该行收货完成.");
                }
                
                }
            }

        }

        void threadhelper_AllWorkItemCompleted(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.Stop();
        }
        #endregion
        
        private void createLottableControl(flrs2_res.UtilityHeader header)
        {

            int tab=28;
            if (header.VISISRP == "1")
            {
                this.receivelinereq.UtilityHeader.isrp = "Y";
                this.AddControlToPanel("载具ID", this.dropid, tab++, true, "UtilityHeader.drid");
                //InvokeHelper.Invoke(this, "AddControlToPanel", "载具ID", "", tab++, true, "UtilityHeader.drid");
                //InvokeHelper.Invoke(this, "AddControlToPanel", "载具ID", this.dropid, tab++, true, "UtilityHeader.drid");
            }

            foreach (var prop in header.GetType().GetProperties())
            {
                if (prop.Name.ToLower().IndexOf("field") > -1)
                {
                    //System.Diagnostics.Debug.WriteLine(prop.Name + "-" + prop.GetValue(header, new object[] { }).ToString());
                    int val=Convert.ToInt32( prop.GetValue(header, new object[] { }).ToString());
                    string fieldname = prop.Name;
                    string[] numbers = Regex.Split(fieldname, @"\D+");
                    int num =Convert.ToInt32(numbers[1]);
                    if (val > 0)
                    {
                        if (Convert.ToBoolean(num & 1))
                        {

                           
                            int isrequirednum = Convert.ToInt32(header.GetPropValue(string.Format("Field{0}", num + 1)).ToString());
                            bool isrequired = Convert.ToBoolean(isrequirednum);
                            int valfieldidx =1;
                            if(num>2)
                                valfieldidx = (num / 2)+1;
                            string label = header.GetPropValue(string.Format("lo{0}", valfieldidx)).ToString();
                            string text =string.Empty;
                            if(valfieldidx==10)
                                text = header.GetPropValue(string.Format("Lottable{0}", valfieldidx)).ToString();
                            else
                                text = header.GetPropValue(string.Format("lottable{0}", valfieldidx)).ToString();
                            string filedmember = string.Format("UtilityHeader.lottable{0}", valfieldidx.ToString("00"));
                            //rfFieldTextBox fieldtext = new rfFieldTextBox(label, text);
                            //fieldtext.DataBinding(this.receivelinereq, filedmember);
                            //InvokeHelper.Invoke(this, "AddControlToPanel", label, text, tab++, isrequired, filedmember);
                            this.AddControlToPanel(label, text, tab++, isrequired, filedmember);
                        }
                        
                    }
                }
            }
            
        }
        //public delegate void AddControlToPanelHandler(Panel p, string c);
        public void AddControlToPanel(string label,string text,int tab,bool isrequired,string fieldmember)
        {
            string name = label + tab.ToString();
            rfFieldTextBox control =null;
            bool isexist=false;
            foreach (Control item in this.bodypanel.Controls)
            {
                if (item.Name == name)
                {
                   control=item as rfFieldTextBox;
                   control.SetText(text);
                    isexist=true;
                    break;
                }
            }
            if (isexist)
            {
                control.DataBinding(this.receivelinereq, fieldmember);
            }
            else
            {
                control = new rfFieldTextBox(label, text, tab, isrequired);
                control.Name = name;
                control.DataBinding(this.receivelinereq, fieldmember);
                this.bodypanel.Controls.Add(control);
                this.bodypanel.Controls.SetChildIndex(control, 0);
                control.Dock = DockStyle.Top;
                this.bodypanel.Height += 39;
            }
            

        }
        
        private void setLottableValue(flrs2_res.UtilityHeader header)
        {
            this.receivelinereq.UtilityHeader.receiptkey = header.pro;
            this.receivelinereq.UtilityHeader.lottable01 = header.lottable1;
            this.receivelinereq.UtilityHeader.lottable02 = header.lottable2;
            this.receivelinereq.UtilityHeader.lottable03 = header.lottable3;
            this.receivelinereq.UtilityHeader.lottable04 = header.lottable4;
            this.receivelinereq.UtilityHeader.lottable05 = header.lottable5 == null ? string.Empty : header.lottable5;
            this.receivelinereq.UtilityHeader.lottable06 = header.lottable6 == null ? string.Empty : header.lottable6; ;
            this.receivelinereq.UtilityHeader.lottable07 = header.lottable7;
            this.receivelinereq.UtilityHeader.lottable08 = header.lottable8;
            this.receivelinereq.UtilityHeader.lottable09 = header.lottable9;
            this.receivelinereq.UtilityHeader.lottable10 = header.Lottable10;
            this.receivelinereq.UtilityHeader.lottable11 = header.lottable11;
            this.receivelinereq.UtilityHeader.lottable12 = header.lottable12;
            this.receivelinereq.UtilityHeader.lottable13 = header.lottable13;
            this.receivelinereq.UtilityHeader.lottable14 = header.lottable14;
            this.receivelinereq.UtilityHeader.lottable15 = header.lottable15;
            this.receivelinereq.UtilityHeader.lottable16 = header.lottable16;
            this.receivelinereq.UtilityHeader.lottable17 = header.lottable17;
            this.receivelinereq.UtilityHeader.lottable18 = header.lottable18;
            this.receivelinereq.UtilityHeader.lottable19 = header.lottable19;
            this.receivelinereq.UtilityHeader.lottable20 = header.lottable20;
            this.receivelinereq.UtilityHeader.lottable21 = header.lottable21;
            this.receivelinereq.UtilityHeader.lottable22 = header.lottable22;

            this.receivelinereq.UtilityHeader.lottable23 = header.lottable23;
            this.receivelinereq.UtilityHeader.lottable24 = header.lottable24;
            this.receivelinereq.UtilityHeader.lottable25 = header.lottable25;
            this.receivelinereq.UtilityHeader.lottable26 = header.lottable26;
            this.receivelinereq.UtilityHeader.lottable27 = header.lottable27;
            this.receivelinereq.UtilityHeader.lottable28 = header.lottable28;
            this.receivelinereq.UtilityHeader.lottable29 = header.lottable29;
            this.receivelinereq.UtilityHeader.lottable30 = header.lottable30;
            this.receivelinereq.UtilityHeader.lottable31 = header.lottable31;
            this.receivelinereq.UtilityHeader.lottable32 = header.lottable32;
            this.receivelinereq.UtilityHeader.lottable33 = header.lottable33;
            this.receivelinereq.UtilityHeader.lottable34 = header.lottable34;
            this.receivelinereq.UtilityHeader.lottable35 = header.lottable35;
            this.receivelinereq.UtilityHeader.lottable36 = header.lottable36;
            this.receivelinereq.UtilityHeader.lottable37 = header.lottable37;
            this.receivelinereq.UtilityHeader.lottable38 = header.lottable38;
            this.receivelinereq.UtilityHeader.lottable39 = header.lottable39;
            this.receivelinereq.UtilityHeader.lottable40 = header.lottable40;
            this.receivelinereq.UtilityHeader.lottable41 = header.lottable41;
            this.receivelinereq.UtilityHeader.lottable42 = header.lottable42;
            this.receivelinereq.UtilityHeader.lottable43 = header.lottable43;
            this.receivelinereq.UtilityHeader.lottable44 = header.lottable44;
            this.receivelinereq.UtilityHeader.lottable45 = header.lottable45;
            this.receivelinereq.UtilityHeader.lottable46 ="";
            this.receivelinereq.UtilityHeader.lottable47 = "";

            

           
        }
        
        private void receiptLineNumbertxt_LostFocus(object sender, EventArgs e)
        {
            if (this.receiptLineNumbertxt.Text == "")
            {
                this.receiptLineNumbertxt.SetFocus();
                return;
            }
            if (this.receiptLineNumbertxt.Text.Length >0 && this.receiptkeytxt.Text.Length != 10)
            {
                MessageBox.Show("ASN有误");
                this.receiptkeytxt.Focus();
                return;
            }

            if (this.receiptLineNumbertxt.Text.Length == 5 )
            {
                Regex regex = new Regex(@"\d{5}");
                if (regex.IsMatch(receiptLineNumbertxt.Text))
                {
                    int num = Convert.ToInt32(this.receiptLineNumbertxt.Text);
                    if (num > 0)
                    {
                        if (asnbylineres != null && asnbylinereq != null && asnbylinereq.UtilityHeader.receiptLineNumber == this.receiptLineNumbertxt.Text
                            && asnbylineres.UtilityHeader.ASNKey == this.receiptkeytxt.Text
                            && this.storerkeytxt.Text==asnbylineres.UtilityHeader.StorerKey)
                            return;
                        asnskureq = null;
                        asnskures = null;
                        this.call_FLGetASNByLine(this.receiptkeytxt.Text, this.receiptLineNumbertxt.Text, this.loginuser.UserName);
                    }
                    else
                    {
                        MessageBox.Show("行号有误");
                        receiptLineNumbertxt.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("行号有误");
                    receiptLineNumbertxt.Focus();
                }

            }
            else if (this.receiptLineNumbertxt.Text.Length > 0)
            {
                MessageBox.Show("行号有误");
                receiptLineNumbertxt.Focus();
            }
        }

        private void call_FLGetASNByLine(string asn, string linenum,string username)
        {
            //this.Start();
            asnbylinereq = flrs1_req.Utility.CreateByAsnLineNum(asn, linenum, username);
            RequestMessage getasnlinenumrequest = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  asnbylinereq);
            //RequestWorkItem workitem = new RequestWorkItem(getasnlinenumrequest, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(getasnlinenumrequest);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(Response.GetErrorMessage());

                this.asnbylinereq = null;
                this.asnskureq = null;
                this.asnskures = null;
                this.storerkeytxt.Clean();
                this.skutxt.Clean();
                this.receiptkeytxt.SetFocus();
            }
            else
            {
                asnbylineres =  Response.Deserialize<flrs1_res.Utility>();
                this.storerkeytxt.SetText(asnbylineres.UtilityHeader.StorerKey);
                this.receivelinereq.UtilityHeader.storerkey = asnbylineres.UtilityHeader.StorerKey;
                this.receivelinereq.UtilityHeader.sku = asnbylineres.UtilityHeader.Sku;
                this.receivelinereq.UtilityHeader.uom = "EA";
                //this.skutxt.SetText(asnbylineres.UtilityHeader.Sku);
                this.skutxt.Clean();
                this.desctxt.Clean();
                this.packkeytxt.Clean();
                this.idtxt.Clean();
                this.qtytxt.SetText("0");
            }

        }

        private void skutxt_LostFocus(object sender, EventArgs e)
        {
            if (this.skutxt.Text.Length > 0 )
            {
                if (this.skutxt.Text == asnbylineres.UtilityHeader.Sku)
                {
                    if (asnskures != null && asnskureq != null && asnskureq.UtilityHeader.sku == this.skutxt.Text && asnskureq.UtilityHeader.pro == this.receiptkeytxt.Text)
                        return;
                    this.receivelinereq.UtilityHeader.drid = this.dropid;
                    call_FLGetSKUInfoByLine(this.asnbylineres, this.receiptLineNumbertxt.Text);
                }
                else
                {
                    MessageBox.Show(string.Format("sku有误[{0}]",asnbylineres.UtilityHeader.Sku));
                    this.skutxt.Focus();
                }
            }
        }

        private void qtytxt_LostFocus(object sender, EventArgs e)
        {
            if (this.asnskures != null && this.asnbylineres != null && string.IsNullOrEmpty(this.qtytxt.Text))
            {

               // MessageBox.Show("接收数量必填");
               // this.qtytxt.Focus();
            }
            else if (this.asnskures != null && this.asnbylineres != null)
            {
                Regex regex = new Regex(@"^\d+$");
                if (regex.IsMatch(this.qtytxt.Text))
                {
                    int qty = Convert.ToInt32(this.qtytxt.Text);
                    if (qty <= 0)
                    {
                        MessageBox.Show("接收数量>0");
                        this.qtytxt.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("接收数量有误");
                    this.qtytxt.Focus();
                }
            }
        }
        private void idtxt_LostFocus(object sender, EventArgs e)
        {
            this.idtxt.Text = this.idtxt.Text.ToUpper();
            if (this.asnskures != null && this.asnbylineres != null && string.IsNullOrEmpty(this.idtxt.Text))
            {
                //MessageBox.Show("LPN必填");
                //this.idtxt.Focus();
            }
            else if (this.bodypanel.Controls.Count > 1)
            {
                Control filedcontrol=this.bodypanel.Controls[this.bodypanel.Controls.Count - 2];
                rfFieldTextBox rftextbox = (rfFieldTextBox)filedcontrol;
                //filedcontrol.Visible = false;
                rftextbox.FieldTextBox.SetFocus();
            }
            else
            {
                this.bodypanel.Focus();
            }
        }

        private void call_FLGetSKUInfoByLine(flrs1_res.Utility lineres,string linenum)
        {
            //this.Start();
            asnskureq = flrs2_req.Utility.CreateByAsnSku(lineres.UtilityHeader.ASNKey, linenum, lineres.UtilityHeader.Sku, lineres.UtilityHeader.StorerKey);
            RequestMessage getskurequest = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  asnskureq);
            //RequestWorkItem workitem = new RequestWorkItem(getskurequest, 2);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(getskurequest);
             string errormsg = Response.GetErrorMessage();
             if (errormsg != string.Empty)
             {
                 MessageBox.Show(Response.GetErrorMessage());
                 this.skutxt.SetFocus();

             }
             else
             {
                 asnskures =  Response.Deserialize<flrs2_res.Utility>();
                 this.desctxt.SetText(asnskures.UtilityHeader.desc);
                 this.packkeytxt.SetText(asnskures.UtilityHeader.pack);
                 //this.qtytxt.SetText("");
                 //this.uomtxt.SetText(asnskures.UtilityHeader.UOM);

                 setLottableValue(asnskures.UtilityHeader);

                 createLottableControl(asnskures.UtilityHeader);
             }

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(receivelinereq);
            call_FLRFReceiveByLine();
          
           
        }
        private void call_FLRFReceiveByLine()
        {
            
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            //this.Start();
            receivelinereq.UtilityHeader.userid = this.loginuser.UserName;
            receivelinereq.UtilityHeader.drid = receivelinereq.UtilityHeader.drid.ToUpper();
            receivelinereq.UtilityHeader.prokey = receivelinereq.UtilityHeader.receiptkey;
            receivelinereq.UtilityHeader.receiptkey = "";
            if( !string.IsNullOrEmpty(receivelinereq.UtilityHeader.drid)){
                this.dropid = receivelinereq.UtilityHeader.drid;
            }

            RequestMessage receiverequest = new RequestMessage(enumRequestType.MessageProcessor,
                 enumMessageType.Utility,
                 enumRequestMethod.functionOperation, this.loginuser,
                 enumSendSysId.External,
                 receivelinereq);
            //RequestWorkItem workitem = new RequestWorkItem(receiverequest, 3);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(receiverequest);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(Response.GetErrorMessage());
                this.receiptLineNumbertxt.SetFocus();
                //if (errormsg.IndexOf("ID has already been used") >= 0)
                //{
                //    this.idtxt.SetFocus();
                //}
                //else if (errormsg.IndexOf("Received Qty > Expected Qty") > 0)
                //{
                //    this.qtytxt.SetFocus();
                //}
                //else
                //{
                //    this.receiptkeytxt.SetFocus();
                //}

            }
            else
            {
                receivelineres =  Response.Deserialize<flrs3_res.Utility>();
                string receiptkey = receivelineres.UtilityHeader.prokey;
                this.receivelinereq = new flrs3_req.Utility();

                this.receivelinereq.UtilityHeader.prokey = receivelineres.UtilityHeader.prokey;
                this.receivelinereq.UtilityHeader.receiptkey = receivelineres.UtilityHeader.prokey;
                this.receivelinereq.UtilityHeader.drid = this.dropid;
                this.asnbylinereq = null;
                this.asnbylineres = null;
                this.asnskureq = null;
                this.asnskures = null;
                this.receivelineres = null;
                this.desctxt.Clean();
                //InvokeHelper.Invoke(this, "dataBinding", null);
                this.storerkeytxt.Clean();
                this.skutxt.Clean();
                this.desctxt.Clean();
                this.qtytxt.Clean();
                this.loctxt.Clean();
                this.idtxt.Clean();
                this.packkeytxt.Clean();
                this.dataBinding();
                

                //MessageBox.Show("收货完成");
                this.receiptkeytxt.SetFocus();
                //InvokeHelper.Invoke(this, "call_asnlist01", receiptkey);
                this.call_asnlist01(receiptkey);
            }
        }
      
        
        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.receiptkeytxt.Text.Length != 10)
            {
                
                errortxt += "收货单号错误";
                focusControl = this.receiptkeytxt;
                
            }
            if (this.receiptLineNumbertxt.Text.Length != 5)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.receiptLineNumbertxt;
                errortxt += "行号错误";
                

            }
            if (this.storerkeytxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.storerkeytxt;
                errortxt += "货主必填";
                
            }
            if (this.skutxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.skutxt;
                errortxt += "sku必填";
                
            }
            if (this.packkeytxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.packkeytxt;
                errortxt += "包装必填";
                
            }
            if (this.qtytxt.Text.Length == 0 || Convert.ToInt32(this.qtytxt.Text)==0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.qtytxt;
                errortxt += "收货数量必须大于0";
               
            }
            if (this.loctxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.loctxt;
                errortxt += "库位必填";
                
            }
            if (this.idtxt.Text.Length == 0)
            {
                if (string.IsNullOrEmpty(errortxt))
                    focusControl = this.idtxt;
                errortxt += "LPN必填";
                
            }
            foreach (Control item in this.bodypanel.Controls)
            {
                if (item is rfFieldTextBox)
                {
                    if (string.IsNullOrEmpty(errortxt))
                        focusControl = item;
                    rfFieldTextBox field = (rfFieldTextBox)item;
                    errortxt += field.Validate();
                    
                }
            }
           
            return errortxt;
        }


        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
           
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode ==( Keys.LButton | Keys.MButton | Keys.ShiftKey | Keys.Space | Keys.F17))
            {
                call_FLRFReceiveByLine();
            }
            base.OnKeyDown(e);

        }

        private void submitdrid_Click(object sender, EventArgs e)
        {
            DialogResult result;
            using (Inputdridfrm inputfrm = new Inputdridfrm())
            {
                result = inputfrm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // login was successful
                    string dridstr = inputfrm.inputidtxt.Text.ToUpper();
                    call_NSPRFRCC01E(dridstr);
                    this.dropid = string.Empty;
                    
                }
            }
        }



        private void call_NSPRFRCC01E(string drid)
        {
            drid_req.Utility dridreq = drid_req.Utility.CreateByDrId(drid);
            
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                 enumMessageType.Utility,
                 enumRequestMethod.functionOperation, this.loginuser,
                 enumSendSysId.External,
                 dridreq);
            //RequestWorkItem workitem = new RequestWorkItem(request, 4);
            //threadhelper.AddWorkItem(workitem);
           ResponseMessage response= ThreadHelper.Execute(request);
           string errormsg = response.GetErrorMessage();
             if (errormsg != string.Empty)
             {
                 MessageBox.Show(response.GetErrorMessage());
             }
             else
             {
                 drid_res.Utility dridres = response.Deserialize<drid_res.Utility>();
                 this.call_NSPRFRC01E(dridres.UtilityHeader.tag, dridres.UtilityHeader.storer, dridres.UtilityHeader.Sku);
             }
        }

        private void call_NSPRFRC01E(string drid,string storekey,string sku)
        {
            drid_req1.Utility dridreq1 = drid_req1.Utility.CreateBy(drid, storekey, sku, this.loginuser.UserName);
            dridreq1.UtilityHeader.userid = this.loginuser.UserName;
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                 enumMessageType.Utility,
                 enumRequestMethod.functionOperation, this.loginuser,
                 enumSendSysId.External,
                 dridreq1);
            //RequestWorkItem workitem = new RequestWorkItem(request, 5);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage response = ThreadHelper.Execute(request);
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(response.GetErrorMessage());
            }
            else
            {
                MessageBox.Show("载具已经提交.");
                this.receiptkeytxt.SetFocus();
            }
        }

        public void call_asnlist01(string receiptkey)
        {
            asnlistreq = asnlist_req.AdvancedShipNotice.CreateByReceiptKey(receiptkey,"");
            RequestMessage request = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.AdvancedShipNotice,
                  enumRequestMethod.listHead, this.loginuser,
                  enumSendSysId.EXceed,
                  asnlistreq);
            RequestWorkItem workitem = new RequestWorkItem(request, 10);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(request);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(Response.GetErrorMessage());
            }
            else
            {
                asnlistres =Response.Deserialize<asnlist_res.AdvancedShipNotice>();
                if (asnlistres.AdvancedShipNoticeHeaders.Count > 0)
                {
                    string status = asnlistres.AdvancedShipNoticeHeaders[0].Status;
                    if (status == "9" || status == "11" || status == "15")
                    {
                        MessageBox.Show("该ASN已经收货完成.");
                        this.receiptkeytxt.Clean();
                        this.receiptLineNumbertxt.Clean();
                    }
                    else
                    {
                        //MessageBox.Show("该行收货完成.");
                        this.receiptLineNumbertxt.SetFocus();
                    }

                }
            }
        }

        private void RFLottableReciptFrm_Load(object sender, EventArgs e)
        {

        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {
           

        }
       
    }
}

