using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RFDeviceAPP
{
    public partial class Inputdridfrm : Form
    {
        public Inputdridfrm()
        {
            InitializeComponent();
             
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.inputidtxt.Text))
            {
                MessageBox.Show("请输入落放ID");
                this.inputidtxt.SetFocus();
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