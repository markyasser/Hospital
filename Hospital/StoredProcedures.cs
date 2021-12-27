using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class StoredProcedures
    {
        //----------------------------Accounts------------------------------
        public static string CreateAccount = "CreateAccount";
        public static string AccountExcist = "AccountExcist";
        public static string IsDoctor = "IsDoctor";
        public static string IsNurse = "IsNurse";
        public static string IsPharma = "IsPharma";
        public static string IsRecept = "IsRecept";

        //-----------------------------Admin--------------------------------
        //Sign Up 
        public static string InsertDoctor = "InsertDoctor";
        public static string InsertReceptionist = "InsertRecepiontist";
        public static string InsertNurse = "InsertNurse";
        public static string InsertPharmacist = "InsertPharmacist";
        //Department
        public static string InsertDepartment = "InsertDepartment";
        public static string DeleteDepartment = "DeleteDepartment";
        public static string GetAllDepartmentNumber = "GetAllDepartmentNumber";
        //surgeries
        public static string InsertSurgery = "InsertSurgery";
        //Medical Tests
        public static string InsertMedicalTest = "InsertMedicalTest";
        //Show Employees
        public static string GetAllDep_Doctors = "GetAllDep_Doctors";
        public static string GetAllDoctors = "GetAllDoctors";
        public static string GetAllNurses = "GetAllNurses";
        public static string GetAllPharma = "GetAllPharma";
        public static string GetAllRecept = "GetAllRecept";

        //-----------------------------Doctor--------------------------------
        public static string SelectPatientWithID = "SelectPatientWithID";
        public static string SelectPatientsID = "SelectPatientsID";
        public static string SelectSurgNames = "SelectSurgNames";
        public static string SurgInOperate = "SurgInOperate";
        public static string SelectUpcommingSurgDates = "SelectSurgDates";
        public static string ReserveSurgery = "ReserveSurgery";
        
        public static string CancelSurgery = "CancelSurgery";

    }
}
