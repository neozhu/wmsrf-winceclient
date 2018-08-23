using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KanbanRF
{
    public partial class shipFrm : Form
    {
        private WebReference.WebService ws;
        private string _user;
        public shipFrm(string user)
        {
            InitializeComponent();
            ws = new KanbanRF.WebReference.WebService();
            this.kanbantxt.Focus();
            _user = user;

            kanbantxt.KeyDown += new KeyEventHandler(kanbantxt_KeyDown);
        }

        void kanbantxt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (kanbantxt.Text.Length > 0)
                {
                    string success = "";
                    //string success = ws.Ship(this.kanbantxt.Text, _user);
                    if (!string.IsNullOrEmpty(success))
                    {
                        MessageBox.Show(success,"错误！");

                    }
                    else
                    {
                        MessageBox.Show("正确");
                    }
                    this.kanbantxt.Text = "";
                    this.kanbantxt.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kanbantxt.Text.Length > 0)
            {
                string success = "";// ws.Ship(this.kanbantxt.Text, _user);
                if (!string.IsNullOrEmpty(success))
                {
                    MessageBox.Show(success, "错误！");

                }
                else
                {
                    MessageBox.Show("正确");
                }
                this.kanbantxt.Text = "";
                this.kanbantxt.Focus();
            }
        }

        private void kanbantxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}