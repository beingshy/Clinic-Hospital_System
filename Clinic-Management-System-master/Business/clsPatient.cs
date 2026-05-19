using System;
using System.Data;
using System.Threading.Tasks;
using ClinicManagementDB_DataAccess;

namespace ClinicManagementDB_Business
{
    public class clsPatient : clsPerson
    {
        public new enum enMode { AddNew = 0, Update = 1 };
        public new enMode Mode = enMode.AddNew;
        public int? PatientID { set; get; }
        public string BloodType { set; get; }
        public string Allergies { set; get; }
        public string MedicalHistory { set; get; }
        public string EmergencyContactName { set; get; }
        public string EmergencyContactPhone { set; get; }
        public new short CreatedByUserID { set; get; }
        public new DateTime CreatedAt { set; get; }
        public new short? UpdatedByUserID { set; get; }
        public new DateTime? UpdatedAt { set; get; }

        public clsPatient()
        {
            this.PatientID = null;
            this.PersonID = -1;
            this.BloodType = null;
            this.Allergies = null;
            this.MedicalHistory = null;
            this.EmergencyContactName = null;
            this.EmergencyContactPhone = null;
            this.CreatedByUserID = -1;
            this.CreatedAt = DateTime.Now;
            this.UpdatedByUserID = null;
            this.UpdatedAt = null;
            Mode = enMode.AddNew;
        }
        private clsPatient(int? PatientID, string BloodType, string Allergies, string MedicalHistory,
            string EmergencyContactName, string EmergencyContactPhone, short PatientCreatedByUserID,
            DateTime PatientCreatedAt, short? PatientUpdatedByUserID, DateTime? PatientUpdatedAt,
            int? PersonID, string FirstName, string SecondName, string ThirdName, string LastName,
            string NationalID, DateTime BirthDate, bool Gender, string Address, string Phone, string Email,
            byte CountryID, short PersonCreatedByUserID, DateTime PersonCreatedAt, short? PersonUpdatedByUserID,
            DateTime? PersonUpdatedAt)
        {
            this.PatientID = PatientID;
            this.BloodType = BloodType;
            this.Allergies = Allergies;
            this.MedicalHistory = MedicalHistory;
            this.EmergencyContactName = EmergencyContactName;
            this.EmergencyContactPhone = EmergencyContactPhone;
            this.CreatedByUserID = PatientCreatedByUserID;
            this.CreatedAt = PatientCreatedAt;
            this.UpdatedByUserID = PatientUpdatedByUserID;
            this.UpdatedAt = PatientUpdatedAt;

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
        private bool _AddNewPatient()
        {
            this.PatientID = (int?)clsPatientData.AddNewPatient((int)base.PersonID, this.BloodType, this.Allergies, this.MedicalHistory, this.EmergencyContactName, this.EmergencyContactPhone, this.CreatedByUserID, this.CreatedAt, this.UpdatedByUserID, this.UpdatedAt);
            return (this.PatientID != -1);
        }
        private bool _UpdatePatient()
            => clsPatientData.UpdatePatient(this.PatientID, (int)base.PersonID, this.BloodType, this.Allergies, this.MedicalHistory, this.EmergencyContactName, this.EmergencyContactPhone, this.CreatedByUserID, this.CreatedAt, this.UpdatedByUserID, this.UpdatedAt);
        public static new clsPatient Find(int? PatientID)
        {
            int PersonID = -1;
            string BloodType = null;
            string Allergies = null;
            string MedicalHistory = null;
            string EmergencyContactName = null;
            string EmergencyContactPhone = null;
            short CreatedByUserID = -1;
            DateTime CreatedAt = DateTime.Now;
            short? UpdatedByUserID = null;
            DateTime? UpdatedAt = null;

            bool IsFound = clsPatientData.GetPatientByID(PatientID, ref PersonID, ref BloodType, ref Allergies, ref MedicalHistory, ref EmergencyContactName, ref EmergencyContactPhone, ref CreatedByUserID, ref CreatedAt, ref UpdatedByUserID, ref UpdatedAt);

            if(IsFound)
            {
                clsPerson clsPerson = clsPerson.Find(PersonID);

                return new clsPatient(PatientID, BloodType, Allergies, MedicalHistory, EmergencyContactName,
                    EmergencyContactPhone, CreatedByUserID, CreatedAt, UpdatedByUserID, UpdatedAt,
                    clsPerson.PersonID, clsPerson.FirstName, clsPerson.SecondName, clsPerson.ThirdName,
                    clsPerson.LastName, clsPerson.NationalID, clsPerson.BirthDate, clsPerson.Gender,
                    clsPerson.Address, clsPerson.Phone, clsPerson.Email, clsPerson.CountryID,
                    clsPerson.CreatedByUserID, clsPerson.CreatedAt, clsPerson.UpdatedByUserID,
                    clsPerson.UpdatedAt);
            }
            else
                return null;
        }
        public new bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPatient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePatient();
            }
            return false;
        }
        public static bool DeletePatient(int? PatientID)
            => clsPatientData.DeletePatient(PatientID);
        public static bool DoesPatientExist(int? PatientID)
            => clsPatientData.DoesPatientExist(PatientID);
        public static bool DoesPatientExistByPersonID(int PersonID)
            => clsPatientData.DoesPatientExistByPersonID(PersonID);
        public static DataTable GetAllPatients(short PageNumber, int PageSize, ref int Records)
            => clsPatientData.GetAllPatients(PageNumber, PageSize, ref Records);
        public static DataTable GetPatientWithPatientID(int PatientID)
            => clsPatientData.GetPatientWithPatientID(PatientID);
        public static DataTable GetPatientWithPersonID(int PersonID)
            => clsPatientData.GetPatientWithPersonID(PersonID);
        public static DataTable GetPatientWithNationalID(string NationalID)
           => clsPatientData.GetPatientWithNationalID(NationalID);
        public static DataTable GetPatientWithName(short PageNumber, int PageSize, ref int Records, string Name)
            => clsPatientData.GetPatientWithName(PageNumber, PageSize, ref Records, Name);
        public static async Task<int> GetTotalPatientsAsync()
            => await clsPatientData.GetTotalPatientsAsync();

        public static async Task<int> GetAveragePatientAgeAsync()
            => await clsPatientData.GetAveragePatientAgeAsync();

        public static async Task<int> GetNewPatientsThisWeekAsync()
            => await clsPatientData.GetNewPatientsThisWeekAsync();


    }
}