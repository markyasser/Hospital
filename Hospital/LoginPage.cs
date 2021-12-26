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
        Color selected = Color.White;
        Color unselected = Color.Silver;
        Controller obj;
        public LoginPage()
        {
            InitializeComponent();
            obj = new Controller();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            // check if the id is valid
            Object Exsit = obj.ValidateUser(id.Text);
            // check if the password is valid

            if (Exsit != null)
            {
                string user = obj.GetUser(id.Text);
                if (user == "Doctor")
                {
                    Doctor dr = new Doctor();
                    dr.Show();
                }
                else if (user == "Pharmacist")
                {
                    Pharmacist p = new Pharmacist();
                    p.Show();
                }
                else if (user == "Receptionist")
                {
                    Receptionist r = new Receptionist();
                    r.Show();
                }
                else if (user == "Nurse")
                {
                    Nurse n = new Nurse();
                    n.Show();
                }
                else 
                {
                    Admin admin = new Admin();
                    admin.Show();
                }
            }
            
            else label1.Text = "* Wrong ID or Password";
            //check the first 2 chars in the id to go to the corresponding interface
            
            //this.Close();
        }

        
        private void id_click(object sender, EventArgs e)
        {
            id.BackColor = selected;
            panel2.BackColor = selected;

            password.BackColor = unselected;
            panel3.BackColor = unselected;
        }

        private void password_click(object sender, EventArgs e)
        {
            password.BackColor = selected;
            panel3.BackColor = selected;

            id.BackColor = unselected;
            panel2.BackColor = unselected;
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            id.BackColor = selected;
            panel2.BackColor = selected;


            password.BackColor = unselected;
            panel3.BackColor = unselected;
            Show_Hide_Password.ForeColor = unselected;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.BackColor = selected;
            panel3.BackColor = selected;
            Show_Hide_Password.ForeColor = Color.Transparent;

            id.BackColor = unselected;
            panel2.BackColor = unselected;
        }

        private void Show_Hide_Password_Click(object sender, EventArgs e)
        {
            if (Show_Hide_Password.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                Show_Hide_Password.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                password.UseSystemPasswordChar = false;
            }
            else
            {
                Show_Hide_Password.IconChar = FontAwesome.Sharp.IconChar.Eye;
                password.UseSystemPasswordChar = true;
            }
        }
    }
}
