namespace 物业任务发布平台
{
    partial class TakeFuWuTaskBill
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.任务名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.任务内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.领取 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.任务名称,
            this.任务内容,
            this.创建时间,
            this.业主,
            this.领取});
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(918, 419);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // 任务内容
            // 
            this.任务内容.DataPropertyName = "TContent";
            this.任务内容.HeaderText = "任务内容";
            this.任务内容.Name = "任务内容";
            this.任务内容.ReadOnly = true;
            this.任务内容.Width = 360;
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
            // 领取
            // 
            this.领取.HeaderText = "领取";
            this.领取.Name = "领取";
            this.领取.ReadOnly = true;
            this.领取.Text = "领取";
            this.领取.UseColumnTextForButtonValue = true;
            // 
            // TakeFuWuTaskBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 441);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "TakeFuWuTaskBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "领取任务";
            this.Load += new System.EventHandler(this.TakeFuWuTaskBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 任务名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 任务内容;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主;
        private System.Windows.Forms.DataGridViewButtonColumn 领取;
    }
}