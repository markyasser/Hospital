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
                    else
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
            appDate.CustomFormat = "yyyy-MM-dd";
            appDate.Format = DateTimePickerFormat.Custom;
            appDate.MinDate = DateTime.Today;
            appTime.CustomFormat = "hh:mm";
            appTime.Format = DateTimePickerFormat.Custom;
            Pname_comboBox.DataSource = c.SelectPatientsID_name();
            Pname_comboBox.DisplayMember = "full_name";
            Pname_comboBox.ValueMember = "patient_id";
            docName_comboBox.DataSource = c.SelectDocID_name();
            docName_comboBox.DisplayMember = "full_name";
            docName_comboBox.ValueMember = "Doctor_id";
            PnameEdit_combo.DataSource = c.SelectPatientsID_name();
            PnameEdit_combo.DisplayMember = "full_name";
            PnameEdit_combo.ValueMember = "patient_id";
            DrNameEdit.DataSource = c.SelectDocID_name();
            DrNameEdit.DisplayMember = "full_name";
            DrNameEdit.ValueMember = "Doctor_id";
            appDateEdit.Visible = false;
            appTimeEdit.Visible = false;
            label35.Visible = false;
            label15.Visible = false;
            appDateEdit.CustomFormat = "yyyy-MM-dd";
            appDateEdit.Format = DateTimePickerFormat.Custom;
            appDateEdit.MinDate = DateTime.Today;
            appTimeEdit.CustomFormat = "hh:mm";
            appTimeEdit.Format = DateTimePickerFormat.Custom;
            PnameDelete.DataSource = c.SelectPatientsID_name();
            PnameDelete.DisplayMember = "full_name";
            PnameDelete.ValueMember = "patient_id";
            DrnameDelete.DataSource = c.SelectDocID_name();
            DrnameDelete.DisplayMember = "full_name";
            DrnameDelete.ValueMember = "Doctor_id";
            Resrve_date.CustomFormat = "yyyy-MM-dd";
            Resrve_date.Format = DateTimePickerFormat.Custom;
            Resrve_date.MinDate = DateTime.Today;
            PID_reserve_comboBox.DataSource = c.PatientsHasNoRoom(Resrve_date.Text);
            PID_reserve_comboBox.DisplayMember = "full_name";
            PID_reserve_comboBox.ValueMember = "patient_id";
            deptname_reserve_comboBox.DataSource = c.getDepartmentData();
            deptname_reserve_comboBox.DisplayMember = "specialization";
            deptname_reserve_comboBox.ValueMember = "Dnumber";
            object ob = deptname_reserve_comboBox.SelectedValue;
            if (ob!=null)
            {
                rooms_reserve_comboBox.DataSource = c.Avail_Rooms(int.Parse(ob.ToString()), Resrve_date.Text);
            }
            rooms_reserve_comboBox.DisplayMember = "RoomNumber";
            rooms_reserve_comboBox.ValueMember = "RoomNumber";
            pay_dateTimePicker.CustomFormat = "yyyy-MM-dd";
            pay_dateTimePicker.Format = DateTimePickerFormat.Custom;
            Pid_bill_combo.DataSource = c.SelectPatientsID_name();
            Pid_bill_combo.DisplayMember = "patient_id";
            Pid_bill_combo.ValueMember = "patient_id";
        }

        private void AddApp_button_Click(object sender, EventArgs e)
        {
            //al mafrod date ali yzhr mn delw2ty le al future -->bemoi 
            if (v.IsPast(appDate.Value))
            {
                MessageBox.Show("Choose a valid date");
            }
            //if (appTime.ToString())
            {
                if (c.appReserved(int.Parse(docName_comboBox.SelectedValue.ToString()), appDate.ToString(), appTime.ToString()) == 0)
                {
                    //insert the app


                }
            }
        }

        private void docName_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (docName_comboBox.SelectedIndex.ToString() != "-1")
                {
                    int x = int.Parse(docName_comboBox.SelectedValue.ToString());
                    DataTable dt = c.SelectDoc_srt_end(x);
                    srtTime_txt.Text = dt.Rows[0].Field<string>("Start_Time");
                    //srtTime_txt.Text = dt.Rows[0][0].ToString();
                    //endTime_txt.Text = dt.Rows[0][1].ToString();
                    endTime_txt.Text = dt.Rows[1].Field<string>("Finish_Time");
                    appTime.MinDate = DateTime.Parse(srtTime_txt.Text);
                    appTime.MaxDate = DateTime.Parse(endTime_txt.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PnameEdit_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (docName_comboBox.SelectedIndex.ToString() != "-1")
                {
                    //srtTime_txt.Text = docName_comboBox.SelectedValue.ToString();
                    //DataTable dt = c.SelectDoc_srt_end(int.Parse(docName_comboBox.SelectedValue.ToString()));
                    //srtTime_txt.Text = dt.Rows[0].Field<string>("Start_Time");
                    //srtTime.Text = dt.Rows[0][0];
                    //endTime.Text = dt.Rows[0][1];
                    //endTime_txt.Text = dt.Rows[1].Field<string>("Finish_Time");
                    //appTime.MinDate = DateTime.Parse(srtTime_txt.Text);
                    //appTime.MaxDate = DateTime.Parse(endTime_txt.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditType_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditType_combo.SelectedItem.ToString() == "Edit Appointment Date")
            {
                appDateEdit.Visible = true;
                label35.Visible = true;
                appDateEdit.Value = DateTime.Parse(c.AppDate(int.Parse(DrNameEdit.SelectedValue.ToString()), int.Parse(PnameEdit_combo.SelectedValue.ToString())));
            }
            else if (EditType_combo.SelectedItem.ToString() == "Edit Appointment Time")
            {
                appTimeEdit.Visible = true;
                label15.Visible = true;
            }
            else if (EditType_combo.SelectedItem.ToString() == "Edit Both")
            {
                appDateEdit.Visible = true;
                appTimeEdit.Visible = true;
                label35.Visible = true;
                label15.Visible = true;
            }
            EditType_combo.Enabled = false;
        }

        private void editApp_btn_Click(object sender, EventArgs e)
        {//edit button not complete

            appDateEdit.Visible = false;
            appTimeEdit.Visible = false;
            label35.Visible = false;
            label15.Visible = false;
            EditType_combo.Enabled = true;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int result = c.DeleteApp(int.Parse(DrnameDelete.SelectedValue.ToString()), int.Parse(PnameDelete.SelectedValue.ToString()), appDateDelete.ToString());
            //    if (result==0)
            //    {
            //        MessageBox.Show("No Instance of This Appointment");
            //    }
            //    else
            //    {
            //        MessageBox.Show("The Appointment deleted successfully");
            //    }
            //}
            //catch(Exception ex)
            //{

            //}
        }

        private void PnameDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            //appDateDelete.DataSource = c.AppDate();//al function de 8lt lazm 
        }

        private void DrnameDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            //appDateDelete.DataSource = c.AppDate();
        }

        private void deptname_reserve_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                rooms_reserve_comboBox.DataSource = c.Avail_Rooms(int.Parse(deptname_reserve_comboBox.SelectedValue.ToString()), Resrve_date.Text);
                rooms_reserve_comboBox.DisplayMember = "RoomNumber";
                rooms_reserve_comboBox.ValueMember = "RoomNumber";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resrve_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PID_reserve_comboBox.SelectedIndex.ToString() == "-1" || rooms_reserve_comboBox.SelectedIndex.ToString() == "-1")
                {
                    MessageBox.Show("Please Enter All the Required Data for Reservation");
                }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void PID_reserve_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
