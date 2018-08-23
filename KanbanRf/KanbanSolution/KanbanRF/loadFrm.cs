using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KanbanRF
{
    public partial class loadFrm : Form
    {
        private string _user;
        WebReference.WebService ws = new KanbanRF.WebReference.WebService();
        public loadFrm(string user)
        {
            InitializeComponent();
            this._user = user;
            loadorder();
            this.platnumbertxt.KeyDown += new KeyEventHandler(platnumbertxt_KeyDown);
            this.kanbantxt.KeyDown += new KeyEventHandler(kanbantxt_KeyDown);
        }

        void kanbantxt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (this.kanbantxt.Text.Length > 0) {
                    string kanban = this.kanbantxt.Text;
                    bool ok = getkanban(kanban);
                    if (ok)
                    {
                        this.listBox2.Items.Add(kanban);
                        addkanban(kanban);
                    }
                    this.kanbantxt.Text = "";
                    this.kanbantxt.Focus();
                }
            }
        }

        void platnumbertxt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.kanbantxt.Focus();
            }
        }
        private string getdesc(int status)
        {
            if (status == 0)
            {
                return "新增";
            }
            else if (status == 5)
            {
                return "装车";
            }
            else if (status == 7) {
                return "终止";
            }
            else if (status == 9)
            {
                return "总装交接";
            }
            else
            {
                return status.ToString();
            }
        }
        public bool getkanban(string kanbanno)
        {
            foreach (object item in this.listBox2.Items)
            {
                if (item.ToString() == kanbanno) {
                    MessageBox.Show("该看板号已经装载");
                    return false;
                }
            }

            WebReference.Kanban kanban = ws.Get(kanbanno);
            if (kanban == null)
            {
                MessageBox.Show(string.Format("没有找到该看板号{0},请重新输入", kanbanno));
                return false;
            }
            if (kanban.Status == 0 || kanban.Status == 3)
            {
                return true;
            }
            
            else
            {
                MessageBox.Show(string.Format("该看板号不符合装载\r\n当前状态:{0}-时间【{1}】,请重新输入", getdesc(kanban.Status), kanban.CheckDate.ToString("MM-dd HH:mm")));
                return false;
            }
        }
        public void loadorder(){
            this.listBox1.Items.Clear();
            WebReference.Order[] orders = ws.GetOrder(0, this._user);
            foreach (WebReference.Order order in orders) {
                string len = string.Format("{0} {1} {2}", order.OrderNo, order.PlateNumber, order.OrderDate.ToString("MM-dd HH:mm"));
                this.listBox1.Items.Add(len);
            }
            this.listBox2.Items.Clear();
            this.ordernotxt.Text = "";
            this.kanbantxt.Text = "";
            this.platnumbertxt.Text = "";
            
        }
        public void createorder() {
            string orderno = ws.CreateOrder(this._user);
            this.ordernotxt.Text = orderno;
            this.listBox1.Items.Insert(0, string.Format("{0}  {1}  {2}", orderno, "", DateTime.Now.ToString("MM-dd HH:mm")));
        }
        public void endload() {


            string result = ws.EndLoad(this.ordernotxt.Text);
            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show(result, "错误！");
                return;
            }
            else
            {
                MessageBox.Show("正确");
                this.loadorder();
            }
             
        }
        public void addkanban(string kanbanno) {
            string[] kbs = new string[] { kanbanno };

            string result = ws.LoadKanban(this.ordernotxt.Text, this.platnumbertxt.Text, kbs, this._user);
            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show(result, "错误！");
            }
            else
            {
                MessageBox.Show(string.Format("{0}正确", kanbanno)); 
            }
        }
        public void loadkanban() {
            if (this.listBox2.Items.Count > 0 && this.ordernotxt.Text.Length > 0)
            {
                List<string> kbs = new List<string>();
                foreach (object kb in this.listBox2.Items)
                {
                    kbs.Add(kb.ToString());
                }


                string result = ws.LoadKanban(this.ordernotxt.Text, this.platnumbertxt.Text, kbs.ToArray(), this._user);
                if (!string.IsNullOrEmpty(result))
                {
                    MessageBox.Show(result,"错误！");
                }
                else
                {
                    MessageBox.Show("正确");
                    this.kanbantxt.Text = "";
                    this.kanbantxt.Focus();
                    this.listBox2.Items.Clear();
                }
            }
            else {
               // MessageBox.Show("本次装载完成");
            }
            
        }
        private void createbtn_Click(object sender, EventArgs e)
        {
            this.createorder();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = this.listBox1.SelectedItem.ToString();
            string[] strarr = item.Split(new char[] { ' ' });
            this.ordernotxt.Text = strarr[0];
            this.platnumbertxt.Text = strarr[1];
            this.platnumbertxt.Focus();
        }

        private void listBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete))
            {
                //if(this.listBox2.SelectedIndex>=0)
               // this.listBox2.Items.RemoveAt(this.listBox2.SelectedIndex);
            }
        }

        private void endbutn_Click(object sender, EventArgs e)
        {
            this.endload();
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            this.loadkanban();
        }
    }
}