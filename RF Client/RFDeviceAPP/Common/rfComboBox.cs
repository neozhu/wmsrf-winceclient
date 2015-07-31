using System;

using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RFDeviceAPP.Common
{
    public class rfComboBox:System.Windows.Forms.ComboBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            this.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            base.OnPaint(e);
        }
      　
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.Parent.SelectNextControl((Control)this, true, true, true, true);
            }
            //if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
            //{
            //    this.Parent.SelectNextControl(this, false, true, true, true);
            //}
            //else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            //{
            //    this.Parent.SelectNextControl(this, true, true, true, true);
            //}
            base.OnKeyDown(e);
        }
    }
}
