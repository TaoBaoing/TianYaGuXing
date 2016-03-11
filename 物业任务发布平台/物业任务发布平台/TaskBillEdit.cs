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
    public partial class TaskBillEdit : Form
    {
        private long mId;

        public void Init(long id)
        {
            mId = id;
        }

        public TaskBillEdit()
        {
            InitializeComponent();
        }

      
        private void TaskBillEdit_Load(object sender, EventArgs e)
        {
            string sql =
                "select bill.Id,task.TName,task.TContent,bill.YeZhuDateTime,ywy.UserName as 'YeWuYuanName',yz.UserName as 'YuZhuName', bill.YeWuYuanJieShouDateTime,bill.YeWuYuanWanChengDateTime,bill.BillState from FuWuTaskBill bill left join FuWuTask task on bill.FuWuTaskId=task.Id left join MUser ywy on bill.YeWuYuanId=ywy.Id left join MUser yz on bill.YeZhuId=yz.Id where bill.Id='" +
                mId + "' ";
          var dt= new HHDapperSql().ExecuteDataSet(sql).Tables[0];
            if (dt.Rows.Count < 1)
            {
                return;
            }
            var row = dt.Rows[0];

            if (Util.User.UserType == UserType.物业员工&& row["BillState"]!=null&& (string)row["BillState"]==BillState.进行中)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }

            txtTName.Text = row["TName"].ToString();
            richTextBox1.Text = objtostring(row["TContent"]);
            txtYeZhuName.Text = objtostring(row["YuZhuName"]);
            txtCreateTime.Text = objtostring(row["YeZhuDateTime"]);
            txtBillState.Text= objtostring(row["BillState"]);
            txtYeWuYuanName.Text = objtostring(row["YeWuYuanName"]);
            txtFinishDateTime.Text = objtostring(row["YeWuYuanWanChengDateTime"]);
        }

        private string objtostring(object obj)
        {
            if (obj == null)
            {
                return "";
            }
            return obj.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定完成？", "确定", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var sql = "update FuWuTaskBill set YeWuYuanWanChengDateTime='"+DateTime.Now+"',BillState='" + BillState.完成 + "' where Id='" + mId + "'";
                new HHDapperSql().ExecuteNonQuery(sql);
                DialogResult=DialogResult.OK;
                Close();
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
