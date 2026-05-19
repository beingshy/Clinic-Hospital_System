using ClinicManagementDB_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.MedicalRecord
{
    public partial class ctrlMedicalRecordInfo : UserControl
    {
        clsMedicalRecord _MedicalRecord;
        public ctrlMedicalRecordInfo()
        {
            InitializeComponent();
        }
        public void SetMedicalRecordID(int MedicalRecordID)
        {
            _MedicalRecord = clsMedicalRecord.Find(MedicalRecordID);
            _LoadData();
        }

        private void _LoadData()
        {
            if(_MedicalRecord == null) return;
            lblMedicalRecordID.Text = _MedicalRecord.MedicalRecordID.ToString();
            lblAppointmentID.Text = _MedicalRecord.AppointmentID.ToString();
            lblDiagonsis.Text = _MedicalRecord.Diagnosis;
            lblPrescription.Text = string.IsNullOrWhiteSpace(_MedicalRecord.Prescription) ? "N/A" : _MedicalRecord.Prescription;
            lblNotes.Text = string.IsNullOrWhiteSpace(_MedicalRecord.Notes) ? "N/A" : _MedicalRecord.Notes;
        }
    }
}
