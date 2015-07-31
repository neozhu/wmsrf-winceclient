using System;

using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace RFDeviceAPP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
#if !DEBUG
            if (chkupdate())
            {
                MessageBox.Show("请更新版本");

                startup();
                Application.Exit();
            }
#endif
             string[] screen;
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            DialogResult result;
            using (Login loginForm = new Login()){
                result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // login was successful
               screen=loginForm.Screen;
               Application.Run(new HomeFrm(loginForm.LoginUser, screen));
                
            }
            }
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.ExceptionObject.ToString());
        }

        static void startup()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "UpdateClient.exe";
            string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            processStartInfo.WorkingDirectory = path.Replace("RFDeviceAPP.exe", "UpdateClient.exe");
            Process.Start(path.Replace("RFDeviceAPP.exe", "UpdateClient.exe"), null);
           
        }
        static bool chkupdate()
        {
            if (getupdateversion() > getVersion())
            {
                return true;
            }
            else {
                return false;
            }
        }
         static decimal getVersion()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            string filename = path.Replace("RFDeviceAPP.exe", "Ver.txt");
            if (!File.Exists(filename))
            {
                File.Create(filename);

            }
            System.Threading.Thread.Sleep(10);
            StreamReader sr = new StreamReader(filename);
            string line = sr.ReadToEnd();
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

        static decimal getupdateversion()
        {
            updateservice.LiveUpdate update = new RFDeviceAPP.updateservice.LiveUpdate();
            return update.GetVersion();
        }
    }
}