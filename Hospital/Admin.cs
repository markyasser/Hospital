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
        private IconButton activeButton;
        private Panel leftBtnBorder;
        private Color PrevColorOfActiveButton;
        public Admin()
        {
            InitializeComponent();
            controllerObj = new Controller();
            WindowState = FormWindowState.Maximized;
            HideSubmenus();
            HidePanels();
            InitializePanels();
            Open_Close_SideBar();
            CreateLeftButtonBorder();
            //to show the department only if the position is a doctor
            dep.Visible = false;
            label43.Visible = false;
            label11.Visible = false;
        }
        //Drag Form
        //hide submenus at the beginning
        void HideSubmenus()
        {
            Employee_panel.Visible = false;
        }
        //hide the panels (nurses, surgery, etc.)
        void HidePanels()
        {
            CreateAccount_panel.Visible = false;
            List_panel.Visible = false;
            Delete_panel.Visible = false;
            Search_panel.Visible = false;
            Earnings_panel.Visible = false;
            Departments_Panel.Visible = false;
        }
        //make the dock: fill for all the pannels
        void InitializePanels()
        {
            CreateAccount_panel.Dock = DockStyle.Fill;
            List_panel.Dock = DockStyle.Fill;
            Delete_panel.Dock = DockStyle.Fill;
            Search_panel.Dock = DockStyle.Fill;
            Earnings_panel.Dock = DockStyle.Fill;
            Departments_Panel.Dock = DockStyle.Fill;
        }
        //create border for the activate button feature
        void CreateLeftButtonBorder()
        {
            leftBtnBorder = new Panel();
            leftBtnBorder.Size = new Size(7, 60);
            SideMenu_panel.Controls.Add(leftBtnBorder);
            Employee_panel.Controls.Add(leftBtnBorder);
        }
        //show submenu if you click a button
        void ShowSubmenu(Panel menu)
        {
            if (menu.Visible)
            {
                menu.Visible = false;
            }
            else
            {
                HideSubmenus();
                menu.Visible = true;
            }
        }
        //show panel when you click its button
        void ShowPanel(Panel menu)
        {
            if (!menu.Visible)
            {
                HidePanels();
                menu.BringToFront();
                menu.Visible = true;
            }
        }
        //opens left sidebar if its closed and vice versa
        private void Open_Close_SideBar()
        {
            if (SideMenu_panel.Width > 200) //Collapse menu
            {
                SideMenu_panel.Width = 100; //closed width
                label36.Visible = false;    //hide logo
                label37.Visible = false;
                //for each button in the side panel
                foreach (Button menuButton in SideMenu_panel.Controls.OfType<Button>())
                {
                    menuButton.Text = "";  //hide button name
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
                //for each button in submenu panel
                foreach (Button menuButton in Employee_panel.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                SideMenu_panel.Width = 400;
                label36.Visible = true;
                label37.Visible = true;
                foreach (Button menuButton in SideMenu_panel.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                foreach (Button menuButton in Employee_panel.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(30, 0, 0, 0);
                }
            }
        }
        //to highlight color when pressed
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                //remove highlight from previously selected button
                DisableButton(PrevColorOfActiveButton);
                //Button
                activeButton = (IconButton)senderBtn;
                PrevColorOfActiveButton = activeButton.BackColor;
                activeButton.BackColor = Color.FromArgb(98, 102, 210);
                activeButton.ForeColor = Color.Black;
                activeButton.IconColor = Color.Black;
            }
        }
        //to remove highlight from the previous selected button
        private void DisableButton(Color prevColor)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = prevColor;
                activeButton.ForeColor = Color.White;
                activeButton.IconColor = Color.White;
            }
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                activeButton = (IconButton)senderBtn;
                activeButton.BackColor = Color.FromArgb(37, 36, 81);
                activeButton.ForeColor = color;
                activeButton.TextAlign = ContentAlignment.MiddleCenter;
                activeButton.IconColor = color;
                activeButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                activeButton.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBtnBorder.BackColor = color;
                leftBtnBorder.Location = new Point(0, activeButton.Location.Y);
                leftBtnBorder.Visible = true;
                leftBtnBorder.BringToFront();
                //Current Child Form Icon
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(31, 30, 68);
                activeButton.ForeColor = Color.Gainsboro;
                activeButton.TextAlign = ContentAlignment.MiddleLeft;
                activeButton.IconColor = Color.Gainsboro;
                activeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                activeButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void SideBar_iconButton_Click(object sender, EventArgs e)
        {
            Open_Close_SideBar();
        }

        private void Employee_Button_Click(object sender, EventArgs e)
        {
            ShowSubmenu(Employee_panel);
        }

        private void Earnings_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Earnings_panel);
            ActivateButton(Earnings_iconButton);
        }
        private void Departments_Click(object sender, EventArgs e)
        {
            ShowPanel(Departments_Panel);
            ActivateButton(Departments);
        }
        private void List_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(List_panel);
            ActivateButton(List_iconButton);
        }

        private void Search_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Search_panel);
            ActivateButton(Search_iconButton);
        }

        private void Delete_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Delete_panel);
            ActivateButton(Delete_iconButton);
        }

        private void Create_Account_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(CreateAccount_panel);
            ActivateButton(Create_Account_iconButton);
        }
        private void Logout_iconButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SignUp_Click_1(object sender, EventArgs e)
        {
            bool flag = true;
            if (fname.Text == "")
            {
                label6.Text = "*";
                flag = false;
            }
            else label6.Text = "";

            if (minit.Text == "")
            {
                label8.Text = "*";
                flag = false;
            }
            else label8.Text = "";

            if (lname.Text == "")
            {
                label7.Text = "*";
                flag = false;
            }
            else label7.Text = "";

            int ID;
            bool flag2 = Int32.TryParse(id.Text, out ID);
            if (!flag2)
            {
                label25.Text = "*";
                flag = false;
            }

            if (address.Text == "")
            {
                label12.Text = "*";
                flag = false;
            }
                
            else label12.Text = "";

            if (pos.Text == "")
            {
                label9.Text = "*";
                flag = false;
            }
                
            else label9.Text = "";

            if (password.Text == "")
            {
                label10.Text = "*";
                flag = false;
            }
                
            else label10.Text = "";

            if (dep.Text == "")
            {
                label11.Text = "*";
                flag = false;
            }
            else label11.Text = "";
            int Phone;
            bool flag1 = Int32.TryParse(pnumber.Text, out Phone);
            if (!flag1)
            {
                label1.Text = "*";
                flag = false;
            }  
            else label1.Text = "";
            string Gender = gender.Text;
            if (Gender == "")
            {
                label2.Text = "*";
                flag = false;
            }
            else label2.Text = "";

            if (flag == false) return; //if any input is incorrect return

            char SEX;
            if (Gender == "Male") SEX = 'M';
            else SEX = 'F';
            string birthdate = bdate.Value.ToString();

            int result=0;

            //result = controllerObj.InsertDoctor(id, fname.Text, minit.Text, lname.Text,username.Text, bdate.Value, address.Text, SEX, phone, dep.selectedindex);
            if (result > 0)
                MessageBox.Show("Doctor " + special.Text + " is inserted successfully");
            else
                MessageBox.Show("Insertion Failed");

        }

        private void Show_Hide_Password_Click(object sender, EventArgs e)
        {
            if (Show_Hide_Password.IconChar == IconChar.Eye)
            {
                Show_Hide_Password.IconChar = IconChar.EyeSlash;
                password.UseSystemPasswordChar = false;
            }
            else
            {
                Show_Hide_Password.IconChar = IconChar.Eye;
                password.UseSystemPasswordChar = true;
            }
        }

        private void pos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pos.Text == "Doctor")
            {
                dep.Visible = true;
                label43.Visible = true;
                label11.Visible = true;
            }
            else
            {
                dep.Visible = false;
                label43.Visible = false;
                label11.Visible = false;
            }
        }

        private void Insert_Department_Click(object sender, EventArgs e)
        {
            int dno;
            bool flag = Int32.TryParse(Dnumber.Text, out dno);
            if (!flag)
                label17.Text = "*";
            else label17.Text = "";

            if (special.Text == "")
            {
                label18.Text = "*";
                flag = false;
            }
            else label18.Text = "";

            if (!flag) return;

            int result = controllerObj.InsertDepartment(dno, special.Text.ToString());
            if (result > 0)
                MessageBox.Show("Department " + special.Text + " is inserted successfully");
            else
                MessageBox.Show("Insertion Failed");
        }
    }
}
