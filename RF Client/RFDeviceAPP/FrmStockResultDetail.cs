using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RFDeviceAPP
{
    public partial class FrmStockResultDetail : Form
    {
        public FrmStockResultDetail(RFDeviceAPP.Common.NSPRFIQ01.Response.Utility result)
        {
            InitializeComponent();
            this.addToList(result.UtilityHeaders);
            this.WindowState = FormWindowState.Maximized;
        }

        private void addToList(List<RFDeviceAPP.Common.NSPRFIQ01.Response.UtilityHeader> list)
        {
            foreach (RFDeviceAPP.Common.NSPRFIQ01.Response.UtilityHeader header in list)
            {

                this.listBox1.Items.Add("货     主:" + header.StorerKey);
                this.listBox1.Items.Add("料     号:" + header.Sku);
                this.listBox1.Items.Add("中文品名:" + header.Descr);
                this.listBox1.Items.Add("      LPN:" + header.ID);
                this.listBox1.Items.Add("储     位:" + header.Loc);
                this.listBox1.Items.Add("数     量:" + header.Qty);
                this.listBox1.Items.Add("------------------------");
            }
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
            }
        }

        private void FrmStockResultDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
            }
        }
    }
}