using System;

using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Proxy;

namespace RFDeviceAPP.Common
{
    public class rfPanel:Panel
    {
        public void AddControl(Control control)
        {
            if (this.InvokeRequired)
            {
                InvokeHelper.Invoke(this, "AddControl", control);
            }
            else
            {
                this.Controls.Add(control);
                this.Controls.SetChildIndex(control, 0);
            }
        }
    }
}
