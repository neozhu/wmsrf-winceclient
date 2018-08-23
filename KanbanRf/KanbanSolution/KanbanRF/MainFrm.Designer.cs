namespace KanbanRF
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.outbutton = new System.Windows.Forms.Button();
            this.inbutton = new System.Windows.Forms.Button();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.querybtn = new System.Windows.Forms.Button();
            this.checkbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outbutton
            // 
            this.outbutton.Location = new System.Drawing.Point(130, 74);
            this.outbutton.Name = "outbutton";
            this.outbutton.Size = new System.Drawing.Size(95, 47);
            this.outbutton.TabIndex = 0;
            this.outbutton.Tag = "缓冲区入库";
            this.outbutton.Text = "缓冲区入库";
            this.outbutton.Click += new System.EventHandler(this.outbutton_Click);
            // 
            // inbutton
            // 
            this.inbutton.Location = new System.Drawing.Point(15, 129);
            this.inbutton.Name = "inbutton";
            this.inbutton.Size = new System.Drawing.Size(95, 47);
            this.inbutton.TabIndex = 1;
            this.inbutton.Text = "总装交接扫描";
            this.inbutton.Click += new System.EventHandler(this.inbutton_Click);
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(15, 45);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(210, 23);
            this.usertxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "操作员";
            // 
            // querybtn
            // 
            this.querybtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.querybtn.Location = new System.Drawing.Point(130, 129);
            this.querybtn.Name = "querybtn";
            this.querybtn.Size = new System.Drawing.Size(95, 47);
            this.querybtn.TabIndex = 3;
            this.querybtn.Text = "缓存区库存查询";
            this.querybtn.Click += new System.EventHandler(this.querybtn_Click);
            // 
            // checkbtn
            // 
            this.checkbtn.Location = new System.Drawing.Point(15, 182);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(95, 47);
            this.checkbtn.TabIndex = 4;
            this.checkbtn.Text = "缓存区盘点";
            this.checkbtn.Click += new System.EventHandler(this.checkbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(130, 182);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(95, 47);
            this.updatebtn.TabIndex = 5;
            this.updatebtn.Text = "更新看板";
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(15, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "发放扫描";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "装车扫描";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 297);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.checkbtn);
            this.Controls.Add(this.querybtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.inbutton);
            this.Controls.Add(this.outbutton);
            this.Name = "MainFrm";
            this.Text = "优捷KanbanRF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button outbutton;
        private System.Windows.Forms.Button inbutton;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button querybtn;
        private System.Windows.Forms.Button checkbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

