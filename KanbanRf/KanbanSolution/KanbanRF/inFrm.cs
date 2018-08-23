using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KanbanRF
{
    public partial class inFrm : Form
    {
        private WebReference.WebService ws;
        private string _user;
        public inFrm(string user)
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
                    string success = ws.Inbound(this.kanbantxt.Text, _user);
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
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (kanbantxt.Text.Length > 0)
            {
                string success = ws.Inbound(this.kanbantxt.Text, _user);
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

        private void inFrm_Load(object sender, EventArgs e)
        {
            
        }

         
    }
}