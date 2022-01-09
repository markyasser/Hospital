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
    public partial class PharmaSettings : Form
    {
        Controller controllerObj;
        private string USERNAME;
        public PharmaSettings(Controller obj, string user)
        {
            InitializeComponent();
            controllerObj = obj;
            USERNAME = user;
        }

        private void Change_Passwrod_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (OldPass.Text == "")
            {
                label66.Text = "*This field cannot be empty";
                flag = false;
            }
            else label66.Text = "";
            if (NewPass.Text == "")
            {
                label67.Text = "*This field cannot be empty";
                flag = false;
            }
            else label67.Text = "";
            if (!flag) return;
            object oldpassword = controllerObj.GetOldPassword(USERNAME);

            if (oldpassword != null && Validation.hashpassword(OldPass.Text) == oldpassword.ToString())
            {
                if (OldPass.Text == NewPass.Text)
                {
                    MessageBox.Show("The new password must be different");
                    return;
                }
                if (NewPass.Text.Length < 4)
                {
                    MessageBox.Show("Password is very weak, insert more than 4 characters");
                    return;
                }
                int result = controllerObj.ChangePassword(USERNAME, Validation.hashpassword(NewPass.Text));
                if (result > 0)
                {
                    MessageBox.Show("Password changed successfully");
                }
                else
                    MessageBox.Show("An error occured");
            }
            else
                MessageBox.Show("Wrong old password");
        }
    }
    
}
