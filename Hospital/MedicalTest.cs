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

        }

        private void Discribtion_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
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
                Med2_gb.Visible = true;
            else 
                Med3_gb.Visible = true;
        }
    }
}
