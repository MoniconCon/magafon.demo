using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarATHON
{
    static class Program
    {
        public static DateTime start = new DateTime(2020, 01, 30, 12, 00, 00);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
    
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mains());
        }
    }
}
