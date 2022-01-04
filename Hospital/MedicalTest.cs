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
    public partial class MedicalTest : Form
    {
        Controller ControllerObj;
        public MedicalTest(Controller Obj)
        {
            ControllerObj = Obj;
            InitializeComponent();
        }

        private void MedicalTest_Load(object sender, EventArgs e)
        {
            DataTable dt1 = ControllerObj.GetAllMedicalTest();
            MT1_cmb.DataSource = dt1;
            MT1_cmb.DisplayMember = "Name";
        }

        private void Discribtion_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar!='.' )
            {
                DisMsg_lbl.Visible = true;
                e.Handled = true;
            }
            else
                DisMsg_lbl.Visible = false;
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            if (!Med2_gb.Visible)
            {
                Med2_gb.Visible = true;
                DataTable dt2 = ControllerObj.GetAllMedicalTest();
                MT2_cmb.DataSource = dt2;
                MT2_cmb.DisplayMember = "Name";
            }
            else
            {
                Med3_gb.Visible = true;
                DataTable dt3 = ControllerObj.GetAllMedicalTest();
                MT3_cmb.DataSource = dt3;
                MT3_cmb.DisplayMember = "Name";
            }
        }

        private void MT1_cmb_TextChanged(object sender, EventArgs e)
        {
            Price1_txt.Text = ControllerObj.GetMedicalTestPrice(MT1_cmb.Text).ToString();
            TotalPrice_txt.Text = CalculateTotalPrice();
        }

        private void MT2_cmb_TextChanged(object sender, EventArgs e)
        {
            Price2_txt.Text = ControllerObj.GetMedicalTestPrice(MT2_cmb.Text).ToString();
            TotalPrice_txt.Text = CalculateTotalPrice();
        }

        private void MT3_cmb_TextChanged(object sender, EventArgs e)
        {
            Price3_txt.Text = ControllerObj.GetMedicalTestPrice(MT3_cmb.Text).ToString();
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
                    }
                    return sum.ToString();
                }
                return sum.ToString();
            }
            return sum.ToString();
        }
    }
}
