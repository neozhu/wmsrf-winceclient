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
    public partial class rfFieldTextBox : UserControl
    {

        private object _datasource;
        private string _datamember;
        public rfFieldTextBox(string label, string text,int tab,bool isRequired)
            : this(label,text)
        {
            this.FieldTextBox.TabIndex = tab;
            this.isRequired = isRequired;
            this.FieldTextBox.TextChanged += new EventHandler(FieldTextBox_TextChanged);
        }

        void FieldTextBox_TextChanged(object sender, EventArgs e)
        {
            //this.DataBinding(_datasource, _datamember);
        }
        public rfFieldTextBox(string label, string text):this()
        {
            this.fieldLabel.Text = label;
            this.FieldTextBox.Text = text;
        }
        public rfFieldTextBox()
        {
            InitializeComponent();
           
        }
        private bool isRequired;

        public bool IsRequired
        {
            get { return isRequired; }
            set { isRequired = value; }
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: Add custom paint code here

            // Calling the base class OnPaint
            base.OnPaint(pe);
        }

        public void SetLabel(string text)
        {
            if (this.InvokeRequired)
            {
                InvokeHelper.Set(this.fieldLabel, "Text", text);
            }
            else
            {
                this.fieldLabel.Text = text;
            }
        }
        public void SetText(string text)
        {
            if (this.InvokeRequired)
            {
                InvokeHelper.Set(this.FieldTextBox, "Text", text);
            }
            else
            {
                this.FieldTextBox.Text = text;
            }
        }
        public string GetText()
        {
            if (this.InvokeRequired)
            {
                return InvokeHelper.Get(this.FieldTextBox, "Text").ToString();
            }
            else
            {
                return this.FieldTextBox.Text;
            }
        }
        public void Clean()
        {
            if (this.InvokeRequired)
            {
                InvokeHelper.Set(this.FieldTextBox, "Text", string.Empty);
            }
            else
            {
                this.FieldTextBox.Text = string.Empty;
            }
        }
        public void DataBinding(object dataSource, string dataMember)
        {
            this._datamember = dataMember;
            this._datasource = dataSource;
            //this.fieldTextBox.DataBindings.Clear();
            //this.fieldTextBox.DataBindings.Add("Text", dataSource, dataMember, true);
            if (this.InvokeRequired)
            {
                InvokeHelper.Invoke(this, "DataBinding", dataSource, dataMember);
            }
            else
            {
                this.FieldTextBox.DataBindings.Clear();
                this.FieldTextBox.DataBindings.Add("Text", dataSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged,string.Empty);
            }
            //InvokeHelper.Invoke(this, "binding", dataSource, dataMember);
            
        }

        public string Validate( ){
            if (this.isRequired)
            {
                if (this.FieldTextBox.Text.Trim() == string.Empty)
                {
                    return this.fieldLabel.Text + "必填";
                }
            }
            return string.Empty;
        }
        //public void binding(object dataSource, string dataMember)
        //{
        //    this.fieldTextBox.DataBindings.Clear();
        //    this.fieldTextBox.DataBindings.Add("Text", dataSource, dataMember, true);

        //}
    }
}
