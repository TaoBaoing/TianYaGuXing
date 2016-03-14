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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var pwd = txtPwd.Text.Trim();

            var user=new HHDapperSql().Query<MUser>("select * from MUser where UserName='" + name+"' and UserPwd='"+pwd+"'").FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("用户名或密码错误");
                return;
            }
            Util.User = user;
            var f=new MainForm();
            this.Hide();
            f.Show();
        }
    }
}
