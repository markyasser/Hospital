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
    public partial class Admin : Form
    {
        Controller controllerObj;
        public Admin()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            if (fname.Text == "")
                label6.Text = "*"; 
            else label6.Text = "";

            if (minit.Text == "")
                label8.Text = "*";
            else label8.Text = "";

            if (lname.Text == "")
                label7.Text = "*";
            else label7.Text = "";

            if (address.Text == "")
                label12.Text = "*";
            else label12.Text = "";

            if (id.Text == "")
                label9.Text = "*";
            else label9.Text = "";

            if (password.Text == "")
                label10.Text = "*";
            else label10.Text = "";
            int Phone;
            bool flag = Int32.TryParse(pnumber.Text, out Phone);
            if (!flag)
                label14.Text = "*";
            else label14.Text = "";
            string Gender = gender.Text;
            char SEX;
            if (Gender == "Male") SEX = 'M';
            else SEX = 'F';
            string birthdate = bdate.Value.ToString();

            int result;
            if (id.Text.Contains("DR"))
            {
                result = controllerObj.InsertDoctor(fname.Text, minit.Text, lname.Text, ID, bdate, address.Text, SEX, Phone, dep.SelectedIndex);
            }
            

            //if (result == 0)
            //{
            //    MessageBox.Show("The insertion of a new Doctor failed");
            //}
            //else
            //{
            //    MessageBox.Show("Employee '" + fname.Text + " " + minit.Text + " " + lname.Text + "' is inserted successfully!");
            //}
        }



        private void SearchList_Click(object sender, EventArgs e)
        {
            string pos = position.Text;
        }

        private void SearchGet_Click(object sender, EventArgs e)
        {
            if (id1.Text == "")
                label26.Text = "*";
            else label26.Text = "";

        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            if (id2.Text == "")
                label27.Text = "*";
            else label27.Text = "";
        }
        private void LogOut_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// ---------------------------------------------------------------------------///
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
