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
        public DataTable SelectAllEmp()
        {

            string StoredProcedureName = StoredProcedures.SelectAllEmployees;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public int CreateAccount(string username, string passwrod)
        {
            string StoredProcedureName = StoredProcedures.CreateAccount;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@passwrod", passwrod);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }   
        public int InsertDoctor(int Doctor_id,string Fname,string Minit,string Lname,
                                string d_username,DateTime Bdate,string address,int phoneNumber, char Gender,int DNO)
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
        public int InsertDepartment(int Dnumber, string specialization)
        {

            string StoredProcedureName = StoredProcedures.InsertDepartment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dnumber", Dnumber);
            Parameters.Add("@specialization", specialization);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
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

