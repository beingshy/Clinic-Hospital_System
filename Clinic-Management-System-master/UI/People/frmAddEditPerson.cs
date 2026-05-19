using ClinicManagementDB_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Global;

namespace UI.People
{
    public partial class frmAddEditPerson : Form
    {
        enum enMode { Add, Edit }
        enMode _FormMode;
        clsPerson _Person;
        public frmAddEditPerson()
        {
            InitializeComponent();
            _FormMode = enMode.Add;
            this.Text = "Add New Person";
            lblHeader.Text = "ADD PERSON";
            _Person = new clsPerson();
        }
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _FormMode = enMode.Edit;
            this.Text = "Edit Person";
            lblHeader.Text = "EDIT PERSON";
            _Person = clsPerson.Find(PersonID);
        }
        private void frmAddOrUpdatePerson_Load(object sender, EventArgs e)
        {
            _LoadCountries();
            _SetConstraints();
            _LoadData();
        }
        private void _LoadData()
        {
            if(_Person.PersonID == null)
            {
                txtByUser.Text = clsGlobal.CurrentUser.Username;
                return;
            }

            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName ?? string.Empty;
            txtLastName.Text = _Person.LastName;
            txtNationalID.Text = _Person.NationalID;
            dtpBirthDate.Value = _Person.BirthDate;

            if(_Person.Gender == false)
                rdMale.Checked = true;
            else
                rdFemale.Checked = true;

            cbCountry.SelectedIndex = cbCountry.FindStringExact(_Person.CountryName);
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address ?? string.Empty;
            txtByUser.Text = clsUser.GetUsernameByID(_Person.CreatedByUserID);
        }
        private void _Save()
        {
            if(!this.ValidateChildren())
            {
                return;
            }

            if(!_CheckConstrint())
                return;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = string.IsNullOrWhiteSpace(txtThirdName.Text.Trim()) ? null : txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalID = txtNationalID.Text.Trim();
            _Person.BirthDate = dtpBirthDate.Value;
            _Person.Gender = rdMale.Checked == true ? false : true;
            _Person.CountryID = (byte)clsCountry.Find(cbCountry.Text).CountryID;
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Address = string.IsNullOrWhiteSpace(txtAddress.Text.Trim()) ? null : txtThirdName.Text.Trim();

            if(_FormMode == enMode.Add)
            {
                _Person.CreatedByUserID = (short)clsGlobal.CurrentUser.UserID;
                _Person.CreatedAt = DateTime.Now;
            }
            else
            {
                _Person.UpdatedByUserID = (short)clsGlobal.CurrentUser.UserID;
                _Person.UpdatedAt = DateTime.Now;
            }

            if(MessageBox.Show("Are you sure you want to save this person?", "Confirm Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(_Person.Save())
                {
                    MessageBox.Show("Person saved successfully.", "Save Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _FormMode = enMode.Edit;
                    this.Text = "Edit Person";
                    lblHeader.Text = "EDIT PERSON";
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the person. Please try again.",
                        "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool _CheckConstrint()
        {
            if(!rdMale.Checked && !rdFemale.Checked)
            {
                MessageBox.Show("Please select your gender.", "Gender Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(cbCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a country from the list.",
                    "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void _SetConstraints()
        {
            dtpBirthDate.MinDate = DateTime.Now.AddYears(-100);
            dtpBirthDate.MaxDate = DateTime.Now;
        }
        private void _LoadCountries()
        {
            DataTable Countries = clsCountry.GetCountries();

            foreach(DataRow Row in Countries.Rows)
            {
                cbCountry.Items.Add((string)Row["CountryName"]);
            }
        }
        private void PreventNonLetterInput(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            if((textbox.Text.Length >= 22 || !(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))))
            {
                e.Handled = true;
            }

        }
        private void PreventNonDigitInput(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if(char.IsControl(e.KeyChar))
                return;

            //// 10 to limit Phone and National ID inupts in this form.
            if((textbox.Text.Length >= 10 || !(char.IsDigit(e.KeyChar))))
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
        private void ValidateEmailTextbox(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            if(!clsValidation.ValidateEmail(textbox.Text))
            {
                textbox.BackColor = Color.FromArgb(91, 15, 15);
                errorProvider1.SetError(textbox, "Please Enter a Valid Email");
                e.Cancel = true;
            }
            else
            {
                textbox.BackColor = Color.FromArgb(35, 35, 35);
                errorProvider1.SetError(textbox, null);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

    }
}
