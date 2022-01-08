using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hospital
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public object ValidateUser(string username)
        {

            string StoredProcedureName = StoredProcedures.AccountExcist;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public string GetUser(string username)
        {
            Object retrunValue;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);

            string StoredProcedureName = StoredProcedures.IsDoctor;
            retrunValue = dbMan.ExecuteScalar(StoredProcedureName, Parameters);
            if (retrunValue != null)
                return "Doctor";

            StoredProcedureName = StoredProcedures.IsPharma;
            retrunValue = dbMan.ExecuteScalar(StoredProcedureName, Parameters);
            if (retrunValue != null)
                return "Pharmacist";

            StoredProcedureName = StoredProcedures.IsRecept;
            retrunValue = dbMan.ExecuteScalar(StoredProcedureName, Parameters);
            if (retrunValue != null)
                return "Receptionist";


            StoredProcedureName = StoredProcedures.IsNurse;
            retrunValue = dbMan.ExecuteScalar(StoredProcedureName, Parameters);
            if (retrunValue != null)
                return "Nurse";

            return "admin";
        }
        public int CreateAccount(string username, string passwrod)
        {
            string StoredProcedureName = StoredProcedures.CreateAccount;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@password",Validation.hashpassword(passwrod));
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertDoctor(int Doctor_id, string Fname, string Minit, string Lname,
                                string d_username, string Bdate, string address, int phoneNumber, char Gender, int DNO)
        {
            string StoredProcedureName = StoredProcedures.InsertDoctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Doctor_id", Doctor_id);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Minit", Minit);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@d_username", d_username);
            Parameters.Add("@Bdate", Bdate);
            Parameters.Add("@address", address);
            Parameters.Add("@phoneNumber", phoneNumber);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@DNO", DNO);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertNotDoctor(int id, string Fname, string Minit, string Lname,
                                string username, string Bdate, string address, int phoneNumber, char Gender, string position)
        {
            string StoredProcedureName = "";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            if (position == "Nurse")
            {
                StoredProcedureName = StoredProcedures.InsertNurse;
                Parameters.Add("@nurse_id", id);
                Parameters.Add("@n_username", username);
            }
            else if (position == "Pharmacist")
            {
                StoredProcedureName = StoredProcedures.InsertPharmacist;
                Parameters.Add("@pharma_id", id);
                Parameters.Add("@p_username", username);
            }
            else if (position == "Receptionist")
            {
                StoredProcedureName = StoredProcedures.InsertReceptionist;
                Parameters.Add("@receptionist_id", id);
                Parameters.Add("@r_username", username);
            }

            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Minit", Minit);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Bdate", Bdate);
            Parameters.Add("@address", address);
            Parameters.Add("@phoneNumber", phoneNumber);
            Parameters.Add("@Gender", Gender);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertDepartment(int Dnumber, string specialization)
        {

            string StoredProcedureName = StoredProcedures.InsertDepartment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dnumber", Dnumber);
            Parameters.Add("@specialization", specialization);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertRoom(int room_number, string type,int dep_id,int price)
        {

            string StoredProcedureName = StoredProcedures.InsertRooms;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@number", room_number);
            Parameters.Add("@type", type);
            Parameters.Add("@dep_id", dep_id);
            Parameters.Add("@price", price);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        
        public int DeleteDepartment(int Dnumber)
        {

            string StoredProcedureName = StoredProcedures.DeleteDepartment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dnumber", Dnumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int DeleteMedicalTest(string testname)
        {
            string StoredProcedureName = StoredProcedures.DeleteMedicalTest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", testname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int DeleteSurgery(string Sname)
        {
            string StoredProcedureName = StoredProcedures.DeleteSurgery;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", Sname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertSurgery(string Surgery_Name, int surg_price)
        {

            string StoredProcedureName = StoredProcedures.InsertSurgery;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Surgery_Name", Surgery_Name);
            Parameters.Add("@surg_price", surg_price);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertMedicalTest(string medical_test_name, int medical_test_price)
        {

            string StoredProcedureName = StoredProcedures.InsertMedicalTest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@medical_test_name", medical_test_name);
            Parameters.Add("@medical_test_price", medical_test_price);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetAllDepartmentNumber()
        {
            string StoredProcedureName = StoredProcedures.GetAllDepartmentNumber;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetAllRoomsInformation()
        {
            string StoredProcedureName = StoredProcedures.GetAllRoomsInfo;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable DepartmentStatistics()
        {
            string StoredProcedureName = StoredProcedures.DepartmentStatistics;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetAllSurgeries()
        {
            string StoredProcedureName = StoredProcedures.GetAllSurgeries;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetAllEmployees(string position, string specialization)
        {
            string StoredProcedureName = "";
            if (position == "Doctor")
            {
                if (specialization != "" && specialization != "All")
                {
                    StoredProcedureName = StoredProcedures.GetAllDep_Doctors;
                    Dictionary<string, object> Parameters = new Dictionary<string, object>();
                    Parameters.Add("@specialization", specialization);
                    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
                }
                StoredProcedureName = StoredProcedures.GetAllDoctors;
            }
            else if (position == "Nurse")
            {
                StoredProcedureName = StoredProcedures.GetAllNurses;
            }
            else if (position == "Pharmacist")
            {
                StoredProcedureName = StoredProcedures.GetAllPharma;
            }
            else if (position == "Receptionist")
            {
                StoredProcedureName = StoredProcedures.GetAllRecept;
            }
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetNames(string position)
        {
            string StoredProcedureName = "";
            if (position == "Doctor")
                StoredProcedureName = StoredProcedures.GetDNames;

            else if (position == "Nurse")
                StoredProcedureName = StoredProcedures.GetNNames;

            else if (position == "Pharmacist")
                StoredProcedureName = StoredProcedures.GetPNames;

            else if (position == "Receptionist")
                StoredProcedureName = StoredProcedures.GetRNames;

            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetEmployeeByName(string position, string fname, string minit, string lname)
        {
            string StoredProcedureName = "";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@fname", fname);
            Parameters.Add("@minit", minit);
            Parameters.Add("@lname", lname);
            if (position == "Doctor")
                StoredProcedureName = StoredProcedures.GetDoctorByName;

            else if (position == "Nurse")
                StoredProcedureName = StoredProcedures.GetNurseByName;

            else if (position == "Pharmacist")
                StoredProcedureName = StoredProcedures.GetPharmaByName;

            else if (position == "Receptionist")
                StoredProcedureName = StoredProcedures.GetReceptionistByName;

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int DeleteEmployee(string position, int id)
        {

            string StoredProcedureName = "";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            if (position == "Doctor")
                StoredProcedureName = StoredProcedures.DeleteDoctor;

            else if (position == "Nurse")
                StoredProcedureName = StoredProcedures.DeleteNurse;

            else if (position == "Pharmacist")
                StoredProcedureName = StoredProcedures.DeletePharma;

            else if (position == "Receptionist")
                StoredProcedureName = StoredProcedures.DeleteRecept;
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int ChangePassword(string username, string password)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@newpassword", password);
            string StoredProcedureName = StoredProcedures.ChangePassword;
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int DeleteAccount(string username)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@user", username);
            string StoredProcedureName = StoredProcedures.DeleteAccount;
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public object GetOldPassword(string username)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            string StoredProcedureName = StoredProcedures.GetOldPassword;
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public object getDnumber(string spt)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@spt", spt);
            string StoredProcedureName = StoredProcedures.GetDepartmentNumberBySpt;
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public DataTable Earnings(string service, DateTime date)
        {
            string StoredProcedureName = "";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date", date);
            if (service == "Rooms")
                StoredProcedureName = StoredProcedures.EarningsRooms;

            else if (service == "Medicines")
                StoredProcedureName = StoredProcedures.EarningsMedicines;

            else if (service == "Appointments")
                StoredProcedureName = StoredProcedures.EarningsAppointments;

            else if (service == "Operations")
                StoredProcedureName = StoredProcedures.EarningsOperations;
            else if (service == "MedicalTests")
                StoredProcedureName = StoredProcedures.EarningsMedicalTests;

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //---------------------------------Doctor----------------------------
        public DataTable SelectPatientsID()
        {
            String StoredProcedureName = StoredProcedures.SelectPatientsID;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable SelectPatientWithID(int id)
        {
            String StoredProcedureName = StoredProcedures.SelectPatientWithID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        } 
        public DataTable SelectPatientsOfDoctor(int id)
        {
            String StoredProcedureName = StoredProcedures.SelectPatientsOfDoctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable SelectSurgNames()
        {
            String StoredProcedureName = StoredProcedures.SelectSurgNames;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
        public DataTable SelectSurgNamesInOperate(int Patid, int DrID)
        {
            String StoredProcedureName = StoredProcedures.SurgInOperate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatID", Patid);
            Parameters.Add("@DRID", DrID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetDoctorPrice(int DrID)
        {
            String StoredProcedureName = StoredProcedures.GetDoctorPrice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", DrID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetMedTestsForPatient(int PID, int DrID)
        {
            String StoredProcedureName = StoredProcedures.GetMedTestsForPatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@pid", PID);
            Parameters.Add("@Did", DrID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetSurgeriesForPatient(int PID, int DrID)
        {
            String StoredProcedureName = StoredProcedures.GetSurgeriesForPatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@pid", PID);
            Parameters.Add("@Did", DrID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable SelectUpcommingSurgDates(int Patid, int DrID, string SurgID)
        {
            String StoredProcedureName = StoredProcedures.SelectUpcommingSurgDates;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatID", Patid);
            Parameters.Add("@DRID", DrID);
            Parameters.Add("@SurgName", SurgID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int ReserveSurgery(int Patid, int DrID, string SurgID, string date)
        {
            String StoredProcedureName = StoredProcedures.ReserveSurgery;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatID", Patid);
            Parameters.Add("@DRID", DrID);
            Parameters.Add("@SurgName", SurgID);
            Parameters.Add("@date", date);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int SetDrWorkingHours(string username, string start, string end)
        {
            String StoredProcedureName = StoredProcedures.SetDrWorkingHours;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@start", start);
            Parameters.Add("@end", end);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int SetAppointmentPrice(string username, int price)
        {
            String StoredProcedureName = StoredProcedures.SetAppointmentPrice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@user", username);
            Parameters.Add("@p", price);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int PrescribeMedicine(int pid, int Did, string date, string time, string med)
        {
            String StoredProcedureName = StoredProcedures.PrescribeMedicine;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Pid", pid);
            Parameters.Add("@Did", Did);
            Parameters.Add("@date", date);
            Parameters.Add("@time", time);
            Parameters.Add("@med", med);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int PrescribeMedicalTest(int pid, int Did, string date, string time, string medTest)
        {
            String StoredProcedureName = StoredProcedures.PrescribeMedicalTest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Pid", pid);
            Parameters.Add("@Did", Did);
            Parameters.Add("@date", date);
            Parameters.Add("@time", time);
            Parameters.Add("@medTest", medTest);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int MakeMedicalTest(int pid, int Did, string medTest, string date, string result)
        {
            String StoredProcedureName = StoredProcedures.MakeMedicalTest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Pid", pid);
            Parameters.Add("@Did", Did);
            Parameters.Add("@testname", medTest);
            Parameters.Add("@date", date);
            Parameters.Add("@result", result);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetAppointTimeToday(int drid, int patid)
        {
            String StoredProcedureName = StoredProcedures.GetAppointTimeToday;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@drid", drid);
            Parameters.Add("@patid", patid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetMedicinesForPatient(int drid, int patid)
        {
            String StoredProcedureName = StoredProcedures.GetMedicinesForPatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Did", drid);
            Parameters.Add("@Pid", patid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetAppointPatientsToday(int drid)
        {
            String StoredProcedureName = StoredProcedures.GetAppointPatientsToday;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@drid", drid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetDrIDByUsername(string user)
        {
            String StoredProcedureName = StoredProcedures.GetDrIDByUsername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@user", user);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetWorkingHours(int ID)
        {
            String StoredProcedureName = StoredProcedures.GetWorkingHours;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Did", ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int CancelSurgery(int Patid, int DrID, string SurgID, string date)
        {
            String StoredProcedureName = StoredProcedures.CancelSurgery;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatID", Patid);
            Parameters.Add("@DRID", DrID);
            Parameters.Add("@SurgName", SurgID);
            Parameters.Add("@date", date);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SelectNurseIDs()
        {
            String StoredProcedureName = StoredProcedures.GetNurseIDs;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetMedTestNames()
        {
            String StoredProcedureName = StoredProcedures.GetMedTestsNames;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetRoomsWithNoNurses()
        {
            String StoredProcedureName = StoredProcedures.GetRoomsWithNoNurses;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetNursesWithNoRooms()
        {
            String StoredProcedureName = StoredProcedures.GetNursesWithNoRooms;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetNursesWithRooms()
        {
            String StoredProcedureName = StoredProcedures.GetNursesWithRooms;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetRoomsWithNurses()
        {
            String StoredProcedureName = StoredProcedures.GetRoomsWithNurses;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetAllRooms()
        {
            String StoredProcedureName = StoredProcedures.GetAllRooms;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetRoomsWithPatient()
        {
            String StoredProcedureName = StoredProcedures.GetRoomsWithPatient;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetRoomOfANurse(int Nid)
        {
            String StoredProcedureName = StoredProcedures.GetRoomOfANurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@nID", Nid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int AssignNurseToRoom(int Nid, int RID)
        {
            String StoredProcedureName = StoredProcedures.AssignNurseToRoom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", Nid);
            Parameters.Add("@RID", RID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int RemoveNursefromRoom(int Nid)
        {
            String StoredProcedureName = StoredProcedures.RemoveNursefromRoom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", Nid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable DisplayNurseRoomsData()
        {
            String StoredProcedureName = StoredProcedures.DisplayNurseRoomsData;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //-------------------------- ----Receptionist------------------------
        public int InsertPatient(int patient_id, string Fname, char Minit, string Lname,
                                string Bdate, string address, int phone_number, string gender)
        {
            string StoredProcedureName = StoredProcedures.InsertPatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", patient_id);
            Parameters.Add("@fname", Fname);
            Parameters.Add("@minit", Minit);
            Parameters.Add("@lname", Lname);
            Parameters.Add("@Bdate", Bdate);
            Parameters.Add("@address", address);
            Parameters.Add("@phone_number", phone_number);
            Parameters.Add("@gender", gender[0]);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int isPatientExist(int patient_id)
        {
            string StoredProcedureName = StoredProcedures.isPatientExist;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Pid", patient_id);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public DataTable SelectPatientsID_name()
        {
            String StoredProcedureName = StoredProcedures.SelectPatientsID_name;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
        public DataTable SelectDocID_name(int dno)
        {
            String StoredProcedureName = StoredProcedures.SelectDocID_name;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@dno", dno);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable SelectDoc_srt_end(int id)
        {
            String StoredProcedureName = StoredProcedures.SelectDoc_srt_end;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Doctor_ID", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int appReserved(int docID, string date, string time)
        {
            String StoredProcedureName = StoredProcedures.appReserved;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Doctor_ID", docID);
            Parameters.Add("@Date", date);
            Parameters.Add("@Time", time);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public DataTable AppDate(int Drid, int Pid)
        {
            String StoredProcedureName = StoredProcedures.AppDate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Doctor_ID", Drid);
            Parameters.Add("@Patient_ID", Pid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int updateApp(int Drid, int Pid,string time,string oldDate,string newDate)
        {
            String StoredProcedureName = StoredProcedures.updateApp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Doctor_ID", Drid);
            Parameters.Add("@Patient_ID", Pid);
            Parameters.Add("@Time", time);
            Parameters.Add("@oldDate", oldDate);
            Parameters.Add("@newDate", newDate);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable AppTime(int Drid, int Pid,string date)
        {
            String StoredProcedureName = StoredProcedures.AppTime;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Doctor_ID", Drid);
            Parameters.Add("@Patient_ID", Pid);
            Parameters.Add("@Date", date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int updateAppTime(int Drid, int Pid, string Date, string oldTime,string newTime)
        {
            String StoredProcedureName = StoredProcedures.updateAppTime;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Doctor_ID", Drid);
            Parameters.Add("@Patient_ID", Pid);
            Parameters.Add("@Date", Date);
            Parameters.Add("@oldTime", oldTime);
            Parameters.Add("@newTime", newTime);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int DeleteApp(int Drid, int Pid, string date,string time)
        {
            String StoredProcedureName = StoredProcedures.DeleteApp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Patient_ID", Pid);
            Parameters.Add("@Doctor_ID", Drid);
            Parameters.Add("@Date", date);
            Parameters.Add("@Time", time);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertApp(int Drid, int Pid, string date, string time)
        {
            String StoredProcedureName = StoredProcedures.InsertApp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Doctor_ID", Drid);
            Parameters.Add("@Patient_ID", Pid);
            Parameters.Add("@Date", date);
            Parameters.Add("@Time", time);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable PatientsHasNoRoom(string date)
        {
            String StoredProcedureName = StoredProcedures.PatientsHasNoRoom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date", date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable getDepartmentData()
        {
            string StoredProcedureName = StoredProcedures.getDepartmentData;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable Avail_Rooms(int dnum, string date)
        {
            string StoredProcedureName = StoredProcedures.Avail_Rooms;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@dnum", dnum);
            Parameters.Add("@date", date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int ReserveRoom(int pat_id, int Rno, string date, int nights)
        {
            string StoredProcedureName = StoredProcedures.ReserveRoom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@pat_id", pat_id);
            Parameters.Add("@room_no", Rno);
            Parameters.Add("@date", date);
            Parameters.Add("@nights_spent", nights);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int AddAppointment(int Pid,int docID, string date,string time)
        {
            String StoredProcedureName = StoredProcedures.AddAppointment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Pid", Pid);
            Parameters.Add("@Doctor_ID", docID);
            Parameters.Add("@Date", date);
            Parameters.Add("@Time", time);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable MedicalTestBill(int Pid,string date)
        {
            String StoredProcedureName = StoredProcedures.MedicalTestBill;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@P_id", Pid);
            Parameters.Add("@Date", date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int MedicalTestSum(int Pid, string date)
        {
            String StoredProcedureName = StoredProcedures.MedicalTestSum;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@P_id", Pid);
            Parameters.Add("@Date", date);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public DataTable MedicineBill(int Pid, string date)
        {
            String StoredProcedureName = StoredProcedures.MedicineBill;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatientID", Pid);
            Parameters.Add("@Date", date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int MedicineSum(int Pid, string date)
        {
            String StoredProcedureName = StoredProcedures.MedicineSum;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatientID", Pid);
            Parameters.Add("@Date", date);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public DataTable ReserveBill(int Pid, string date)
        {
            String StoredProcedureName = StoredProcedures.ReserveBill;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@pat_id", Pid);
            Parameters.Add("@date", date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int ReserveSum(int Pid, string date)
        {
            String StoredProcedureName = StoredProcedures.ReserveSum;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@pat_id", Pid);
            Parameters.Add("@date", date);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public DataTable SurgeryBill(int Pid, string date)
        {
            String StoredProcedureName = StoredProcedures.SurgeryBill;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Pid", Pid);
            Parameters.Add("@Date", date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int sumSurgery(int Pid, string date)
        {
            String StoredProcedureName = StoredProcedures.sumSurgery;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Pid", Pid);
            Parameters.Add("@Date", date);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int ValidDateReserve(string date,int nights)
        {
            String StoredProcedureName = StoredProcedures.ValidDateReserve;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Date", date);
            Parameters.Add("@nights", nights);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int VaidAppEdit(string date, string time)
        {
            String StoredProcedureName = StoredProcedures.VaidAppEdit;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Date", date);
            Parameters.Add("@Time", time);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        //-------------------------------Pharmacist--------------------------
        public int InsertMedicine(int MedicineID, string MedicineName,int Price,int Quantity ,string ExpiryDate )
        {
            string StoredProcedureName = StoredProcedures.InsertMedicine;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@MedicineName", MedicineName);
            Parameters.Add("@MedicineExpiryDate", ExpiryDate);
            Parameters.Add("@MedicineQuantity", Quantity);
            Parameters.Add("@MedicinePrice", Price);
            Parameters.Add("@MedicineID", MedicineID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetAllMedicine()
        {
            string StoredProcedureName = StoredProcedures.GetAllMedicine;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public object GetMedPrice (string MedicineName)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@MedicineName", MedicineName);
            string StoredProcedureName = StoredProcedures.GetMedPrice;
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int SetMedPrice(string MedicineName,int UpdatedPrice)
        {
            string StoredProcedureName = StoredProcedures.SetMedPrice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add ("@MedicineName", MedicineName);
            Parameters.Add("@MedicinePrice", UpdatedPrice);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int GetMedID(string MedicineName)
        {
            string StoredProcedureName = StoredProcedures.GetMedID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@MedicineName", MedicineName);
            return int.Parse (dbMan.ExecuteScalar(StoredProcedureName, Parameters).ToString());
        }
        public DataTable GetAllMedicalTest ()
        {
            string StoredProcedureName = StoredProcedures.GetAllMedicalTest;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public object GetMedicalTestPrice(string MedicalTestName)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@MedicalTestName", MedicalTestName);
            string StoredProcedureName = StoredProcedures.GetMedicalTestPrice;
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable GetPatientName()
        {
            String StoredProcedureName = StoredProcedures.GetPatientName;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetAllPatientName()
        {
            String StoredProcedureName = StoredProcedures.GetAllPatientName;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetEmptyMedicines()
        {
            String StoredProcedureName = StoredProcedures.GetEmptyMedicines;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetValid()
        {
            String StoredProcedureName = StoredProcedures.GetValid;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetExpiredMedicines()
        {
            string StoredProcedureName = StoredProcedures.GetExpiredMedicines;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetNurseName()
        {
            string StoredProcedureName = StoredProcedures.GetNurseName;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetNurseIDWithName(string Fullname)
        {
            String StoredProcedureName = StoredProcedures.GetNurseIDWithName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fullname", Fullname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        
        public int InsertServe(int Nurse_ID, int RoomNumber)
        {
            string StoredProcedureName = StoredProcedures.InsertServe;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Nurse_ID", Nurse_ID);
            Parameters.Add("@RoomNumber", RoomNumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DontServe(int Nurse_ID, int RoomNumber)
        {
            String StoredProcedureName = StoredProcedures.DontServe;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Nurse_ID", Nurse_ID);
            Parameters.Add("@RoomNumber", RoomNumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetRooms()
        {
            String StoredProcedureName = StoredProcedures.GetRooms;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetPatientIDWithName(string Fullname)
        {
            String StoredProcedureName = StoredProcedures.GetPatientIDWithName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fullname", Fullname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int AddMedicineToPatient(int MedID,int Pid,int Quantity)
        {
            string StoredProcedureName = StoredProcedures.AddMedicineToPatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@MedID", MedID);
            Parameters.Add("@Pid", Pid);
            Parameters.Add("@Quantity", Quantity);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int BuyMedicine(string MedName, int Amount)
        {
            string StoredProcedureName = StoredProcedures.BuyMedicine;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@MedName", MedName);
            Parameters.Add("@Amount", Amount);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
    }

}

