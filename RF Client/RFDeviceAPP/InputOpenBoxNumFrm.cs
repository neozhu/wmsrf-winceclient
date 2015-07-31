using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RFDeviceAPP
{
    public partial class InputOpenBoxNumFrm : Form
    {
        public InputOpenBoxNumFrm()
        {
            InitializeComponent();


          
        }
        public string inputBox
        {
            get { return this.qtytxt.Text; }
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.qtytxt.Text))
            {
                MessageBox.Show("请输入开箱数");
                this.qtytxt.SetFocus();
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}