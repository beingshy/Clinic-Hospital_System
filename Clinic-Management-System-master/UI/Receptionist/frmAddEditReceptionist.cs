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

namespace UI.Receptionist
{
    public partial class frmAddEditReceptionist : Form
    {
        enum enMode { Add, Edit }
        enMode _FormMode;
        clsPerson _SelectedPerson;
        clsUser _ReceptionistUser;
        clsReceptionist _Receptionist;
        short _ReceptionistID;
        public frmAddEditReceptionist()
        {
            InitializeComponent();
            _FormMode = enMode.Add;
            lblHeader.Text = "ADD DOCTOR";
            _LoadData();
        }
        public frmAddEditReceptionist(short ReceptionistID)
        {
            InitializeComponent();
            _FormMode = enMode.Edit;
            _ReceptionistID = ReceptionistID;
            int? PersonID = clsReceptionist.GetPersonID(ReceptionistID);
            if(PersonID == null)
                return;
            ctrlPersonFinder1.SetPersonID((int)PersonID);
            ctrlPersonFinder1.SearchEnabled = false;
            lblHeader.Text = "EDIT RECEPTIONIST";
            tabPage2.Text = "Edit Receptionist";
            tabControl1.SelectedIndex = 1;
            btnNext.Enabled = true;
            gbReceptionistInfo.Enabled = true;
            btnSave.Enabled = true;

            _LoadData();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void _LoadData()
        {

            if(_FormMode == enMode.Add)
            {
                cbStatus.SelectedIndex = 0;
                _Receptionist = new clsReceptionist();
                return;
            }

            _Receptionist = clsReceptionist.Find(_ReceptionistID);

            if(_Receptionist == null)
                return;
            if(_Receptionist.EndDate != null)
                chkSetEndDate.Checked = true;

            ctrlPersonFinder1.SetPersonID((int)_Receptionist.PersonID);
            lblReceptionistID.Text = _Receptionist.ReceptionistID.ToString();
            switch(_Receptionist.ReceptionistStatus)
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
                    cbStatus.SelectedItem = "Terminated";
                    break;
            }
            dtpHireDate.Value = _Receptionist.HireDate;
            dtpEndDate.Value = _Receptionist.EndDate ?? DateTime.Now;
            txtReceptionistUsername.Text = _Receptionist.ReceptionistUser.Username;

        }
        private void PersonSelected(clsPerson Person)
        {
            if(clsReceptionist.DoesReceptionistExistsByPersonID(Person.PersonID))
            {
                MessageBox.Show("This person is already stored as a receptionist.", "Already Receptionist",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _SelectedPerson = null;
                btnNext.Enabled = false;
                gbReceptionistInfo.Enabled = false;
                btnSave.Enabled = false;
                return;
            }

            if(!Person.HasUser)
            {
                MessageBox.Show("The selected person does not have a user account associated with them.",
                  "No User Found",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
                _SelectedPerson = null;
                btnNext.Enabled = false;
                gbReceptionistInfo.Enabled = false;
                btnSave.Enabled = false;
                return;
            }

            _ReceptionistUser = clsUser.FindByPersonID((int)Person.PersonID);
            txtReceptionistUsername.Text = _ReceptionistUser.Username;
            _SelectedPerson = Person;
            btnNext.Enabled = true;
            gbReceptionistInfo.Enabled = true;
            btnSave.Enabled = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if(_FormMode == enMode.Add)
            {
                _Receptionist.PersonID = (int)_SelectedPerson.PersonID;
                _Receptionist.CreatedByUserID = (short)clsGlobal.CurrentUser.UserID;
                _Receptionist.CreatedAt = DateTime.Now;
                _Receptionist.ReceptionistUserID = (short)_ReceptionistUser.UserID;
            }
            else
            {
                _Receptionist.UpdatedByUserID = (short)clsGlobal.CurrentUser.UserID;
                _Receptionist.UpdatedAt = DateTime.Now;
            }
            _Receptionist.HireDate = dtpHireDate.Value;

            if(chkSetEndDate.Checked)
                _Receptionist.EndDate = dtpEndDate.Value;
            else
                _Receptionist.EndDate = null;

            switch(cbStatus.SelectedItem)
            {
                case "Active":
                    _Receptionist.ReceptionistStatus = 1;
                    break;
                case "On Leave":
                    _Receptionist.ReceptionistStatus = 2;
                    break;
                case "Resigned":
                    _Receptionist.ReceptionistStatus = 3;
                    break;
                case "Retired":
                    _Receptionist.ReceptionistStatus = 4;
                    break;
            }

            if(_Receptionist.Save())
            {
                MessageBox.Show("Receptionist information has been saved successfully.",
                                "Save Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                lblReceptionistID.Text = _Receptionist.ReceptionistID.ToString();

                btnSave.Visible = false;
                ctrlPersonFinder1.SearchEnabled = false;
            }
            else
            {
                MessageBox.Show("Failed to save receptionist information. Please try again.",
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
        private void frmAddEditReceptionist_Load(object sender, EventArgs e)
        {
            ctrlPersonFinder1.OnPersonSelected += PersonSelected;
        }

    }
}
