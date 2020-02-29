using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZBSSys
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
            FrmLoginSys login = new FrmLoginSys();
            if (login.ShowDialog() == DialogResult.OK)
            { //判断登录窗口的结果是否为“OK”
                Application.Run(new FrmMain());
            }

            //Application.Run(new FrmLoginSys());
        }
    }
}
