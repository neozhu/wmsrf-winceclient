using System;

using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RFDeviceAPP.Common
{
    public class rfLabel:Label
    {
        public rfLabel():base()
        {
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.Size = new System.Drawing.Size(100, 17);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            
            base.OnPaint(e);
        }
        
    }
}
