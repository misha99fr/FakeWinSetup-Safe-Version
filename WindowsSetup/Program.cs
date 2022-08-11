using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WindowsSetup
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool createdNew;
            Mutex mutex = new Mutex(true, "123121424823438483", out createdNew);
            if (createdNew)
            {
                Application.Run((Form)new Warning());
            }
            else
            {
                int num = (int)MessageBox.Show("why are two processes running?");
                Environment.Exit(0);
            }
        }
    }
}