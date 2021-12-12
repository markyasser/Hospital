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
        public int InsertDoctor(string Fname, string Minit, string Lname, int id, string Bdate, string address, char sex, int phoneNumber, int DNO)
        {
            string query = "INSERT INTO Doctor (Fname, Minit, Lname, id,Bdate,Address,sex,Phone_Number,DNO) " +
                            "Values ('" + Fname + "','" + Minit + "','" + Lname + "'," +
                            id + ",'" + Bdate + "','" + address + "','" + sex + "','" + phoneNumber + "','" +
                            DNO + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertNurse(string Fname, string Minit, string Lname, int id, string Bdate, string address, char sex, int phoneNumber, int DNO)
        {
            string query = "INSERT INTO Doctor (Fname, Minit, Lname, id,Bdate,Address,sex,Phone_Number,DNO) " +
                            "Values ('" + Fname + "','" + Minit + "','" + Lname + "'," +
                            id + ",'" + Bdate + "','" + address + "','" + sex + "','" + phoneNumber + "','" +
                            DNO + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertPharma(string Fname, string Minit, string Lname, int id, string Bdate, string address, char sex, int phoneNumber, int DNO)
        {
            string query = "INSERT INTO Doctor (Fname, Minit, Lname, id,Bdate,Address,sex,Phone_Number,DNO) " +
                            "Values ('" + Fname + "','" + Minit + "','" + Lname + "'," +
                            id + ",'" + Bdate + "','" + address + "','" + sex + "','" + phoneNumber + "','" +
                            DNO + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertReceptionit(string Fname, string Minit, string Lname, int id, string Bdate, string address, char sex, int phoneNumber, int DNO)
        {
            string query = "INSERT INTO Doctor (Fname, Minit, Lname, id,Bdate,Address,sex,Phone_Number,DNO) " +
                            "Values ('" + Fname + "','" + Minit + "','" + Lname + "'," +
                            id + ",'" + Bdate + "','" + address + "','" + sex + "','" + phoneNumber + "','" +
                            DNO + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int AddAccount(string id, string passsword)
        {
            string query = "INSERT INTO Accounts (ID , Password) " +
                            "Values ('" + id + "','" + passsword + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}

