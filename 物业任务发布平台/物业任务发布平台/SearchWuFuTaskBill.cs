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
    public partial class SearchWuFuTaskBill : Form
    {
        private bool IsPingJia;
        public SearchWuFuTaskBill()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        public void Init(bool pingjia)
        {
            IsPingJia = pingjia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            var sql =
                "select bill.PingJia,bill.Id,task.TName,bill.YeZhuDateTime,ywy.UserName as 'YeWuYuanName',yz.UserName as 'YuZhuName', bill.YeWuYuanJieShouDateTime,bill.YeWuYuanWanChengDateTime,bill.BillState from FuWuTaskBill bill left join FuWuTask task on bill.FuWuTaskId=task.Id left join MUser ywy on bill.YeWuYuanId=ywy.Id left join MUser yz on bill.YeZhuId=yz.Id where 1=1 ";
            if (IsPingJia)
            {
                sql += " and bill.BillState='" + BillState.完成 + "'  and bill.YeZhuId='" + Util.User.Id + "'";
            }
            else
            {
                if (Util.User.UserType == UserType.业主)
                {
                    sql += " and bill.YeZhuId='" + Util.User.Id + "'";
                }
                else
                {
                    if (Util.User.UserType == UserType.物业员工)
                    {
                        sql += " and bill.YeWuYuanId='" + Util.User.Id + "'";
                        //
                    }

                    if (!string.IsNullOrEmpty(comboBox2.Text))
                    {
                        sql += " and yz.UserName='" + comboBox2.Text + "'";
                    }
                }


                if (!string.IsNullOrEmpty(comboBox1.Text) && comboBox1.Text != "全部")
                {
                    sql += " and bill.BillState='" + comboBox1.Text + "'";
                }
            }
            

            dataGridView1.DataSource=new HHDapperSql().ExecuteDataSet(sql).Tables[0].DefaultView;
        }

        private void SearchWuFuTaskBill_Load(object sender, EventArgs e)
        {
            if (IsPingJia)
            {
                label2.Visible = false;
                comboBox2.Visible = false;
                label1.Visible = false;
                comboBox1.Visible = false;
                button1.Visible = false;
                BindData();
            }
            else
            {
                if (Util.User.UserType == UserType.业主)
                {
                    label2.Visible = false;
                    comboBox2.Visible = false;
                }

                var list = new HHDapperSql().Query<MUser>("select * from MUser order by UserName ");
                comboBox2.Items.Clear();
                comboBox2.Items.Add("");
                foreach (MUser user in list)
                {
                    comboBox2.Items.Add(user.UserName);
                }
            }
           
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var f=new TaskBillEdit();
            f.Init(Convert.ToInt64(id),IsPingJia);
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindData();
            }
        }
    }
}
