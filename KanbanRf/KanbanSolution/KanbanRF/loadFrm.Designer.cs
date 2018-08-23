namespace KanbanRF
{
    partial class loadFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ordernotxt = new System.Windows.Forms.TextBox();
            this.platnumbertxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kanbantxt = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.loadbtn = new System.Windows.Forms.Button();
            this.endbutn = new System.Windows.Forms.Button();
            this.createbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.Text = "未结束的装载清单";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Location = new System.Drawing.Point(3, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 50);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "选中的装载清单";
            // 
            // ordernotxt
            // 
            this.ordernotxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ordernotxt.Location = new System.Drawing.Point(4, 98);
            this.ordernotxt.Name = "ordernotxt";
            this.ordernotxt.ReadOnly = true;
            this.ordernotxt.Size = new System.Drawing.Size(112, 23);
            this.ordernotxt.TabIndex = 3;
            // 
            // platnumbertxt
            // 
            this.platnumbertxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.platnumbertxt.Location = new System.Drawing.Point(123, 98);
            this.platnumbertxt.Name = "platnumbertxt";
            this.platnumbertxt.Size = new System.Drawing.Size(112, 23);
            this.platnumbertxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "装载看板号";
            // 
            // kanbantxt
            // 
            this.kanbantxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kanbantxt.Location = new System.Drawing.Point(4, 142);
            this.kanbantxt.Name = "kanbantxt";
            this.kanbantxt.Size = new System.Drawing.Size(231, 23);
            this.kanbantxt.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.Location = new System.Drawing.Point(4, 172);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(231, 66);
            this.listBox2.TabIndex = 7;
            this.listBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox2_KeyDown);
            // 
            // loadbtn
            // 
            this.loadbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadbtn.Location = new System.Drawing.Point(144, 244);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(91, 58);
            this.loadbtn.TabIndex = 8;
            this.loadbtn.Text = "装载";
            this.loadbtn.Visible = false;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // endbutn
            // 
            this.endbutn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endbutn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.endbutn.Location = new System.Drawing.Point(48, 244);
            this.endbutn.Name = "endbutn";
            this.endbutn.Size = new System.Drawing.Size(91, 58);
            this.endbutn.TabIndex = 9;
            this.endbutn.Text = "装载结束";
            this.endbutn.Click += new System.EventHandler(this.endbutn_Click);
            // 
            // createbtn
            // 
            this.createbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.createbtn.Location = new System.Drawing.Point(144, 3);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(91, 26);
            this.createbtn.TabIndex = 10;
            this.createbtn.Text = "新建";
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(3, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 31);
            this.label4.Text = "装载结束会关闭该装载清单以后将不能再装载";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(3, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 31);
            this.label5.Text = "选中看板号按DEL键可以删除";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(123, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "承运车牌号";
            // 
            // loadFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.endbutn);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.kanbantxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.platnumbertxt);
            this.Controls.Add(this.ordernotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.MinimizeBox = false;
            this.Name = "loadFrm";
            this.Text = "装车操作";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ordernotxt;
        private System.Windows.Forms.TextBox platnumbertxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kanbantxt;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Button endbutn;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}