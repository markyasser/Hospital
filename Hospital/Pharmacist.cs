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
    public partial class Pharmacist : Form
    {
        private Form CurrentChildForm;
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {

        }

      
        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }
            CurrentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            ChildPanel.Controls.Add(ChildForm);
            ChildPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void AddMedicine_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddMedicine());
        }

        private void SetPrice_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SetPrice());
        }

        private void Sell_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SellOrAsk());
        }

        private void ChildPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
