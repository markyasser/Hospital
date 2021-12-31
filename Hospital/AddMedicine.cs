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
        public AddMedicine()
        {
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
    }
}
