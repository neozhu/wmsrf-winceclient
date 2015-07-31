using System;

using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RFDeviceAPP.Proxy;
 
namespace RFDeviceAPP.Common
{
    public class rfTextBox : TextBox
    {
       
        protected override void OnPaint(PaintEventArgs e)
        {
            this.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.Size = new System.Drawing.Size(231, 23);
            base.OnPaint(e);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //if (e.KeyChar == '\r')//ENTER键
            //{

            //    keybd_event(9, 0, 0, 0);//TAB键 KeyCode为9
            //}
            //if (char.IsLower(e.KeyChar))
            //{
            //    e.KeyChar = char.ToUpper(e.KeyChar);
                  
            //}
            base.OnKeyPress(e);
        }
        public void SetFocus()
        {
            if (this.InvokeRequired)
            {
                InvokeHelper.Invoke(this, "SetFocus", null);
            }
            else
            {
                this.Focus();
            }
        }
        public void SetReadOnly(bool val)
        {
            if (this.InvokeRequired)
            {
                InvokeHelper.Invoke(this, "SetReadOnly", val);
            }
            else
            {
                this.ReadOnly = val;
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (this.Parent is rfFieldTextBox)
                {
                    this.Parent.Parent.SelectNextControl((Control)this, true, true, true, true);
                }
                else
                {
                    this.Parent.SelectNextControl((Control)this, true, true, true, true);
                }
            }
            if (e.KeyCode == Keys.Up )
            {
                if (this.Parent is rfFieldTextBox)
                {
                    this.Parent.Parent.SelectNextControl((Control)this, false, true, true, true);
                }
                else
                {
                    this.Parent.SelectNextControl((Control)this, false, true, true, true);
                }
            }
            else if (e.KeyCode == Keys.Down )
            {
                if (this.Parent is rfFieldTextBox)
                {
                    this.Parent.Parent.SelectNextControl((Control)this, true, true, true, true);
                }
                else
                {
                    this.Parent.SelectNextControl((Control)this, true, true, true, true);
                }
            }
            base.OnKeyDown(e);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            //this.Parent.SelectNextControl(this, false, true, true, true);
            base.OnTextChanged(e);
        }
        protected override void OnGotFocus(EventArgs e)
        {
            this.SelectAll();
            base.OnGotFocus(e);
        }

        public void SetText(string text)
        {
            if (this.InvokeRequired)
            {
                InvokeHelper.Set(this,"Text",text);
            }
            else
            {
                this.Text = text;
            }
        }
        public string GetText( )
        {
            if (this.InvokeRequired)
            {
               return InvokeHelper.Get(this, "Text").ToString();
            }
            else
            {
                return this.Text ;
            }
        }
        public void Clean()
        {
            if (this.InvokeRequired)
            {
                InvokeHelper.Set(this, "Text", string.Empty);
            }
            else
            {
                this.Text = string.Empty;
            }
        }
        public void DataBinding(object dataSource, string dataMember)
        {
            //this.fieldTextBox.DataBindings.Clear();
            //this.fieldTextBox.DataBindings.Add("Text", dataSource, dataMember, true);
            if (this.InvokeRequired)
            {
                InvokeHelper.Invoke(this, "DataBinding", dataSource, dataMember);
            }
            else
            {
                this.DataBindings.Clear();
                this.DataBindings.Add("Text", dataSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged);
            }
            //InvokeHelper.Invoke(this, "binding", dataSource, dataMember);

        }
        
        //[DllImport("Coredll.dll", EntryPoint = "keybd_event")]
        //public static extern void keybd_event(
        //byte bVk,
        //byte bScan,
        //int dwFlags,
        //int dwExtraInfo
        //);
    }
}
