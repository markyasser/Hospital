using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
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
            //Application.Run(new LoginPage());
            //Application.Run(new Admin("Admin"));
            //Application.Run(new Receptionist());
            //Application.Run(new Doctor("sarah1"));
            //Application.Run(new Pharmacist());
            Application.Run(new Nurse());
        }
    }
}
