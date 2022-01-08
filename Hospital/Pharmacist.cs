using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace Hospital
{
    public partial class Pharmacist : Form
    {
        Controller ControllerObj;
        private Form CurrentChildForm;
        private IconButton CurrentBtn;
        public Pharmacist()
        {
            ControllerObj = new Controller();
            InitializeComponent();
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
            ActivateButton(sender, Color.White);
            OpenChildForm(new AddMedicine(ControllerObj));
        }

        private void SetPrice_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new SetPrice(ControllerObj));
        }

        private void Sell_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new SellOrAsk(ControllerObj));
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            DisabeButton();
            if (senderBtn != null)
            {
                CurrentBtn = (IconButton)senderBtn;
                CurrentBtn.BackColor = Color.LightSeaGreen;
                CurrentBtn.ForeColor = color;
                CurrentBtn.TextAlign = ContentAlignment.MiddleCenter;
                CurrentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void DisabeButton()
        {
            if (CurrentBtn != null)
            {
                CurrentBtn.BackColor = Color.FromArgb(98, 102, 244);
                CurrentBtn.ForeColor = Color.White;
                CurrentBtn.TextAlign = ContentAlignment.MiddleLeft;
                CurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                if (CurrentBtn.Text == "Add medicine")
                    CurrentBtn.IconColor = Color.FromArgb(186, 13, 13);
                else if (CurrentBtn.Text == "Set Price")
                    CurrentBtn.IconColor = Color.FromArgb(10, 204, 23);
                else
                    CurrentBtn.IconColor = Color.Black;

            }
        }


        private void Logo_Click(object sender, EventArgs e)
        {
            DisabeButton();
        }

        private void SideMenu_Click(object sender, EventArgs e)
        {
            DisabeButton();
        }

        private void Statistics_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new Statistics(ControllerObj));
        }
    }
}
