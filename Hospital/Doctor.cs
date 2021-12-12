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
    public partial class Doctor : Form
    {
        
        public Doctor()
        {
            InitializeComponent();
            HideSubmenus();
            HidePanels();
            InitializePanels();
        }
        void HideSubmenus()
        {
            Patient_panel.Visible = false;
        }
        void HidePanels()
        {
            SelectPatient_panel.Visible = false;
            WorkingHours_panel.Visible = false;
        }
        void InitializePanels()
        {
            SelectPatient_panel.Dock = DockStyle.Fill;
            WorkingHours_panel.Dock = DockStyle.Fill;
        }
        void ShowSubmenu(Panel menu)
        {
            if (menu.Visible)
            {
                menu.Visible = false;
            }
            else
            {
                HideSubmenus();
                menu.Visible = true;
            }
        }
        void ShowPanel(Panel menu)
        {
            if (!menu.Visible)
            {
                HidePanels();
                menu.Visible = true;
            }
        }

        private void Patient_button_Click(object sender, EventArgs e)
        {
            ShowSubmenu(Patient_panel);
        }

        private void SelectPatient_button_Click(object sender, EventArgs e)
        {
            ShowPanel(SelectPatient_panel);
        }

        private void WorkHours_button_Click(object sender, EventArgs e)
        {
            ShowPanel(WorkingHours_panel);
        }
    }
}
