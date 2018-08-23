using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KanbanRF
{
    public partial class checkFrm : Form
    {
        private string _user;
        WebReference.WebService ws = new KanbanRF.WebReference.WebService();
        public checkFrm(string user)
        {
            InitializeComponent();
            _user = user;
            this.kanbantxt.Focus();
            kanbantxt.KeyDown += new KeyEventHandler(kanbantxt_KeyDown);
        }

        void kanbantxt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.button1.Focus();
            }
        }

        private void kanbantxt_LostFocus(object sender, EventArgs e)
        {
            if(kanbantxt.Text.Length>0)
                Check();
        }
        private void Check() {
            string msg = ws.CheckIn(this.kanbantxt.Text, _user);
            MessageBox.Show(msg);
            this.kanbantxt.Text = "";
            this.kanbantxt.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kanbantxt.Text.Length > 0)
                Check();
            else
            {
                MessageBox.Show("请输入看板号");
                this.kanbantxt.Focus();
            }
        }
    }
}