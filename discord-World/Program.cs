using SelfBot_Framework.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discord_World
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            Task task = Task.Run(SelfBot_Framework.Startup.Startup.ass);
            Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1()); 
        }
    }
}
