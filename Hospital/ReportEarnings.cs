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

        DataSet1TableAdapters.MedicineTableAdapter medicineAdapt;
        DataSet1TableAdapters.Buy_MedicineTableAdapter buymedAdapt;

        DataSet1TableAdapters.AppointmentTableAdapter appAdapt;

        DataSet1TableAdapters.OperateTableAdapter oppAdapt;
        DataSet1TableAdapters.SurgeryTableAdapter surgAdapt;
        public ReportEarnings(string Type,string date)
        {
            InitializeComponent();
            testAdapt = new DataSet1TableAdapters.Medical_TestsTableAdapter();
            DocAdapt = new DataSet1TableAdapters.DoctorTableAdapter();
            PatAdapt = new DataSet1TableAdapters.PatientTableAdapter();
            makeTestdAdapt = new DataSet1TableAdapters.Make_MedicalTestTableAdapter();
            medicineAdapt = new DataSet1TableAdapters.MedicineTableAdapter();
            buymedAdapt = new DataSet1TableAdapters.Buy_MedicineTableAdapter();
            appAdapt = new DataSet1TableAdapters.AppointmentTableAdapter();
            oppAdapt = new DataSet1TableAdapters.OperateTableAdapter();
            surgAdapt = new DataSet1TableAdapters.SurgeryTableAdapter();


            makeTestdAdapt.Fill(dataSet11.Make_MedicalTest, date);
            DocAdapt.Fill(dataSet11.Doctor);
            PatAdapt.Fill(dataSet11.Patient);
            testAdapt.Fill(dataSet11.Medical_Tests);

            appAdapt.Fill(dataSet11.Appointment, date);

            medicineAdapt.Fill(dataSet11.Medicine);
            buymedAdapt.Fill(dataSet11.Buy_Medicine,date);


            oppAdapt.Fill(dataSet11.Operate, date);
            surgAdapt.Fill(dataSet11.Surgery);

            ChooseReport(Type);
            
        }
        void ChooseReport(string type)
        {
            if (type == "MedicalTest")
            {
                crystalReportViewer1.Dock = DockStyle.Fill;
                crystalReportViewer1.BringToFront();
                this.MedTestCR1.SetDataSource(dataSet11);
                this.crystalReportViewer1.RefreshReport();
            }
            else if (type == "Operation")
            {
                crystalReportViewer5.Dock = DockStyle.Fill;
                crystalReportViewer5.BringToFront();
                this.OperateCrystalReport2.SetDataSource(dataSet11);
                this.crystalReportViewer5.RefreshReport();
            }
            else if (type == "Appointment")
            {
                crystalReportViewer3.Dock = DockStyle.Fill;
                crystalReportViewer3.BringToFront();
                this.AppointCrystalReport1.SetDataSource(dataSet11);
                this.crystalReportViewer1.RefreshReport();
            }
            else if (type == "Reserve")
            {
                crystalReportViewer4.Dock = DockStyle.Fill;
                crystalReportViewer4.BringToFront();
                this.MedTestCR1.SetDataSource(dataSet11);
                this.crystalReportViewer1.RefreshReport();
            }
            else if (type == "Medicine")
            {
                crystalReportViewer2.Dock = DockStyle.Fill;
                crystalReportViewer2.BringToFront();
                this.MedicineCrystalReport1.SetDataSource(dataSet11);
                this.crystalReportViewer2.RefreshReport();
            }
        }
        private void ReportEarnings_Load(object sender, EventArgs e)
        {

        }
    }
}
