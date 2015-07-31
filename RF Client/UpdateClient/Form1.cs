using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace UpdateClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void updatebt_Click(object sender, EventArgs e)
        {
            decimal ver=getupdateversion();
            if (ver > getVersion())
            {
                byte[] binfile = getUpdate();
                Update(binfile);
                updatever(ver);
                MessageBox.Show("更新完成");
                this.Close();
            }
            else
            {
                MessageBox.Show("没有版本可以更新");
            }
        }

        private void Update(byte[] binfile)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            string filename = path.Replace("UpdateClient.exe", "RFDeviceAPP.exe");
            if(File.Exists(filename))
                File.Move(filename,filename.Replace("exe",DateTime.Now.ToString("yyyymmddhhmmss")));
            FileStream fs = new FileStream(filename, FileMode.Create);
            fs.Write(binfile, 0, binfile.Length);
            fs.Flush();
            fs.Close();



        }
        private void updatever(decimal ver)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            string filename = path.Replace("UpdateClient.exe", "Ver.txt");
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(ver);
            sw.Close();
        }
        private decimal getVersion()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            string filename = path.Replace("UpdateClient.exe", "Ver.txt");
            if (!File.Exists(filename))
            {
                File.Create(filename);

            }
            System.Threading.Thread.Sleep(10);
            StreamReader sr = new StreamReader(filename);
            string line= sr.ReadToEnd();
            sr.Close();
            if (string.IsNullOrEmpty(line))
            {
                return 0;

            }
            else
            {
                return decimal.Parse(line);
            }

        }
        private byte[] getUpdate()
        {
            updateservice.LiveUpdate update = new UpdateClient.updateservice.LiveUpdate();
            return update.GetExeFile();
        }
        private decimal getupdateversion()
        {
            updateservice.LiveUpdate update = new UpdateClient.updateservice.LiveUpdate();
            return update.GetVersion();
        }
    }
}