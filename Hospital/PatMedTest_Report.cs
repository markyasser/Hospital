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
    public partial class PatMedTest_Report : Form
    {

        Patient_DataSetTableAdapters.AppointmentTableAdapter AppointAdap;
        Patient_DataSetTableAdapters.DoctorTableAdapter DoctorAdap;
        Patient_DataSetTableAdapters.Make_MedicalTestTableAdapter MakeAdap;
        Patient_DataSetTableAdapters.Medical_TestsTableAdapter TestAdap;
        Patient_DataSetTableAdapters.PatientTableAdapter PatAdap;
        Patient_DataSetTableAdapters.Presc_MedicineTableAdapter MedAdap;

        public PatMedTest_Report(int patID, int Did)
        {
            InitializeComponent();
            AppointAdap = new Patient_DataSetTableAdapters.AppointmentTableAdapter();
            DoctorAdap = new Patient_DataSetTableAdapters.DoctorTableAdapter();
            MakeAdap = new Patient_DataSetTableAdapters.Make_MedicalTestTableAdapter();
            TestAdap = new Patient_DataSetTableAdapters.Medical_TestsTableAdapter();
            PatAdap = new Patient_DataSetTableAdapters.PatientTableAdapter();
            MedAdap = new Patient_DataSetTableAdapters.Presc_MedicineTableAdapter();
            AppointAdap.Fill(patient_DataSet1.Appointment);
            DoctorAdap.Fill(patient_DataSet1.Doctor);
            MakeAdap.Fill(patient_DataSet1.Make_MedicalTest, patID, Did);
            TestAdap.Fill(patient_DataSet1.Medical_Tests);
            PatAdap.Fill(patient_DataSet1.Patient);
            MedAdap.Fill(patient_DataSet1.Presc_Medicine,patID, Did);
            this.PatientMedTest_CrystalReport1.SetDataSource(patient_DataSet1);
            this.crystalReportViewer1.RefreshReport();
        }

        private void PatMedTest_Report_Load(object sender, EventArgs e)
        {

        }
    }
}
