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
        Controller ControllerObj;
        public SetPrice(Controller Obj)
        {
            ControllerObj = Obj;
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

        private void SetPrice_Load(object sender, EventArgs e)
        {
            DataTable dt1 = ControllerObj.GetAllMedicine();
            Name_cmb.DataSource = dt1;
            Name_cmb.DisplayMember = "Name";
        }

        private void Name_cmb_TextChanged(object sender, EventArgs e)
        {
            object ob = ControllerObj.GetMedPrice(Name_cmb.Text);
            if (ob != null)
            {
                PreviousPrice_txt.Text = ob.ToString();
            }
            
        }

        private void UpdatePrice_btn_Click(object sender, EventArgs e)
        {
            int result = ControllerObj.SetMedPrice(Name_cmb.Text, Convert.ToInt32(UpdatedPrice_txt.Text));
            if (result == 0)
                MessageBox.Show("Updating price failed");
            else
                MessageBox.Show("Updating price succeed");
        }
    }
}
