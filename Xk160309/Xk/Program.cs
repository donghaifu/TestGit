using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Xk
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool runone;
            System.Threading.Mutex run = new System.Threading.Mutex(true, "zhuangpeituzhi", out runone);
            if (runone)
            {
                run.ReleaseMutex();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmLogin());
                if (CPublic.isUser == true)
                {
                    Application.Run(new frmMain());
                }
            }
            else
            {
                MessageBox.Show("已经有一个程序在运行，请充分利用！");
            }
        }
    }
}
