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
        private int CurrentDoctorID; //to be sent from login page
        private IconButton activeButton; //holds the currently selected (highlighted) button
        private Color PrevColorOfActiveButton;
        private bool SidePanel_IsOpen;
        private const int OpenSideMenuWidth = 330;
        private const int ClosedSideMenuWidth = 100;
        private string USERNAME;
        public Doctor(string user)
        {
            InitializeComponent();
            controllerObj = new Controller();
            USERNAME = user;
            UserName_label.Text = USERNAME;
            GetDoctorID(USERNAME);
            HideSubmenus();  
            HidePanels();    
            InitializePanels();
            SidePanel_IsOpen = true;
            Open_Close_SideMenu();
        }
        void GetDoctorID(string username)
        {
            DataTable dt = controllerObj.GetDrIDByUsername(username);
            if (dt != null)
            {
                CurrentDoctorID = int.Parse(dt.Rows[0][0].ToString());
            }
            else
            {
                MessageBox.Show("Error Occured, can't find id");
                this.Close();
            }
        }
        //refresh all patients IDs in the sent combobox
        void RefreshPatient(ComboBox output)
        {
            string[] values;
            DataTable dt = controllerObj.SelectPatientsID();
            if (dt != null)
            {
                values = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                if (values != null)
                {
                    output.DataSource = values;
                }
                else
                {
                    output.Items.Clear();
                }
            }
            else
            {
                output.DataSource = null;
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
            else
            {
                SurgName_Reserve_comboBox.DataSource = null;
            }

        }
        void RefreshSurgOperate()
        {
            if (PatID_Surg_comboBox.SelectedIndex == -1)
            {
                return;
            }
            string[] values;
            DataTable dt = controllerObj.SelectSurgNamesInOperate(int.Parse(PatID_Surg_comboBox.Text), CurrentDoctorID);
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
            else
            {
                SurgName_Cancel_comboBox.DataSource = null;
            }
        }
        void RefreshSurgUpcommingDatesOperate(string surgID)
        {
            if (PatID_Surg_comboBox.SelectedIndex == -1)
            {
                return;
            }
            string[] values;
            DataTable dt = controllerObj.SelectUpcommingSurgDates(int.Parse(PatID_Surg_comboBox.Text), CurrentDoctorID, surgID);
            if (dt != null)
            {
                values = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                if (values != null)
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        values[i] = Convert.ToDateTime(values[i]).ToString("yyyy-MM-dd");
                    }
                    SurgDate_Cancel_comboBox.DataSource = values;
                }
                else
                {
                    SurgDate_Cancel_comboBox.Items.Clear();
                }
            }
            else
            {
                SurgDate_Cancel_comboBox.DataSource = null;
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
            else
            {
                NurseID_Delete_comboBox.DataSource = null;
            }
        }
        void RefreshRoomNo_Assign()
        {
            string[] values;
            DataTable dt = controllerObj.GetRoomsWithPatient();
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
            else
            {
                RoomNo_Assign_comboBox.DataSource = null;
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
            else
            {
                RoomNo_Change_comboBox.DataSource = null;
            }
        }
        void RefreshNurseDataGrid()
        {
            DataTable dt = controllerObj.DisplayNurseRoomsData();
            Rooms_Nurses_dataGridView.DataSource = dt;
            Rooms_Nurses_dataGridView.Refresh();

        }
        void RefreshMedTestNames()
        {
            string[] values;
            DataTable dt = controllerObj.GetMedTestNames();
            if (dt != null)
            {
                values = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                if (values != null)
                {
                    TestName_comboBox.DataSource = values;
                }
                else
                {
                    TestName_comboBox.Items.Clear();
                }
            }
            else
            {
                TestName_comboBox.DataSource = null;
            }
        }
        void RefreshMedicine()
        {
            RefreshAppointPatientsToday(PatIDinMed_comboBox);
            RefreshAppointTimeToday(TimeinMed_comboBox, PatIDinMed_comboBox);
        }
        void RefreshAppointPatientsToday(ComboBox outputcombo)
        {
            string[] values;
            DataTable dt = controllerObj.GetAppointPatientsToday(CurrentDoctorID);
            if (dt != null)
            {
                values = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                if (values != null)
                {
                    outputcombo.DataSource = values;
                }
                else
                {
                    outputcombo.Items.Clear();
                }
            }
            else
            {
                outputcombo.DataSource = null;
            }
        }
        void RefreshPrice()
        {
            DataTable dt = controllerObj.GetDoctorPrice(CurrentDoctorID);
            if (dt != null)
            {
                int price;
                bool isValid = int.TryParse(dt.Rows[0][0].ToString(), out price);
                if (isValid)
                {
                    SetAppointPrice_textBox.Text = price.ToString();
                }
            }
        }
        void RefreshAppointTimeToday(ComboBox outputcombo, ComboBox patidcombo)
        {
            string[] values;
            if (patidcombo.SelectedIndex == -1)
            {
                return;
            }
            DataTable dt = controllerObj.GetAppointTimeToday(CurrentDoctorID, int.Parse(patidcombo.Text.ToString()));
            if (dt != null)
            {
                values = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                if (values != null)
                {
                    outputcombo.DataSource = values;
                }
                else
                {
                    outputcombo.Items.Clear();
                }
            }
            else
            {
                outputcombo.DataSource = null;
            }
        }
        void RefreshWorkingHours()
        {
            DataTable dt = controllerObj.GetWorkingHours(CurrentDoctorID);
            if (dt != null)
            {
                if (dt.Columns.Count >= 1)
                {
                    WrkStrtTime.Text = dt.Rows[0][0].ToString();
                }
                if (dt.Columns.Count >= 2)
                {
                    WrkEndTime.Text = dt.Rows[0][1].ToString();
                }
            }
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
            Prescription_panel.Visible = false;
            MedTest_panel.Visible = false;
            Surgery_panel.Visible = false;
            Nurses_panel.Visible = false;
            Price_panel.Visible = false;
        }
        //make the dock: fill for all the pannels
        void InitializePanels()
        {
            SelectPatient_panel.Dock = DockStyle.Fill;
            WorkingHours_panel.Dock = DockStyle.Fill;
            Prescription_panel.Dock = DockStyle.Fill;
            MedTest_panel.Dock = DockStyle.Fill;
            Surgery_panel.Dock = DockStyle.Fill;
            Nurses_panel.Dock = DockStyle.Fill;
            Price_panel.Dock = DockStyle.Fill;
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
            RefreshPatient(SelectPatID_comboBox);
            ShowPanel(SelectPatient_panel);
            ActivateButton(SelectPatient_iconButton);
        }

        private void Prescription_iconButton_Click(object sender, EventArgs e)
        {
            RefreshMedicine();
            ShowPanel(Prescription_panel);
            ActivateButton(Prescription_iconButton);
        }

        private void MedicalTests_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(MedTest_panel);
            RefreshPatient(PatID_Test_comboBox);
            RefreshMedTestNames();
            ActivateButton(MedicalTests_iconButton);
        }

        private void Surgery_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Surgery_panel);
            RefreshPatient(PatID_Surg_comboBox);
            RefreshSurgNames();
            RefreshSurgOperate();
            ActivateButton(Surgery_iconButton);
        }

        private void Nurses_iconButton_Click(object sender, EventArgs e)
        {
            RefreshNurseDataGrid();
            RefreshNurseID_Assign();
            RefreshNurseID_Change();
            RefreshNurseID_Delete();
            RefreshRoomNo_Assign();
            RefreshRoomNo_Change();
            ShowPanel(Nurses_panel);
            ActivateButton(Nurses_iconButton);
            RefreshNurseDataGrid();
        }

        private void WorkHours_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(WorkingHours_panel);
            RefreshWorkingHours();
            ActivateButton(WorkHours_iconButton);
        }

        private void Price_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Price_panel);
            RefreshPrice();
            ActivateButton(Price_iconButton);
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
            DataTable dt = controllerObj.SelectPatientWithID(id);
            string FullName = dt.Rows[0].ItemArray[1].ToString() + " " + dt.Rows[0].ItemArray[2].ToString() + " " + dt.Rows[0].ItemArray[3].ToString();
            PatName_textBox.Text = FullName;
            PatBD_textBox.Text = Convert.ToDateTime(dt.Rows[0].ItemArray[4]).ToString("yyyy-MM-dd");
            PatAddress_textBox.Text = dt.Rows[0].ItemArray[5].ToString();
            PatGender_textBox.Text = dt.Rows[0].ItemArray[7].ToString();
            PatPhoneNo_textBox.Text = dt.Rows[0].ItemArray[6].ToString();
            //------------------------Medicines-------------------
            dt = controllerObj.GetMedicinesForPatient(CurrentDoctorID, int.Parse(SelectPatID_comboBox.Text));
            CurrentMedicines_dataGridView.DataSource = dt;
            CurrentMedicines_dataGridView.Refresh();
            //------------------------Medical Tests-------------------
            dt = controllerObj.GetMedTestsForPatient(int.Parse(SelectPatID_comboBox.Text), CurrentDoctorID);
            CurrMedTests_dataGridView.DataSource = dt;
            CurrMedTests_dataGridView.Refresh();
            //------------------------Medical Tests-------------------
            dt = controllerObj.GetSurgeriesForPatient(int.Parse(SelectPatID_comboBox.Text), CurrentDoctorID);
            Surgery_dataGridView.DataSource = dt;
            Surgery_dataGridView.Refresh();
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
            if (PatID_Surg_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a patient");
                return;
            }
            if (SurgName_Reserve_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a surgery");
                return;
            }
            int result = controllerObj.ReserveSurgery(int.Parse(PatID_Surg_comboBox.Text), CurrentDoctorID, SurgName_Reserve_comboBox.Text, SurgDate_dateTimePicker.Text.ToString());
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
            if (PatID_Surg_comboBox.SelectedIndex == -1)
            {
                return;
            }
            int result = controllerObj.CancelSurgery(int.Parse(PatID_Surg_comboBox.Text), CurrentDoctorID, SurgName_Cancel_comboBox.Text.ToString(), SurgDate_Cancel_comboBox.Text.ToString());
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

        private void WrkHrs_button_Click(object sender, EventArgs e)
        {

            int result = controllerObj.SetDrWorkingHours(USERNAME, WrkStrtTime.Text, WrkEndTime.Text);
            if (result == 0)
            {
                MessageBox.Show("Update failed");
            }
            else
            {
                MessageBox.Show("Update successful!");
            }
        }

        private void SetApppointPrice_button_Click(object sender, EventArgs e)
        {
            int price;
            bool isNumber = int.TryParse(SetAppointPrice_textBox.Text, out price);
            if (!isNumber)
            {
                MessageBox.Show("Update failed, Price must be a number!");
                return;
            }
            bool ispos = price > 0 ? true : false;
            if (!ispos)
            {
                MessageBox.Show("Update failed, Price must be a positive number!");
                return;
            }
            int result = controllerObj.SetAppointmentPrice(USERNAME, price);
            if (result == 0)
            {
                MessageBox.Show("Update failed");
            }
            else
            {
                MessageBox.Show("Update successful!");
            }
        }

        private void PatIDinMed_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAppointTimeToday(TimeinMed_comboBox, PatIDinMed_comboBox);
        }

        private void TimeinMed_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddMed_button_Click(object sender, EventArgs e)
        {
            if (PatIDinMed_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("There are no patients for today");
                return;
            }
            if (MedName_Add_textBox.Text == string.Empty)
            {
                MessageBox.Show("Please write a medicine name");
                return;
            }
            int patid = int.Parse(PatIDinMed_comboBox.Text);
            string time = TimeinMed_comboBox.Text;
            string date = DateTime.Today.Date.ToString("yyyy-MM-dd");
            int result = controllerObj.PrescribeMedicine(patid, CurrentDoctorID, date, time, MedName_Add_textBox.Text);
            if (result == 0)
            {
                MessageBox.Show("Prescription failed");
            }
            else
            {
                MessageBox.Show("Prescription successful!");
            }
        }
        //private void RefreshMedicinesForPatient()
       

        private void PatIDinTest_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void PrescribeTest_button_Click(object sender, EventArgs e)
        {
            if (PatIDinMed_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("There are no patients for today");
                return;
            }
            if (PrescTestName_textBox.Text == string.Empty)
            {
                MessageBox.Show("Please write a medical test name");
                return;
            }
            int patid = int.Parse(PatIDinMed_comboBox.Text);
            string time = TimeinMed_comboBox.Text;
            string date = DateTime.Today.Date.ToString("yyyy-MM-dd");
            int result = controllerObj.PrescribeMedicalTest(patid, CurrentDoctorID, date, time, PrescTestName_textBox.Text);
            if (result == 0)
            {
                MessageBox.Show("Prescription failed");
            }
            else
            {
                MessageBox.Show("Prescription successful!");
            }
        }

        private void MakeTest_button_Click(object sender, EventArgs e)
        {
            if (PatID_Test_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a patient");
                return;
            }
            if (TestName_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a medical test");
                return;
            }
            int patid = int.Parse(PatID_Test_comboBox.Text);
            string testName = TestName_comboBox.Text;
            string date = Test_dateTimePicker.Text;
            string TestRes = TestResult_richTextBox.Text.ToString();
            int result = controllerObj.MakeMedicalTest(patid, CurrentDoctorID, testName, date, TestRes);
            if (result == 0)
            {
                MessageBox.Show("Adding medical test failed");
            }
            else
            {
                MessageBox.Show("Adding medical test successful!");
            }
        }

        private void PatID_Surg_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSurgNames();
            RefreshSurgOperate();
        }
    }
}
