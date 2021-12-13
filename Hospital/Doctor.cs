using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace Hospital
{
    public partial class Doctor : Form
    {
        private IconButton activeButton;
        private Panel leftBtnBorder;
        public Doctor()
        {
            InitializeComponent();
            HideSubmenus();  
            HidePanels();    
            InitializePanels();
            Open_Close_SideBar();
            CreateLeftButtonBorder();
        }
        //hide submenus at the beginning
        void HideSubmenus()
        {
            Patient_panel.Visible = false;
        }
        //hide the panels (nurses, surgery, etc.)
        void HidePanels()
        {
            SelectPatient_panel.Visible = false;
            WorkingHours_panel.Visible = false;
            Medicines_panel.Visible = false;
            MedTest_panel.Visible = false;
            Surgery_panel.Visible = false;
            Nurses_panel.Visible = false;
        }
        //make the dock: fill for all the pannels
        void InitializePanels()
        {
            SelectPatient_panel.Dock = DockStyle.Fill;
            WorkingHours_panel.Dock = DockStyle.Fill;
            Medicines_panel.Dock = DockStyle.Fill;
            MedTest_panel.Dock = DockStyle.Fill;
            Surgery_panel.Dock = DockStyle.Fill;
            Nurses_panel.Dock = DockStyle.Fill;
        }
        //create border for the activate button feature
        void CreateLeftButtonBorder()
        {
            leftBtnBorder = new Panel();
            leftBtnBorder.Size = new Size(7, 60);
            SideMenu_panel.Controls.Add(leftBtnBorder);
            Patient_panel.Controls.Add(leftBtnBorder);
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
                foreach (Button menuButton in Patient_panel.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                SideMenu_panel.Width = 333;
                label36.Visible = true;
                label37.Visible = true;
                foreach (Button menuButton in SideMenu_panel.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                foreach (Button menuButton in Patient_panel.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(30, 0, 0, 0);
                }
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
        private void Patient_iconButton_Click(object sender, EventArgs e)
        {
            ShowSubmenu(Patient_panel);
        }

        private void SelectPatient_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(SelectPatient_panel);
        }

        private void Medicines_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Medicines_panel);
        }

        private void MedicalTests_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(MedTest_panel);
        }

        private void Surgery_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Surgery_panel);
        }

        private void Nurses_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Nurses_panel);
        }

        private void WorkHours_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(WorkingHours_panel);
        }

        private void SideBar_iconButton_Click(object sender, EventArgs e)
        {
            Open_Close_SideBar();
        }
    }
}
