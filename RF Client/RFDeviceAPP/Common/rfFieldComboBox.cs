using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Proxy;

namespace RFDeviceAPP.Common
{
    public partial class rfFieldComboBox : UserControl
    {
        public rfFieldComboBox(string label, string text,int tab)
            : this(label,text)
        {
            this.FieldComboBox.TabIndex = tab;
        }
        public rfFieldComboBox(string label, string text):this()
        {
            this.fieldLabel.Text = label;
            this.FieldComboBox.Text = text;
        }
        public rfFieldComboBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: Add custom paint code here

            // Calling the base class OnPaint
            base.OnPaint(pe);
        }


        public void SetText(string text)
        {
            if (this.InvokeRequired)
            {
                InvokeHelper.Set(this.FieldComboBox, "Text", text);
            }
            else
            {
                this.FieldComboBox.Text = text;
            }
        }
        public string GetText()
        {
            if (this.InvokeRequired)
            {
                return InvokeHelper.Get(this.FieldComboBox, "Text").ToString();
            }
            else
            {
                return this.FieldComboBox.Text;
            }
        }
        public void Clean()
        {
            if (this.InvokeRequired)
            {
                InvokeHelper.Set(this.FieldComboBox, "Text", string.Empty);
            }
            else
            {
                this.FieldComboBox.Text = string.Empty;
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
                this.FieldComboBox.DataBindings.Clear();
                this.FieldComboBox.DataBindings.Add("Text", dataSource, dataMember, true);
            }
            //InvokeHelper.Invoke(this, "binding", dataSource, dataMember);
            
        }
        public object DataSource
        {
            set {
                InvokeHelper.Set(this.FieldComboBox, "DataSource", value);
              
            }
            get {
               return InvokeHelper.Get(this.FieldComboBox, "DataSource");
            }
        }
        public string DisplayMember
        {
            set {
                InvokeHelper.Set(this.FieldComboBox, "DisplayMember", value);
                  }
            get
            {
                return InvokeHelper.Get(this.FieldComboBox, "DisplayMember").ToString();
            }
        }
        public string ValueMember
        {
            set
            {
                InvokeHelper.Set(this.FieldComboBox, "ValueMember", value);
            }
            get
            {
                return InvokeHelper.Get(this.FieldComboBox, "ValueMember").ToString();
            }
        }
        //public void binding(object dataSource, string dataMember)
        //{
        //    this.fieldTextBox.DataBindings.Clear();
        //    this.fieldTextBox.DataBindings.Add("Text", dataSource, dataMember, true);

        //}
    }
}
