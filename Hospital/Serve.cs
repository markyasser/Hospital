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
    public partial class Serve : Form
    {
        Controller ControllerObj;
        public Serve(Controller obj)
        {
            ControllerObj = obj;
            InitializeComponent();
        }

        private void Serve_Load(object sender, EventArgs e)
        {
            DataTable dt1 = ControllerObj.GetNurseID();
            DataTable dt2 = ControllerObj.GetNurseID();
            DataTable dt3 = ControllerObj.GetRooms();
            DataTable dt4 = ControllerObj.GetRooms();
            ID_cmb.DataSource = dt1;
            DontID_cmb.DataSource = dt2;
            RoomNumber_cmb.DataSource = dt3;
            DontRoomNumber_cmb.DataSource = dt4;
            ID_cmb.DisplayMember = "NurseID";
            DontID_cmb.DisplayMember = "NurseID";
            RoomNumber_cmb.DisplayMember = "RoomNo";
            DontRoomNumber_cmb.DisplayMember = "RoomNo";
        }

        private void Serve_btn_Click(object sender, EventArgs e)
        {
            int result = ControllerObj.InsertServe(Convert.ToInt32(ID_cmb.Text)
                                , Convert.ToInt32(RoomNumber_cmb.Text));
            if (result != 0)
                MessageBox.Show("insertion is succeed");
            else
                MessageBox.Show("Insertion is failed");
        }

        private void ID_cmb_TextChanged(object sender, EventArgs e)
        {
            Name_txt.Text = ControllerObj.GetNurseName(Convert.ToInt32(ID_cmb.Text)).ToString();
        }

        private void DontID_cmb_TextChanged(object sender, EventArgs e)
        {
            DontName_txt.Text = ControllerObj.GetNurseName(Convert.ToInt32(ID_cmb.Text)).ToString();
        }

        private void DontServe_btn_Click(object sender, EventArgs e)
        {
            int result = ControllerObj.DontServe(Convert.ToInt32(ID_cmb.Text)
                                , Convert.ToInt32(RoomNumber_cmb.Text));
            if (result != 0)
                MessageBox.Show("deletion is succeed");
            else
                MessageBox.Show("deletion is failed");
        }

        private void Serve_gb_Enter(object sender, EventArgs e)
        {

        }
    }
}
