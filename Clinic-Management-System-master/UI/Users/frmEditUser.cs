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

namespace UI.Users
{
    public partial class frmEditUser : Form
    {
        short _UserID;
        clsUser _User;
        public frmEditUser(short UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private void frmEditUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);
            if(_User == null)
            {
                this.Enabled = false;
                return;
            }

            txtPersonID.Text = _User.PersonID.ToString();
            txtUserID.Text = _User.UserID.ToString();
            txtUsername.Text = _User.Username;
            switch(_User.Role)
            {
                case 1:
                    cbRole.SelectedItem = "Admin"; 
                    break;
                case 2:
                    cbRole.SelectedItem = "Doctor";
                    break;
                case 3:
                    cbRole.SelectedItem = "Receptionist";
                    break;
            }

            if(_User.IsActive)
                rdActive.Checked = true;
            else
                rdInactive.Checked = true;

            txtCreatedBy.Text = clsUser.GetUsernameByID(_User.CreatedByUserID);

        }
        private bool CheckConstraint()
        {
            if(clsUser.DoesUserExist(txtUsername.Text.Trim()) && _User.Username != txtUsername.Text.Trim())
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

            return false;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CheckConstraint())
                return;

            _User.Username = txtUsername.Text.Trim();
            _User.IsActive = rdActive.Checked;
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

            _User.UpdatedByUserID = clsGlobal.CurrentUser.UserID;
            _User.UpdatedAt = DateTime.Now;
          

            if(_User.Save())
            {
                MessageBox.Show("User information has been updated successfully.",
                                "Save Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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
