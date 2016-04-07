namespace 物业任务发布平台
{
    partial class YeZhuLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.业主评价服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.任务名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业务员 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.接受时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.完成时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.评价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.选择服务ToolStripMenuItem,
            this.查询服务ToolStripMenuItem,
            this.业主评价服务ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 选择服务ToolStripMenuItem
            // 
            this.选择服务ToolStripMenuItem.Name = "选择服务ToolStripMenuItem";
            this.选择服务ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.选择服务ToolStripMenuItem.Text = "业主选择服务";
            this.选择服务ToolStripMenuItem.Click += new System.EventHandler(this.选择服务ToolStripMenuItem_Click);
            // 
            // 查询服务ToolStripMenuItem
            // 
            this.查询服务ToolStripMenuItem.Name = "查询服务ToolStripMenuItem";
            this.查询服务ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.查询服务ToolStripMenuItem.Text = "查询服务";
            this.查询服务ToolStripMenuItem.Click += new System.EventHandler(this.查询服务ToolStripMenuItem_Click);
            // 
            // 业主评价服务ToolStripMenuItem
            // 
            this.业主评价服务ToolStripMenuItem.Name = "业主评价服务ToolStripMenuItem";
            this.业主评价服务ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.业主评价服务ToolStripMenuItem.Text = "业主评价服务";
            this.业主评价服务ToolStripMenuItem.Click += new System.EventHandler(this.业主评价服务ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.任务名称,
            this.创建时间,
            this.业主,
            this.业务员,
            this.接受时间,
            this.完成时间,
            this.状态,
            this.评价});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(944, 466);
            this.dataGridView1.TabIndex = 5;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "Id";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Width = 80;
            // 
            // 任务名称
            // 
            this.任务名称.DataPropertyName = "TName";
            this.任务名称.HeaderText = "任务名称";
            this.任务名称.Name = "任务名称";
            this.任务名称.ReadOnly = true;
            this.任务名称.Width = 150;
            // 
            // 创建时间
            // 
            this.创建时间.DataPropertyName = "YeZhuDateTime";
            this.创建时间.HeaderText = "创建时间";
            this.创建时间.Name = "创建时间";
            this.创建时间.ReadOnly = true;
            // 
            // 业主
            // 
            this.业主.DataPropertyName = "YuZhuName";
            this.业主.HeaderText = "业主";
            this.业主.Name = "业主";
            this.业主.ReadOnly = true;
            // 
            // 业务员
            // 
            this.业务员.DataPropertyName = "YeWuYuanName";
            this.业务员.HeaderText = "业务员";
            this.业务员.Name = "业务员";
            this.业务员.ReadOnly = true;
            // 
            // 接受时间
            // 
            this.接受时间.DataPropertyName = "YeWuYuanJieShouDateTime";
            this.接受时间.HeaderText = "接受时间";
            this.接受时间.Name = "接受时间";
            this.接受时间.ReadOnly = true;
            // 
            // 完成时间
            // 
            this.完成时间.DataPropertyName = "YeWuYuanWanChengDateTime";
            this.完成时间.HeaderText = "完成时间";
            this.完成时间.Name = "完成时间";
            this.完成时间.ReadOnly = true;
            // 
            // 状态
            // 
            this.状态.DataPropertyName = "BillState";
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            this.状态.ReadOnly = true;
            // 
            // 评价
            // 
            this.评价.DataPropertyName = "PingJia";
            this.评价.HeaderText = "评价";
            this.评价.Name = "评价";
            this.评价.ReadOnly = true;
            this.评价.Width = 200;
            // 
            // YeZhuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "YeZhuLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物业管理增值服务系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YeZhuLogin_FormClosing);
            this.Load += new System.EventHandler(this.YeZhuLogin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 业主评价服务ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 任务名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业务员;
        private System.Windows.Forms.DataGridViewTextBoxColumn 接受时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 完成时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 评价;
    }
}