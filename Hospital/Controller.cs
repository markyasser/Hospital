using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hospital
{
    class Controller
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
            Parameters.Add("@password", passwrod);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }   
        public int InsertDoctor(int Doctor_id,string Fname,string Minit,string Lname,
                                string d_username, string Bdate,string address,int phoneNumber, char Gender,int DNO)
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
            string StoredProcedureName="";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            if (position=="Nurse")
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
        public int InsertSurgery( string Surgery_Name, int surg_price)
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
        public DataTable GetAllEmployees(string position, string specialization)
        {
            string StoredProcedureName = "";
            if (position == "Doctor")
            {  
                
                if (specialization != "")
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
        //-------------------------------Pharmacist--------------------------
    }

}

