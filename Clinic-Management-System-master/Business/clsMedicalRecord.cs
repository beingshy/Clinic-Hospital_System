using System;
using System.Data;
using ClinicManagementDB_DataAccess;

namespace ClinicManagementDB_Business
{
    public class clsMedicalRecord
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? MedicalRecordID { set; get; }
        public string Diagnosis { set; get; }
        public string Prescription { set; get; }
        public string Notes { set; get; }
        public int AppointmentID { set; get; }
        public short CreatedByUserID { set; get; }
        public DateTime CreatedAt { set; get; }

        public clsMedicalRecord()
        {
            this.MedicalRecordID = null;
            this.Diagnosis = string.Empty;
            this.Prescription = null;
            this.Notes = null;
            AppointmentID = -1;
            this.CreatedByUserID = -1;
            this.CreatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }
        private clsMedicalRecord(int? MedicalRecordID, string Diagnosis, string Prescription, string Notes,int AppointmentID, short CreatedByUserID, DateTime CreatedAt)
        {
            this.MedicalRecordID = MedicalRecordID;
            this.Diagnosis = Diagnosis;
            this.Prescription = Prescription;
            this.Notes = Notes;
            this.AppointmentID = AppointmentID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedAt = CreatedAt;
            Mode = enMode.Update;
        }
        private bool _AddNewMedicalRecord()
        {
            this.MedicalRecordID = (int?)clsMedicalRecordData.AddNewMedicalRecord(this.Diagnosis, this.Prescription, this.Notes, this.AppointmentID, this.CreatedByUserID, this.CreatedAt);
            return (this.MedicalRecordID != -1);
        }
        private bool _UpdateMedicalRecord()
            => clsMedicalRecordData.UpdateMedicalRecord(this.MedicalRecordID, this.Diagnosis, this.Prescription, this.Notes, this.AppointmentID, this.CreatedByUserID, this.CreatedAt);
        public static clsMedicalRecord Find(int? MedicalRecordID)
        {
            string Diagnosis = string.Empty;
            string Prescription = null;
            string Notes = null;
            int AppointmentID = -1;
            short CreatedByUserID = -1;
            DateTime CreatedAt = DateTime.Now;

            bool IsFound = clsMedicalRecordData.GetMedicalRecordByID(MedicalRecordID, ref Diagnosis, ref Prescription, ref Notes,ref AppointmentID, ref CreatedByUserID, ref CreatedAt);

            if(IsFound)
                return new clsMedicalRecord(MedicalRecordID, Diagnosis, Prescription, Notes, AppointmentID, CreatedByUserID, CreatedAt);
            else
                return null;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewMedicalRecord())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateMedicalRecord();
            }
            return false;
        }
        public static bool DeleteMedicalRecord(int? MedicalRecordID)
            => clsMedicalRecordData.DeleteMedicalRecord(MedicalRecordID);
        public static bool DoesMedicalRecordExist(int? MedicalRecordID)
            => clsMedicalRecordData.DoesMedicalRecordExist(MedicalRecordID);
        public static DataTable GetPatientMedicalRecords(int PatientID)
            => clsMedicalRecordData.GetPatientMedicalRecords(PatientID);
    }
}
