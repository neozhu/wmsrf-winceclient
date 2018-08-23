namespace KanbanRF
{
    partial class updateFrm
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
            this.kanbantxt = new System.Windows.Forms.TextBox();
            this.kanbannotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.storerkeytxt = new System.Windows.Forms.TextBox();
            this.skutxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qtytxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.statuslb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "原看板号";
            // 
            // kanbantxt
            // 
            this.kanbantxt.Location = new System.Drawing.Point(4, 20);
            this.kanbantxt.Name = "kanbantxt";
            this.kanbantxt.Size = new System.Drawing.Size(231, 23);
            this.kanbantxt.TabIndex = 1;
            this.kanbantxt.TextChanged += new System.EventHandler(this.kanbantxt_TextChanged);
            this.kanbantxt.LostFocus += new System.EventHandler(this.kanbantxt_LostFocus);
            // 
            // kanbannotxt
            // 
            this.kanbannotxt.Location = new System.Drawing.Point(4, 64);
            this.kanbannotxt.Name = "kanbannotxt";
            this.kanbannotxt.Size = new System.Drawing.Size(231, 23);
            this.kanbannotxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "货主";
            // 
            // storerkeytxt
            // 
            this.storerkeytxt.Location = new System.Drawing.Point(4, 107);
            this.storerkeytxt.Name = "storerkeytxt";
            this.storerkeytxt.Size = new System.Drawing.Size(231, 23);
            this.storerkeytxt.TabIndex = 3;
            // 
            // skutxt
            // 
            this.skutxt.Location = new System.Drawing.Point(4, 158);
            this.skutxt.Name = "skutxt";
            this.skutxt.Size = new System.Drawing.Size(231, 23);
            this.skutxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "SKU";
            // 
            // qtytxt
            // 
            this.qtytxt.Location = new System.Drawing.Point(3, 200);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(231, 23);
            this.qtytxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "数量";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(142, 228);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(93, 58);
            this.savebtn.TabIndex = 12;
            this.savebtn.Text = "保存";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // statuslb
            // 
            this.statuslb.Location = new System.Drawing.Point(4, 225);
            this.statuslb.Name = "statuslb";
            this.statuslb.Size = new System.Drawing.Size(100, 20);
            this.statuslb.ParentChanged += new System.EventHandler(this.statuslb_ParentChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "新看板号";
            // 
            // updateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 302);
            this.Controls.Add(this.statuslb);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.qtytxt);
            this.Controls.Add(this.skutxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.storerkeytxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kanbannotxt);
            this.Controls.Add(this.kanbantxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "updateFrm";
            this.Text = "更新手工看板";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kanbantxt;
        private System.Windows.Forms.TextBox kanbannotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox storerkeytxt;
        private System.Windows.Forms.TextBox skutxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qtytxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label statuslb;
        private System.Windows.Forms.Label label5;
    }
}