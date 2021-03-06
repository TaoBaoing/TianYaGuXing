﻿using System;
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
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            BindDataGrid();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var f = new UserEdit();
            f.Init(Convert.ToInt64(id));
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindDataGrid();
            }
        }

        private void 删除选中项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除选中行吗？", "删除", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (dataGridView1.SelectedRows.Count < 1)
                {
                    return;
                }
                var inid = "";
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    var id = Convert.ToInt64(row.Cells[0].Value);
                    inid = inid + "," + id;
                }
                inid = inid.Remove(0, 1);
                var sql = "delete from MUser where Id in (" + inid + ")";
                new HHDapperSql().ExecuteNonQuery(sql);
       
                MessageBox.Show("删除成功");
                BindDataGrid();
            }
        }

        private void 新增用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form=new UserEdit();
            if (form.ShowDialog() == DialogResult.OK)
            {
                BindDataGrid();
            }
        }

        private void BindDataGrid()
        {
            var list=new HHDapperSql().Query<MUser>("select * from MUser where UserName <> 'admin' order by Id desc");
            
            dataGridView1.DataSource = list;
        }
    }
}
