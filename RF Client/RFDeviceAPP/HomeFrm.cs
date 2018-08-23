using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RFDeviceAPP
{
    public partial class HomeFrm : Form
    {
        private Common.UserInfo _user = null;

        private RFLottableReciptFrm rflotreciptfrm = null;

        private RFPutWayFrm rfputwayfrm = null;

        private RFPaperPickingFrm paperpickingfrm = null;
        private RFPackingFrm packingfrm = null;
        private RFFLPickingFrm flpickingfrm = null;
        private TaskTPKFrm tasktpkfrm = null;
        private RFRL021Frm rfrl021frm = null;
        private RFRL021_2Frm rfrl021_2frm = null;
        NSPRFRL02BATCHFrm rl02bfrm = null;
        NSPRFRL021SOFrm rl02sfrm = null;
        NSPRFSH01Frm sh01frm = null;
        private NSPRFSH01Frm_2 sh01frm_2 = null;
        private NSPRFRL01B1FLFrm rl01bflrm = null;
        private FrmStockQuery stockquery = null;
        private frmPODQC frmpodqc = null;
        private FrmPODCheck frmpodcheck = null;
        private FrmPODPick frmpodpick = null;
        private FrmPODLabel frmpodlabel = null;
        private FrmPODLoad frmpodload = null;
        private NSPRFQUERYBYDROPIDForm nsprfquerybydropidfrm = null;
        private FrmScanSN1 frmscansn1 = null;

        //2017/01/16  pop_wu  add workinstructions screen
        private FrmInstrcutions frminstrcution = null;
        //

        //2018/05/15  pop_wu  add RTRSKU screen
        private FrmRTRSku1 frmrtrsku = null;
        //

        private string[] screen;
        public HomeFrm(Common.UserInfo loginuser,string[] screen)
        {
            _user = loginuser;
            this.screen = screen;
            InitializeComponent();
            this.userStatusControl.SetUser(_user);
            setCommandBtn();
        }
        //车到仓操作 F01
        //车离仓操作 F02
        //卸货操作 F03
        //装车操作 F04
        //PQC操作  F05
        //分料操作 F06
        //纸面拣货 F07
        //收货操作 F08
        //简易拣货 F09
        //上架操作 F10
        //二次上架 F11
        //开始任务 F12
        //一次集货 F13
        //二次集货 F14
        //包装操作 F15
        //二次拣货 F16
        //库存查询 F17
        //发运操作 F18
        //移动操作 F19
        private void setCommandBtn()
        {
            if (!isExist("isadmin"))
            {
                if (isExist("f01"))
                {
                    this.f01btn.Enabled = true;
                }
                else
                {
                    this.f01btn.Enabled = false;
                }
                if (isExist("f02"))
                {
                    this.f02btn.Enabled = true;
                }
                else
                {
                    this.f02btn.Enabled = false;
                }
                if (isExist("f03"))
                {
                    this.f03btn.Enabled = true;
                }
                else
                {
                    this.f03btn.Enabled = false;
                }
                if (isExist("f04"))
                {
                    this.f04btn.Enabled = true;
                }
                else
                {
                    this.f04btn.Enabled = false;
                }
                if (isExist("f05"))
                {
                    this.f05btn.Enabled = true;
                }
                else
                {
                    this.f05btn.Enabled = false;
                }
                if (isExist("f06"))
                {
                    this.f06btn.Enabled = true;
                }
                else
                {
                    this.f06btn.Enabled = false;
                }
                if (isExist("f07"))
                {
                    this.f07btn.Enabled = true;
                }
                else
                {
                    this.f07btn.Enabled = false;
                }
                if (isExist("f08"))
                {
                    this.f08btn.Enabled = true;
                }
                else
                {
                    this.f08btn.Enabled = false;
                }
                if (isExist("f09"))
                {
                    this.f09btn.Enabled = true;
                    this.f09_1btn.Enabled = true;
                }
                else
                {
                    this.f09btn.Enabled = false;
                    this.f09_1btn.Enabled = false;
                }
                if (isExist("f10"))
                {
                    this.f10btn.Enabled = true;
                }
                else
                {
                    this.f10btn.Enabled = false;
                }
                if (isExist("f11"))
                {
                    this.f11btn.Enabled = true;
                }
                else
                {
                    this.f11btn.Enabled = false;
                }
                if (isExist("f12"))
                {
                    this.f12btn.Enabled = true;
                }
                else
                {
                    this.f12btn.Enabled = false;
                }
                
                if (isExist("f13"))
                {
                    this.f13btn.Enabled = true;
                }
                else
                {
                    this.f13btn.Enabled = false;
                }
                if (isExist("f14"))
                {
                    this.f14btn.Enabled = true;
                }
                else
                {
                    this.f14btn.Enabled = false;
                }
                if (isExist("f15"))
                {
                    this.f15btn.Enabled = true;
                }
                else
                {
                    this.f15btn.Enabled = false;
                }
                if (isExist("f16"))
                {
                    this.f16btn.Enabled = true;
                }
                else
                {
                    this.f16btn.Enabled = false;
                }
                if (isExist("f17"))
                {
                    this.f17btn.Enabled = true;
                }
                else
                {
                    this.f17btn.Enabled = false;
                }
                if (isExist("f18"))
                {
                    this.f18btn.Enabled = true;
                }
                else
                {
                    this.f18btn.Enabled = false;
                }
                if (isExist("f19"))
                {
                    this.f19btn.Enabled = true;
                }
                else
                {
                    this.f19btn.Enabled = false;
                }

                if (isExist("f20"))
                {
                    this.f20btn.Enabled = true;
                }
                else
                {
                    this.f20btn.Enabled = false;
                }
                if (isExist("f21"))
                {
                    this.f21btn.Enabled = true;
                }
                else
                {
                    this.f21btn.Enabled = false;
                }
                if (isExist("f22"))
                {
                    this.f22btn.Enabled = true;
                }
                else
                {
                    this.f22btn.Enabled = false;
                }
                if (isExist("f23"))
                {
                    this.f23btn.Enabled = true;
                }
                else
                {
                    this.f23btn.Enabled = false;
                }
                if (isExist("f24"))
                {
                    this.f24btn.Enabled = true;
                }
                else
                {
                    this.f24btn.Enabled = false;
                }
            }

        }
        private bool isExist(string cmd)
        {
            foreach (string str in this.screen)
            {
                if (str.ToLower() == cmd.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public HomeFrm()
        {
            InitializeComponent();
        }

        private void task_Click(object sender, EventArgs e)
        {
            TaskFrm taskfrm = new TaskFrm();
            taskfrm.Show();
        }

        private void HomeFrm_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
           
            //this.TopMost = true;
        }
        

        private void arrivalbtn_Click(object sender, EventArgs e)
        {
            ArrivalFrm arrfrm = new ArrivalFrm(this._user);
            arrfrm.Show();
        }

        private void leavebtn_Click(object sender, EventArgs e)
        {
            LeaveFrm leavefrm = new LeaveFrm(this._user);
            leavefrm.Show();
        }

        private void dischargebtn_Click(object sender, EventArgs e)
        {
            RFBeginDischargefrm disfrm = new RFBeginDischargefrm(this._user);
            disfrm.Show();
        }

        private void classifybtn_Click(object sender, EventArgs e)
        {
            ClassifyFrm classifyfrm = new ClassifyFrm(this._user);
            classifyfrm.Show();
        }

        private void pqcbtn_Click(object sender, EventArgs e)
        {
            PQCFrm qpcfrm = new PQCFrm(this._user);
            qpcfrm.Show();
        }

        

        private void receiptbtn_Click(object sender, EventArgs e)
        {
            rflotreciptfrm = new RFLottableReciptFrm(this._user);
            rflotreciptfrm.Show();
            rflotreciptfrm.Activate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //TestForm1 test = new TestForm1( );
            //test.Show();
            //if (rflotreciptfrm == null)
            //{

            rfputwayfrm = new RFPutWayFrm(this._user);
            rfputwayfrm.Show();
            rfputwayfrm.Activate();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paperpickingfrm = new RFPaperPickingFrm(this._user);
            paperpickingfrm.Show();
            paperpickingfrm.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmExpressPrint expressfrm = new FrmExpressPrint(this._user);
            expressfrm.Show();
            expressfrm.Activate();
            //TestForm11 ddd = new TestForm11();
            //ddd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            packingfrm = new RFPackingFrm(this._user);
            packingfrm.Show();
            packingfrm.Activate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flpickingfrm = new RFFLPickingFrm(this._user,false);
            flpickingfrm.Show();
            flpickingfrm.Activate();
        }

        private void tasktpkbtn_Click(object sender, EventArgs e)
        {
            tasktpkfrm = new TaskTPKFrm(this._user);
            tasktpkfrm.Show();
            tasktpkfrm.Activate();
        }

        private void collectionbtn_Click(object sender, EventArgs e)
        {
            rfrl021frm = new RFRL021Frm(this._user);
            rfrl021frm.Show();
            rfrl021frm.Activate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rl02bfrm = new NSPRFRL02BATCHFrm(this._user);
            rl02bfrm.Show();
            rl02bfrm.Activate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rl02sfrm = new NSPRFRL021SOFrm(this._user);
            rl02sfrm.Show();
            rl02sfrm.Activate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
             
             sh01frm = new  NSPRFSH01Frm(this._user);
            sh01frm.Show();
            sh01frm.Activate();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rfrl021_2frm = new RFRL021_2Frm(this._user);
            rfrl021_2frm.Show();
            rfrl021_2frm.Activate();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            rl01bflrm = new NSPRFRL01B1FLFrm(this._user);
            rl01bflrm.Show();
            rl01bflrm.Activate();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sh01frm_2 = new NSPRFSH01Frm_2(this._user);
            sh01frm_2.Show();
            sh01frm_2.Activate();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            stockquery = new FrmStockQuery(this._user);
            stockquery.Show();
            stockquery.Activate();
        }

        private void f20btn_Click(object sender, EventArgs e)
        {
            frmpodqc = new frmPODQC(this._user);
            frmpodqc.Show();
            frmpodqc.Activate();
        }

        private void f21btn_Click(object sender, EventArgs e)
        {
            frmpodcheck = new FrmPODCheck(this._user);
            frmpodcheck.Show();
            frmpodcheck.Activate();
        }

        private void f22btn_Click(object sender, EventArgs e)
        {
            frmpodpick = new FrmPODPick(this._user);
            frmpodpick.Show();
            frmpodpick.Activate();
        }

        private void f23btn_Click(object sender, EventArgs e)
        {
            frmpodlabel = new FrmPODLabel(this._user);
            frmpodlabel.Show();
            frmpodlabel.Activate();
        }

        private void f24btn_Click(object sender, EventArgs e)
        {
            frmpodload = new FrmPODLoad(this._user);
            frmpodload.Show();
            frmpodload.Activate();
        }

        private void f25btn_Click(object sender, EventArgs e)
        {
            nsprfquerybydropidfrm = new NSPRFQUERYBYDROPIDForm(this._user);
            nsprfquerybydropidfrm.Show();
            nsprfquerybydropidfrm.Activate();
        }

        private void f09_1btn_Click(object sender, EventArgs e)
        {
            flpickingfrm = new RFFLPickingFrm(this._user,true);
            flpickingfrm.Show();
            flpickingfrm.Activate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frminstrcution = new FrmInstrcutions(this._user);
            frminstrcution.Show();
            frminstrcution.Activate();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmrtrsku = new FrmRTRSku1(this._user);
            frmrtrsku.Show();
            frmrtrsku.Activate();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmscansn1 = new FrmScanSN1(this._user);
            frmscansn1.Show();
            frmscansn1.Activate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmExpressPrint frmexpress = new FrmExpressPrint(this._user);
            frmexpress.Show();
            frmexpress.Activate();
        }

        
    }
}