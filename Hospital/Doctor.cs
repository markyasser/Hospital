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
        Controller controllerObj;
        private int CurrentPatientID;
        private int CurrentDoctorID; //to be sent from login page
        private IconButton activeButton; //holds the currently selected (highlighted) button
        private Color PrevColorOfActiveButton;
        private bool SidePanel_IsOpen;
        private const int OpenSideMenuWidth = 330;
        private const int ClosedSideMenuWidth = 100;
        public Doctor()
        {
            InitializeComponent();
            controllerObj = new Controller();
            CurrentPatientID = 1;
            CurrentDoctorID = 1;
            HideSubmenus();  
            HidePanels();    
            InitializePanels();
            SidePanel_IsOpen = true;
            Open_Close_SideMenu();
            RefreshComboBox();
        }
        void RefreshPatient()
        {
            string[] values;
            DataTable dt = controllerObj.SelectPatientsID();
            if (dt != null)
            {
                values = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                if (values != null)
                {
                    SelectPatID_comboBox.DataSource = values;
                }
                else
                {
                    SelectPatID_comboBox.Items.Clear();
                }
            }
          
        }
        void RefreshSurgNames()
        {
            string[] values;
            DataTable dt = controllerObj.SelectSurgNames();
            if (dt != null)
            {
                values = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                if (values != null)
                {
                    SurgName_Reserve_comboBox.DataSource = values;
                }
                else
                {
                    SurgName_Reserve_comboBox.Items.Clear();
                }
            }
          
        }
        void RefreshSurgOperate()
        {
            string[] values;
            DataTable dt = controllerObj.SelectSurgNamesInOperate(CurrentPatientID, CurrentDoctorID);
            if (dt != null)
            {
                values = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                if (values != null)
                {
                    SurgName_Cancel_comboBox.DataSource = values;
                }
                else
                {
                    SurgName_Cancel_comboBox.Items.Clear();
                }
            }
           
        }
        void RefreshSurgUpcommingDatesOperate(string surgID)
        {
            string[] values;
            DataTable dt = controllerObj.SelectUpcommingSurgDates(CurrentPatientID, CurrentDoctorID, surgID); ;
            if (dt != null)
            {
                values = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                if (values != null)
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        int j = 0;
                        while (values[i][j] != ' ')
                        {
                            j++;
                        }
                        values[i] = values[i].Substring(0, j);
                        j = 0;
                        while (values[i][j] != '/')
                        {
                            j++;
                        }
                        string day = values[i].Substring(0, j);
                        if (j == 1)
                        {
                            day = "0" + day;
                        }
                        j++;
                        int k = 0;
                        while (values[i][j] != '/')
                        {
                            j++;
                            k++;
                        }
                        string month = values[i].Substring(day.Length, k);
                        if (k == 1)
                        {
                            month = "0" + month;
                        }
                        string year = values[i].Substring(j + 1, 4);
                        values[i] = year + "-" + month + "-" + day;
                    }
                    SurgDate_Cancel_comboBox.DataSource = values;
                }
                else
                {
                    SurgDate_Cancel_comboBox.Items.Clear();
                }
            }

        }

        void RefreshNurseID_Change()
        {
            string[] values;
            DataTable dt = controllerObj.GetNursesWithNoRooms();
            if (dt != null)
            {
                values = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                if (values != null)
                {
                    NurseID_Change_comboBox.DataSource = values;
                }
                else
                {
                    NurseID_Change_comboBox.Items.Clear();
                }
            }
            else
            {
                NurseID_Change_comboBox.DataSource = null;
            }

        }
        void RefreshNurseID_Assign()
        {
            string[] values;
            DataTable dt = controllerObj.GetNursesWithNoRooms();
            if (dt != null)
            {
                values = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                if (values != null)
                {
                    NurseID_Assign_comboBox.DataSource = values;
                }
                else
                {
                    NurseID_Assign_comboBox.Items.Clear();
                }
            }
            else
            {
                NurseID_Assign_comboBox.DataSource = null;
            }
        }
        void RefreshNurseID_Delete()
        {
            string[] values;
            DataTable dt = controllerObj.GetNursesWithRooms();
            if (dt != null)
            {
                values = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                if (values != null)
                {
                    NurseID_Delete_comboBox.DataSource = values;
                }
                else
                {
                    NurseID_Delete_comboBox.Items.Clear();
                }
            }
        }
        void RefreshRoomNo_Assign()
        {
            string[] values;
            DataTable dt = controllerObj.GetAllRooms();
            if (dt != null)
            {
                values = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                if (values != null)
                {
                    RoomNo_Assign_comboBox.DataSource = values;
                }
                else
                {
                    RoomNo_Assign_comboBox.Items.Clear();
                }
            }
        }
        void RefreshRoomNo_Change()
        {
            string[] values;
            DataTable dt = controllerObj.GetRoomsWithNurses();
            if (dt != null)
            {
                values = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                if (values != null)
                {
                    RoomNo_Change_comboBox.DataSource = values;
                }
                else
                {
                    RoomNo_Change_comboBox.Items.Clear();
                }
            }
        }
        void RefreshNurseDataGrid()
        {
            DataTable dt = controllerObj.DisplayNurseRoomsData();
            Rooms_Nurses_dataGridView.DataSource = dt;
            Rooms_Nurses_dataGridView.Refresh();

        }
        void RefreshComboBox()
        {
            RefreshPatient();
            RefreshSurgNames();
            RefreshSurgOperate();
            RefreshNurseID_Assign();
            RefreshNurseID_Change();
            RefreshNurseID_Delete();
            RefreshRoomNo_Assign();
            RefreshRoomNo_Change();
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
            RefreshNurseDataGrid();
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

        private void SelectPatID_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(SelectPatID_comboBox.Text.ToString());
            CurrentPatientID = id;
            DataTable dt = controllerObj.SelectPatientWithID(id);
            string FullName = dt.Rows[0].ItemArray[1].ToString() + " " + dt.Rows[0].ItemArray[2].ToString() + " " + dt.Rows[0].ItemArray[3].ToString();
            PatName_textBox.Text = FullName;
            PatBD_textBox.Text = dt.Rows[0].ItemArray[4].ToString();
            PatAddress_textBox.Text = dt.Rows[0].ItemArray[5].ToString();
            PatGender_textBox.Text = dt.Rows[0].ItemArray[7].ToString();
            PatPhoneNo_textBox.Text = dt.Rows[0].ItemArray[6].ToString();
        }

        private void Doctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerObj.TerminateConnection();
        }

        private void SurgName_Cancel_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = SurgName_Cancel_comboBox.Text;
            RefreshSurgUpcommingDatesOperate(name);
        }

        private void ReserveSurg_button_Click(object sender, EventArgs e)
        {
            int result = controllerObj.ReserveSurgery(CurrentPatientID, CurrentDoctorID, SurgName_Reserve_comboBox.Text, SurgDate_dateTimePicker.Text.ToString());
            if (result == 0)
            {
                MessageBox.Show("Reservation of a new surgery failed");
            }
            else
            {
                MessageBox.Show("Reservation successful!");
                RefreshSurgOperate();
            }
        }

        private void DeleteSurg_button_Click(object sender, EventArgs e)
        {
            int result = controllerObj.CancelSurgery(CurrentPatientID, CurrentDoctorID, SurgName_Cancel_comboBox.Text.ToString(), SurgDate_Cancel_comboBox.Text.ToString());
            if (result == 0)
            {
                MessageBox.Show("Cancelation failed");
            }
            else
            {
                MessageBox.Show("Cancelation successful!");
                RefreshSurgOperate();
            }
        }

        private void NurseID_Delete_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetRoomOfANurse(int.Parse(NurseID_Delete_comboBox.Text.ToString()));
            if (dt != null)
            {
                RoomNo_Delete_textBox.Text = dt.Rows[0].ItemArray[0].ToString();
            }
            else
            {
                RoomNo_Delete_textBox.Text = "";
            }

        }

        private void AssignNurse_button_Click(object sender, EventArgs e)
        {
            if (NurseID_Assign_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a nurse, if no nurses are shown, this means that all nurses are currently serving another rooms");
                return;
            }
            if (RoomNo_Assign_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a room, if no rooms are shown, this means that all rooms are currently served");
                return;
            }
            int result = controllerObj.AssignNurseToRoom(int.Parse(NurseID_Assign_comboBox.Text.ToString()), int.Parse(RoomNo_Assign_comboBox.Text.ToString()));
            if (result == 0)
            {
                MessageBox.Show("Assignment failed");
            }
            else
            {
                MessageBox.Show("Assignment successful!");
                RefreshNurseID_Assign();
                RefreshNurseID_Change();
                RefreshNurseID_Delete();
                RefreshRoomNo_Change();
                RefreshNurseDataGrid();
            }
        }

        private void ChangeNurse_button_Click(object sender, EventArgs e)
        {
            if (NurseID_Change_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a nurse, if no nurses are shown, this means that all nurses are currently serving another rooms");
                return;
            }
            if (RoomNo_Change_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a room, if no rooms are shown, this means that all rooms are currently served");
                return;
            }
            int result = controllerObj.AssignNurseToRoom(int.Parse(NurseID_Change_comboBox.Text.ToString()), int.Parse(RoomNo_Change_comboBox.Text.ToString()));
            if (result == 0)
            {
                MessageBox.Show("Change failed");
            }
            else
            {
                MessageBox.Show("Change successful!");
                RefreshNurseID_Delete();
                RefreshNurseDataGrid();
            }
        }

        private void DeleteNurse_button_Click(object sender, EventArgs e)
        {
            if (NurseID_Delete_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a nurse, if no nurses are shown, this means that all nurses are currently serving another rooms");
                return;
            }
            int result = controllerObj.RemoveNursefromRoom(int.Parse(NurseID_Delete_comboBox.Text.ToString()));
            if (result == 0)
            {
                MessageBox.Show("Deletion failed");
            }
            else
            {
                MessageBox.Show("Deletion successful!");
                RefreshNurseID_Assign();
                RefreshNurseID_Change();
                RefreshNurseID_Delete();
                RefreshNurseDataGrid();
            }
        }
    }
}
