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

namespace UI.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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
            }
            else
            {
                textbox.BackColor = Color.FromArgb(35, 35, 35);
                errorProvider1.SetError(textbox, null);
            }
        }
        private void lblKhalidAlshammari_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/5ldv");

        }
        private void lblResetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet.", "Feature Not Available",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser LoggedUser = clsUser.GetUserByUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if(LoggedUser == null)
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if(chkRememberMe.Checked)
                    clsGlobal.SaveLoginCredentials(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                else
                    clsGlobal.DeleteLoginCredentials();

                clsGlobal.CurrentUser = LoggedUser;
                clsGlobal.CurrentUser.LastLoginAt = DateTime.Now;
                clsGlobal.CurrentUser.Save();

                clsGlobal.CurrentLoginHistory = new clsLoginHistory();
                clsGlobal.CurrentLoginHistory.UserID = (short)clsGlobal.CurrentUser.UserID;
                clsGlobal.CurrentLoginHistory.LoginTime = DateTime.Now;
                clsGlobal.CurrentLoginHistory.Save();

                frmMain frmMain = new frmMain();
                frmMain.OnFormClose += ShowNewLoginForm;
                frmMain.Show();
                this.Hide();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowNewLoginForm()
        {
            _HandleLoginCredentials();
            this.Show();
        }
        private void _HandleLoginCredentials()
        {
            string Username = string.Empty;
            string Password = string.Empty;

            if(clsGlobal.GetLoginCredentials(ref Username, ref Password))
            {
                txtUsername.Text = Username;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
            {
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                chkRememberMe.Checked = false;
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            _HandleLoginCredentials();
        }
    }
}
