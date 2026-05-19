using System;
using System.Data;
using ClinicManagementDB_DataAccess;

namespace ClinicManagementDB_Business
{
    public class clsLoginHistory
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? LoginHistoryID { set; get; }
        public short UserID { set; get; }
        public DateTime LoginTime { set; get; }
        public DateTime? LogoutTime { set; get; }

        public clsLoginHistory()
        {
            this.LoginHistoryID = null;
            this.UserID = -1;
            this.LoginTime = DateTime.Now;
            this.LogoutTime = null;
            Mode = enMode.AddNew;
        }
        private clsLoginHistory(int? LoginHistoryID, short UserID, DateTime LoginTime, DateTime? LogoutTime)
        {
            this.LoginHistoryID = LoginHistoryID;
            this.UserID = UserID;
            this.LoginTime = LoginTime;
            this.LogoutTime = LogoutTime;
            Mode = enMode.Update;
        }
        private bool _AddNewLoginHistory()
        {
            this.LoginHistoryID = (int?)clsLoginHistoryData.AddNewLoginHistory(this.UserID, this.LoginTime, this.LogoutTime);
            return (this.LoginHistoryID != -1);
        }
        private bool _UpdateLoginHistory()
            => clsLoginHistoryData.UpdateLoginHistory(this.LoginHistoryID, this.UserID, this.LoginTime, this.LogoutTime);
        public static clsLoginHistory Find(int? LoginHistoryID)
        {
            short UserID = -1;
            DateTime LoginTime = DateTime.Now;
            DateTime? LogoutTime = null;

            bool IsFound = clsLoginHistoryData.GetLoginHistoryByID(LoginHistoryID, ref UserID, ref LoginTime, ref LogoutTime);

            if(IsFound)
                return new clsLoginHistory(LoginHistoryID, UserID, LoginTime, LogoutTime);
            else
                return null;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewLoginHistory())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateLoginHistory();
            }
            return false;
        }
        public static bool DeleteLoginHistory(int? LoginHistoryID)
            => clsLoginHistoryData.DeleteLoginHistory(LoginHistoryID);
        public static bool DoesLoginHistoryExist(int? LoginHistoryID)
            => clsLoginHistoryData.DoesLoginHistoryExist(LoginHistoryID);
        public static DataTable GetUserLoginHistory(short UserID)
            => clsLoginHistoryData.GetUserLoginHistory(UserID);
        public static DataTable GetLoginHistory()
            => clsLoginHistoryData.GetAllLoginHistory();

    }
}
