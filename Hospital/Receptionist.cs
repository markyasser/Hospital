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
        private string USERNAME; //sent from login screen
        LoginPage l;
        public Receptionist(string user, LoginPage log)
        {
            InitializeComponent();
            c = new Controller();
            v = new Validation();
            CollapseMenu();
            HideSubmenus();
            InitializePanels();
            HidePanels();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);
            USERNAME = user;
            l = log;
            WindowState = FormWindowState.Maximized;
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
            settings_panel.Dock = DockStyle.Fill;
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
            settings_panel.Visible = false;
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
            label50.Visible = false;
            ShowPanel(addPatient_panel);
            HideSubmenus();
        }

        private void MakeAPP_iconButton_Click(object sender, EventArgs e)
        {
            label50.Visible = false;
            ShowPanel(makeApp_panel);
            HideSubmenus();
            Receptionist_Load(null, null);
        }

        private void EditApp_iconButton_Click(object sender, EventArgs e)
        {
            label50.Visible = false;
            ShowPanel(editApp_panel);

            HideSubmenus();
        }

        private void cancelApp_iconButton_Click(object sender, EventArgs e)
        {
            label50.Visible = false;
            ShowPanel(cancelApp_panel);
            HideSubmenus();
        }

        private void reserve_btn_Click(object sender, EventArgs e)
        {
            label50.Visible = false;
            ShowPanel(reserve_panel);
            HideSubmenus();
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            label50.Visible = false;
            ShowPanel(pay_panel);
            HideSubmenus();
        }

        private void logoyt_btn_Click(object sender, EventArgs e)
        {
            label50.Visible = false;
            DialogResult choice = MessageBox.Show("Are you sure you want to Log out?", "Log out", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                c.TerminateConnection();
                this.Close();
            }
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
                        f = true;
                    }
                }
                if (f || gender_comboBox.SelectedIndex.ToString() == "-1")//lo fadi
                {
                    MessageBox.Show("Enter All Required Data");
                }
                //if (Fname_textBox.Text == "" || Lname_textBox.Text == "" || minit_textBox.Text == "" || Address_textBox.Text == "" || ID_textBox.Text == "" || phno_textBox.Text == ""||gender_comboBox.SelectedIndex.ToString()=="-1")
                //{
                //    MessageBox.Show("Enter All Required Data");
                //}
                else
                {
                    if (!v.IsAlpha(Fname_textBox.Text) || !v.IsAlpha(Lname_textBox.Text) || !v.IsAlpha(minit_textBox.Text) || !v.IsPosInteger(ID_textBox.Text) || !v.IsPosInteger(phno_textBox.Text))
                    {
                        MessageBox.Show("Enter Valid Data");
                    }
                    else if (c.isPatientExist(int.Parse(ID_textBox.Text)) == 0)
                    {
                        int result = c.InsertPatient(int.Parse(ID_textBox.Text), Fname_textBox.Text, char.Parse(minit_textBox.Text), Lname_textBox.Text, patient_dateTimePicker.Text, Address_textBox.Text, int.Parse(phno_textBox.Text), gender_comboBox.SelectedItem.ToString());
                        if (result == 0)
                        {
                            MessageBox.Show("The insertion of a new row failed");
                        }
                        else
                        {
                            MessageBox.Show("The row is inserted successfully!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Patient Is Already In The System");
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
            //-------------------------make-----------------------
            patient_dateTimePicker.CustomFormat = "yyyy-MM-dd";
            patient_dateTimePicker.Format = DateTimePickerFormat.Custom;
            appDate.CustomFormat = "yyyy-MM-dd";
            appDate.Format = DateTimePickerFormat.Custom;
            appDate.MinDate = DateTime.Today;
            appTime.CustomFormat = "hh:mm";
            appTime.Format = DateTimePickerFormat.Custom;
            Pname_comboBox.DataSource = c.SelectPatientsID_name();
            Pname_comboBox.DisplayMember = "full_name";
            Pname_comboBox.ValueMember = "patient_id";
            make_Dept_name.DataSource = c.getDepartmentData();
            make_Dept_name.DisplayMember = "specialization";
            make_Dept_name.ValueMember = "Dnumber";

            if (make_Dept_name.SelectedIndex.ToString() != "-1")
            {
                int x;
                if (int.TryParse(make_Dept_name.SelectedValue.ToString(), out x))
                {
                    docName_comboBox.DataSource = c.SelectDocID_name(x);
                    docName_comboBox.DisplayMember = "full_name";
                    docName_comboBox.ValueMember = "Doctor_id";
                }
            }
            //----------------edit app-----------------------------
            PnameEdit_combo.DataSource = c.SelectPatientsID_name();
            PnameEdit_combo.DisplayMember = "full_name";
            PnameEdit_combo.ValueMember = "patient_id";

            edit_dept_name.DataSource = c.getDepartmentData();
            edit_dept_name.DisplayMember = "specialization";
            edit_dept_name.ValueMember = "Dnumber";
            if (edit_dept_name.SelectedIndex.ToString() != "-1")
            {
                int x;
                if (int.TryParse(make_Dept_name.SelectedValue.ToString(), out x))
                {
                    DrNameEdit.DataSource = c.SelectDocID_name(x);
                    DrNameEdit.DisplayMember = "full_name";
                    DrNameEdit.ValueMember = "Doctor_id";
                }
            }

            appDateEdit.Enabled = false;
            appTimeEdit.Enabled = false;

            appDateEdit.CustomFormat = "yyyy-MM-dd";
            appDateEdit.Format = DateTimePickerFormat.Custom;
            appDateEdit.MinDate = DateTime.Today;
            appTimeEdit.CustomFormat = "hh:mm";
            appTimeEdit.Format = DateTimePickerFormat.Custom;

            //---------delete app----------
            PnameDelete.DataSource = c.SelectPatientsID_name();
            PnameDelete.DisplayMember = "full_name";
            PnameDelete.ValueMember = "patient_id";
            delete_dept_name.DataSource = c.getDepartmentData();
            delete_dept_name.DisplayMember = "specialization";
            delete_dept_name.ValueMember = "Dnumber";
            if (delete_dept_name.SelectedIndex.ToString() != "-1")
            {
                int x;
                if (int.TryParse(delete_dept_name.SelectedValue.ToString(), out x))
                {
                    DrnameDelete.DataSource = c.SelectDocID_name(x);
                    DrnameDelete.DisplayMember = "full_name";
                    DrnameDelete.ValueMember = "Doctor_id";
                }
            }
            if (PnameDelete.SelectedIndex.ToString() != "-1" && DrnameDelete.SelectedIndex.ToString() != "-1")
            {
                int x, y;
                if (int.TryParse(PnameDelete.SelectedValue.ToString(), out x) && int.TryParse(DrnameDelete.SelectedValue.ToString(), out y))
                {
                    appDateDelete.DataSource = c.AppDate(y, x);
                    appDateDelete.DisplayMember = "date";
                    appDateDelete.ValueMember = "date";
                }
            }
            if (PnameEdit_combo.SelectedIndex.ToString() != "-1" && DrNameEdit.SelectedIndex.ToString() != "-1" && oldAppDate.SelectedIndex.ToString() != "-1")
            {
                int x, y;
                if (int.TryParse(PnameEdit_combo.SelectedValue.ToString(), out x) && int.TryParse(DrNameEdit.SelectedValue.ToString(), out y))
                {
                    oldAppTime.DataSource = c.AppTime(y, x, oldAppDate.SelectedValue.ToString());
                    oldAppTime.DisplayMember = "Time";
                    oldAppTime.ValueMember = "Time";
                    //anta bt3ml edit le 7agat maogoda so use combox we selec it then change it

                }
            }
            //---------reserve 
            Resrve_date.CustomFormat = "yyyy-MM-dd";
            Resrve_date.Format = DateTimePickerFormat.Custom;
            Resrve_date.MinDate = DateTime.Today;
            PID_reserve_comboBox.DataSource = c.PatientsHasNoRoom(Resrve_date.Text);
            PID_reserve_comboBox.DisplayMember = "full_name";
            PID_reserve_comboBox.ValueMember = "patient_id";
            if (c.getDepartmentData() != null)
            {
                deptname_reserve_comboBox.DataSource = c.getDepartmentData();

                deptname_reserve_comboBox.DisplayMember = "specialization";
                deptname_reserve_comboBox.ValueMember = "Dnumber";
            }

            if (deptname_reserve_comboBox.SelectedIndex.ToString() != "-1")
            {
                rooms_reserve_comboBox.DataSource = c.Avail_Rooms(int.Parse(deptname_reserve_comboBox.SelectedValue.ToString()), Resrve_date.Text);
                rooms_reserve_comboBox.DisplayMember = "RoomNumber";
                rooms_reserve_comboBox.ValueMember = "RoomNumber";
            }
            Pid_res_textBox.Text = "Please Choose a patient";
            //Bill
            pay_dateTimePicker.CustomFormat = "yyyy-MM-dd";
            pay_dateTimePicker.Format = DateTimePickerFormat.Custom;
            Pid_bill_combo.DataSource = c.SelectPatientsID_name();
            Pid_bill_combo.DisplayMember = "full_name";
            Pid_bill_combo.ValueMember = "patient_id";
            Pid_bill.Text = "Please Choose a patient";
        }

        private void AddApp_button_Click(object sender, EventArgs e)
        {
            try
            {
                //if (v.IsPast(appDate.Value))
                //{
                //    MessageBox.Show("Choose a valid date");
                //}
                if (docName_comboBox.SelectedIndex.ToString() == "-1" || Pname_comboBox.SelectedIndex.ToString() == "-1" || make_Dept_name.SelectedIndex.ToString() == "-1")
                {
                    MessageBox.Show("Please Enter All Required Data");
                }
                else
                {
                    if (c.appReserved(int.Parse(docName_comboBox.SelectedValue.ToString()), appDate.Text, appTime.Text) != 0 || c.appReservedBefore(int.Parse(docName_comboBox.SelectedValue.ToString()), appDate.Text, appTime.Text) != 0)
                    {
                        MessageBox.Show("This Appointment is already reserved");
                    }
                    else
                    {
                        //insert the app
                        int result = c.AddAppointment(int.Parse(Pname_comboBox.SelectedValue.ToString()), int.Parse(docName_comboBox.SelectedValue.ToString()), appDate.Text, appTime.Text);
                        if (result == 0)
                        {
                            MessageBox.Show("Reservation Failled");
                        }
                        else
                        {
                            MessageBox.Show("The Appointment is made successfully");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void docName_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int x;
                if (docName_comboBox.SelectedIndex == -1)
                {
                    return;
                }
                bool valid = int.TryParse(docName_comboBox.SelectedValue.ToString(), out x);
                if (!valid)
                {
                    return;
                }


                DataTable dt = c.SelectDoc_srt_end(x);
                //srtTime_txt.Text = dt.Rows[0].Field<string>("Start_Time");
                srtTime_txt.Text = dt.Rows[0][0].ToString();
                endTime_txt.Text = dt.Rows[0][1].ToString();
                //endTime_txt.Text = dt.Rows[1].Field<string>("Finish_Time");


                appTime.MinDate = DateTimePicker.MinimumDateTime;

                appTime.MaxDate = DateTime.Parse(endTime_txt.Text);
                appTime.MinDate = DateTime.Parse(srtTime_txt.Text);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PnameEdit_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (docName_comboBox.SelectedIndex.ToString() != "-1")
            //    {
            //        //srtTime_txt.Text = docName_comboBox.SelectedValue.ToString();
            //        //DataTable dt = c.SelectDoc_srt_end(int.Parse(docName_comboBox.SelectedValue.ToString()));
            //        //srtTime_txt.Text = dt.Rows[0].Field<string>("Start_Time");
            //        //srtTime.Text = dt.Rows[0][0];
            //        //endTime.Text = dt.Rows[0][1];
            //        //endTime_txt.Text = dt.Rows[1].Field<string>("Finish_Time");
            //        //appTime.MinDate = DateTime.Parse(srtTime_txt.Text);
            //        //appTime.MaxDate = DateTime.Parse(endTime_txt.Text);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void EditType_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditType_combo.SelectedItem.ToString() == "Edit Appointment Date")
            {
                appDateEdit.Enabled = true;

            }
            else if (EditType_combo.SelectedItem.ToString() == "Edit Appointment Time")
            {
                appTimeEdit.Enabled = true;

            }
            EditType_combo.Enabled = false;
        }

        private void editApp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EditType_combo.SelectedIndex.ToString() != "-1" || edit_dept_name.SelectedIndex.ToString() != "-1" || DrNameEdit.SelectedIndex.ToString() != "-1" || PnameEdit_combo.SelectedIndex.ToString() != "-1")
                {
                    if (EditType_combo.SelectedItem.ToString() == "Edit Appointment Date" && oldAppDate.SelectedIndex.ToString() != "-1")
                    {
                        //you can't edit the appointment in the past or to the past 
                        int temp;
                        if (int.TryParse(c.DateCheckEdit(int.Parse(DrNameEdit.SelectedValue.ToString()), appDateEdit.Text).ToString(), out temp))
                        {
                            if (temp != 0)
                            {
                                bool valid = int.TryParse(c.VaidAppEdit(int.Parse(DrNameEdit.SelectedValue.ToString()), appDateEdit.Text, oldAppTime.SelectedValue.ToString()).ToString(), out temp);
                                if (valid)
                                {
                                    if (temp != 0)//|| c.VaidAppEditBefore(int.Parse(DrNameEdit.SelectedValue.ToString()), appDateEdit.Text, oldAppTime.SelectedValue.ToString()) != 0)
                                    {
                                        int result = c.updateApp(int.Parse(DrNameEdit.SelectedValue.ToString()), int.Parse(PnameEdit_combo.SelectedValue.ToString()), oldAppTime.SelectedValue.ToString(), oldAppDate.SelectedValue.ToString(), appDateEdit.Text);
                                        if (result == 0)
                                        {
                                            MessageBox.Show("Upadate Failed");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Update Successfully");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("This Appointment is reserved");
                                    }
                                }
                            }
                            else
                            {
                                int result = c.updateApp(int.Parse(DrNameEdit.SelectedValue.ToString()), int.Parse(PnameEdit_combo.SelectedValue.ToString()), oldAppTime.SelectedValue.ToString(), oldAppDate.SelectedValue.ToString(), appDateEdit.Text);
                                if (result == 0)
                                {
                                    MessageBox.Show("Upadate Failed");
                                }
                                else
                                {
                                    MessageBox.Show("Update Successfully");
                                }
                            }
                        }
                    }
                    

                }
                else if (EditType_combo.SelectedItem.ToString() == "Edit Appointment Time" && oldAppDate.SelectedIndex.ToString() != "-1")
                {
                    int x, y;
                    if (int.TryParse(PnameEdit_combo.SelectedValue.ToString(), out x) && int.TryParse(DrNameEdit.SelectedValue.ToString(), out y))
                    {
                        int temp;
                        bool valid = int.TryParse(c.VaidAppEdit(y, oldAppDate.SelectedValue.ToString(), appTimeEdit.Text).ToString(), out temp);
                        if (valid)
                        {
                            if (temp != 0)// ||c.VaidAppEditBefore(y, oldAppDate.SelectedValue.ToString(), appTimeEdit.Text) != 0)
                            {
                                int result = c.updateAppTime(y, x, oldAppDate.SelectedValue.ToString(), oldAppTime.SelectedValue.ToString(), appTimeEdit.Text);
                                if (result == 0)
                                {
                                    MessageBox.Show("Upadate Failed");
                                }
                                else
                                {
                                    MessageBox.Show("Update Successfully");
                                }
                            }
                            else
                            {
                                MessageBox.Show("This Appointment is reserved");
                            }
                        }
                    }
                   
                }

                else
                {
                    MessageBox.Show("Please Enter All The Required Data");
                }
                appDateEdit.Enabled = false;
                appTimeEdit.Enabled = false;

                EditType_combo.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int result = c.DeleteApp(int.Parse(DrnameDelete.SelectedValue.ToString()), int.Parse(PnameDelete.SelectedValue.ToString()), appDateDelete.SelectedValue.ToString(), appTimeDelete.SelectedValue.ToString());
                if (result == 0)
                {
                    MessageBox.Show("Deletion Failed");
                }
                else
                {
                    MessageBox.Show("The Appointment deleted successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DrnameDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PnameDelete.SelectedIndex.ToString() != "-1" && DrnameDelete.SelectedIndex.ToString() != "-1")
            {
                int x, y;
                if (int.TryParse(PnameDelete.SelectedValue.ToString(), out x) && int.TryParse(DrnameDelete.SelectedValue.ToString(), out y))
                {
                    appDateDelete.DataSource = c.AppDate(y, x);
                    appDateDelete.DisplayMember = "date";
                    appDateDelete.ValueMember = "date";
                }
            }
        }

        private void deptname_reserve_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (rooms_reserve_comboBox.SelectedIndex == -1)
                {
                    return;
                }
                int x;
                bool valid = int.TryParse(deptname_reserve_comboBox.SelectedValue.ToString(), out x);
                if (!valid)
                {
                    return;
                }
                rooms_reserve_comboBox.DataSource = c.Avail_Rooms(x, Resrve_date.Text);
                rooms_reserve_comboBox.DisplayMember = "RoomNumber";
                rooms_reserve_comboBox.ValueMember = "RoomNumber";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void resrve_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PID_reserve_comboBox.SelectedIndex.ToString() == "-1" || rooms_reserve_comboBox.SelectedIndex.ToString() == "-1")
                {
                    MessageBox.Show("Please Enter All the Required Data for Reservation");
                    return;
                }
                if (c.ValidDateReserve(int.Parse(rooms_reserve_comboBox.SelectedValue.ToString()), Resrve_date.Text, (int)Nonights.Value) == 0)
                {
                    int result = c.ReserveRoom(int.Parse(PID_reserve_comboBox.SelectedValue.ToString()), int.Parse(rooms_reserve_comboBox.SelectedValue.ToString()), Resrve_date.Text, (int)Nonights.Value);
                    if (result == 0)
                    {
                        MessageBox.Show("Reservation Failled");
                    }
                    else
                    {
                        MessageBox.Show("The Room resrved successfully");
                    }
                }
                else
                {
                    MessageBox.Show("The Room is Already reserved in this date");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }
        private void Resrve_date_ValueChanged(object sender, EventArgs e)
        {
            PID_reserve_comboBox.DataSource = c.PatientsHasNoRoom(Resrve_date.Text);
            PID_reserve_comboBox.DisplayMember = "full_name";
            PID_reserve_comboBox.ValueMember = "patient_id";
            rooms_reserve_comboBox.DataSource = c.Avail_Rooms(int.Parse(deptname_reserve_comboBox.SelectedValue.ToString()), Resrve_date.Text);
            rooms_reserve_comboBox.DisplayMember = "RoomNumber";
            rooms_reserve_comboBox.ValueMember = "RoomNumber";
        }

        private void make_Dept_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int x;
                if (make_Dept_name.SelectedIndex == -1)
                {
                    return;
                }
                bool valid = int.TryParse(make_Dept_name.SelectedValue.ToString(), out x);
                if (!valid)
                {
                    return;
                }
                docName_comboBox.DataSource = c.SelectDocID_name(x);
                docName_comboBox.DisplayMember = "full_name";
                docName_comboBox.ValueMember = "Doctor_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void DrNameEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int x;
                if (DrNameEdit.SelectedIndex.ToString() == "-1")
                {
                    return;
                }
                if (int.TryParse(DrNameEdit.SelectedValue.ToString(), out x))
                {

                    DataTable dt = c.SelectDoc_srt_end(x);
                    //srtTime_txt.Text = dt.Rows[0].Field<string>("Start_Time");
                    edit_start_Time.Text = dt.Rows[0][0].ToString();
                    edit_end_Time.Text = dt.Rows[0][1].ToString();
                    //endTime_txt.Text = dt.Rows[1].Field<string>("Finish_Time");
                    appTimeEdit.MinDate = DateTime.Parse(edit_start_Time.Text);
                    appTimeEdit.MaxDate = DateTime.Parse(edit_end_Time.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void PnameEdit_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int x, y;
                if (PnameEdit_combo.SelectedIndex.ToString() != "-1" && DrNameEdit.SelectedIndex.ToString() != "-1")
                {
                    if (int.TryParse(PnameEdit_combo.SelectedValue.ToString(), out x) && int.TryParse(DrNameEdit.SelectedValue.ToString(), out y))
                    {
                        oldAppDate.DataSource = c.AppDate(y, x);
                        //display and value members
                        oldAppDate.DisplayMember = "date";
                        oldAppDate.ValueMember = "date";
                        Pid_edit_textBox.Text = x.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void oldAppDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (PnameEdit_combo.SelectedIndex.ToString() != "-1" && DrNameEdit.SelectedIndex.ToString() != "-1" && oldAppDate.SelectedIndex.ToString() != "-1")
                {
                    int x, y;
                    if (int.TryParse(PnameEdit_combo.SelectedValue.ToString(), out x) && int.TryParse(DrNameEdit.SelectedValue.ToString(), out y))
                    {
                        oldAppTime.DataSource = c.AppTime(y, x, oldAppDate.SelectedValue.ToString());
                        oldAppTime.DisplayMember = "Time";
                        oldAppTime.ValueMember = "Time";
                        //anta bt3ml edit le 7agat maogoda so use combox we selec it then change it

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void delete_dept_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (delete_dept_name.SelectedIndex.ToString() != "-1")
            {
                int x;
                if (int.TryParse(delete_dept_name.SelectedValue.ToString(), out x))
                {
                    DrnameDelete.DataSource = c.SelectDocID_name(x);
                    DrnameDelete.DisplayMember = "full_name";
                    DrnameDelete.ValueMember = "Doctor_id";
                }
            }
        }

        private void appDateDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appDateDelete.SelectedIndex.ToString() != "-1")
            {
                int x, y;
                if (int.TryParse(PnameDelete.SelectedValue.ToString(), out x) && int.TryParse(DrnameDelete.SelectedValue.ToString(), out y))
                {
                    appTimeDelete.DataSource = c.AppTime(y, x, appDateDelete.SelectedValue.ToString());
                    appTimeDelete.DisplayMember = "Time";
                    appTimeDelete.ValueMember = "Time";
                }

            }
        }

        private void Pid_bill_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pid_bill.Text = Pid_bill_combo.SelectedValue.ToString();
        }

        private void bill_button_Click(object sender, EventArgs e)
        {
            try
            {
                int x;
                string d = pay_dateTimePicker.Text;
                if (Pid_bill_combo.SelectedIndex.ToString() != "-1" && BillType.SelectedIndex.ToString() != "-1" && int.TryParse(Pid_bill_combo.SelectedValue.ToString(), out x))
                {
                    if (BillType.SelectedItem.ToString() == "Appointment")
                    {
                        bill_dataGridView.DataSource = c.appBill(x, d);
                        bill_dataGridView.Refresh();
                    }
                    else if (BillType.SelectedItem.ToString() == "Medical Test")
                    {
                        bill_dataGridView.DataSource = c.MedicalTestBill(x, d);
                        bill_dataGridView.Refresh();
                    }
                    else if (BillType.SelectedItem.ToString() == "Medicine")
                    {
                        bill_dataGridView.DataSource = c.MedicineBill(x, d);
                        bill_dataGridView.Refresh();
                    }
                    else if (BillType.SelectedItem.ToString() == "Surgery")
                    {
                        bill_dataGridView.DataSource = c.SurgeryBill(x, d);
                        bill_dataGridView.Refresh();
                    }
                    else
                    {
                        bill_dataGridView.DataSource = c.ReserveBill(x, d);
                        bill_dataGridView.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void totBill_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Pid_bill_combo.SelectedIndex.ToString() != "-1")
                {
                    int x = int.Parse(Pid_bill_combo.SelectedValue.ToString());
                    string d = pay_dateTimePicker.Text;
                    int s1, s2, s3, s4, s5;
                    bool valid1 = int.TryParse(c.sumSurgery(x, d).ToString(), out s1);
                    if (!valid1)
                    {
                        s1 = 0;
                    }
                    bool valid2 = int.TryParse(c.MedicalTestSum(x, d).ToString(), out s2);
                    if (!valid2)
                    {
                        s2 = 0;
                    }
                    bool valid3 = int.TryParse(c.MedicineSum(x, d).ToString(), out s3);
                    if (!valid3)
                    {
                        s3 = 0;
                    }
                    bool valid4 = int.TryParse(c.ReserveSum(x, d).ToString(), out s4);
                    if (!valid4)
                    {
                        s4 = 0;
                    }
                    bool valid5 = int.TryParse(c.AppSum(x, d).ToString(), out s5);
                    if (!valid5)
                    {
                        s5 = 0;
                    }
                    int sum = s1 + s2 + s3 + s4 + s5;
                    price_pay_textBox.Text = sum.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void PID_reserve_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pid_res_textBox.Text = PID_reserve_comboBox.SelectedValue.ToString();
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
            object oldpassword = c.GetOldPassword(USERNAME);

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
                int result = c.ChangePassword(USERNAME, Validation.hashpassword(NewPass.Text));
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

        private void Settings_iconButton_Click(object sender, EventArgs e)
        {
            label50.Visible = false;
            ShowPanel(settings_panel);
            HideSubmenus();
        }

        private void Receptionist_FormClosing(object sender, FormClosingEventArgs e)
        {
            l.Close();
        }
    }
}
