using System;
using System.Data;
using ClinicManagementDB_DataAccess;

namespace ClinicManagementDB_Business
{
    public class clsCountry
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public byte? CountryID { set; get; }
        public string CountryName { set; get; }

        public clsCountry()
        {
            this.CountryID = null;
            this.CountryName = "";
            Mode = enMode.AddNew;
        }
        private clsCountry(byte? CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            Mode = enMode.Update;
        }
        private bool _AddNewCountry()
        {
            this.CountryID = (byte?)clsCountryData.AddNewCountry(this.CountryName);
            return (this.CountryID != -1);
        }
        private bool _UpdateCountry()
        {
            return clsCountryData.UpdateCountry(this.CountryID, this.CountryName);
        }
        public static clsCountry Find(byte? CountryID)
        {
            string CountryName = "";

            bool IsFound = clsCountryData.GetCountryByID(CountryID, ref CountryName);

            if(IsFound)
                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }
        public static clsCountry Find(string CountryName)
        {
            byte? CountryID = null;

            bool IsFound = clsCountryData.GetCountryByName(ref CountryID, CountryName);

            if(IsFound)
                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateCountry();
            }
            return false;
        }
        public static bool DeleteCountry(byte? CountryID)
        => clsCountryData.DeleteCountry(CountryID);
        public static bool DoesCountryExist(byte? CountryID)
        => clsCountryData.DoesCountryExist(CountryID);
        public static DataTable GetCountries()
        => clsCountryData.GetAllCountries();
    }
}
