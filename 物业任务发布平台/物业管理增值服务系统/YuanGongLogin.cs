using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 物业任务发布平台
{
    public partial class YuanGongLogin : Form
    {
        public YuanGongLogin()
        {
            InitializeComponent();
        }
        private void Exit()
        {
            Application.Exit();
        }
        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new UserList();
            f.Show();
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }
      
        private void 服务任务管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FuWuTaskList();
            f.Show();
        }

        private void 选择服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SelectFuWuTask();
            f.Show();
        }

        private void 查询服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SearchWuFuTaskBill();
            f.Show();
        }

        private void 业务员领取任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new TakeFuWuTaskBill();
            f.Show();
        }
    }
}
