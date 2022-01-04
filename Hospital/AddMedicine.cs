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
    public partial class AddMedicine : Form
    {
        Controller ControllerObj;
        public AddMedicine(Controller Obj)
        {
            ControllerObj = Obj;
            InitializeComponent();
        }

        private void Name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                NameMsg_lbl.Visible = true;
                e.Handled = true;
            }
            else
                NameMsg_lbl.Visible = false;
        }

        private void MedID_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MedIDMsg_lbl.Visible = true;
                e.Handled = true;
            }
            else
                MedIDMsg_lbl.Visible = false;
        }

        private void Quantity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                QuantityMsg_lbl.Visible = true;
                e.Handled = true;
            }
            else
                QuantityMsg_lbl.Visible = false;
        }

        private void Price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                PriceMsg_lbl.Visible = true;
                e.Handled = true;
            }
            else
                PriceMsg_lbl.Visible = false;
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void AddMedicine_btn_Click(object sender, EventArgs e)
        {
            if (MedID_txt.Text == "")
            {
                EmptyMedIDMsg_lbl.Visible = true;
                if (Name_txt.Text == "")
                {
                    EmptyNameMsb_lbl.Visible = true;
                    if (Quantity_txt.Text == "")
                        EmptyQuantityMsg_lbl.Visible = true;
                }
            }
            else
            {
                int result = ControllerObj.InsertMedicine(Convert.ToInt32(MedID_txt.Text), Name_txt.Text,
                             Convert.ToInt32(Price_txt.Text), Convert.ToInt32(Quantity_txt.Text),
                             dateTimePicker1.Value.ToShortDateString());
                if (result == 0)
                    MessageBox.Show("insertion has been failed");
                else
                    MessageBox.Show("insertion has been success");
            }
        }
    }
}
