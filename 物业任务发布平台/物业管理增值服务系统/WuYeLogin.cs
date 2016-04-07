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
    public partial class WuYeLogin : Form
    {
        public WuYeLogin()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
        }

        private void WuYeLogin_Load(object sender, EventArgs e)
        {
            BingData();
        }

        private void BingData()
        {
            BindGridView1();
            BindGridView2();
        }

        private void BindGridView1()
        {
            var sql =
                "select bill.PingJia,bill.Id,task.TName,bill.YeZhuDateTime,ywy.UserName as 'YeWuYuanName',yz.UserName as 'YuZhuName', bill.YeWuYuanJieShouDateTime,bill.YeWuYuanWanChengDateTime,bill.BillState from FuWuTaskBill bill left join FuWuTask task on bill.FuWuTaskId=task.Id left join MUser ywy on bill.YeWuYuanId=ywy.Id left join MUser yz on bill.YeZhuId=yz.Id where bill.BillState='" + BillState.完成 + "' or bill.BillState='" + BillState.进行中 + "' ";
            dataGridView1.DataSource = new HHDapperSql().ExecuteDataSet(sql).Tables[0].DefaultView;
        }
        private void BindGridView2()
        {
            var sql =
              "select bill.PingJia,bill.Id,task.TName,bill.YeZhuDateTime,ywy.UserName as 'YeWuYuanName',yz.UserName as 'YuZhuName', bill.YeWuYuanJieShouDateTime,bill.YeWuYuanWanChengDateTime,bill.BillState from FuWuTaskBill bill left join FuWuTask task on bill.FuWuTaskId=task.Id left join MUser ywy on bill.YeWuYuanId=ywy.Id left join MUser yz on bill.YeZhuId=yz.Id where bill.BillState='" + BillState.未开始 + "' ";
            dataGridView2.DataSource = new HHDapperSql().ExecuteDataSet(sql).Tables[0].DefaultView;
        }

        private void WuYeLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            Application.Exit();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void 查询服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SearchWuFuTaskBill();
            f.Show();
        }

        private void 服务任务管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FuWuTaskList();
            f.Show();
        }
    }
}
