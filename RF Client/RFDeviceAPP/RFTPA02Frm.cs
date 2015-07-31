using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;
using tpa00_res = RFDeviceAPP.Common.NSPRFTPA00.Response;
using RFDeviceAPP.Proxy;
using tpa02_req = RFDeviceAPP.Common.NSPRFTPA02.Request;
using tpa02_res = RFDeviceAPP.Common.NSPRFTPA02.Response;

namespace RFDeviceAPP
{
    public partial class RFTPA02Frm : Form
    {
        private UserInfo loginuser;
        private Dictionary<string, string> packkeylist;
        private Dictionary<string, tpa00_res.UtilityHeader> headerlist;
        private tpa00_res.Utility tpa00res;
        private tpa02_req.Utility tpa02req;
        private tpa02_res.Utility tpa02res;
        public Dictionary<string, tpa00_res.UtilityHeader> HeaderList
        {
            get { return headerlist; }
        }
        public string ToLoc {
            get { return this.toloc2.Text; }
            
        }
        public string Reason
        {
            get {
                if (this.toloc1.Text != this.toloc2.Text)
                {
                    return "NOFIT";
                    //return "";
                }
                else
                {
                    return "";
                }
            }
        }
        public RFTPA02Frm(UserInfo loginuser, tpa00_res.Utility tpa00res, string toloc, Dictionary<string, string> packkeylist)
             
        {
            InitializeComponent();
            this.loginuser = loginuser;
            this.toloc1.Text = toloc;
            this.tpa00res = tpa00res;
            this.lpnlist.Items.Clear();
            this.packkeylist = packkeylist;
            databind();

            this.lpn.SetFocus();
             
        }
        private void databind()
        {
            headerlist = new Dictionary<string, RFDeviceAPP.Common.NSPRFTPA00.Response.UtilityHeader>();
            foreach (tpa00_res.UtilityHeader header in tpa00res.UtilityHeaders)
            {
                string line = string.Format("{0} {1}", header.FromId, header.Qty);
                this.lpnlist.Items.Add(line);
                if (!headerlist.ContainsKey(header.FromId))
                headerlist.Add(header.FromId, header);
            }
            this.setLpnCount(this.lpnlist.Items.Count);
            
        }
        private void setLpnCount(int count)
        {
            this.lpncount.Text = string.Format("一共有 {0} 个LPN", count);
        }
       
        private bool CheckIN(string lpn)
        {
            return this.headerlist.ContainsKey(lpn);
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.toloc1.Text) || string.IsNullOrEmpty(this.toloc2.Text)){
                MessageBox.Show("至储位不能为空","提示");
            }else{
                if (string.IsNullOrEmpty(this.lpn.Text))
                {
                    this.lpn.SetFocus();
                    MessageBox.Show("请输入LPN","提示");
                }
                else
                {
                    if (!CheckIN(this.lpn.Text))
                    {
                        MessageBox.Show("LPN不存在", "提示");
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void submitsingle_Click(object sender, EventArgs e)
        {
            if (this.lpn.Text.Length == 0)
            {
                MessageBox.Show("请输入LPN");
                this.lpn.SetFocus();
                return;
            }
            
            if (!headerlist.ContainsKey(this.lpn.Text))
            {
                MessageBox.Show("LPN没有找到");
                this.lpn.SetFocus();
                return;
            }
            tpa00_res.UtilityHeader header = headerlist[this.lpn.Text];
            string packkey = packkeylist[header.FromId];
            this.tpa02req = tpa02_req.Utility.Create(this.loginuser.UserName, header.TaskDetailKey, header.FromLoc, header.FromId, this.ToLoc, header.FromId, header.Qty, packkey, "EA", this.Reason);

            RequestMessage requestmessage = new RequestMessage(enumRequestType.MessageProcessor,
                  enumMessageType.Utility,
                  enumRequestMethod.functionOperation, this.loginuser,
                  enumSendSysId.EXceed,
                  this.tpa02req);
            ResponseMessage response=  ThreadHelper.Execute(requestmessage);
            string errormsg = response.GetErrorMessage();
            if (errormsg != string.Empty)
            {

                MessageBox.Show(errormsg);

            }
            else
            {
                MessageBox.Show("上架完成");
                deleteitem(this.lpn.Text);
                headerlist.Remove(this.lpn.Text);
                this.lpn.Clean();
                this.toloc2.Clean();
                this.lpn.SetFocus();
            }

        }
        private void deleteitem(string lpn)
        {
            for (int i = 0; i < this.lpnlist.Items.Count; i++)
            {
                object item = this.lpnlist.Items[i];
                string line = (string)item;
                if (line.IndexOf(lpn) >= 0)
                {
                    this.lpnlist.Items.Remove(item);
                    break;
                }
            }


            this.setLpnCount(this.lpnlist.Items.Count);
        }

        private void toloc2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RFTPA02Frm_Load(object sender, EventArgs e)
        {
            this.lpn.SetFocus();
        }
    }
}

