using System;
using System.Windows.Forms;
using CattleHealthy_NET9_Final.Forms;

namespace CattleHealthy_NET9_Final
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());
        }
    }
}
