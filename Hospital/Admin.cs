using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
        string USERNAME;
        int var;
        public Admin(string user) 
        {
            var = 0;
            USERNAME = user;
            InitializeComponent();
            controllerObj = new Controller();
            Fill_ComboBox();

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

            depart.Visible = false;
            label28.Visible = false;

            Dep_textBox.Visible = false;
            label62.Visible = false;
        }
        private void Fill_ComboBox()
        {
            DataTable table = controllerObj.GetAllDepartmentNumber();
            string[] arrray = table.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < arrray.Length; i++)
            {
                dep.Items.Add(arrray[i]);
            }
            for (int i = 0; i < arrray.Length; i++)
            {
                depart.Items.Add(arrray[i]);
            }
            depart.Items.Add("All");
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
            Search_panel.Visible = false;
            Earnings_panel.Visible = false;
            Departments_Panel.Visible = false;
            surgery_Panel.Visible = false;
            medtests_Panel.Visible = false;
            settings_panel.Visible = false;
        }
        //make the dock: fill for all the pannels
        void InitializePanels()
        {
            CreateAccount_panel.Dock = DockStyle.Fill;
            List_panel.Dock = DockStyle.Fill;
            Search_panel.Dock = DockStyle.Fill;
            Earnings_panel.Dock = DockStyle.Fill;
            Departments_Panel.Dock = DockStyle.Fill;
            surgery_Panel.Dock = DockStyle.Fill;
            medtests_Panel.Dock = DockStyle.Fill;
            settings_panel.Dock = DockStyle.Fill;
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
            getEarnings();
        }
        private void Departments_Click(object sender, EventArgs e)
        {
            ShowPanel(Departments_Panel);
            ActivateButton(Departments);
            FillDepartmentTable();
        }
        private void surgeries_Click(object sender, EventArgs e)
        {
            ShowPanel(surgery_Panel);
            ActivateButton(surgeries);
            FillSurgery();
        }

        private void MedicalTests_Click(object sender, EventArgs e)
        {
            ShowPanel(medtests_Panel);
            ActivateButton(MedicalTests);
            FillMedicalTestsTable();
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


        private void Create_Account_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(CreateAccount_panel);
            ActivateButton(Create_Account_iconButton);
        }
        private void Settings_iconButton_Click(object sender, EventArgs e)
        {
            ShowPanel(settings_panel);
            ActivateButton(Settings_iconButton);
        }
        private void Logout_iconButton_Click(object sender, EventArgs e)
        {
            LoginPage l = new LoginPage();
            l.Show();
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
                label3.Text = "*";
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
            if (username.Text == "")
            {
                label19.Text = "*";
                flag = false;
            }

            else label19.Text = "";
            if (dep.Text == "" && pos.Text== "Doctor")
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
            string birthdate;
            birthdate = bdate.Value.Year.ToString()+ "-" + bdate.Value.Month.ToString() + "-" + bdate.Value.Day.ToString();

            int result1=0, result2 = 0;

            
            if (password.Text.Length < 4)
            {
                MessageBox.Show("Password is very weak");
                return;
            }
            if (pos.Text == "Doctor")
            {
                result2 = controllerObj.CreateAccount(username.Text, password.Text);
                if (result2 != 0)
                {
                    int dpnumber = int.Parse(controllerObj.getDnumber(dep.Text).ToString());
                    result1 = controllerObj.InsertDoctor(ID, fname.Text, minit.Text, lname.Text, username.Text, birthdate, address.Text, Phone, SEX, dpnumber);
                    if (result1 == 0)
                    {
                        controllerObj.DeleteAccount(username.Text);
                    }
                    else FillDepartmentTable();
                }
                else
                {
                    MessageBox.Show("This Username already exist");
                    return;
                }

            }
            else
            {
                result2 = controllerObj.CreateAccount(username.Text, password.Text);
                if (result2 != 0)
                {
                    result1 = controllerObj.InsertNotDoctor(ID, fname.Text, minit.Text, lname.Text, username.Text, birthdate, address.Text, Phone, SEX, pos.Text);
                    if (result1 == 0)
                    {
                        controllerObj.DeleteAccount(username.Text);
                    }
                        
                }
                else
                {
                    MessageBox.Show("This Username already exist");
                    return;
                }
            }
            if (result1 > 0 && result2 > 0)
                MessageBox.Show(pos.Text + " " + fname.Text + " is inserted successfully");
            else
                MessageBox.Show("This ID already exist");

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
        private void position_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (position.Text == "")
            {
                label29.Text = "* Please choose an employee position";
                return;
            }
            else label29.Text = "";
            if (position.Text == "Doctor")
            {
                depart.Visible = true;
                label28.Visible = true;
                dataGridView1.DataSource = controllerObj.GetAllEmployees(position.Text, depart.Text.ToString());
            }
            else
            {
                depart.Visible = false;
                label28.Visible = false;
                dataGridView1.DataSource = controllerObj.GetAllEmployees(position.Text, depart.Text.ToString());
            }
        }
        private void Insert_Department_Click(object sender, EventArgs e)
        {
            int dno;
            bool flag = Int32.TryParse(Dnumber.Text, out dno);
            if (!flag)
                label17.Text = "* Please enter a valid Department number";
            else label17.Text = "";

            if (special.Text == "")
            {
                label18.Text = "* Please enter a valid Department Specialization";
                flag = false;
            }
            else label18.Text = "";

            if (!flag) return;

            int result = controllerObj.InsertDepartment(dno, special.Text.ToString());
            if (result > 0)
            {
                MessageBox.Show("Department " + special.Text + " is inserted successfully");
                depart.Items.Add(special.Text);
                FillDepartmentTable();
            }
            else
                MessageBox.Show("This Department already exist");
        }

        private void ShowList_button_Click(object sender, EventArgs e)
        {
            if (position.Text == "")
            {
                label29.Text = "* Please choose an employee position";
                return;
            }
            else label29.Text = "";

            dataGridView1.DataSource = controllerObj.GetAllEmployees(position.Text,depart.Text.ToString());
        }

        private void depart_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerObj.GetAllEmployees(position.Text, depart.Text.ToString());
        }

        private void Insert_Surgery_Click(object sender, EventArgs e)
        {
            int cost;
            bool flag = Int32.TryParse(price.Text, out cost);
            if (!flag)
                label59.Text = "* Please enter a valid price";
            else label59.Text = "";

            if (surgery_name.Text == "")
            {
                label32.Text = "* Please enter a valid name";
                flag = false;
            }
            else label32.Text = "";

            if (!flag) return;

            int result = controllerObj.InsertSurgery( surgery_name.Text.ToString(),cost);
            if (result > 0)
            {
                MessageBox.Show("Surgery " + surgery_name.Text + " is inserted successfully");
                FillSurgery();
            }
            else
                MessageBox.Show("This Surgery already exist");
        }

        private void surgery_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Insert_MedicalTest_Click(object sender, EventArgs e)
        {
            int cost;
            bool flag = Int32.TryParse(test_price.Text, out cost);
            if (!flag)
                label33.Text = "* Please enter a valid price";
            else label33.Text = "";

            if (test_name.Text == "")
            {
                label50.Text = "* Please enter a valid name";
                flag = false;
            }
            else label50.Text = "";

            if (!flag) return;

            int result = controllerObj.InsertMedicalTest(test_name.Text.ToString(), cost);
            if (result > 0)
            {
                MessageBox.Show("Medical Test : '" + test_name.Text + "' is inserted successfully");
                FillMedicalTestsTable();
            }
               
            else
                MessageBox.Show("This Medical Test already exist");
        }

        private void select_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = true;
            if (search_position.Text == "")
            {
                label61.Text = "* please select a position";
                flag = false;
            }
            else label61.Text = "";

            string fullname = select_name.Text;
            string fname = "";
            string minit = "";
            string lname = "";
            int index = 0;
            while (fullname[index] != ' ')
            {
                fname += fullname[index];
                index++;
            }
            index++;
            minit += fullname[index];
            index+=3;
            while (fullname[index] != ' ')
            {
                lname += fullname[index];
                index++;
            }

            if (!flag) return;
            DataTable table =  controllerObj.GetEmployeeByName(search_position.Text, fname,minit,lname);
            object[] arrray = table.Rows[0].ItemArray;
            ID_textBox.Text = arrray[0].ToString();
            BD_textBox.Text = arrray[1].ToString();
            Gender_textBox.Text = arrray[2].ToString();
            Address_textBox.Text= arrray[3].ToString();
            PhoneNo_textBox.Text = "0" + arrray[4].ToString();

            if (search_position.Text=="Doctor")
            {
                Dep_textBox.Visible = true;
                label62.Visible = true;
                Dep_textBox.Text = arrray[5].ToString();
            }
            else
            {
                Dep_textBox.Visible = false;
                label62.Visible = false;
            }
        }
        private void Search_By_ID_button_Click(object sender, EventArgs e)
        {
            if (ID_textBox.Text != "")
            {
                DialogResult choice = MessageBox.Show("Are you sure you want to delete "+ search_position.Text + " " + ID_textBox.Text, " Delete Employee", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    int result = controllerObj.DeleteEmployee(search_position.Text, Int32.Parse(select_name.Text));
                    if (result > 0)
                        MessageBox.Show(search_position.Text + " " + ID_textBox.Text + " is Delete from the database");
                    else
                        MessageBox.Show("Deletetion Failed");
                }
            }
        }
        private void search_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_name.Text = "";
            select_name.Items.Clear();
            DataTable table = controllerObj.GetNames(search_position.Text);
            if (table !=null)
            {
                string[] arrray1 = table.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                string[] arrray2 = table.Rows.OfType<DataRow>().Select(k => k[1].ToString()).ToArray();
                string[] arrray3 = table.Rows.OfType<DataRow>().Select(k => k[2].ToString()).ToArray();
                for (int i = 0; i < arrray1.Length; i++)
                {
                    select_name.Items.Add(arrray1[i]+' '+ arrray2[i] + ". "+arrray3[i] + ' ');
                }
            }
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
            object oldpassword = controllerObj.GetOldPassword(USERNAME);
            
            if (oldpassword !=null && OldPass.Text == oldpassword.ToString())
            {
                if (OldPass.Text == NewPass.Text)
                {
                    MessageBox.Show("The new password must be different");
                    return;
                }
                if (NewPass.Text.Length < 4)
                {
                    MessageBox.Show("Password is very weak");
                    return;
                }
                int result = controllerObj.ChangePassword(USERNAME, Validation.hashpassword(NewPass.Text));
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
        void FillDepartmentTable()
        {
            dataGridView2.DataSource = controllerObj.DepartmentStatistics();
            if (dataGridView2.Columns.Count!=4)
            {
                DataGridViewButtonColumn delete_dep = new DataGridViewButtonColumn();
                dataGridView2.Columns.Add(delete_dep);
                delete_dep.HeaderText = "Delete";
                delete_dep.Text = "Delete";
                delete_dep.UseColumnTextForButtonValue = true;
            }
        }
        void FillMedicalTestsTable()
        {
            dataGridView8.DataSource = controllerObj.GetAllMedicalTest();
            if (dataGridView8.Columns.Count == 2)
            {
                DataGridViewButtonColumn delete_dep = new DataGridViewButtonColumn();
                dataGridView8.Columns.Add(delete_dep);
                delete_dep.HeaderText = "Delete";
                delete_dep.Text = "Delete";
                delete_dep.UseColumnTextForButtonValue = true;
            }
        }
        void FillSurgery()
        {
            dataGridView9.DataSource = controllerObj.GetAllSurgeries();
            if (dataGridView9.Columns.Count == 2)
            {
                DataGridViewButtonColumn delete_dep = new DataGridViewButtonColumn();
                dataGridView9.Columns.Add(delete_dep);
                delete_dep.HeaderText = "Delete";
                delete_dep.Text = "Delete";
                delete_dep.UseColumnTextForButtonValue = true;
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string dname = dataGridView2[1, e.RowIndex].Value.ToString();
            int x=0;
            bool flag = Int32.TryParse(dname, out x);
            if (flag)
            {
                x=1;
                dname = dataGridView2[2, e.RowIndex].Value.ToString();
            }
            if (dataGridView2[e.ColumnIndex, e.RowIndex].Value.ToString() == "Delete")
            {
                
                DialogResult choice = MessageBox.Show("Are you sure you want to delete " + dname + " departement ?", " Delete Department", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    int dn = Int32.Parse(dataGridView2[x, e.RowIndex].Value.ToString());
                    int result = controllerObj.DeleteDepartment(dn);
                    if (result > 0)
                    {
                        MessageBox.Show("Department " + dname + " is Delete from the database");
                        FillDepartmentTable();
                    }
                    else
                        MessageBox.Show("Could not delete this department");
                }
            }
           
        }
        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string medtest = dataGridView8[0, e.RowIndex].Value.ToString();
            int x = 0;
            bool flag = Int32.TryParse(dataGridView8[1, e.RowIndex].Value.ToString(), out x);
            if (!flag)
            {
                x = 1;
                medtest = dataGridView8[1, e.RowIndex].Value.ToString();
            }
            if (dataGridView8[e.ColumnIndex, e.RowIndex].Value.ToString() == "Delete")
            {

                DialogResult choice = MessageBox.Show("Are you sure you want to delete Medical Test " + medtest + "  ?", " Delete Medical Test", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                   
                    int result = controllerObj.DeleteMedicalTest(medtest);
                    if (result > 0)
                    {
                        MessageBox.Show("Medical Test " + medtest + " is Delete from the database");
                        FillMedicalTestsTable();
                    }
                    else
                        MessageBox.Show("Could not delete this Medical Test");
                }
            }
        }
        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Sname = dataGridView9[0, e.RowIndex].Value.ToString();
            int x = 0;
            bool flag = Int32.TryParse(dataGridView9[1, e.RowIndex].Value.ToString(), out x);
            if (!flag)
            {
                x = 1;
                Sname = dataGridView9[1, e.RowIndex].Value.ToString();
            }
            if (dataGridView9[e.ColumnIndex, e.RowIndex].Value.ToString() == "Delete")
            {

                DialogResult choice = MessageBox.Show("Are you sure you want to delete Surgery " + Sname + "  ?", " Delete Medical Test", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {

                    int result = controllerObj.DeleteSurgery(Sname);
                    if (result > 0)
                    {
                        MessageBox.Show("Surgery " + Sname + " is Delete from the database");
                        FillSurgery();
                    }
                    else
                        MessageBox.Show("Could not delete this Surgery");
                }
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            getEarnings();
        }
        void getEarnings()
        {
            dataGridView3.DataSource = controllerObj.Earnings("Medicines", dateTimePicker1.Value);
            dataGridView4.DataSource = controllerObj.Earnings("MedicalTests", dateTimePicker1.Value);
            dataGridView5.DataSource = controllerObj.Earnings("Appointments", dateTimePicker1.Value);
            dataGridView6.DataSource = controllerObj.Earnings("Operations", dateTimePicker1.Value);
            dataGridView7.DataSource = controllerObj.Earnings("Rooms", dateTimePicker1.Value);
        }
        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            return;
        }
        private void label64_Click(object sender, EventArgs e)
        {
            return;
        }

        
    }
}
