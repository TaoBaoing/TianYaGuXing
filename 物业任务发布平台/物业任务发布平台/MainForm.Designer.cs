namespace 物业任务发布平台
{
    partial class MainForm
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
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.服务任务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.业务员领取任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.服务任务管理ToolStripMenuItem,
            this.选择服务ToolStripMenuItem,
            this.查询服务ToolStripMenuItem,
            this.业务员领取任务ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 25);
            this.menuStrip1.TabIndex = 0;
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
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 服务任务管理ToolStripMenuItem
            // 
            this.服务任务管理ToolStripMenuItem.Name = "服务任务管理ToolStripMenuItem";
            this.服务任务管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.服务任务管理ToolStripMenuItem.Text = "服务任务管理";
            this.服务任务管理ToolStripMenuItem.Click += new System.EventHandler(this.服务任务管理ToolStripMenuItem_Click);
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
            // 业务员领取任务ToolStripMenuItem
            // 
            this.业务员领取任务ToolStripMenuItem.Name = "业务员领取任务ToolStripMenuItem";
            this.业务员领取任务ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.业务员领取任务ToolStripMenuItem.Text = "业务员领取任务";
            this.业务员领取任务ToolStripMenuItem.Click += new System.EventHandler(this.业务员领取任务ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 475);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物业任务平台";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 服务任务管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 业务员领取任务ToolStripMenuItem;
    }
}