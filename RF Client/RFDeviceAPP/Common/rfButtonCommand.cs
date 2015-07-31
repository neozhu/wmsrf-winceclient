using System;

using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using RFDeviceAPP.Proxy;

namespace RFDeviceAPP.Common
{
    public class rfButtonCommand:Button
    {
        public rfButtonCommand()
        {
            //this.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
             //           | System.Windows.Forms.AnchorStyles.Right)));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //this.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            //            | System.Windows.Forms.AnchorStyles.Right)));
            //this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            base.OnPaint(e);
        }
        

        protected override void OnKeyDown(KeyEventArgs e)
        {
             if ((e.KeyCode == Keys.Enter)){
                 base.OnClick(e);
             }
             //this.Parent.SelectNextControl((Control)this, true, true, true, true);

             if (e.KeyCode == Keys.Up)
             {
                 if (this.Parent is Panel)
                 {
                     if (this.Parent.Parent is Panel)
                         this.Parent.Parent.Parent.SelectNextControl((Control)this, false, true, true, true);
                     else
                        this.Parent.Parent.SelectNextControl((Control)this, false, true, true, true);
                 }
                 else
                 {
                     this.Parent.SelectNextControl((Control)this, false, true, true, true);
                 }
             }
             else if (e.KeyCode == Keys.Down)
             {
                 if (this.Parent is Panel)
                 {
                     if (this.Parent.Parent is Panel)
                         this.Parent.Parent.Parent.SelectNextControl((Control)this, true, true, true, true);
                     else
                     this.Parent.Parent.SelectNextControl((Control)this, true, true, true, true);
                 }
                 else
                 {
                     this.Parent.SelectNextControl((Control)this, true, true, true, true);
                 }
             }

            base.OnKeyDown(e);
        }


        public void SetEnabled(bool val)
        {
            if (this.InvokeRequired)
            {
                InvokeHelper.Invoke(this, "SetEnabled", val);
            }
            else
            {
                this.Enabled = val;
            }
        }
    }
}
