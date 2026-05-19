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

namespace UI.Patient.Controls
{
    public partial class ctrlPatientInfo : UserControl
    {
        public ctrlPatientInfo()
        {
            InitializeComponent();
        }

        int? _PatientID;
        clsPatient _Patient;
        public clsPatient SelectedPatient { get { return _Patient; } }
        public void SetPatientID(int PatientID)
        {
            _PatientID = PatientID;
            _Patient = clsPatient.Find(_PatientID);
            if(_Patient != null)
                _LoadData();
        }
        public void ResetValues()
        {
            if(_Patient == null) return;

            _PatientID = null;
            _Patient = null;

            ctrlPersonInfo1.ResetValues();

            lblAllergies.Text = "[????]";
            lblBloodType.Text = "[????]";
            lblEmergencyContactName.Text = "[????]";
            lblEmergencyContactPhone.Text = "[????]";
            lblMedicalHistory.Text = "[????]";
            lblPatientID.Text = "[????]";
            lblCreatedByAt.Text = $"Created By [??] At [??]";
            lblUpdatedByAt.Text = $"Last Update By [??] At [??]";
        }
        private void _LoadData()
        {
            ctrlPersonInfo1.SetPersonID((int)_Patient.PersonID);

            lblPatientID.Text = _Patient.PatientID.ToString();
            lblAllergies.Text = _Patient.Allergies ?? "No Known Allergies";
            lblBloodType.Text = _Patient.BloodType ?? "Not Known";
            lblEmergencyContactName.Text = _Patient.EmergencyContactName ?? "Not Available";
            lblEmergencyContactPhone.Text = _Patient.EmergencyContactPhone ?? "Not Available";
            lblMedicalHistory.Text = _Patient.MedicalHistory ?? "No Known Medical History";

            lblCreatedByAt.Text = $"Created By {clsUser.GetUsernameByID(_Patient.CreatedByUserID)} At {_Patient.CreatedAt.ToString()}";
            if(_Patient.UpdatedByUserID.HasValue)
            {
                lblUpdatedByAt.Visible = true;
                lblUpdatedByAt.Text = $"Last Update By {clsUser.GetUsernameByID(_Patient.UpdatedByUserID)} At {_Patient.UpdatedAt.ToString()} ";
            }
            else
            {
                lblUpdatedByAt.Visible = false;
            }
        }
    }
}
