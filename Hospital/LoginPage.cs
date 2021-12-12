using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            // check if the id is valid

            // check if the password is valid
            if (id.Text =="admin" && password.Text =="admin")
            {
                Admin admin = new Admin();
                admin.Show();
            }
            else
            {
                Doctor dr = new Doctor();
                dr.Show();
            }
            //check the first 2 chars in the id to go to the corresponding interface
            
            //this.Close();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
