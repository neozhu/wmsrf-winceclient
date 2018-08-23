namespace RFDeviceAPP
{
    partial class HomeFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.f01btn = new System.Windows.Forms.Button();
            this.f02btn = new System.Windows.Forms.Button();
            this.f03btn = new System.Windows.Forms.Button();
            this.f06btn = new System.Windows.Forms.Button();
            this.f05btn = new System.Windows.Forms.Button();
            this.f08btn = new System.Windows.Forms.Button();
            this.f10btn = new System.Windows.Forms.Button();
            this.f07btn = new System.Windows.Forms.Button();
            this.f15btn = new System.Windows.Forms.Button();
            this.f09btn = new System.Windows.Forms.Button();
            this.f12btn = new System.Windows.Forms.Button();
            this.f13btn = new System.Windows.Forms.Button();
            this.f11btn = new System.Windows.Forms.Button();
            this.f16btn = new System.Windows.Forms.Button();
            this.f04btn = new System.Windows.Forms.Button();
            this.f14btn = new System.Windows.Forms.Button();
            this.f19btn = new System.Windows.Forms.Button();
            this.f18btn = new System.Windows.Forms.Button();
            this.f17btn = new System.Windows.Forms.Button();
            this.f20btn = new System.Windows.Forms.Button();
            this.f21btn = new System.Windows.Forms.Button();
            this.f22btn = new System.Windows.Forms.Button();
            this.f23btn = new System.Windows.Forms.Button();
            this.f24btn = new System.Windows.Forms.Button();
            this.f25btn = new System.Windows.Forms.Button();
            this.f09_1btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.userStatusControl = new RFDeviceAPP.UserStatusControl();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f01btn
            // 
            this.f01btn.Location = new System.Drawing.Point(3, 32);
            this.f01btn.Name = "f01btn";
            this.f01btn.Size = new System.Drawing.Size(105, 30);
            this.f01btn.TabIndex = 2;
            this.f01btn.Text = "车到仓操作";
            this.f01btn.Click += new System.EventHandler(this.arrivalbtn_Click);
            // 
            // f02btn
            // 
            this.f02btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.f02btn.Location = new System.Drawing.Point(130, 32);
            this.f02btn.Name = "f02btn";
            this.f02btn.Size = new System.Drawing.Size(105, 30);
            this.f02btn.TabIndex = 3;
            this.f02btn.Text = "车离仓操作";
            this.f02btn.Click += new System.EventHandler(this.leavebtn_Click);
            // 
            // f03btn
            // 
            this.f03btn.Location = new System.Drawing.Point(3, 68);
            this.f03btn.Name = "f03btn";
            this.f03btn.Size = new System.Drawing.Size(105, 30);
            this.f03btn.TabIndex = 4;
            this.f03btn.Text = "卸货操作";
            this.f03btn.Click += new System.EventHandler(this.dischargebtn_Click);
            // 
            // f06btn
            // 
            this.f06btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.f06btn.Location = new System.Drawing.Point(130, 140);
            this.f06btn.Name = "f06btn";
            this.f06btn.Size = new System.Drawing.Size(105, 30);
            this.f06btn.TabIndex = 5;
            this.f06btn.Text = "分料操作";
            this.f06btn.Click += new System.EventHandler(this.classifybtn_Click);
            // 
            // f05btn
            // 
            this.f05btn.Location = new System.Drawing.Point(3, 104);
            this.f05btn.Name = "f05btn";
            this.f05btn.Size = new System.Drawing.Size(105, 30);
            this.f05btn.TabIndex = 6;
            this.f05btn.Text = "PQC操作";
            this.f05btn.Click += new System.EventHandler(this.pqcbtn_Click);
            // 
            // f08btn
            // 
            this.f08btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.f08btn.Location = new System.Drawing.Point(130, 176);
            this.f08btn.Name = "f08btn";
            this.f08btn.Size = new System.Drawing.Size(105, 30);
            this.f08btn.TabIndex = 7;
            this.f08btn.Text = "收货操作";
            this.f08btn.Click += new System.EventHandler(this.receiptbtn_Click);
            // 
            // f10btn
            // 
            this.f10btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.f10btn.Location = new System.Drawing.Point(130, 212);
            this.f10btn.Name = "f10btn";
            this.f10btn.Size = new System.Drawing.Size(105, 30);
            this.f10btn.TabIndex = 8;
            this.f10btn.Text = "上架操作";
            this.f10btn.Click += new System.EventHandler(this.button8_Click);
            // 
            // f07btn
            // 
            this.f07btn.Location = new System.Drawing.Point(3, 140);
            this.f07btn.Name = "f07btn";
            this.f07btn.Size = new System.Drawing.Size(105, 30);
            this.f07btn.TabIndex = 9;
            this.f07btn.Text = "纸面拣货";
            this.f07btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // f15btn
            // 
            this.f15btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.f15btn.Location = new System.Drawing.Point(130, 284);
            this.f15btn.Name = "f15btn";
            this.f15btn.Size = new System.Drawing.Size(105, 30);
            this.f15btn.TabIndex = 11;
            this.f15btn.Text = "包装操作";
            this.f15btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // f09btn
            // 
            this.f09btn.Location = new System.Drawing.Point(3, 176);
            this.f09btn.Name = "f09btn";
            this.f09btn.Size = new System.Drawing.Size(105, 30);
            this.f09btn.TabIndex = 12;
            this.f09btn.Text = "简易拣货";
            this.f09btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // f12btn
            // 
            this.f12btn.Location = new System.Drawing.Point(3, 247);
            this.f12btn.Name = "f12btn";
            this.f12btn.Size = new System.Drawing.Size(105, 30);
            this.f12btn.TabIndex = 13;
            this.f12btn.Text = "开始任务";
            this.f12btn.Click += new System.EventHandler(this.tasktpkbtn_Click);
            // 
            // f13btn
            // 
            this.f13btn.Location = new System.Drawing.Point(3, 319);
            this.f13btn.Name = "f13btn";
            this.f13btn.Size = new System.Drawing.Size(105, 30);
            this.f13btn.TabIndex = 14;
            this.f13btn.Text = "一次集货";
            this.f13btn.Click += new System.EventHandler(this.collectionbtn_Click);
            // 
            // f11btn
            // 
            this.f11btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.f11btn.Location = new System.Drawing.Point(130, 248);
            this.f11btn.Name = "f11btn";
            this.f11btn.Size = new System.Drawing.Size(105, 30);
            this.f11btn.TabIndex = 15;
            this.f11btn.Text = "二次上架";
            this.f11btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // f16btn
            // 
            this.f16btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.f16btn.Location = new System.Drawing.Point(130, 320);
            this.f16btn.Name = "f16btn";
            this.f16btn.Size = new System.Drawing.Size(105, 30);
            this.f16btn.TabIndex = 16;
            this.f16btn.Text = "二次拣货";
            this.f16btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // f04btn
            // 
            this.f04btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.f04btn.Location = new System.Drawing.Point(130, 68);
            this.f04btn.Name = "f04btn";
            this.f04btn.Size = new System.Drawing.Size(105, 30);
            this.f04btn.TabIndex = 17;
            this.f04btn.Text = "装车操作";
            this.f04btn.Click += new System.EventHandler(this.button7_Click);
            // 
            // f14btn
            // 
            this.f14btn.Location = new System.Drawing.Point(3, 355);
            this.f14btn.Name = "f14btn";
            this.f14btn.Size = new System.Drawing.Size(105, 30);
            this.f14btn.TabIndex = 18;
            this.f14btn.Text = "二次集货";
            this.f14btn.Click += new System.EventHandler(this.button9_Click);
            // 
            // f19btn
            // 
            this.f19btn.Location = new System.Drawing.Point(3, 391);
            this.f19btn.Name = "f19btn";
            this.f19btn.Size = new System.Drawing.Size(105, 30);
            this.f19btn.TabIndex = 19;
            this.f19btn.Text = "移动操作";
            this.f19btn.Click += new System.EventHandler(this.button10_Click);
            // 
            // f18btn
            // 
            this.f18btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.f18btn.Location = new System.Drawing.Point(130, 104);
            this.f18btn.Name = "f18btn";
            this.f18btn.Size = new System.Drawing.Size(105, 30);
            this.f18btn.TabIndex = 20;
            this.f18btn.Text = "发运操作";
            this.f18btn.Click += new System.EventHandler(this.button11_Click);
            // 
            // f17btn
            // 
            this.f17btn.Location = new System.Drawing.Point(3, 427);
            this.f17btn.Name = "f17btn";
            this.f17btn.Size = new System.Drawing.Size(105, 30);
            this.f17btn.TabIndex = 21;
            this.f17btn.Text = "库存查询";
            this.f17btn.Click += new System.EventHandler(this.button12_Click);
            // 
            // f20btn
            // 
            this.f20btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.f20btn.Location = new System.Drawing.Point(130, 356);
            this.f20btn.Name = "f20btn";
            this.f20btn.Size = new System.Drawing.Size(105, 30);
            this.f20btn.TabIndex = 22;
            this.f20btn.Text = "QCPOD";
            this.f20btn.Click += new System.EventHandler(this.f20btn_Click);
            // 
            // f21btn
            // 
            this.f21btn.Location = new System.Drawing.Point(3, 463);
            this.f21btn.Name = "f21btn";
            this.f21btn.Size = new System.Drawing.Size(105, 30);
            this.f21btn.TabIndex = 23;
            this.f21btn.Text = "复检POD";
            this.f21btn.Click += new System.EventHandler(this.f21btn_Click);
            // 
            // f22btn
            // 
            this.f22btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.f22btn.Location = new System.Drawing.Point(130, 392);
            this.f22btn.Name = "f22btn";
            this.f22btn.Size = new System.Drawing.Size(105, 30);
            this.f22btn.TabIndex = 24;
            this.f22btn.Text = "拣货POD";
            this.f22btn.Click += new System.EventHandler(this.f22btn_Click);
            // 
            // f23btn
            // 
            this.f23btn.Location = new System.Drawing.Point(3, 499);
            this.f23btn.Name = "f23btn";
            this.f23btn.Size = new System.Drawing.Size(105, 30);
            this.f23btn.TabIndex = 25;
            this.f23btn.Text = "贴标POD";
            this.f23btn.Click += new System.EventHandler(this.f23btn_Click);
            // 
            // f24btn
            // 
            this.f24btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.f24btn.Location = new System.Drawing.Point(130, 428);
            this.f24btn.Name = "f24btn";
            this.f24btn.Size = new System.Drawing.Size(105, 30);
            this.f24btn.TabIndex = 26;
            this.f24btn.Text = "装车POD";
            this.f24btn.Click += new System.EventHandler(this.f24btn_Click);
            // 
            // f25btn
            // 
            this.f25btn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.f25btn.Location = new System.Drawing.Point(3, 283);
            this.f25btn.Name = "f25btn";
            this.f25btn.Size = new System.Drawing.Size(105, 30);
            this.f25btn.TabIndex = 27;
            this.f25btn.Text = "一次集货(查询)";
            this.f25btn.Click += new System.EventHandler(this.f25btn_Click);
            // 
            // f09_1btn
            // 
            this.f09_1btn.Location = new System.Drawing.Point(3, 212);
            this.f09_1btn.Name = "f09_1btn";
            this.f09_1btn.Size = new System.Drawing.Size(105, 30);
            this.f09_1btn.TabIndex = 28;
            this.f09_1btn.Text = "区域拣货";
            this.f09_1btn.Click += new System.EventHandler(this.f09_1btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 29;
            this.button1.Text = "服务指令";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 30);
            this.button3.TabIndex = 30;
            this.button3.Text = "分料";
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(130, 536);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 29);
            this.button4.TabIndex = 31;
            this.button4.Text = "精品扫描";
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // userStatusControl
            // 
            this.userStatusControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.userStatusControl.IsRuning = false;
            this.userStatusControl.Location = new System.Drawing.Point(0, 0);
            this.userStatusControl.LoginUser = null;
            this.userStatusControl.Name = "userStatusControl";
            this.userStatusControl.Size = new System.Drawing.Size(238, 26);
            this.userStatusControl.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 30);
            this.button2.TabIndex = 32;
            this.button2.Text = "快递面单";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 596);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.f09_1btn);
            this.Controls.Add(this.f25btn);
            this.Controls.Add(this.f24btn);
            this.Controls.Add(this.f23btn);
            this.Controls.Add(this.f22btn);
            this.Controls.Add(this.f21btn);
            this.Controls.Add(this.f20btn);
            this.Controls.Add(this.f17btn);
            this.Controls.Add(this.f18btn);
            this.Controls.Add(this.f19btn);
            this.Controls.Add(this.f14btn);
            this.Controls.Add(this.f04btn);
            this.Controls.Add(this.f16btn);
            this.Controls.Add(this.f11btn);
            this.Controls.Add(this.f13btn);
            this.Controls.Add(this.f12btn);
            this.Controls.Add(this.f09btn);
            this.Controls.Add(this.f15btn);
            this.Controls.Add(this.f07btn);
            this.Controls.Add(this.f10btn);
            this.Controls.Add(this.f08btn);
            this.Controls.Add(this.f05btn);
            this.Controls.Add(this.f06btn);
            this.Controls.Add(this.f03btn);
            this.Controls.Add(this.f02btn);
            this.Controls.Add(this.f01btn);
            this.Controls.Add(this.userStatusControl);
            this.Name = "HomeFrm";
            this.Text = "WMS RF Client";
            this.Load += new System.EventHandler(this.HomeFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserStatusControl userStatusControl;
        private System.Windows.Forms.Button f01btn;
        private System.Windows.Forms.Button f02btn;
        private System.Windows.Forms.Button f03btn;
        private System.Windows.Forms.Button f06btn;
        private System.Windows.Forms.Button f05btn;
        private System.Windows.Forms.Button f08btn;
        private System.Windows.Forms.Button f10btn;
        private System.Windows.Forms.Button f07btn;
        private System.Windows.Forms.Button f15btn;
        private System.Windows.Forms.Button f09btn;
        private System.Windows.Forms.Button f12btn;
        private System.Windows.Forms.Button f13btn;
        private System.Windows.Forms.Button f11btn;
        private System.Windows.Forms.Button f16btn;
        private System.Windows.Forms.Button f04btn;
        private System.Windows.Forms.Button f14btn;
        private System.Windows.Forms.Button f19btn;
        private System.Windows.Forms.Button f18btn;
        private System.Windows.Forms.Button f17btn;
        private System.Windows.Forms.Button f20btn;
        private System.Windows.Forms.Button f21btn;
        private System.Windows.Forms.Button f22btn;
        private System.Windows.Forms.Button f23btn;
        private System.Windows.Forms.Button f24btn;
        private System.Windows.Forms.Button f25btn;
        private System.Windows.Forms.Button f09_1btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
    }
}