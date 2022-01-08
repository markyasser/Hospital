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
    public partial class AllEarnings : Form
    {
        int Avg1, Avg2, Avg3, Avg4, Avg5;
        public AllEarnings(int avg1, int avg2,int avg3, int avg4, int avg5)
        {
            InitializeComponent();
            Avg1 = avg1;
            Avg2 = avg2;
            Avg3 = avg3;
            Avg4 = avg4;
            Avg5 = avg5;
        }

        private void AllEarnings_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            chart1.Series["Series1"].Points.AddXY("Medicines", Avg1);
            chart1.Series["Series1"].Points.AddXY("Medical Tests", Avg2);
            chart1.Series["Series1"].Points.AddXY("Appointment", Avg3);
            chart1.Series["Series1"].Points.AddXY("Rooms", Avg4);
            chart1.Series["Series1"].Points.AddXY("Operation", Avg5);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
