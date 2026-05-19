using System;
using System.Data;
using ClinicManagementDB_DataAccess;

namespace ClinicManagementDB_Business
{
    public class clsReceptionist
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public short? ReceptionistID { set; get; }
        public int PersonID { set; get; }
        public DateTime HireDate { set; get; }
        public DateTime? EndDate { set; get; }
        public byte ReceptionistStatus { set; get; }
        public short ReceptionistUserID { set; get; }
        public clsUser ReceptionistUser { set; get; }
        public short CreatedByUserID { set; get; }
        public DateTime CreatedAt { set; get; }
        public short? UpdatedByUserID { set; get; }
        public DateTime? UpdatedAt { set; get; }
        public string ReceptionistStatusString
        {
            get
            {
                switch(this.ReceptionistStatus)
                {
                    case 1:
                        return "Active";
                    case 2:
                        return "On Leave";
                    case 3:
                        return "Resigned";
                    case 4:
                        return "Terminated";

                    default:
                        return "Not Known";
                }
            }
        }

        public clsReceptionist()
        {
            this.ReceptionistID = null;
            this.PersonID = -1;
            this.HireDate = DateTime.Now;
            this.EndDate = null;
            this.ReceptionistStatus = 0;
            this.ReceptionistUserID = -1;
            this.CreatedByUserID = -1;
            this.CreatedAt = DateTime.Now;
            this.UpdatedByUserID = null;
            this.UpdatedAt = null;
            Mode = enMode.AddNew;
        }
        private clsReceptionist(short? ReceptionistID, int PersonID, DateTime HireDate, DateTime? EndDate, byte ReceptionistStatus, short ReceptionistUserID, short CreatedByUserID, DateTime CreatedAt, short? UpdatedByUserID, DateTime? UpdatedAt)
        {
            this.ReceptionistID = ReceptionistID;
            this.PersonID = PersonID;
            this.HireDate = HireDate;
            this.EndDate = EndDate;
            this.ReceptionistStatus = ReceptionistStatus;
            this.ReceptionistUserID = ReceptionistUserID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedAt = CreatedAt;
            this.UpdatedByUserID = UpdatedByUserID;
            this.UpdatedAt = UpdatedAt;
            this.ReceptionistUser = clsUser.Find(ReceptionistUserID);
            Mode = enMode.Update;
        }
        private bool _AddNewReceptionist()
        {
            this.ReceptionistID = (short?)clsReceptionistData.AddNewReceptionist(this.PersonID, this.HireDate, this.EndDate, this.ReceptionistStatus, this.ReceptionistUserID, this.CreatedByUserID, this.CreatedAt, this.UpdatedByUserID, this.UpdatedAt);
            return (this.ReceptionistID != -1);
        }
        private bool _UpdateReceptionist()
            => clsReceptionistData.UpdateReceptionist(this.ReceptionistID, this.PersonID, this.HireDate, this.EndDate, this.ReceptionistStatus, this.ReceptionistUserID, this.CreatedByUserID, this.CreatedAt, this.UpdatedByUserID, this.UpdatedAt);
        public static clsReceptionist Find(short? ReceptionistID)
        {
            int PersonID = -1;
            DateTime HireDate = DateTime.Now;
            DateTime? EndDate = null;
            byte ReceptionistStatus = 0;
            short ReceptionistUserID = -1;
            short CreatedByUserID = -1;
            DateTime CreatedAt = DateTime.Now;
            short? UpdatedByUserID = null;
            DateTime? UpdatedAt = null;

            bool IsFound = clsReceptionistData.GetReceptionistByID(ReceptionistID, ref PersonID, ref HireDate, ref EndDate, ref ReceptionistStatus, ref ReceptionistUserID, ref CreatedByUserID, ref CreatedAt, ref UpdatedByUserID, ref UpdatedAt);

            if(IsFound)
                return new clsReceptionist(ReceptionistID, PersonID, HireDate, EndDate, ReceptionistStatus, ReceptionistUserID, CreatedByUserID, CreatedAt, UpdatedByUserID, UpdatedAt);
            else
                return null;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewReceptionist())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateReceptionist();
            }
            return false;
        }
        public static bool DeleteReceptionist(short? ReceptionistID)
            => clsReceptionistData.DeleteReceptionist(ReceptionistID);
        public static bool DoesReceptionistExist(short? ReceptionistID)
            => clsReceptionistData.DoesReceptionistExist(ReceptionistID);
        public static DataTable GetReceptionists()
            => clsReceptionistData.GetAllReceptionists();
        
        public static int? GetPersonID(short? ReceptionistID) 
            => clsReceptionistData.GetPersonID(ReceptionistID);

        public static bool DoesReceptionistExistsByPersonID(int? PersonID) 
            => clsReceptionistData.DoesReceptionistExistByPersonID(PersonID);

    }
}
