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
        public SellOrAsk()
        {
            InitializeComponent();
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            if (!Med2_gb.Visible)
                Med2_gb.Visible = true;
            else if (!Med3_gb.Visible)
                Med3_gb.Visible = true;
            else if (!Med4_gb.Visible)
                Med4_gb.Visible = true;
            else
                Med5_gb.Visible = true;
        }

        private void SellOrAsk_Load(object sender, EventArgs e)
        {

        }
    }
}
