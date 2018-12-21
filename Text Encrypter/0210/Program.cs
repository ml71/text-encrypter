using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinMaggieTextEncrypter.Properties;

namespace LinMaggieTextEncrypter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Console.WriteLine("PASSWORD at runtime: " + Settings.Default.Password.ToString());
            Application.Run(new FormTextEncrypter());
           
        }
    }
}
