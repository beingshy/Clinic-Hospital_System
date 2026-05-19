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

namespace UI.Doctor
{
    public partial class frmAddEditDoctor : Form
    {

        enum enMode { Add, Edit }
        enMode _FormMode;
        clsPerson _SelctedPerson;
        clsUser _DoctorUser;
        clsDoctor _Doctor;
        short _DoctorID;

        public frmAddEditDoctor()
        {
            InitializeComponent();
            _FormMode = enMode.Add;
            lblHeader.Text = "ADD DOCTOR";
            _LoadData();
        }
        public frmAddEditDoctor(short DoctorID)
        {
            InitializeComponent();
            _FormMode = enMode.Edit;
            _DoctorID = DoctorID;
            int? PersonID = clsDoctor.GetPersonID(DoctorID);
            if(PersonID == null)
                return;
            ctrlPersonFinder1.SetPersonID((int)PersonID);
            ctrlPersonFinder1.SearchEnabled = false;
            lblHeader.Text = "EDIT DOCTOR";
            tabPage2.Text = "Edit Doctor";
            tabControl1.SelectedIndex = 1;
            btnNext.Enabled = true;
            gbDoctorInfo.Enabled = true;
            btnSave.Enabled = true;

            _LoadData();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void _LoadDepartments()
        {
            DataTable dt = clsDepartment.GetDepartments();
            foreach(DataRow dr in dt.Rows)
            {
                cbDepartment.Items.Add(dr["DepartmentName"]);
            }
        }
        private void _LoadData()
        {
            _LoadDepartments();

            if(_FormMode == enMode.Add)
            {
                cbDepartment.SelectedIndex = 0;
                cbStatus.SelectedIndex = 0;
                _Doctor = new clsDoctor();
                return;
            }

            _Doctor = clsDoctor.Find(_DoctorID);

            if(_Doctor == null)
                return;

            ctrlPersonFinder1.SetPersonID((int)_Doctor.PersonID);
            lblDoctorID.Text = _Doctor.DoctorID.ToString();
            cbDepartment.SelectedItem = _Doctor.Department.DepartmentName;
            txtLicenseNumber.Text = _Doctor.LicenseNumber.ToString();
            txtYearsOfExperience.Text = _Doctor.YearsOfExperience.ToString();
            txtSpecialization.Text = _Doctor.Specialization;
            switch(_Doctor.DoctorStatus)
            {
                case 1:
                    cbStatus.SelectedItem = "Active";
                    break;
                case 2:
                    cbStatus.SelectedItem = "On Leave";
                    break;
                case 3:
                    cbStatus.SelectedItem = "Resigned";
                    break;
                case 4:
                    cbStatus.SelectedItem = "Retired";
                    break;
                case 5:
                    cbStatus.SelectedItem = "Terminated";
                    break;
            }
            dtpHireDate.Value = _Doctor.HireDate;
            dtpEndDate.Value = _Doctor.EndDate ?? DateTime.Now;
            txtConsultationFee.Text = _Doctor.ConsultationFee.ToString() ?? string.Empty;
            txtDoctorUsername.Text = _Doctor.DoctorUser.Username;

        }
        private void PersonSelected(clsPerson Person)
        {
            if(clsDoctor.DoesDoctorExistByPersonID(Person.PersonID))
            {
                MessageBox.Show("This person is already stored as a doctor.", "Already Doctor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _SelctedPerson = null;
                btnNext.Enabled = false;
                gbDoctorInfo.Enabled = false;
                btnSave.Enabled = false;
                return;
            }

            if(!Person.HasUser)
            {
                MessageBox.Show("The selected person does not have a user account associated with them.",
                  "No User Found",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
                _SelctedPerson = null;
                btnNext.Enabled = false;
                gbDoctorInfo.Enabled = false;
                btnSave.Enabled = false;
                return;
            }

            _DoctorUser = clsUser.FindByPersonID((int)Person.PersonID);
            txtDoctorUsername.Text = _DoctorUser.Username;
            _SelctedPerson = Person;
            btnNext.Enabled = true;
            gbDoctorInfo.Enabled = true;
            btnSave.Enabled = true;
        }
        private void frmAddEditDoctor_Load(object sender, EventArgs e)
        {
            ctrlPersonFinder1.OnPersonSelected += PersonSelected;
        }
        private bool _CheckConstraint()
        {
            if(clsDoctor.DoesUsernameUsedByAnotherDoctor(_Doctor.DoctorID, txtDoctorUsername.Text.Trim()))
            {
                MessageBox.Show("The username is already used by another doctor. Please choose a different username.",
                    "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_CheckConstraint())
                return;

            if(_FormMode == enMode.Add)
            {
                _Doctor.PersonID = (int)_SelctedPerson.PersonID;
                _Doctor.CreatedByUserID = (short)clsGlobal.CurrentUser.UserID;
                _Doctor.CreatedAt = DateTime.Now;
                _Doctor.DoctorUserID = (short)_DoctorUser.UserID;
            }
            else
            {
                _Doctor.UpdatedByUserID = (short)clsGlobal.CurrentUser.UserID;
                _Doctor.UpdatedAt = DateTime.Now;
            }
            _Doctor.DepartmentID = (byte)clsDepartment.Find(cbDepartment.SelectedItem.ToString()).DepartmentID;
            _Doctor.LicenseNumber = txtLicenseNumber.Text.Trim();
            _Doctor.Specialization = txtSpecialization.Text.Trim();
            _Doctor.YearsOfExperience = byte.Parse(txtYearsOfExperience.Text);
            _Doctor.HireDate = dtpHireDate.Value;

            if(chkSetEndDate.Checked)
                _Doctor.EndDate = dtpEndDate.Value;
            else
                _Doctor.EndDate = null;

            _Doctor.ConsultationFee = string.IsNullOrWhiteSpace(txtConsultationFee.Text.Trim())
                ? null : (decimal?)decimal.Parse(txtConsultationFee.Text);
            switch(cbStatus.SelectedItem)
            {
                case "Active":
                    _Doctor.DoctorStatus = 1;
                    break;
                case "On Leave":
                    _Doctor.DoctorStatus = 2;
                    break;
                case "Resigned":
                    _Doctor.DoctorStatus = 3;
                    break;
                case "Retired":
                    _Doctor.DoctorStatus = 4;
                    break;
                case "Terminated":
                    _Doctor.DoctorStatus = 5;
                    break;
            }

            if(_Doctor.Save())
            {
                MessageBox.Show("Doctor information has been saved successfully.",
                                "Save Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                lblDoctorID.Text = _Doctor.DoctorID.ToString();

                btnSave.Visible = false;
                ctrlPersonFinder1.SearchEnabled = false;
            }
            else
            {
                MessageBox.Show("Failed to save doctor information. Please try again.",
                                "Save Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }
        private void chkSetEndDate_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSetEndDate.Checked)
            {
                dtpEndDate.Enabled = true;
            }
            else
            {
                dtpEndDate.Enabled = false;
            }
        }
        private void PreventNonLetterInput(object sender, KeyPressEventArgs e)
        {

        }
        private void PreventNonDigitInput(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            if(char.IsControl(e.KeyChar)) return;

            if(textbox.Text.Length >= 10 || !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void PreventNonDigitAndNonLetterAndNonPunctuationInput(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if(textbox.Text.Length >= 40 ||
                !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar)) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ValidateTextbox(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if(textbox.Text.Length < Int16.Parse(textbox.Tag.ToString()))
            {
                textbox.BackColor = Color.FromArgb(91, 15, 15);
                errorProvider1.SetError(textbox, "Please Enter a Valid Value");
                e.Cancel = true;
            }
            else
            {
                textbox.BackColor = Color.FromArgb(35, 35, 35);
                errorProvider1.SetError(textbox, null);
            }
        }


    }
}
