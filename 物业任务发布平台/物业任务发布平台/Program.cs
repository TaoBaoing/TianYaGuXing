using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 物业任务发布平台
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (DateTime.Now > new DateTime(2016, 3, 15))
            {
                MessageBox.Show("过期");
                return;
            }
            else
            {
                Application.Run(new Form1());
            }
           
        }
    }
}
