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
    public partial class FuWuTaskEdit : Form
    {
        private long mId = 0;
        private FuWuTask mFuWuTask;
        public FuWuTaskEdit()
        {
            InitializeComponent();
        }

        public void Init(long id)
        {
            mId = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mFuWuTask.TName = txtName.Text.Trim();
            mFuWuTask.TContent = txtContent.Text.Trim();

            if (mId > 0)
            {
                new HHDapperSql().Update(mFuWuTask);
            }
            else
            {
                new HHDapperSql().Insert(mFuWuTask);
            }
            DialogResult = DialogResult.OK;
            MessageBox.Show("保存成功");
            Close();
        }

        private void FuWuTaskEdit_Load(object sender, EventArgs e)
        {
            if (mId > 0)
            {
                mFuWuTask = new HHDapperSql().Query<FuWuTask>(mId);
            }
            else
            {
                mFuWuTask = new FuWuTask();
            }
            AppToUi();
        }
        private void AppToUi()
        {
            txtName.Text = mFuWuTask.TName;
            txtContent.Text = mFuWuTask.TContent;
        }
    }
}
