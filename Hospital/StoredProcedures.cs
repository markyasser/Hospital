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
        public static string DeleteAccount = "DeleteAccount";
        public static string IsDoctor = "IsDoctor";
        public static string IsNurse = "IsNurse";
        public static string IsPharma = "IsPharma";
        public static string IsRecept = "IsRecept";
        public static string ChangePassword = "ChangePassword";
        public static string GetOldPassword = "GetOldPassword";
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
        public static string DepartmentStatistics = "DepartmentStatistics";
        public static string GetDepartmentNumberBySpt = "GetDepartmentNumberBySpt";
        //surgeries
        public static string InsertSurgery = "InsertSurgery";
        public static string DeleteSurgery = "DeleteSurgery";
        public static string GetAllSurgeries = "GetAllSurgeries";
        //Medical Tests
        public static string InsertMedicalTest = "InsertMedicalTest";
        public static string DeleteMedicalTest = "DeleteMedicalTest";
        //Rooms
        public static string InsertRooms = "InsertRooms";
        public static string GetAllRoomsInfo = "GetAllRoomsInfo";
        //public static string GetAllMedicalTest = "GetAllMedicalTest";
        //Show Employees
        public static string GetAllDep_Doctors = "GetAllDep_Doctors";
        public static string GetAllDoctors = "GetAllDoctors";
        public static string GetAllNurses = "GetAllNurses";
        public static string GetAllPharma = "GetAllPharma";
        public static string GetAllRecept = "GetAllRecept";
        //delete Employees
        public static string DeleteDoctor = "DeleteDoctor";
        public static string DeletePharma = "DeletePharma";
        public static string DeleteNurse = "DeleteNurse";
        public static string DeleteRecept = "DeleteRecept";

        public static string GetDNames = "GetDnames";
        public static string GetNNames = "GetNnames";
        public static string GetPNames = "GetPnames";
        public static string GetRNames = "GetRnames";

        public static string GetDoctorByName = "GetDoctorByName";
        public static string GetNurseByName = "GetNurseByName";
        public static string GetReceptionistByName = "GetReceptionistByName";
        public static string GetPharmaByName = "GetPharmaByName";
        //EARNINGS
        public static string EarningsMedicines = "EarningsMedicines";
        public static string EarningsMedicalTests = "EarningsMedicalTests";
        public static string EarningsRooms = "EarningsRooms";
        public static string EarningsOperations = "EarningsOperations";
        public static string EarningsAppointments = "EarningsAppointments";
        //-----------------------------Doctor--------------------------------
        public static string SelectPatientWithID = "SelectPatientWithID";
        public static string SelectPatientsID = "SelectPatientsID";
        public static string SelectSurgNames = "SelectSurgNames";
        public static string SurgInOperate = "SurgInOperate";
        public static string SelectUpcommingSurgDates = "SelectSurgDates";
        public static string ReserveSurgery = "ReserveSurgery";
        
        public static string CancelSurgery = "CancelSurgery";
        public static string GetNurseIDs = "GetNurseIDs";
        public static string GetRoomsWithNoNurses = "GetRoomsWithNoNurses";
        public static string GetNursesWithNoRooms = "SelectNurseIDsWithNoRooms";
        public static string GetNursesWithRooms = "SelectNurseIDsWithRooms";
        public static string GetRoomsWithNurses = "GetRoomsWithNurses";
        public static string GetRoomOfANurse = "GetRoomOfANurse";
        public static string AssignNurseToRoom = "AssignNurseToRoom";
        public static string RemoveNursefromRoom = "RemoveNursefromRoom";
        public static string GetAllRooms = "GetAllRooms";
        
        public static string DisplayNurseRoomsData = "DisplayNurseRoomsData";
        public static string SetDrWorkingHours = "SetDrWorkingHours";
        public static string SetAppointmentPrice = "SetAppointmentPrice";
        public static string GetAppointTimeToday = "GetAppointTimeToday";
        public static string GetAppointPatientsToday = "GetAppointPatientsToday";
        public static string PrescribeMedicine = "PrescribeMedicine";
        public static string GetMedicinesForPatient = "GetMedicinesForPatient";
        public static string PrescribeMedicalTest = "PrescribeMedicalTest";
        public static string MakeMedicalTest = "MakeMedicalTest";
        public static string GetMedTestsNames = "GetMedTestsNames";
        public static string GetDrIDByUsername = "GetDrIDByUsername";
        public static string GetWorkingHours = "GetWorkingHours";
        public static string GetRoomsWithPatient = "GetRoomsWithPatient";
        public static string GetDoctorPrice = "GetDoctorPrice";
        public static string GetMedTestsForPatient = "GetMedTestsForPatient";
        public static string GetSurgeriesForPatient = "GetSurgeriesForPatient";
        public static string SelectPatientsOfDoctor = "SelectPatientsOfDoctor";


        //--------------------------------Receptionist-----------------------------------
        public static string InsertPatient = "InsertPatient";
        //--------------------------------Pharmacist-------------------------------------
        public static string InsertMedicine = "InsertMedicine";
        public static string GetAllMedicine = "GetAllMedicine";
        public static string GetMedPrice = "GetMedPrice";
        public static string SetMedPrice = "SetMedPrice";
        //-----------------------------------Nurse--------------------------------------
        public static string GetAllMedicalTest = "GetAllMedicalTest";
        public static string GetMedicalTestPrice = "GetMedicalTestPrice";
        public static string GetExpiredMedicines = "GetExpiredMedicines";
        public static string GetValidMedicines = "GetValidMedicines";
        public static string GetEmptyMedicines = "GetEmptyMedicines";
        public static string GetNurseName = "GetNurseName";
        public static string GetNurseID = "GetNurseID";
        public static string GetRooms = "GetRooms";
        public static string InsertServe = "InsertServe";
        public static string DontServe = "DontServe";
        public static string GetPatientName = "GetPatientName";
        public static string AddMedicineToPatient = "AddMedicineToPatient";
    }
}
