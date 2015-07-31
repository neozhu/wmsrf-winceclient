using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RFDeviceAPP
{
    public partial class TaskFrm : baseForm
    {

        public TaskFrm()
        {
            InitializeComponent();
        }

        private void TaskFrm_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //this.userStatusControl1.LoginUser.Status = "空闲";
            
        }
        

    }
}