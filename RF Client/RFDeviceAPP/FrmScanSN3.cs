using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Proxy;
using RFDeviceAPP.Common;

namespace RFDeviceAPP
{
    public partial class FrmScanSN3 : RFDeviceAPP.baseForm
    {
        public FrmScanSN3(Common.UserInfo loginuser, string orderkey, string sku)
            : base(loginuser)
        {
            InitializeComponent();
        }
    }
}