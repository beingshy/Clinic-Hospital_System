using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using ClinicManagementDB_DataAccess;

namespace ClinicManagementDB_Business
{
    public class clsDoctor : clsPerson
    {
        public new enum enMode { AddNew = 0, Update = 1 };
        public new enMode Mode = enMode.AddNew;
        public short? DoctorID { set; get; }
        public byte DepartmentID { set; get; }
        public clsDepartment Department { set; get; }
        public string LicenseNumber { set; get; }
        public string Specialization { set; get; }
        public byte YearsOfExperience { set; get; }
        public DateTime HireDate { set; get; }
        public DateTime? EndDate { set; get; }
        public byte DoctorStatus { set; get; }
        public decimal? ConsultationFee { set; get; }
        public short DoctorUserID { set; get; }
        public clsUser DoctorUser { set; get; }
        public new short CreatedByUserID { set; get; }
        public new DateTime CreatedAt { set; get; }
        public new short? UpdatedByUserID { set; get; }
        public new DateTime? UpdatedAt { set; get; }
        public string DoctorStatusString
        {
            get
            {
                switch(this.DoctorStatus)
                {
                    case 1:
                        return "Active";
                    case 2:
                        return "On Leave";
                    case 3:
                        return "Resigned";
                    case 4:
                        return "Retired";
                    case 5:
                        return "Terminated";

                    default:
                        return "Not Known";
                }
            }
        }
        public clsDoctor()
        {
            this.DoctorID = null;
            this.PersonID = -1;
            this.DepartmentID = 0;
            this.LicenseNumber = string.Empty;
            this.Specialization = string.Empty;
            this.YearsOfExperience = 0;
            this.HireDate = DateTime.Now;
            this.EndDate = null;
            this.DoctorStatus = 0;
            this.ConsultationFee = null;
            this.DoctorUserID = -1;
            this.CreatedByUserID = -1;
            this.CreatedAt = DateTime.Now;
            this.UpdatedByUserID = null;
            this.UpdatedAt = null;
            Mode = enMode.AddNew;
        }
        private clsDoctor(short? DoctorID, byte DepartmentID, string LicenseNumber,
            string Specialization, byte YearsOfExperience, DateTime HireDate,
            DateTime? EndDate, byte DoctorStatus, decimal? ConsultationFee,
            short DoctorUserID, short DoctorCreatedByUserID, DateTime DoctorCreatedAt,
            short? DoctorUpdatedByUserID, DateTime? DoctorUpdatedAt, int? PersonID,
            string FirstName, string SecondName, string ThirdName, string LastName,
            string NationalID, DateTime BirthDate, bool Gender, string Address,
            string Phone, string Email, byte CountryID, short PersonCreatedByUserID,
            DateTime PersonCreatedAt, short? PersonUpdatedByUserID, DateTime? PersonUpdatedAt)
        {
            this.DoctorID = DoctorID;
            this.DepartmentID = DepartmentID;
            this.Department = clsDepartment.Find(this.DepartmentID);
            this.LicenseNumber = LicenseNumber;
            this.Specialization = Specialization;
            this.YearsOfExperience = YearsOfExperience;
            this.HireDate = HireDate;
            this.EndDate = EndDate;
            this.DoctorStatus = DoctorStatus;
            this.ConsultationFee = ConsultationFee;
            this.DoctorUserID = DoctorUserID;
            this.DoctorUser = clsUser.Find(this.DoctorUserID);
            this.CreatedByUserID = DoctorCreatedByUserID;
            this.CreatedAt = DoctorCreatedAt;
            this.UpdatedByUserID = DoctorUpdatedByUserID;
            this.UpdatedAt = DoctorUpdatedAt;

            base.PersonID = PersonID;
            base.FirstName = FirstName;
            base.SecondName = SecondName;
            base.ThirdName = ThirdName;
            base.LastName = LastName;
            base.NationalID = NationalID;
            base.BirthDate = BirthDate;
            base.Gender = Gender;
            base.Address = Address;
            base.Phone = Phone;
            base.Email = Email;
            base.CountryID = CountryID;
            base.CreatedByUserID = PersonCreatedByUserID;
            base.CreatedAt = PersonCreatedAt;
            base.UpdatedByUserID = PersonUpdatedByUserID;
            base.UpdatedAt = PersonUpdatedAt;

            Mode = enMode.Update;
        }
        private bool _AddNewDoctor()
        {
            this.DoctorID = (short?)clsDoctorData.AddNewDoctor((int)base.PersonID, this.DepartmentID, this.LicenseNumber, this.Specialization, this.YearsOfExperience, this.HireDate, this.EndDate, this.DoctorStatus, this.ConsultationFee, this.DoctorUserID, this.CreatedByUserID, this.CreatedAt, this.UpdatedByUserID, this.UpdatedAt);
            return (this.DoctorID != -1);
        }
        private bool _UpdateDoctor()
            => clsDoctorData.UpdateDoctor(this.DoctorID, (int)base.PersonID, this.DepartmentID, this.LicenseNumber, this.Specialization, this.YearsOfExperience, this.HireDate, this.EndDate, this.DoctorStatus, this.ConsultationFee, this.DoctorUserID, this.CreatedByUserID, this.CreatedAt, this.UpdatedByUserID, this.UpdatedAt);
        public static clsDoctor Find(short? DoctorID)
        {
            int PersonID = -1;
            byte DepartmentID = 0;
            string LicenseNumber = string.Empty;
            string Specialization = string.Empty;
            byte YearsOfExperience = 0;
            DateTime HireDate = DateTime.Now;
            DateTime? EndDate = null;
            byte DoctorStatus = 0;
            decimal? ConsultationFee = null;
            short DoctorUserID = -1;
            short CreatedByUserID = -1;
            DateTime CreatedAt = DateTime.Now;
            short? UpdatedByUserID = null;
            DateTime? UpdatedAt = null;

            bool IsFound = clsDoctorData.GetDoctorByID(DoctorID, ref PersonID, ref DepartmentID, ref LicenseNumber, ref Specialization, ref YearsOfExperience, ref HireDate, ref EndDate, ref DoctorStatus, ref ConsultationFee, ref DoctorUserID, ref CreatedByUserID, ref CreatedAt, ref UpdatedByUserID, ref UpdatedAt);

            if(IsFound)
            {
                clsPerson Person = clsPerson.Find(PersonID);
                return new clsDoctor(DoctorID, DepartmentID, LicenseNumber, Specialization, YearsOfExperience, HireDate, EndDate, DoctorStatus, ConsultationFee, DoctorUserID, CreatedByUserID, CreatedAt, UpdatedByUserID, UpdatedAt, Person.PersonID, Person.FirstName, Person.SecondName, Person.ThirdName, Person.LastName, Person.NationalID, Person.BirthDate, Person.Gender, Person.Address, Person.Phone, Person.Email, Person.CountryID, Person.CreatedByUserID, Person.CreatedAt, Person.UpdatedByUserID, Person.UpdatedAt);

            }
            else
                return null;
        }
        public new bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewDoctor())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateDoctor();
            }
            return false;
        }
        public static bool DeleteDoctor(short? DoctorID)
            => clsDoctorData.DeleteDoctor(DoctorID);
        public static bool DoesDoctorExistByDoctorID(short? DoctorID)
            => clsDoctorData.DoesDoctorExistByDoctorID(DoctorID);
        public static bool DoesDoctorExistByPersonID(int? PersonID)
            => clsDoctorData.DoesDoctorExistByPersonID(PersonID);
        public static bool DoesUsernameUsedByAnotherDoctor(short? DoctorID, string Username)
            => clsDoctorData.DoesUsernameUsedByAnotherDoctor(DoctorID, Username);
        public static int? GetPersonID(short DoctorID)
            => clsDoctorData.GetDoctorPersonID(DoctorID);
        public static DataTable GetDoctors()
            => clsDoctorData.GetAllDoctors();
        public bool IsDoctorAvailable(DateTime appointmentDate) 
            => clsDoctorData.IsDoctorAvailable(this.DoctorID, appointmentDate);
        public static async Task<decimal> GetAverageConsultationFeeAsync()
            => await clsDoctorData.GetAverageConsultationFeeAsync();

        public static async Task<int> GetTotalAvailableDoctorsAsync()
            => await clsDoctorData.GetTotalAvailableDoctorsAsync();


    }
}
