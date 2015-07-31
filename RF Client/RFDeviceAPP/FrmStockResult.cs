using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RFDeviceAPP
{
    public partial class FrmStockResult : Form
    {
        public FrmStockResult(RFDeviceAPP.Common.NSPRFIQ01.Response.Utility result)
        {
            InitializeComponent();
            this.databinding(result.UtilityHeaders);
        }
        private void databinding(List<RFDeviceAPP.Common.NSPRFIQ01.Response.UtilityHeader> list)
        {
            this.dataGridTableStyle1.MappingName = list.GetType().Name;
            this.dataGrid1.TableStyles.Clear();
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            this.dataGrid1.DataSource = list;
          
            
        }
        private void FrmStockResult_Load(object sender, EventArgs e)
        {

        }

        private void dataGrid1_DoubleClick(object sender, EventArgs e)
        {
           int idx=  this.dataGrid1.CurrentRowIndex;
           
        }
    }
}