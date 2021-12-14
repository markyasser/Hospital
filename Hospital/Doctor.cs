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
        private IconButton activeButton; //holds the currently selected (highlighted) button
        private Color PrevColorOfActiveButton;
        private bool SidePanel_IsOpen;
        private const int OpenSideMenuWidth = 330;
        private const int ClosedSideMenuWidth = 100;
        public Doctor()
        {
            InitializeComponent();
            HideSubmenus();  
            HidePanels();    
            InitializePanels();
            SidePanel_IsOpen = true;
            Open_Close_SideMenu();
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
        private void Open_Close_SideMenu()
        {
            if (SidePanel_IsOpen) //Collapse menu
            {
                SideMenu_panel.Width = ClosedSideMenuWidth; //closed width
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
                SidePanel_IsOpen = false;
            }
            else
            { //Expand menu
                SideMenu_panel.Width = OpenSideMenuWidth;
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
                SidePanel_IsOpen = true;
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
        private void Patient_iconButton_Click(object sender, EventArgs e)
        {
            ShowSubmenu(Patient_panel);
        }

        private void SelectPatient_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(SelectPatient_panel);
            ActivateButton(SelectPatient_iconButton);
        }

        private void Medicines_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Medicines_panel);
            ActivateButton(Medicines_iconButton);
        }

        private void MedicalTests_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(MedTest_panel);
            ActivateButton(MedicalTests_iconButton);
        }

        private void Surgery_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Surgery_panel);
            ActivateButton(Surgery_iconButton);
        }

        private void Nurses_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Nurses_panel);
            ActivateButton(Nurses_iconButton);
        }

        private void WorkHours_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(WorkingHours_panel);
            ActivateButton(WorkHours_iconButton);
        }

        private void SideBar_iconButton_Click(object sender, EventArgs e)
        {
            Open_Close_SideMenu();
            //SidePanel_timer.Start();
        }

        //sliding bar, not used yet
        private void SidePanel_timer_Tick(object sender, EventArgs e)
        {
            if (!SidePanel_IsOpen)
            {
                SideMenu_panel.Width = SideMenu_panel.Width + 10;
                if (SideMenu_panel.Width >= 330)
                {
                    SidePanel_timer.Stop();
                    Open_Close_SideMenu();

                    SidePanel_IsOpen = true;
                    //Refresh();
                }
            }
            else
            {
                SideMenu_panel.Width = SideMenu_panel.Width - 10;
                if (SideMenu_panel.Width <= 100)
                {
                    SidePanel_timer.Stop();
                    Open_Close_SideMenu();
                    SidePanel_IsOpen = false;
                    //Refresh();
                }
            }
        }
    }
}
