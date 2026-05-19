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
using UI.Global;

namespace UI.MedicalRecord
{
    public partial class frmAddMedicalRecord : Form
    {
        clsAppointment _Appointment;
        clsMedicalRecord _MedicalRecord;
        public Action<int> OnMedicalRecordAdded;
        public frmAddMedicalRecord(int AppointmentID)
        {
            _Appointment = clsAppointment.Find(AppointmentID);
            _MedicalRecord = new clsMedicalRecord();
            InitializeComponent();
        }

        private void frmAddMedicalRecord_Load(object sender, EventArgs e)
        {
            if(_Appointment.AppointmentID == null)
                btnSave.Enabled = false;

            _LoadData();
        }
        private void _LoadData()
        {
            if(_Appointment.AppointmentID == null)
                return;

            txtAppointmentID.Text = _Appointment.AppointmentID.ToString();
        }
        private bool _CheckConstraint()
        {
            if(string.IsNullOrWhiteSpace(txtDiagnosis.Text.Trim()))
            {
                MessageBox.Show("Diagnosis is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private void _Save()
        {
            if(_CheckConstraint())
            {
                return;
            }
            _MedicalRecord.Diagnosis = txtDiagnosis.Text.Trim();
            _MedicalRecord.Prescription = string.IsNullOrWhiteSpace(txtPrescription.Text.Trim()) ? null : txtPrescription.Text.Trim();
            _MedicalRecord.Notes = string.IsNullOrWhiteSpace(txtNotes.Text.Trim()) ? null : txtNotes.Text.Trim();
            _MedicalRecord.AppointmentID = (int)_Appointment.AppointmentID;
            _MedicalRecord.CreatedByUserID = (short)clsGlobal.CurrentUser.UserID;
            _MedicalRecord.CreatedAt = DateTime.Now;

            if(MessageBox.Show("Are you sure you want to save this Medical Record?", "Confirm Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(_MedicalRecord.Save())
                {
                    OnMedicalRecordAdded.Invoke((int)_MedicalRecord.MedicalRecordID);

                    MessageBox.Show("Medical Record saved successfully.", "Save Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the Medical Record. Please try again.",
                        "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
