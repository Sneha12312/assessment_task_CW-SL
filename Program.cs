using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessment_task
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2()); //open the window for form2
            Application.Run(new Form16()); //after form2 is closed, open form16
            Application.Run(new Form4()); //after form16 is closed, open form4
            Application.Run(new Form5()); //after form4 is closed, open form5



        }
    }
}
