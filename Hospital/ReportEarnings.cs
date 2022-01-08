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
    public partial class ReportEarnings : Form
    {
        DataSet1TableAdapters.Medical_TestsTableAdapter testAdapt;
        DataSet1TableAdapters.DoctorTableAdapter DocAdapt;
        DataSet1TableAdapters.PatientTableAdapter PatAdapt;
        DataSet1TableAdapters.Make_MedicalTestTableAdapter makeTestdAdapt;
        public ReportEarnings(string date)
        {
            InitializeComponent();
            testAdapt = new DataSet1TableAdapters.Medical_TestsTableAdapter();
            DocAdapt = new DataSet1TableAdapters.DoctorTableAdapter();
            PatAdapt = new DataSet1TableAdapters.PatientTableAdapter();
            makeTestdAdapt = new DataSet1TableAdapters.Make_MedicalTestTableAdapter();

            makeTestdAdapt.Fill(dataSet11.Make_MedicalTest, date);
            DocAdapt.Fill(dataSet11.Doctor);
            PatAdapt.Fill(dataSet11.Patient);
            testAdapt.Fill(dataSet11.Medical_Tests);

            this.CrystalReport11.SetDataSource(dataSet11);
            this.crystalReportViewer1.RefreshReport();
        }

        private void ReportEarnings_Load(object sender, EventArgs e)
        {

        }
    }
}
