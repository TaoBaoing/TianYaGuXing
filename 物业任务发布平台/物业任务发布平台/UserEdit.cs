using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.Dapper;

namespace 物业任务发布平台
{
    public partial class UserEdit : Form
    {
        private long mId=0;
        private MUser mUser;
        public UserEdit()
        {
            InitializeComponent();
        }

        public void Init(long id)
        {
            mId = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mUser.UserName = txtName.Text.Trim();
            mUser.UserPwd = txtPwd.Text.Trim();
            mUser.Phone = txtPhone.Text.Trim();
            mUser.UserType = cbbUserType.Text.Trim();

            if (mId > 0)
            {
                new HHDapperSql().Update(mUser);
            }
            else
            {
                new HHDapperSql().Insert(mUser);
            }
            DialogResult=DialogResult.OK;
            MessageBox.Show("保存成功");
            Close();
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            if (mId > 0)
            {
                mUser=new HHDapperSql().Query<MUser>(mId);
            }
            else
            {
                mUser=new MUser();
            }
            AppToUi();
        }

        private void AppToUi()
        {
            txtName.Text = mUser.UserName;
            txtPwd.Text = mUser.UserPwd;
            txtPhone.Text = mUser.Phone;
            cbbUserType.Text = mUser.UserType;
        }

    }
}
