using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HTTPserverHere
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CommandLine.args = args;
            Application.Run(new Main_Form());
        }
    }
}
