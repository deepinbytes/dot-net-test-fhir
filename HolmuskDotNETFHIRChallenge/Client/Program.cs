using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
namespace FHIRClientApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists("FHIR.Data.dll"))
            {
                MessageBox.Show("ServiceDLL Missing Application Will Now close");
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            }
        }
    }
}
