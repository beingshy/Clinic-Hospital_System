using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using ClinicManagementDB_Business;
namespace UI.Users
{
    public partial class frmChangeUserPassword : Form
    {
        short _UserID;
        clsUser _User;
        public frmChangeUserPassword(short UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            _User = clsUser.Find(_UserID);
            ctrlPersonInfo1.SetPersonID(_User.PersonID);
            ctrlUserInfoVertical1.SetUserID((short)_User.UserID);
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
        private bool _CheckConstraint()
        {
            if(txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                MessageBox.Show("New password and confirm password do not match.", "Password Mismatch",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if(clsSecurityHelper.ComputeHash(txtCurrentPassword.Text.Trim()) != _User.Password)
            {
                MessageBox.Show("The current password is incorrect. Please try again.",
                    "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if(clsSecurityHelper.ComputeHash(txtNewPassword.Text.Trim()) == _User.Password)
            {
                MessageBox.Show("The new password cannot be the same as the current password. Please choose a different password.",
                    "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_CheckConstraint())
                return;

            _User.Password = clsSecurityHelper.ComputeHash(txtNewPassword.Text.Trim());

            if(_User.Save())
            {
                MessageBox.Show("Password changed successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred while saving the new password. Please try again.",
                    "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
