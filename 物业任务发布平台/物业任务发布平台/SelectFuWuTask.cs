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
    public partial class SelectFuWuTask : Form
    {
        private IEnumerable<FuWuTask> list;
        private FuWuTask mFuWuTask;
        public SelectFuWuTask()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
             list = new HHDapperSql().Query<FuWuTask>("select * from FuWuTask order by Id desc");
           
            comboBox1.Items.Clear();
            foreach (FuWuTask task in list)
            {
                comboBox1.Items.Add(task.TName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mFuWuTask == null)
            {
                MessageBox.Show("没有选择服务");
                return;
            }
            var bill=new FuWuTaskBill();
            bill.FuWuTaskId = mFuWuTask.Id;
            bill.YeZhuId = Util.User.Id;
            bill.YeZhuDateTime=DateTime.Now;
            bill.BillState = BillState.未开始;

            new HHDapperSql().Insert(bill);
            MessageBox.Show("选择成功，请在服务查询中查看");
            Close();
        }

        private void SelectFuWuTask_Load(object sender, EventArgs e)
        {
          
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var f = list.FirstOrDefault(x => x.TName == comboBox1.Text);
            if (f != null)
            {
                mFuWuTask = f;
                richTextBox1.Text = f.TContent;
                lblPrice.Text = f.Price;
            }
        }
    }
}
