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
    public partial class TakeFuWuTaskBill : Form
    {
        public TakeFuWuTaskBill()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void TakeFuWuTaskBill_Load(object sender, EventArgs e)
        {
            BingData();
        }

        private void BingData()
        {
            if (Util.User.UserType != UserType.物业员工)
            {
                return;
            }
            var sql =
              "select bill.Id,task.TName,task.TContent,bill.YeZhuDateTime,ywy.UserName as 'YeWuYuanName',yz.UserName as 'YuZhuName', bill.YeWuYuanJieShouDateTime,bill.YeWuYuanWanChengDateTime,bill.BillState from FuWuTaskBill bill left join FuWuTask task on bill.FuWuTaskId=task.Id left join MUser ywy on bill.YeWuYuanId=ywy.Id left join MUser yz on bill.YeZhuId=yz.Id where bill.BillState='" + BillState.未开始+"'";

            dataGridView1.DataSource = new HHDapperSql().ExecuteDataSet(sql).Tables[0].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if (MessageBox.Show("确定要接受此任务吗？","确认",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var sql = "update FuWuTaskBill set YeWuYuanId='" + Util.User.Id + "',YeWuYuanJieShouDateTime='" +
                              DateTime.Now + "',BillState='"+BillState.进行中+"' where Id='" + id + "'";

                    new HHDapperSql().ExecuteNonQuery(sql);
                    BingData();
                }
            }
        }
    }
}
