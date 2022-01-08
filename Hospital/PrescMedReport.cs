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
    public partial class PrescMedReport : Form
    {
        Prescription_DataSetTableAdapters.AppointmentTableAdapter AppointAdap;
        Prescription_DataSetTableAdapters.DoctorTableAdapter DoctorAdap;
        Prescription_DataSetTableAdapters.PatientTableAdapter PatAdap;
        Prescription_DataSetTableAdapters.Presc_MedicineTableAdapter MedAdap;
        Prescription_DataSetTableAdapters.Presc_MedicalTestTableAdapter TestAdap;
 
        public PrescMedReport(int pid, int did, string date)
        {
            InitializeComponent();
            AppointAdap = new Prescription_DataSetTableAdapters.AppointmentTableAdapter();
            DoctorAdap = new Prescription_DataSetTableAdapters.DoctorTableAdapter();
            PatAdap = new Prescription_DataSetTableAdapters.PatientTableAdapter();
            MedAdap = new Prescription_DataSetTableAdapters.Presc_MedicineTableAdapter();
            TestAdap = new Prescription_DataSetTableAdapters.Presc_MedicalTestTableAdapter();
            AppointAdap.Fill(prescription_DataSet1.Appointment);
            DoctorAdap.Fill(prescription_DataSet1.Doctor);
            PatAdap.Fill(prescription_DataSet1.Patient);
            MedAdap.Fill(prescription_DataSet1.Presc_Medicine, pid, did, date);
            TestAdap.Fill(prescription_DataSet1.Presc_MedicalTest, pid, did, date);
            this.PrescMed_CrystalReport1.SetDataSource(prescription_DataSet1);
            this.crystalReportViewer1.RefreshReport();
        }

        private void PrescMedReport_Load(object sender, EventArgs e)
        {

        }
    }
}
