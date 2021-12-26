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
<<<<<<< HEAD
            Application.Run(new LoginPage());
=======
            //Application.Run(new LoginPage());
>>>>>>> 065c3ef6e06e6434b5e1f1a22b5822abe66aab31
            //Application.Run(new Admin());
            //Application.Run(new LoginPage());
            //Application.Run(new Admin());
            //Application.Run(new Receptionist());
            Application.Run(new Doctor());
            //Application.Run(new Pharmacist());
            //Application.Run(new Nurse());
        }
    }
}
