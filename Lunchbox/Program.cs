using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lunchbox
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ２重起動のチェック
            bool createdNew;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, Application.ProductName, out createdNew);
            if (createdNew == false)
            {
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            Application.Run();

            mutex.ReleaseMutex();
        }
    }
}
