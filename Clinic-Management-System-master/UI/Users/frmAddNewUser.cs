using Business;
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

namespace UI.Users
{
    public partial class frmAddNewUser : Form
    {
        clsPerson _SelctedPerson;
        public frmAddNewUser()
        {
            InitializeComponent();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void PersonSelected(clsPerson Person)
        {
            if(Person.HasUser)
            {
                MessageBox.Show("This person already has an associated user.", "User Exists",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _SelctedPerson = null;
                btnNext.Enabled = false;
                gbUserInfo.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            _SelctedPerson = Person;
            btnNext.Enabled = true;
            gbUserInfo.Enabled = true;
            btnSave.Enabled = true;
            txtCreatedBy.Text = clsGlobal.CurrentUser.Username;
        }
        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            ctrlPersonFinder1.OnPersonSelected += PersonSelected;
            cbRole.SelectedIndex = 0;
        }
        private void PreventNonDigitAndNonLetterInput(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if(textbox.Text.Length >= 40 ||
                !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void PreventInvalidPasswordInput(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if(textbox.Text.Length >= 22 ||
                !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
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
        private bool CheckConstraint()
        {
            if(clsUser.DoesUserExist(txtUsername.Text.Trim()))
            {
                MessageBox.Show("This username is already taken. Please choose a different one.",
                "Username Taken",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return true;
            }
            if(txtUsername.Text.Trim().Length <= 3)
            {
                MessageBox.Show("The username must be longer than 3 characters.",
                    "Invalid Username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return true;
            }
            if(txtPassowrd.Text.Trim().Length < 4)
            {
                MessageBox.Show("The password must be longer than 3 characters.",
                "Invalid Password",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CheckConstraint())
                return;

            clsUser _User = new clsUser();
            _User.PersonID = (int)_SelctedPerson.PersonID;
            _User.Username = txtUsername.Text.Trim();
            _User.Password = txtPassowrd.Text.Trim();
            _User.IsActive = rdActive.Checked;
            _User.CreatedByUserID = (short)clsGlobal.CurrentUser.UserID;
            _User.CreatedAt = DateTime.Now;
            switch(cbRole.Text)
            {
                case "Admin":
                    _User.Role = 1;
                    break;
                case "Doctor":
                    _User.Role = 2;
                    break;
                case "Receptionist":
                    _User.Role = 3;
                    break;
            }

            if(_User.Save())
            {
                MessageBox.Show("User information has been saved successfully.",
                                "Save Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                ctrlUserInfoVertical1.SetUserID((short)_User.UserID);
                pnlSideCard.Enabled = true;
                btnSave.Visible = false;
            }
            else
            {
                MessageBox.Show("Failed to save user information. Please try again.",
                                "Save Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }
    }
}
