using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 物业任务发布平台
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

    

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit();
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
            var f=new SelectFuWuTask();
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

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new SelectFuWuTask();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new UserList();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new FuWuTaskList();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new SearchWuFuTaskBill();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var f = new TakeFuWuTaskBill();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var f = new SearchWuFuTaskBill();
            f.Init(true);
            f.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Util.User.UserType == UserType.物业员工)
            {
                button3.Enabled = true;
                button5.Enabled = true;
                业务员领取任务ToolStripMenuItem.Enabled = true;
            }
            else if (Util.User.UserType == UserType.业主)
            {
                button3.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                选择服务ToolStripMenuItem.Enabled = true;
                业主评价服务ToolStripMenuItem.Enabled = true;
            }
            else  if (Util.User.UserType == UserType.物业管理)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                业务员领取任务ToolStripMenuItem.Enabled = true;
                服务任务管理ToolStripMenuItem.Enabled = true;
                选择服务ToolStripMenuItem.Enabled = true;
                业主评价服务ToolStripMenuItem.Enabled = true;
            }
            else if (Util.User.UserType == UserType.管理员)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                用户管理ToolStripMenuItem.Enabled = true;
                业务员领取任务ToolStripMenuItem.Enabled = true;
                服务任务管理ToolStripMenuItem.Enabled = true;
                选择服务ToolStripMenuItem.Enabled = true;
                业主评价服务ToolStripMenuItem.Enabled = true;
            }


        }

  

        private void button7_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void 业主评价服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SearchWuFuTaskBill();
            f.Init(true);
            f.Show();
        }
    }
}
