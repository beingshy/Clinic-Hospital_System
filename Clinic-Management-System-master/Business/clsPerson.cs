using System;
using System.Data;
using ClinicManagementDB_DataAccess;

namespace ClinicManagementDB_Business
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? PersonID { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string NationalID { set; get; }
        public DateTime BirthDate { set; get; }
        public bool Gender { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public byte CountryID { set; get; }
        public short CreatedByUserID { set; get; }
        public DateTime CreatedAt { get; set; }
        public short? UpdatedByUserID { set; get; }
        public DateTime? UpdatedAt { set; get; }
        public string FullName
        {
            get
            {
                string FullName = "";
                FullName = FirstName + " ";
                FullName += SecondName + " ";
                if(ThirdName != null)
                    FullName += ThirdName + " ";
                FullName += LastName + " ";
                return FullName;
            }
        }
        public string PartialFullName
        {
            get
            {
                string PartialFullName = $"{FirstName} {SecondName} {LastName}";
                return PartialFullName;
            }
        }

        public string CountryName
            => clsCountry.Find(this.CountryID).CountryName ?? string.Empty;
        public string StringGender
        {
            get
            {
                if(this.Gender == false)
                    return "Male";
                else
                    return "Female";
            }
        }
        public bool HasUser
        {
            get => clsPersonData.DoesPersonHasUser(this.PersonID);
        }
        public clsPerson()
        {
            this.PersonID = null;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = null;
            this.LastName = "";
            this.NationalID = "";
            this.BirthDate = DateTime.Now;
            this.Gender = false;
            this.Address = null;
            this.Phone = "";
            this.Email = "";
            this.CountryID = 0;
            this.CreatedByUserID = -1;
            this.CreatedAt = DateTime.Now;
            this.UpdatedByUserID = null;
            this.UpdatedAt = null;
            Mode = enMode.AddNew;
        }
        private clsPerson(int? PersonID, string FirstName, string SecondName, string ThirdName, string LastName, string NationalID, DateTime BirthDate, bool Gender, string Address, string Phone, string Email, byte CountryID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalID = NationalID;
            this.BirthDate = BirthDate;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.CountryID = CountryID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedAt = CreatedAt;
            this.UpdatedByUserID = UpdatedByUserID;
            this.UpdatedAt = UpdatedAt;
            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = (int?)clsPersonData.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalID, this.BirthDate, this.Gender, this.Address, this.Phone, this.Email, this.CountryID, this.CreatedByUserID, this.CreatedAt, this.UpdatedByUserID, this.UpdatedAt);
            return (this.PersonID != -1);
        }
        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalID, this.BirthDate, this.Gender, this.Address, this.Phone, this.Email, this.CountryID, this.CreatedByUserID, this.CreatedAt, this.UpdatedByUserID, this.UpdatedAt);
        }
        public static clsPerson Find(int? PersonID)
        {
            string FirstName = "";
            string SecondName = "";
            string ThirdName = null;
            string LastName = "";
            string NationalID = "";
            DateTime BirthDate = DateTime.Now;
            bool Gender = false;
            string Address = null;
            string Phone = "";
            string Email = "";
            byte CountryID = 0;
            short CreatedByUserID = -1;
            DateTime CreatedAt = DateTime.Now;
            short? UpdatedByUserID = null;
            DateTime? UpdatedAt = null;

            bool IsFound = clsPersonData.GetPersonByID(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref NationalID, ref BirthDate, ref Gender, ref Address, ref Phone, ref Email, ref CountryID, ref CreatedByUserID, ref CreatedAt, ref UpdatedByUserID, ref UpdatedAt);

            if(IsFound)
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalID, BirthDate, Gender, Address, Phone, Email, CountryID, CreatedByUserID, CreatedAt, UpdatedByUserID, UpdatedAt);
            else
                return null;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePerson();
            }
            return false;
        }
        public static bool DeletePerson(int? PersonID)
            => clsPersonData.DeletePerson(PersonID);
        public static bool DoesPersonExist(int? PersonID)
            => clsPersonData.DoesPersonExist(PersonID);

        public static DataTable GetPeople(short PageNumber, int PageSize, ref int Records)
        => clsPersonData.GetAllPeople(PageNumber, PageSize, ref Records);
        public static DataTable GetPersonWithPersonID(int PersonID)
            => clsPersonData.GetPersonWithPersonID(PersonID);
        public static DataTable GetPersonWithNationalID(string NationalID)
            => clsPersonData.GetPersonWithNationalID(NationalID);
        public static DataTable GetPeopleWithName(short PageNumber, int PageSize, ref int Records, string Name)
            => clsPersonData.GetPeopleWithName(PageNumber, PageSize, ref Records, Name);
    
    
    }
}
