using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;

namespace Kaifa.B2B.ImportService
{
    public partial class Kaifa_B2B_ImportService : ServiceBase
    {
        public Kaifa_B2B_ImportService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
