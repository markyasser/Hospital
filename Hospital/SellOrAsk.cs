using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class SellOrAsk : Form
    {
        Controller ControllerObj;
        public SellOrAsk(Controller Obj)
        {
            ControllerObj = Obj;
            InitializeComponent();
        }

        private void SellOrAsk_Load(object sender, EventArgs e)
        {
            DataTable dt1 = ControllerObj.GetAllMedicine();
            Medname1_cmb.DisplayMember = "Name";
            Medname1_cmb.DataSource = dt1;

            DataTable dt2 = ControllerObj.GetPatientName();
            PatientName_cmb.DisplayMember = "Full name";
            PatientName_cmb.DataSource = dt2;

        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            if (!Med2_gb.Visible)
            {
                Med2_gb.Visible = true;
                DataTable dt2 = ControllerObj.GetAllMedicine();
                Medname2_cmb.DataSource = dt2;
                Medname2_cmb.DisplayMember = "Name";
            }
            else if (!Med3_gb.Visible)
            {
                Med3_gb.Visible = true;
                DataTable dt3 = ControllerObj.GetAllMedicine();
                Medname3_cmb.DataSource = dt3;
                Medname3_cmb.DisplayMember = "Name";
            }
            else if (!Med4_gb.Visible)
            {
                Med4_gb.Visible = true;
                DataTable dt4 = ControllerObj.GetAllMedicine();
                Medname4_cmb.DataSource = dt4;
                Medname4_cmb.DisplayMember = "Name";
            }
            else
            {
                Med5_gb.Visible = true;
                DataTable dt5 = ControllerObj.GetAllMedicine();
                Medname5_cmb.DataSource = dt5;
                Medname5_cmb.DisplayMember = "Name";
            }
        }

        private void Medname1_cmb_TextChanged(object sender, EventArgs e)
        {
            Price1_txt.Text = ControllerObj.GetMedPrice(Medname1_cmb.Text).ToString();
            TotalPrice_txt.Text = CalculateTotalPrice();
        }

        private void Medname2_cmb_TextChanged(object sender, EventArgs e)
        {
            Price2_txt.Text = ControllerObj.GetMedPrice(Medname2_cmb.Text).ToString();
            TotalPrice_txt.Text = CalculateTotalPrice();
        }

        private void Medname3_cmb_TextChanged(object sender, EventArgs e)
        {
            Price3_txt.Text = ControllerObj.GetMedPrice(Medname3_cmb.Text).ToString();
            TotalPrice_txt.Text = CalculateTotalPrice();
        }

        private void Medname4_cmb_TextChanged(object sender, EventArgs e)
        {
            Price4_txt.Text = ControllerObj.GetMedPrice(Medname4_cmb.Text).ToString();
            TotalPrice_txt.Text = CalculateTotalPrice();
        }

        private void Medname5_cmb_TextChanged(object sender, EventArgs e)
        {
            Price5_txt.Text = ControllerObj.GetMedPrice(Medname5_cmb.Text).ToString();
            TotalPrice_txt.Text = CalculateTotalPrice();
        }

        private String CalculateTotalPrice()
        {
            int sum = 0;
            if (Med1_gb.Visible == true)
            {
                sum += Convert.ToInt32(Price1_txt.Text) * Convert.ToInt32(Amount1_NUD.Value);
                if (Med2_gb.Visible == true)
                {
                    sum += Convert.ToInt32(Price2_txt.Text) * Convert.ToInt32(Amount2_NUD.Value); ;
                    if (Med3_gb.Visible == true)
                    {
                        sum += Convert.ToInt32(Price3_txt.Text) * Convert.ToInt32(Amount3_NUD.Value); ;
                        if (Med4_gb.Visible == true)
                        {
                            sum += Convert.ToInt32(Price4_txt.Text) * Convert.ToInt32(Amount4_NUD.Value); ;
                            if (Med5_gb.Visible == true)
                            {
                                sum += Convert.ToInt32(Price5_txt.Text) * Convert.ToInt32(Amount5_NUD.Value); ;
                            }
                            return sum.ToString();
                        }
                        return sum.ToString();
                    }
                    return sum.ToString();
                }
                return sum.ToString();
            }
            return sum.ToString();
        }

        int PerformMed1()
        {

            int result = ControllerObj.BuyMedicine(Medname1_cmb.Text, Convert.ToInt32(Amount1_NUD.Value));
            if (result != 0)
            {
                int MedID = Convert.ToInt32(ControllerObj.GetMedID(Medname1_cmb.Text));
                int result1 = ControllerObj.AddMedicineToPatient(MedID,
                    Convert.ToInt32(PatientID_cmb.Text), Convert.ToInt32(Amount1_NUD.Value));
                return result1;
            }
            else
                return 0;

        }

        int PerformMed2()
        {

            int result = ControllerObj.BuyMedicine(Medname2_cmb.Text, Convert.ToInt32(Amount2_NUD.Value));
            if (result != 0)
            {
                int MedID = Convert.ToInt32(ControllerObj.GetMedID(Medname2_cmb.Text));
                int result1 = ControllerObj.AddMedicineToPatient(MedID,
                    Convert.ToInt32(PatientID_cmb.Text), Convert.ToInt32(Amount2_NUD.Value));
                return result1;
            }
            else
                return 0;
        }

        int PerformMed3()
        {

            int result = ControllerObj.BuyMedicine(Medname3_cmb.Text, Convert.ToInt32(Amount3_NUD.Value));
            if (result != 0)
            {
                int MedID = Convert.ToInt32(ControllerObj.GetMedID(Medname3_cmb.Text));
                int result1 = ControllerObj.AddMedicineToPatient(MedID,
                    Convert.ToInt32(PatientID_cmb.Text), Convert.ToInt32(Amount3_NUD.Value));
                return result1;
            }
            else
                return 0;
        }

        int PerformMed4()
        {

            int result = ControllerObj.BuyMedicine(Medname4_cmb.Text, Convert.ToInt32(Amount4_NUD.Value));
            if (result != 0)
            {
                int MedID = Convert.ToInt32(ControllerObj.GetMedID(Medname4_cmb.Text));
                int result1 = ControllerObj.AddMedicineToPatient(MedID,
                    Convert.ToInt32(PatientID_cmb.Text), Convert.ToInt32(Amount4_NUD.Value));
                return result1;
            }
            else
                return 0;
        }

        int PerformMed5()
        {

            int result = ControllerObj.BuyMedicine(Medname5_cmb.Text, Convert.ToInt32(Amount5_NUD.Value));
            if (result != 0)
            {
                int MedID = Convert.ToInt32(ControllerObj.GetMedID(Medname5_cmb.Text));
                int result1 = ControllerObj.AddMedicineToPatient(MedID,
                    Convert.ToInt32(PatientID_cmb.Text), Convert.ToInt32(Amount5_NUD.Value));
                return result1;
            }
            else
                return 0;
        }

        private void Get_btn_Click(object sender, EventArgs e)
        {
            if (Med1_gb.Visible == true)
            {
                int result1 = PerformMed1();
                if (result1 != 0)
                    MessageBox.Show("Buying first medicine succes");
                else
                    MessageBox.Show("Buying first medicine failed");
                if (Med2_gb.Visible == true)
                {
                    int result2 = PerformMed2();
                    if (result2 != 0)
                        MessageBox.Show("Buying second medicine succes");
                    else
                        MessageBox.Show("Buying second medicine failed");
                    if (Med3_gb.Visible == true)
                    {
                        int result3 = PerformMed3();
                        if (result3 != 0)
                            MessageBox.Show("Buying third medicine succes");
                        else
                            MessageBox.Show("Buying third medicine failed");
                        if (Med4_gb.Visible == true)
                        {
                            int result4 = PerformMed4();
                            if (result4 != 0)
                                MessageBox.Show("Buying fourth medicine succes");
                            else
                                MessageBox.Show("Buying fourth medicine failed");
                            if (Med5_gb.Visible == true)
                            {
                                int result5 = PerformMed5();
                                if (result5 != 0)
                                    MessageBox.Show("Buying fifth medicine succes");
                                else
                                    MessageBox.Show("Buying fifth medicine failed");
                            }
                        }
                    }
                }
            }
        }

        private void PatientName_cmb_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.GetPatientIDWithName(PatientName_cmb.Text);
            PatientID_cmb.DataSource = dt;
            PatientID_cmb.DisplayMember = "patient_id";
        }

        private void RemoveMed_btn_Click(object sender, EventArgs e)
        {
            if (Med5_gb.Visible == true)
            {
                Med5_gb.Visible = false;
                TotalPrice_txt.Text = CalculateTotalPrice();
            }
            else if (Med4_gb.Visible == true)
            {
                Med4_gb.Visible = false;
                TotalPrice_txt.Text = CalculateTotalPrice();
            }
            else if (Med3_gb.Visible == true)
            {
                Med3_gb.Visible = false;
                TotalPrice_txt.Text = CalculateTotalPrice();
            }
            else
            {
                Med2_gb.Visible = false;
                TotalPrice_txt.Text = CalculateTotalPrice();
            }
        }

        private void Amount1_NUD_ValueChanged(object sender, EventArgs e)
        {
            TotalPrice_txt.Text = CalculateTotalPrice();
        }

        private void Amount2_NUD_ValueChanged(object sender, EventArgs e)
        {
            TotalPrice_txt.Text = CalculateTotalPrice();
        }

        private void Amount3_NUD_ValueChanged(object sender, EventArgs e)
        {
            TotalPrice_txt.Text = CalculateTotalPrice();
        }

        private void Amount4_NUD_ValueChanged(object sender, EventArgs e)
        {
            TotalPrice_txt.Text = CalculateTotalPrice();
        }

        private void Amount5_NUD_ValueChanged(object sender, EventArgs e)
        {
            TotalPrice_txt.Text = CalculateTotalPrice();
        }

        private void PatientName_cmb_TextChanged_1(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.GetPatientIDWithName(PatientName_cmb.Text);
            PatientID_cmb.DisplayMember = "ID";
            PatientID_cmb.DataSource = dt;
        }

    }
}