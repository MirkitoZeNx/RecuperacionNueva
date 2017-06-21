using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Git_Ex1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Protected Overridable Property DoubleBuffered As Boolean(true);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
