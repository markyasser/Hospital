using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class StoredProcedures
    {
        public static string RetrieveProject = "selectProjectsofDeptLoc";
        public static string SelectAllEmployees = "getAllEmps";

        public static string CreateAccount = "CreateAccount";
        public static string AccountExcist = "AccountExcist";
        public static string IsDoctor = "IsDoctor";
        public static string IsNurse = "IsNurse";
        public static string IsPharma = "IsPharma";
        public static string IsRecept = "IsRecept";

        public static string InsertDoctor = "InsertDoctor";
        public static string InsertReceptionist = "InsertRecepiontist";
        public static string InsertNurse = "InsertNurse";
        public static string InsertPharmacist = "InsertPharmacist";
        public static string InsertDepartment = "InsertDepartment";
        public static string DeleteDepartment = "DeleteDepartment";
        public static string GetAllDepartmentNumber = "GetAllDepartmentNumber";

        public static string SelectDepartmentNum = "selectDepartmentNum";
        public static string SelectDepartmentLocation = "selectDepartmentLocation";

    }
}
