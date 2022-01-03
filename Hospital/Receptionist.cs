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
    public partial class Receptionist : Form
    {
        private int borderSize = 2;
        Controller c;
        Validation v;

        public Receptionist()
        {
            InitializeComponent();
            c = new Controller();           
            v = new Validation();
            //CollapseMenu();
            HideSubmenus();
            InitializePanels();
            HidePanels();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);

        }
        //Drag Form
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}

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
                foreach (Button menuButton in App_panel.Controls.OfType<Button>())
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
                foreach (Button menuButton in App_panel.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(30, 0, 0, 0);
                }
            }
        }

        private void menu_btn_Click(object sender, EventArgs e)//menu click buttons
        {
            CollapseMenu();
        }


        //hide submenus at the beginning
        void HideSubmenus()
        {
            App_panel.Visible = false;
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
                menu.Visible = true;//to hide if there is any open submenus
            }
        }
        //make the dock: fill for all the pannels
        void InitializePanels()
        {
            addPatient_panel.Dock = DockStyle.Fill;
            makeApp_panel.Dock = DockStyle.Fill;
            editApp_panel.Dock = DockStyle.Fill;
            cancelApp_panel.Dock = DockStyle.Fill;
            reserve_panel.Dock = DockStyle.Fill;
            pay_panel.Dock = DockStyle.Fill; ;
        }
        //hide the panels
        void HidePanels()
        {
            addPatient_panel.Visible = false;
            makeApp_panel.Visible = false;
            addPatient_panel.Visible = false;
            editApp_panel.Visible = false;
            cancelApp_panel.Visible = false;
            reserve_panel.Visible = false;
            pay_panel.Visible = false;
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

        private void addPatiendt_btn_Click(object sender, EventArgs e)
        {
            ShowPanel(addPatient_panel);
            HideSubmenus();
        }

        private void MakeAPP_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(makeApp_panel);
            HideSubmenus();
        }

        private void EditApp_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(editApp_panel);

            HideSubmenus();
        }

        private void cancelApp_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(cancelApp_panel);
            HideSubmenus();
        }

        private void reserve_btn_Click(object sender, EventArgs e)
        {
            ShowPanel(reserve_panel);
            HideSubmenus();
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            ShowPanel(pay_panel);
            HideSubmenus();
        }

        private void logoyt_btn_Click(object sender, EventArgs e)
        {
            HideSubmenus();
        }

        private void app_btn_Click(object sender, EventArgs e)
        {
            ShowSubmenu(App_panel);
        }

        private void Addpatient_button_Click(object sender, EventArgs e)
        {
            try
            {
                bool f = false;
                foreach (TextBox txtbox in addPatient_panel.Controls.OfType<TextBox>())
                {
                    if (v.IsEmpty(txtbox.Text))
                    {
                        f=true;
                    }
                }
                if(f || gender_comboBox.SelectedIndex.ToString() == "-1")//lo fadi
                {
                    MessageBox.Show("Enter All Required Data");
                }
                //if (Fname_textBox.Text == "" || Lname_textBox.Text == "" || minit_textBox.Text == "" || Address_textBox.Text == "" || ID_textBox.Text == "" || phno_textBox.Text == ""||gender_comboBox.SelectedIndex.ToString()=="-1")
                //{
                //    MessageBox.Show("Enter All Required Data");
                //}
                else
                {
                    if (!v.IsAlpha(Fname_textBox.Text)||!v.IsAlpha(Lname_textBox.Text)||!v.IsAlpha(minit_textBox.Text)||!v.IsPosInteger(ID_textBox.Text)||!v.IsPosInteger(phno_textBox.Text))
                    {
                        MessageBox.Show("Enter Valid Data");
                    }
                    else
                    {
                        int result = c.InsertPatient(int.Parse(ID_textBox.Text), Fname_textBox.Text, char.Parse(minit_textBox.Text), Lname_textBox.Text, patient_dateTimePicker.Text, Address_textBox.Text,phno_textBox.Text,gender_comboBox.SelectedItem.ToString());
                        if (result >0)
                        {
                            MessageBox.Show("The Patient added successfully to the system");
                        }
                        else
                        {
                            MessageBox.Show("Insertion Failled");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insertion Failled");
            }
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            patient_dateTimePicker.CustomFormat = "yyyy-MM-dd";
            patient_dateTimePicker.Format = DateTimePickerFormat.Custom;
        }
    }
}
