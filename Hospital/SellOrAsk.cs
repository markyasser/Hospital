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

        private void SellOrAsk_Load(object sender, EventArgs e)
        {
            DataTable dt1 = ControllerObj.GetAllMedicine();
            Medname1_cmb.DataSource = dt1;
            Medname1_cmb.DisplayMember = "Name";

            DataTable dt = ControllerObj.SelectPatientsID();
            PatientID_cmb.DataSource = dt1;
            PatientID_cmb.DisplayMember = "Pid";
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
                sum += Convert.ToInt32(Price1_txt.Text) * Convert.ToInt32(Amount1_txt.Text);
                if (Med2_gb.Visible == true)
                {
                    sum += Convert.ToInt32(Price2_txt.Text) * Convert.ToInt32(Amount2_txt.Text); ;
                    if (Med3_gb.Visible == true)
                    {
                        sum += Convert.ToInt32(Price3_txt.Text) * Convert.ToInt32(Amount3_txt.Text); ;
                        if (Med4_gb.Visible == true)
                        {
                            sum += Convert.ToInt32(Price4_txt.Text) * Convert.ToInt32(Amount4_txt.Text); ;
                            if (Med5_gb.Visible == true)
                            {
                                sum += Convert.ToInt32(Price5_txt.Text) * Convert.ToInt32(Amount5_txt.Text); ;
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

        //int PerformMed1()
        //{

        //    int result = ControllerObj.BuyMedicine(Medname1_cmb.Text, Convert.ToInt32(Amount1_txt.Text));
        //    if (result != 0)
        //    {
        //        int result1 = ControllerObj.AddMedicineToPatient(Medname1_cmb.Text,
        //            Convert.ToInt32(PatientID_cmb.Text), Convert.ToInt32(Amount1_txt.Text));
        //        return result1;
        //    }
        //    else
        //        return 0;

        //}

        //int PerformMed2()
        //{

        //    int result = ControllerObj.BuyMedicine(Medname2_cmb.Text, Convert.ToInt32(Amount2_txt.Text));
        //    if (result != 0)
        //    {
        //        int result1 = ControllerObj.AddMedicineToPatient(Medname2_cmb.Text,
        //            Convert.ToInt32(PatientID_cmb.Text), Convert.ToInt32(Amount2_txt.Text));
        //        return result1;
        //    }
        //    else
        //        return 0;
        //}

        //int PerformMed3()
        //{

        //    int result = ControllerObj.BuyMedicine(Medname3_cmb.Text, Convert.ToInt32(Amount3_txt.Text));
        //    if (result != 0)
        //    {
        //        int result1 = ControllerObj.AddMedicineToPatient(Medname3_cmb.Text,
        //            Convert.ToInt32(PatientID_cmb.Text), Convert.ToInt32(Amount3_txt.Text));
        //        return result1;
        //    }
        //    else
        //        return 0;
        //}

        //int PerformMed4()
        //{

        //    int result = ControllerObj.BuyMedicine(Medname4_cmb.Text, Convert.ToInt32(Amount4_txt.Text));
        //    if (result != 0)
        //    {
        //        int result1 = ControllerObj.AddMedicineToPatient(Medname4_cmb.Text,
        //            Convert.ToInt32(PatientID_cmb.Text), Convert.ToInt32(Amount4_txt.Text));
        //        return result1;
        //    }
        //    else
        //        return 0;
        //}

        //int PerformMed5()
        //{

        //    int result = ControllerObj.BuyMedicine(Medname5_cmb.Text, Convert.ToInt32(Amount5_txt.Text));
        //    if (result != 0)
        //    {
        //        int result1 = ControllerObj.AddMedicineToPatient(Medname5_cmb.Text,
        //            Convert.ToInt32(PatientID_cmb.Text), Convert.ToInt32(Amount5_txt.Text));
        //        return result1;
        //    }
        //    else
        //        return 0;
        //}

        //private void Get_btn_Click(object sender, EventArgs e)
        //{
        //    if (Med1_gb.Visible == true)
        //    {
        //        int result1=PerformMed1();
        //        if (result1 != 0)
        //            MessageBox.Show("Buying first medicine succes");
        //        else
        //            MessageBox.Show("Buying first medicine failed");
        //        if (Med2_gb.Visible==true)
        //        {
        //            int result2 = PerformMed2();
        //            if (result2 != 0)
        //                MessageBox.Show("Buying second medicine succes");
        //            else
        //                MessageBox.Show("Buying second medicine failed");
        //            if (Med3_gb.Visible==true)
        //            {
        //                int result3 = PerformMed3();
        //                if (result3 != 0)
        //                    MessageBox.Show("Buying third medicine succes");
        //                else
        //                    MessageBox.Show("Buying third medicine failed");
        //                if (Med4_gb.Visible==true)
        //                {
        //                    int result4 = PerformMed4();
        //                    if (result4 != 0)
        //                        MessageBox.Show("Buying fourth medicine succes");
        //                    else
        //                        MessageBox.Show("Buying fourth medicine failed");
        //                    if(Med5_gb.Visible==true)
        //                    {
        //                        int result5 = PerformMed5();
        //                        if (result5 != 0)
        //                            MessageBox.Show("Buying fifth medicine succes");
        //                        else
        //                            MessageBox.Show("Buying fifth medicine failed");
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        private void Label5_Click(object sender, EventArgs e)
        {

        }



        private void Amount2_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                Amount2Msg_lbl.Visible = true;
                e.Handled = true;
            }
            else
                Amount2Msg_lbl.Visible = false;
        }

        private void Amount1_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                Amount1Msg_lbl.Visible = true;
                e.Handled = true;
            }
            else
                Amount1Msg_lbl.Visible = false;
        }

        private void Amount3_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                Amount3Msg_lbl.Visible = true;
                e.Handled = true;
            }
            else
                Amount3Msg_lbl.Visible = false;
        }

        private void Amount4_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                Amount4Msg_lbl.Visible = true;
                e.Handled = true;
            }
            else
                Amount4Msg_lbl.Visible = false;
        }

        private void Amount5_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                Amount5Msg_lbl.Visible = true;
                e.Handled = true;
            }
            else
                Amount5Msg_lbl.Visible = false;
        }

        private void PatientID_cmb_TextChanged(object sender, EventArgs e)
        {
            PatientName_txt.Text = ControllerObj.GetPatientName(Convert.ToInt32(PatientID_cmb.Text)).ToString();
        }
    }
}
