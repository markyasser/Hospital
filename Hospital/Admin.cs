using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Hospital
{
    public partial class Admin : Form
    {
        Controller controllerObj;
        private int borderSize = 2;
        private Size formSize;
        public Admin()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            CollapseMenu();
            hide.Visible = false;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void show_hide_Click(object sender, EventArgs e)
        {
            show_hide.Visible = false;
            hide.Visible = true;
            password.UseSystemPasswordChar = false;
        }
        private void hide_Click(object sender, EventArgs e)
        {
            show_hide.Visible = true;
            hide.Visible = false;
            password.UseSystemPasswordChar = true;
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
            if (Gender == "")
                label13.Text = "*";
            else label13.Text = "";
            char SEX;
            if (Gender == "Male") SEX = 'M';
            else SEX = 'F';
            string birthdate = bdate.Value.ToString();

            int result;
            if (id.Text.Contains("DR"))
            {
                //result = controllerObj.InsertDoctor(fname.Text, minit.Text, lname.Text, ID, bdate, address.Text, SEX, Phone, dep.SelectedIndex);
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



        //private void SearchList_Click(object sender, EventArgs e)
        //{
        //    string pos = position.Text;
        //}

        //private void SearchGet_Click(object sender, EventArgs e)
        //{
        //    if (id1.Text == "")
        //        label26.Text = "*";
        //    else label26.Text = "";

        //}

        //private void DeleteEmployee_Click(object sender, EventArgs e)
        //{
        //    if (id2.Text == "")
        //        label27.Text = "*";
        //    else label27.Text = "";
        //}
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
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                panelMenu.Width = 100;
                HP_lbl.Visible = false;
                MS_lbl.Visible = false;
                menu_btn.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 333;
                HP_lbl.Visible = true;
                MS_lbl.Visible = true;
                menu_btn.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
        private void menu_btn_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
    }
}
