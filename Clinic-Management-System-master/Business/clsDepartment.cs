using System;
using System.Data;
using System.Threading.Tasks;
using ClinicManagementDB_DataAccess;

namespace ClinicManagementDB_Business
{
    public class clsDepartment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public byte? DepartmentID { set; get; }
        public string DepartmentName { set; get; }
        public string DepartmentDescription { set; get; }
        public string DepartmentLocation { set; get; }

        public clsDepartment()
        {
            this.DepartmentID = null;
            this.DepartmentName = "";
            this.DepartmentDescription = null;
            this.DepartmentLocation = null;
            Mode = enMode.AddNew;
        }
        private clsDepartment(byte? DepartmentID, string DepartmentName, string DepartmentDescription, string DepartmentLocation)
        {
            this.DepartmentID = DepartmentID;
            this.DepartmentName = DepartmentName;
            this.DepartmentDescription = DepartmentDescription;
            this.DepartmentLocation = DepartmentLocation;
            Mode = enMode.Update;
        }
        private bool _AddNewDepartment()
        {
            this.DepartmentID = (byte?)clsDepartmentData.AddNewDepartment(this.DepartmentName, this.DepartmentDescription, this.DepartmentLocation);
            return (this.DepartmentID != -1);
        }
        private bool _UpdateDepartment()
        {
            return clsDepartmentData.UpdateDepartment(this.DepartmentID, this.DepartmentName, this.DepartmentDescription, this.DepartmentLocation);
        }
        public static clsDepartment Find(byte? DepartmentID)
        {
            string DepartmentName = "";
            string DepartmentDescription = null;
            string DepartmentLocation = null;

            bool IsFound = clsDepartmentData.GetDepartmentByID(DepartmentID, ref DepartmentName, ref DepartmentDescription, ref DepartmentLocation);

            if(IsFound)
                return new clsDepartment(DepartmentID, DepartmentName, DepartmentDescription, DepartmentLocation);
            else
                return null;
        }
        public static clsDepartment Find(string DepartmentName)
        {
            byte? DepartmentID = null;
            string DepartmentDescription = null;
            string DepartmentLocation = null;

            bool IsFound = clsDepartmentData.GetDepartmentByDepartmentName(ref DepartmentID, DepartmentName, ref DepartmentDescription, ref DepartmentLocation);

            if(IsFound)
                return new clsDepartment(DepartmentID, DepartmentName, DepartmentDescription, DepartmentLocation);
            else
                return null;
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewDepartment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateDepartment();
            }
            return false;
        }
        public static bool DeleteDepartment(byte? DepartmentID)
            => clsDepartmentData.DeleteDepartment(DepartmentID);
        public static bool DoesDepartmentExist(byte? DepartmentID)
            => clsDepartmentData.DoesDepartmentExist(DepartmentID);
        public async static Task<short> TotalDoctorsByDepartmentIDAsync(byte? DepartmentID)
            => await clsDepartmentData.TotalDoctorsByDepartmentIDAsync(DepartmentID);
        public async static Task<int> TotalVisitsByDepartmentIDAsync(byte? DepartmentID)
            => await clsDepartmentData.TotalVisitsByDepartmentIDAsync(DepartmentID);
        public async static Task<decimal> TotalRevenueByDepartmentIDAsync(byte? DepartmentID)
            => await clsDepartmentData.TotalRevenueByDepartmentIDAsync(DepartmentID);
        public static DataTable GetDepartments()
            => clsDepartmentData.GetAllDepartments();
        public async static Task<int> GetTotalDepartmentsAsync() 
            => await clsDepartmentData.GetTotalDepartmentsAsync();
    }
}
