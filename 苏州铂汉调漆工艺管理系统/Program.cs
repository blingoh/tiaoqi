using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 调漆工艺管理系统
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin loginFrm = new FrmLogin();
            loginFrm.ShowDialog();

            if (DialogResult.Yes == loginFrm.DialogResult)
            {
                Application.Run(new FrmMain());
            }
        }
    }
}
