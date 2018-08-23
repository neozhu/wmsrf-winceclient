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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void outbutton_Click(object sender, EventArgs e)
        {
            if (this.usertxt.Text.Length == 0)
            {
                MessageBox.Show("请输入操作员");
                this.usertxt.Focus();
            }
            else {
                outFrm frm = new outFrm(this.usertxt.Text);
                frm.Show();
                frm.Activate();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void inbutton_Click(object sender, EventArgs e)
        {
            if (this.usertxt.Text.Length == 0)
            {
                MessageBox.Show("请输入操作员");
                this.usertxt.Focus();
            }
            else
            {
                inFrm frm = new inFrm(this.usertxt.Text);
                frm.Show();
                frm.Activate();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void querybtn_Click(object sender, EventArgs e)
        {
            queryFrm frm = new queryFrm(this.usertxt.Text);
            frm.Show();
            frm.Activate();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            if (this.usertxt.Text.Length == 0)
            {
                MessageBox.Show("请输入操作员");
                this.usertxt.Focus();
            }
            else
            {
                checkFrm frm = new checkFrm(this.usertxt.Text);
                frm.Show();
                frm.Activate();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (this.usertxt.Text.Length == 0)
            {
                MessageBox.Show("请输入操作员");
                this.usertxt.Focus();
            }
            else
            {
                updateFrm frm = new updateFrm(this.usertxt.Text);
                frm.Show();
                frm.Activate();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.usertxt.Text.Length == 0)
            {
                MessageBox.Show("请输入操作员");
                this.usertxt.Focus();
            }
            else
            {
                shipFrm frm = new shipFrm(this.usertxt.Text);
                frm.Show();
                frm.Activate();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.usertxt.Text.Length == 0)
            {
                MessageBox.Show("请输入操作员");
                this.usertxt.Focus();
            }
            else
            {
                loadFrm frm = new loadFrm(this.usertxt.Text);
                frm.Show();
                frm.Activate();
                frm.WindowState = FormWindowState.Maximized;
            }
        }
    }
}