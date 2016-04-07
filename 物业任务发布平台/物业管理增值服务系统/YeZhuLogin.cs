using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HH.Dapper;

namespace 物业任务发布平台
{
    public partial class YeZhuLogin : Form
    {
        public YeZhuLogin()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void YeZhuLogin_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void YeZhuLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit();
        }
        private void BindData()
        {
            var sql =
                "select bill.PingJia,bill.Id,task.TName,bill.YeZhuDateTime,ywy.UserName as 'YeWuYuanName',yz.UserName as 'YuZhuName', bill.YeWuYuanJieShouDateTime,bill.YeWuYuanWanChengDateTime,bill.BillState from FuWuTaskBill bill left join FuWuTask task on bill.FuWuTaskId=task.Id left join MUser ywy on bill.YeWuYuanId=ywy.Id left join MUser yz on bill.YeZhuId=yz.Id where 1=1 ";

            sql += " and bill.YeZhuId='" + Util.User.Id + "'";

            dataGridView1.DataSource = new HHDapperSql().ExecuteDataSet(sql).Tables[0].DefaultView;
        }
        private void Exit()
        {
            Application.Exit();
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

        private void 业主评价服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SearchWuFuTaskBill();
            f.Init(true);
            f.Show();
        }
    }
}
