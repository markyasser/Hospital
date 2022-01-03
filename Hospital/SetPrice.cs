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
    public partial class SetPrice : Form
    {
        public SetPrice()
        {
            InitializeComponent();
        }

        private void UpdatedPrice_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                PriceMsg_lbl.Visible = true;
                e.Handled = true;
            }
            else
                PriceMsg_lbl.Visible = false;
        }
    }
}
