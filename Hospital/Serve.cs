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
            DataTable dt1 = ControllerObj.GetNurseName();
            Name_cmb.DisplayMember = "Full name";
            Name_cmb.DataSource = dt1;

            DataTable dt2 = ControllerObj.GetNurseName();
            DontName_cmb.DisplayMember = "Full name";
            DontName_cmb.DataSource = dt2;

            DataTable dt3 = ControllerObj.GetRooms();
            RoomNumber_cmb.DisplayMember = "RoomNumber";
            RoomNumber_cmb.DataSource = dt3;

            DataTable dt4 = ControllerObj.GetRooms();
            DontRoomNumber_cmb.DisplayMember = "RoomNumber";
            DontRoomNumber_cmb.DataSource = dt4;

            
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

        private void DontServe_btn_Click(object sender, EventArgs e)
        {
            int result = ControllerObj.DontServe(Convert.ToInt32(DontID_cmb.Text)
                                , Convert.ToInt32(DontRoomNumber_cmb.Text));
            if (result != 0)
                MessageBox.Show("deletion is succeed");
            else
                MessageBox.Show("deletion is failed");
        }


        private void Name_cmb_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.GetNurseIDWithName(Name_cmb.Text);
            ID_cmb.DisplayMember = "ID";
            ID_cmb.DataSource = dt;
        }

        private void DontName_cmb_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.GetNurseIDWithName(DontName_cmb.Text);
            DontID_cmb.DisplayMember = "ID";
            DontID_cmb.DataSource = dt;
        }
    }
}
