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
using UI.Users.Controls;

namespace UI.Patient
{
    public partial class frmAddEditPatient : Form
    {
        enum enMode { Add, Edit }
        enMode _FormMode;
        clsPerson _SelctedPerson;
        clsPatient _Patient;
        int _PatientID;
        public frmAddEditPatient()
        {
            InitializeComponent();
            _FormMode = enMode.Add;
            lblHeader.Text = "ADD PATIENT";
        }
        public frmAddEditPatient(int PatientID)
        {
            InitializeComponent();
            _FormMode = enMode.Edit;
            _PatientID = PatientID;
            ctrlPersonFinder1.SearchEnabled = false;
            lblHeader.Text = "EDIT PATIENT";
            tabPage2.Text = "Edit Patient";
            tabControl1.SelectedIndex = 1;
            btnNext.Enabled = true;
            gbPatientInfo.Enabled = true;
            btnSave.Enabled = true;

            _LoadData();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void _LoadData()
        {
            _Patient = clsPatient.Find(_PatientID);

            if(_Patient == null)
                return;

            ctrlPersonFinder1.SetPersonID((int)_Patient.PersonID);
            lblPatientID.Text = _Patient.PatientID.ToString();
            txtAllergies.Text = _Patient.Allergies ?? string.Empty;
            txtMedicalHistory.Text = _Patient.MedicalHistory ?? string.Empty;
            txtEmergencyContactName.Text = _Patient.EmergencyContactName ?? string.Empty;
            txtEmergencyContactPhone.Text = _Patient.EmergencyContactPhone ?? string.Empty;
            cbBloodType.SelectedIndex = _Patient.BloodType != null ? cbBloodType.FindString(_Patient.BloodType) : 0;

        }
        private void PersonSelected(clsPerson Person)
        {
            if(clsPatient.DoesPatientExistByPersonID((int)Person.PersonID))
            {
                MessageBox.Show("This person is already stored as a patient.", "Already Patient",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _SelctedPerson = null;
                btnNext.Enabled = false;
                gbPatientInfo.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            _SelctedPerson = Person;
            btnNext.Enabled = true;
            gbPatientInfo.Enabled = true;
            btnSave.Enabled = true;
        }
        private void frmAddEditPatient_Load(object sender, EventArgs e)
        {
            ctrlPersonFinder1.OnPersonSelected += PersonSelected;
            if(_FormMode == enMode.Add)
                cbBloodType.SelectedIndex = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_FormMode == enMode.Add)
            {
                _Patient = new clsPatient();
                _Patient.PersonID = (int)_SelctedPerson.PersonID;
                _Patient.CreatedByUserID = (short)clsGlobal.CurrentUser.UserID;
                _Patient.CreatedAt = DateTime.Now;
            }
            else
            {
                _Patient.UpdatedByUserID = (short)clsGlobal.CurrentUser.UserID;
                _Patient.UpdatedAt = DateTime.Now;
            }

            _Patient.BloodType = cbBloodType.SelectedItem.ToString() == "Not Known" ? null : cbBloodType.SelectedItem.ToString();
            _Patient.Allergies = string.IsNullOrWhiteSpace(txtAllergies.Text) ? null : txtAllergies.Text;
            _Patient.MedicalHistory = string.IsNullOrWhiteSpace(txtMedicalHistory.Text) ? null : txtMedicalHistory.Text;
            _Patient.EmergencyContactName = string.IsNullOrWhiteSpace(txtEmergencyContactName.Text) ? null : txtEmergencyContactName.Text;
            _Patient.EmergencyContactPhone = string.IsNullOrWhiteSpace(txtEmergencyContactPhone.Text) ? null : txtEmergencyContactPhone.Text;


            if(_Patient.Save())
            {
                MessageBox.Show("Patient information has been saved successfully.",
                                "Save Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                lblPatientID.Text = _Patient.PatientID.ToString();

                btnSave.Visible = false;

            }
            else
            {
                MessageBox.Show("Failed to save patient information. Please try again.",
                                "Save Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }
        private void PreventNonLetterInput(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if(textbox.Text.Length >= 40 ||
                !(char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void PreventNonDigitInput(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if(char.IsControl(e.KeyChar))
                return;

            if((textbox.Text.Length >= 10 || !(char.IsDigit(e.KeyChar))))
            {
                e.Handled = true;
            }
        }
    }
}
