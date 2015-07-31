using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using RFDeviceAPP.Proxy;
using RL02S_req = RFDeviceAPP.Common.NSPRFRL021SO.Request;
using RL02S_res = RFDeviceAPP.Common.NSPRFRL021SO.Response;
using RL021_req = RFDeviceAPP.Common.NSPRFRL021.Request;
using RL021_res = RFDeviceAPP.Common.NSPRFRL021.Response;
using RL02_req = RFDeviceAPP.Common.NSPRFRL02.Request;
using RL02_res = RFDeviceAPP.Common.NSPRFRL02.Response;
namespace RFDeviceAPP
{
    public partial class NSPRFRL021SOFrm : RFDeviceAPP.baseForm
    {
        private RL02S_req.Utility RL02Sreq;
        private RL02S_res.Utility RL02Sres;
        private RL021_req.Utility RL021req;
        private RL021_res.Utility RL021res;
        private RL02_req.Utility RL02req;
        private RL02_res.Utility RL02res;
        private ThreadHelper threadhelper;
        private Control focusControl;
        private List<OrderItem> orderlist;

        public NSPRFRL021SOFrm(UserInfo userinfo)
            : base(userinfo)
        {
            InitializeComponent();
            this.orderkey.Focus();
            this.KeyPreview = true;

            threadhelper = new ThreadHelper();

            threadhelper.AllWorkItemCompleted += new EventHandler(threadhelper_AllWorkItemCompleted);
            threadhelper.WorkItemCompleted += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemCompleted);
            threadhelper.WorkItemFailed += new EventHandler<WorkItemEventArgs>(threadhelper_WorkItemFailed);
        }

        #region threadhelper
        void threadhelper_WorkItemCompleted(object sender, WorkItemEventArgs e)
        {
            /*
            int tag = e.WorkItem.Tag;
            WorkItem item = e.WorkItem;
            string errormsg = item.Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                this.RL02Sreq = null;
                this.RL02Sres = null;
            }
            else
            {
                if (tag == 1)
                {
                    this.RL02Sres = item.Response.Deserialize<RL02S_res.Utility>();
                    if (RL02Sres != null)
                    {
                        foreach (RL02S_res.UtilityHeader header in RL02Sres.UtilityHeaders)
                        {
                            string itemstring = string.Format("{2} {0} {1}", header.DropID, header.Loc,header.OrderKey);
                            if (itemstring.Length > 5)
                            {
                                InvokeHelper.Invoke(this, "adddroplist", itemstring);
                            }
                        }
                        this.toloc.SetFocus();
                    }
                }
                if (tag >= 2 && tag<100)
                {
                    this.RL021res = item.Response.Deserialize<RL021_res.Utility>();
                    RL021_req.Utility req=item.Request.Deserialize<RL021_req.Utility>();

                    InvokeHelper.Invoke(this, "NSPRFRL02", req.UtilityHeader.MovableUnit, this.RL021res.UtilityHeader,tag);
                }
                if (tag >= 100)
                {
                    this.RL02res = item.Response.Deserialize<RL02_res.Utility>();
                    string rectype = this.RL02res.UtilityHeader.rectype;
                    if (tag == 100 + this.droplist.Items.Count + 1)
                    {
                        MessageBox.Show("拣货完成", "提示");
                    }
                }

            }
             */
        }
        void threadhelper_WorkItemFailed(object sender, WorkItemEventArgs e)
        {
            InvokeHelper.Set(this.submitbtn, "Enabled", true);
            MessageBox.Show("Failed" + e.WorkItem.Ex.Message);
            this.orderkey.SetFocus();
        }
        void threadhelper_AllWorkItemCompleted(object sender, EventArgs e)
        {
            InvokeHelper.Set(this.submitbtn, "Enabled", true);
            this.Stop();
        }


        #endregion

        #region call api
        public void call_NSPRFRL021SO()
        {
            //this.Start();
            this.RL02Sreq = RL02S_req.Utility.Create(this.orderkey.Text);

            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.LoginUser,
                  enumSendSysId.EXceed,
                  this.RL02Sreq);
            RequestWorkItem workitem = new RequestWorkItem(requestmessage, 1);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);

           string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                return;

            }
            this.RL02Sres = Response.Deserialize<RL02S_res.Utility>();
            if (RL02Sres != null)
            {
                this.orderlist = new List<OrderItem>();
                foreach (RL02S_res.UtilityHeader header in RL02Sres.UtilityHeaders)
                {
                    if (header.OrderKey.Length > 0)
                    {
                        OrderItem item = new OrderItem();
                        item.Dropid = header.DropID;
                        item.Orderkey = header.OrderKey;
                        item.Loc = header.Loc;
                        if (item.Orderkey.Length > 0)
                        {
                            this.orderlist.Add(item);
                        }
                    }
                    //string itemstring = string.Format("{2} {0} {1}", header.DropID, header.Loc, header.OrderKey);
                    //if (itemstring.Length > 5)
                    //{
                    //    //InvokeHelper.Invoke(this, "adddroplist", itemstring);
                    //    this.adddroplist(itemstring);
                    //}
                }
                this.countlable.Text = string.Format("总数： {0}", this.orderlist.Count);
                this.gridbinding(this.orderlist);
                this.dropid.SetFocus();
            }

        }
        public void NSPRFRL021()
        {
            string errormsg = string.Empty;
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }
            this.submitbtn.Enabled = false;
            //this.Start();
            for (int i = 0; i < this.orderlist.Count; i++)
            {
                //string line = this.droplist.Items[i].ToString();
                //string[] temp = line.Split(new char[] { ' ' });
                string dropid = orderlist[i].Dropid;
                this.RL021req = RL021_req.Utility.Create(dropid);

                RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                      enumMessageType.Utility,
                      enumRequestMethod.functionOperation, this.LoginUser,
                      enumSendSysId.EXceed,
                      this.RL021req);
                //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 2+i);
                //threadhelper.AddWorkItem(workitem);
               ResponseMessage Response = ThreadHelper.Execute(requestmessage);
               errormsg = Response.GetErrorMessage();
              if (errormsg != string.Empty)
              {
                  MessageBox.Show(errormsg);
                  break;
                  
              }
              RL021_res.Utility R021res = Response.Deserialize<RL021_res.Utility>();
              this.NSPRFRL02(this.RL021req.UtilityHeader.MovableUnit, R021res.UtilityHeader, 0);

            }
            this.clean();
            if (string.IsNullOrEmpty(errormsg))
            {
                MessageBox.Show("拣货完成", "提示");
            }
            this.submitbtn.Enabled = true;
        }
        public void NSPRFRL021_1()
        {
            string errormsg = string.Empty;
            string errortxt = this.Vaildate();
            if (errortxt != string.Empty)
            {
                MessageBox.Show(errortxt);
                this.focusControl.Focus();
                return;
            }

            //this.submitbtn.Enabled = false;
            //this.Start();
            string[] list = getdropidlist(this.dropid.Text);
            if (list == null || list.Length == 0)
                return;
            foreach (string pid in list)
            {
                this.RL021req = RL021_req.Utility.Create(pid);

                RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                      enumMessageType.Utility,
                      enumRequestMethod.functionOperation, this.LoginUser,
                      enumSendSysId.EXceed,
                      this.RL021req);
                //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 2+i);
                //threadhelper.AddWorkItem(workitem);
                ResponseMessage Response = ThreadHelper.Execute(requestmessage);
                errormsg = Response.GetErrorMessage();
                if (errormsg != string.Empty)
                {
                    MessageBox.Show(errormsg);
                    return;

                }
                RL021_res.Utility R021res = Response.Deserialize<RL021_res.Utility>();
                
                this.NSPRFRL02(this.RL021req.UtilityHeader.MovableUnit, R021res.UtilityHeader, 0);

            }

            if (string.IsNullOrEmpty(errormsg))
            {
                deleteitem(this.dropid.Text);
                this.gridbinding(this.orderlist);
                this.countlable.Text = string.Format("总数： {0}", this.orderlist.Count);


                if (this.orderlist.Count == 0)
                {
                    this.clean();
                    MessageBox.Show("订单拣货完成", "提示");
                }
                else
                {
                    MessageBox.Show("拣货完成", "提示");
                }
             
               
            }

        }
        private string[] getdropidlist(string loc)
        {
            List<string> strlist = new List<string>();
            for (int i = 0; i < this.orderlist.Count; i++)
            {
                OrderItem item = this.orderlist[i];
                if (item.Dropid == loc || item.Loc == loc)
                {
                    strlist.Add(item.Dropid); 
                }
            }
            return strlist.ToArray();
        }
        private List<OrderItem> CopyForm(List<OrderItem> list,string dropid)
        {
            List<OrderItem> copy = new List<OrderItem>();
            foreach (OrderItem item in list)
            {
                if (!(item.Dropid == dropid || item.Loc == dropid))
                {
                    OrderItem newitem = new OrderItem();
                    newitem.Loc = item.Loc;
                    newitem.Dropid = item.Dropid;
                    newitem.Orderkey = item.Orderkey;
                    copy.Add(newitem);
                }
            }
            return copy;
        }
        private void resetlist(List<OrderItem> list)
        {
            this.orderlist = new List<OrderItem>();

            foreach (OrderItem item in list)
            {
                 
                    OrderItem newitem = new OrderItem();
                    newitem.Loc = item.Loc;
                    newitem.Dropid = item.Dropid;
                    newitem.Orderkey = item.Orderkey;
                    orderlist.Add(newitem);
                 
            }
        }
        private void deleteitem(string dropid)
        {

            resetlist(this.CopyForm(this.orderlist, dropid));
            this.dropid.Clean();
        }
        private OrderItem Find(OrderItem orderitem)
        {
            foreach (OrderItem item in this.orderlist)
            {
                if (item.Dropid == orderitem.Dropid && item.Orderkey == orderitem.Orderkey && item.Loc == orderitem.Loc)
                {
                    return item;
                }
            }
            return null;
        }

        private void clean()
        {
            this.orderkey.Clean();
            this.orderlist=new List<OrderItem>();
            this.toloc.Clean();
        }
        public void NSPRFRL02(string movableunit,RL021_res.UtilityHeader header,int tag)
        {
            
            RL02req = new RFDeviceAPP.Common.NSPRFRL02.Request.Utility();
            RL02req.UtilityHeader.caseid = header.CaseID;
            RL02req.UtilityHeader.desc = header.Descr;
            RL02req.UtilityHeader.fromloc = header.FromLoc;
            RL02req.UtilityHeader.fromtag = header.fromtag;
            RL02req.UtilityHeader.lotnum = header.lotnum;
            RL02req.UtilityHeader.MovableUnit = movableunit;
            RL02req.UtilityHeader.sku = header.Sku;
            RL02req.UtilityHeader.storer = header.storer;
            RL02req.UtilityHeader.toloc = this.toloc.Text;
            RL02req.UtilityHeader.toqty = header.Qty;
            RL02req.UtilityHeader.totag = header.totag;
            RL02req.UtilityHeader.uom = header.UOM;

            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.LoginUser,
                  enumSendSysId.EXceed,
                  this.RL02req);
            //RequestWorkItem workitem = new RequestWorkItem(requestmessage, 100+tag);
            //threadhelper.AddWorkItem(workitem);
            ResponseMessage Response = ThreadHelper.Execute(requestmessage);
            string errormsg = Response.GetErrorMessage();
            if (errormsg != string.Empty)
            {
                MessageBox.Show(errormsg);
                return;

            }
        }
        public string Vaildate()
        {
            string errortxt = string.Empty;
            if (this.orderkey.Text.Length == 0)
            {
                focusControl = this.orderkey;
                errortxt += "订单号或关务流水号必填";
            }
            if (this.orderlist.Count == 0)
            {
                focusControl = this.orderkey;
                errortxt += "没有找到订单";
            }
            if (this.toloc.Text.Length == 0)
            {
                focusControl = this.toloc;
                errortxt += "至储位必填";
            }
            if (this.dropid.Text.Length == 0)
            {
                focusControl = this.toloc;
                errortxt += "箱ID或储位必填";
            }else{
                if (!isexist(this.dropid.Text))
                {
                    focusControl = this.toloc;
                    errortxt += "箱ID或储位不存在";
                }
            }

            return errortxt;
        }

        #endregion

        public void adddroplist(string itemstring)
        {
            //this.droplist.Items.Add(itemstring);
            this.countlable.Text = string.Format("总数： {0}", this.orderlist.Count);
            //this.portlist.SelectedIndex = 0;
        }
        private void orderkey_LostFocus(object sender, EventArgs e)
        {
            if (this.orderkey.Text.Length > 0)
            {
                //this.droplist.Items.Clear();
                if (this.orderlist == null || this.orderlist.Count == 0)
                {
                    call_NSPRFRL021SO();
                }
            }
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            
            NSPRFRL021_1();
        }

        private void NSPRFRL021SOFrm_Load(object sender, EventArgs e)
        {

        }

        private void dropid_LostFocus(object sender, EventArgs e)
        {
            if (this.dropid.Text.Length > 0)
            {
                if (!isexist(this.dropid.Text))
                {
                    MessageBox.Show("输入的箱ID或储位不存在!");
                    
                    return;
                }
            }
        }
        private bool isexist(string dropid)
        {
            foreach (OrderItem item in this.orderlist)
            {
                if (item.Dropid.Equals(dropid) || item.Loc.Equals(dropid))
                {
                    return true;
                }
            }
            return false;
            
        }

        private void gridbinding(List<OrderItem> datalist)
        {
            this.dataGridTableStyle1.MappingName = datalist.GetType().Name;
            this.dataGrid1.DataSource = datalist;
           // this.dataGrid1.datab
        }

         

    }

    public class OrderItem
    {
        public OrderItem()
        {

        }
        private string orderkey;

        public string Orderkey
        {
            get { return orderkey; }
            set { orderkey = value; }
        }
        private string dropid;

        public string Dropid
        {
            get { return dropid; }
            set { dropid = value; }
        }
        private string loc;

        public string Loc
        {
            get { return loc; }
            set { loc = value; }
        }
    }
}
