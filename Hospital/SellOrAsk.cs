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

            //DataTable dt = ControllerObj.GetAllPatien;
            //Medname1_cmb.DataSource = dt1;
            //Medname1_cmb.DisplayMember = "Name";
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
                sum += Convert.ToInt32(Price1_txt.Text);
                if (Med2_gb.Visible == true)
                {
                    sum += Convert.ToInt32(Price2_txt.Text);
                    if (Med3_gb.Visible == true)
                    {
                        sum += Convert.ToInt32(Price3_txt.Text);
                        if (Med4_gb.Visible == true)
                        {
                            sum += Convert.ToInt32(Price4_txt.Text);
                            if (Med5_gb.Visible == true)
                            {
                                sum += Convert.ToInt32(Price5_txt.Text);
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

        private void Get_btn_Click(object sender, EventArgs e)
        {
            //to DO
        }
    }
}
