using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Models;

namespace PoliceInfo
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
            bool mainRestart;
            do
            {
                mainRestart = false;
                FrmLogin objLogin = new FrmLogin();
                DialogResult result = objLogin.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FrmMain objMain = new FrmMain();
                    Application.Run(objMain);
                    if(objMain.DialogResult==DialogResult.Cancel)
                    {
                        mainRestart = true;
                    }
                }
                else
                {
                    Application.Exit();
                    break;
                }
            } while (mainRestart);            
        }
        public static Login currentLogin = null;
    }
}
