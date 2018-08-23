using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KanbanRF
{
    public partial class queryFrm : Form
    {
        private string _user;
        WebReference.WebService ws = new KanbanRF.WebReference.WebService();
        public queryFrm(string user)
        {
            InitializeComponent();
            _user = user;
            this.skutxt.Focus();
            skutxt.KeyDown += new KeyEventHandler(skutxt_KeyDown);
        }

        void skutxt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (skutxt.Text.Length > 0)
                {
                   
                    query();
                    this.button1.Focus();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.skutxt.Text.Length > 0)
            {
                query();
            }
        }
        private void query() {
            this.listBox1.Items.Clear();
            decimal sum = 0;
            int status =5;
            if(this.radioButton1.Checked)
                status=6;
            else if (this.radioButton3.Checked)
                status = 5 ;
            else
                status=9;
            WebReference.Kanban[] list =  ws.Query(this.skutxt.Text, status);
            if (list != null)
            {
                foreach(WebReference.Kanban item in list){
                    sum += item.Qty;
                    string line = string.Format("{0}  {3}  {1}  {2}", item.KanbanNo, item.StorereKey, item.SKU, item.Qty);
                    this.listBox1.Items.Add(line);
                }
            }

            this.total.Text = "汇总 ： " + sum.ToString();
        }

        private void skutxt_LostFocus(object sender, EventArgs e)
        {
            if (this.skutxt.Text.Length > 0)
            {
                this.button1.Focus();
            }
        }

        private void skutxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}