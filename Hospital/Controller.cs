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
        
        public DataTable GetAllDepartmentNumber()
        {
            string StoredProcedureName = StoredProcedures.GetAllDepartmentNumber;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable SelectDepNum()
        {
            string StoredProcedureName = StoredProcedures.SelectDepartmentNum;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
        public DataTable SelectDepLoc()
        {
            String StoredProcedureName = StoredProcedures.SelectDepartmentLocation;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable SelectProject(string location)
        {
            String StoredProcedureName = StoredProcedures.RetrieveProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@location", location);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
    }
}

