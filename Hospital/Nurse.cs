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
    public partial class Nurse : Form
    {
        Controller ControllerObj;
        LoginPage l;
        private Form CurrentChildForm;
        private IconButton CurrentBtn;
        private string USERNAME;
        public Nurse(string user, LoginPage log)
        {
            ControllerObj = new Controller();
            InitializeComponent();
            USERNAME = user;
            l = log;
        }

        private void Nurse_Load(object sender, EventArgs e)
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

        private void AskMedicine_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new SellOrAsk(ControllerObj));
        }


        private void Serve_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new Serve(ControllerObj));
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

        private void Settings_iconButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new PharmaSettings(ControllerObj, USERNAME));
        }

        private void Nurse_FormClosing(object sender, FormClosingEventArgs e)
        {
            l.Close();
        }
    }
}
