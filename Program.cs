using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKhachSan.UI;

namespace QLKhachSan
{
    static class Program
    {
        public static bool OpenLoginFormOnClose { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OpenLoginFormOnClose = false;
            //Application.Run(new frmBill());
            //Application.Run(new frmLogin2());
            //Application.Run(new MainForm());
            Application.Run(new frmLogin());
            
            if (OpenLoginFormOnClose)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
