using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFDeviceAPP.Common;

namespace RFDeviceAPP
{
    public partial class TestForm1 : RFDeviceAPP.baseForm
    {


        private int tabindex;
        private Test _data = new Test();
        public TestForm1()
        {
            InitializeComponent();
            tabindex = 0;
            _data.Filed1 = "test1";
            _data.Filed2 = "myField2";
            this.rfFieldTextBox1.FieldTextBox.DataBindings.Add("Text", _data, "Filed1", true);

            this.rfFieldTextBox2.FieldTextBox.DataBindings.Add("Text", _data, "Filed2", true);
            this.rfFieldTextBox3.FieldTextBox.DataBindings.Add("Text", _data, "Filed3", true);
            this.rfFieldTextBox4.FieldTextBox.DataBindings.Add("Text", _data, "Filed4", true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(_data);
            tabindex++;
            this.Height += 41;
            rfFieldTextBox f1 = new rfFieldTextBox("test(" +tabindex.ToString()+ ")", "test-" +tabindex.ToString() , tabindex,false);
            this.panel2.Controls.Add(f1);
            this.panel2.Controls.SetChildIndex(f1, 0);
            f1.Dock = DockStyle.Top;
            
            this.panel2.Height += 41;
            

            //this.WindowState = FormWindowState.Maximized;
        }

        private void rfButtonCommand1_Click(object sender, EventArgs e)
        {
            BindingSource ds = new BindingSource();
            ds.DataSource= new string[] { "aaaa", "bbbb", "cccc" };
            this.rfFieldComboBox1.DataSource = ds;

            //this._data.Filed1 = DateTime.Now.ToString();
            //this.rfFieldTextBox1.fieldTextBox.DataBindings.Clear();
            //this.rfFieldTextBox1.fieldTextBox.DataBindings.Add("Text", _data, "Filed1", true);
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(test));
            t.Start();
        }
        private void test()
        {
            _data.Filed1 = DateTime.Now.ToString();
            _data.Filed2 = DateTime.Now.ToString();

            this.rfFieldTextBox1.DataBinding(_data, "Filed1");

        }
    }

    public class Test
    {
        private string filed1;

        public string Filed1
        {
            get { return filed1; }
            set { filed1 = value; }
        }
        private string filed2;

        public string Filed2
        {
            get { return filed2; }
            set { filed2 = value; }
        }
        private string filed3;

        public string Filed3
        {
            get { return filed3; }
            set { filed3 = value; }
        }
        private string filed4;

        public string Filed4
        {
            get { return filed4; }
            set { filed4 = value; }
        }
    }
}

