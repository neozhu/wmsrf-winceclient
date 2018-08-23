using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KanbanRF
{
    public partial class updateFrm : Form
    {
        private string _user;
        WebReference.WebService ws = new KanbanRF.WebReference.WebService();
        public updateFrm(string user)
        {
            InitializeComponent();
            _user = user;
            this.kanbantxt.Focus();
            this.kanbantxt.KeyDown += new KeyEventHandler(kanbantxt_KeyDown);
        }

        void kanbantxt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (kanbantxt.Text.Length > 0)
                {
                    this.kanbannotxt.Focus();

                }
            }
        }

        private void kanbantxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void kanbantxt_LostFocus(object sender, EventArgs e)
        {
            if (this.kanbantxt.Text.Length > 0)
            {
                get(this.kanbantxt.Text);
            }
        }
        private void get(string kanbanno) {
            WebReference.Kanban kb = ws.Get(kanbanno);
            if (kb == null)
            {

                this.kanbannotxt.Text = "";
                this.qtytxt.Text = "";
                this.storerkeytxt.Text = "";
                this.skutxt.Text = "";
                this.statuslb.Text = "";
                MessageBox.Show("没有找到看板数据");
                this.kanbantxt.Focus();
            }
            else
            {
                this.kanbannotxt.Text = kb.KanbanNo;
                this.qtytxt.Text = kb.Qty.ToString();
                this.storerkeytxt.Text = kb.StorereKey;
                this.skutxt.Text = kb.SKU;
                this.statuslb.Text = kb.Status.ToString();
                this.kanbannotxt.Focus();

            }
        }
        private void update()
        {
            WebReference.Kanban kb = new KanbanRF.WebReference.Kanban();
            kb.KanbanNo = this.kanbannotxt.Text;
            kb.OriginalKanbanNo = this.kanbantxt.Text;
            kb.StorereKey = this.storerkeytxt.Text;
            kb.SKU = this.skutxt.Text;
            kb.Qty = decimal.Parse(this.qtytxt.Text);
            kb.CheckUser = _user;
            string msg=ws.Update(kb);
            MessageBox.Show(msg);
            this.kanbantxt.Focus();
        }
        private void statuslb_ParentChanged(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (this.kanbannotxt.Text.Length > 0 && this.skutxt.Text.Length > 0 && this.storerkeytxt.Text.Length > 0 && this.qtytxt.Text.Length > 0)
            {
                if (this.kanbantxt.Text != this.kanbannotxt.Text)
                {
                    if (MessageBox.Show("你确定要更新看板号码", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        update();
                }
                else
                {
                    update();
                }
                this.kanbantxt.Text = "";
                this.kanbannotxt.Text = "";
                this.qtytxt.Text = "";
                this.storerkeytxt.Text = "";
                this.skutxt.Text = "";
                this.statuslb.Text = "";
                this.kanbantxt.Focus();
            }
            else
            {
                MessageBox.Show("看板号，货主，SKU，数量都必须填写");
                this.kanbantxt.Focus();
            }
        }
    }
}