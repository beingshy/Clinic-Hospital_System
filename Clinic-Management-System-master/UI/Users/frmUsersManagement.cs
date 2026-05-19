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
using UI.People;

namespace UI.Users
{
    public partial class frmUsersManagement : Form
    {
        DataTable dtUsers = null;
        public frmUsersManagement()
        {
            InitializeComponent();
        }
        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
            cbFilter.SelectedIndex = 0;
        }
        private void _LoadData()
        {
            dtUsers = clsUser.GetUsers();
            dgvUsers.DataSource = dtUsers;

            if(dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvUsers.Columns[2].HeaderText = "User Name";
                dgvUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvUsers.Columns[3].HeaderText = "Is Active";
                dgvUsers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvUsers.Columns[4].HeaderText = "Role";
                dgvUsers.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvUsers.Columns[5].HeaderText = "Last Login At";
                dgvUsers.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }

            lblRecordsValue.Text = dgvUsers.Rows.Count.ToString();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dtUsers != null)
                dtUsers.DefaultView.RowFilter = "";

            lblRecordsValue.Text = dgvUsers.Rows.Count.ToString();

            txtSearch.Visible = (cbFilter.Text != "None") && (cbFilter.Text != "Role") && (cbFilter.Text != "Is Active");
            cbRole.Visible = (cbFilter.Text == "Role");
            cbIsActive.Visible = (cbFilter.Text == "Is Active");

            if(txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dtUsers.DefaultView.RowFilter = "";
                lblRecordsValue.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            string Column = cbFilter.Text.Replace(" ", "");
            if(cbFilter.Text == "User Name")
                dtUsers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", Column, txtSearch.Text.Trim());
            else
                dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", Column, txtSearch.Text.Trim());


            lblRecordsValue.Text = dgvUsers.Rows.Count.ToString();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text == "Person ID" || cbFilter.Text == "User ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtUsers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "IsActive", cbIsActive.Text);
            lblRecordsValue.Text = dgvUsers.Rows.Count.ToString();
        }
        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtUsers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "Role", cbRole.Text);
            lblRecordsValue.Text = dgvUsers.Rows.Count.ToString();
        }
        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {

            if(dgvUsers.Rows.Count == 0)
            {
                ctrlUserInfoVertical1.ResetValues();
                return;
            }

            ctrlUserInfoVertical1.SetUserID((short)dgvUsers.CurrentRow.Cells[0].Value);

            string isSelectedUserActive = (string)dgvUsers.CurrentRow.Cells[3].Value;

            if(isSelectedUserActive == "Yes")
            {
                tsmiActivateOrDeactivate.Text = "Deactivate";
            }
            else
            {
                tsmiActivateOrDeactivate.Text = "Activate";
            }


        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser frmAddNewUser = new frmAddNewUser();
            frmAddNewUser.ShowDialog();
            _LoadData();
        }
        private void tsmiEditUser_Click(object sender, EventArgs e)
        {
            frmEditUser frmEditUser = new frmEditUser((short)dgvUsers.CurrentRow.Cells[0].Value);
            frmEditUser.ShowDialog();
            _LoadData();
        }

        private void tsmiActivateOrDeactivate_Click(object sender, EventArgs e)
        {
            short UserID = (short)dgvUsers.CurrentRow.Cells[0].Value;
            clsUser User = clsUser.Find(UserID);

            if(User.IsActive)
            {
                tsmiActivateOrDeactivate.Text = "Deactivate";
                User.DeactiviateUser();
                _LoadData();
            }
            else
            {
                tsmiActivateOrDeactivate.Text = "Activate";
                User.ActiviateUser();
                _LoadData();
            }

        }

        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {
            short UserID = (short)dgvUsers.CurrentRow.Cells[0].Value;
            frmChangeUserPassword frmChangeUserPassword = new frmChangeUserPassword(UserID);
            frmChangeUserPassword.ShowDialog();
        }

        private void tsmiAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser frmAddNewUser = new frmAddNewUser();
            frmAddNewUser.ShowDialog();
        }

        private void tsmiShowUserInfo_Click(object sender, EventArgs e)
        {
            short UserID = (short)dgvUsers.CurrentRow.Cells[0].Value;
            frmUserInfo frmUserInfo = new frmUserInfo(UserID);
            frmUserInfo.ShowDialog();
        }

        private void tsmiShowPersonInfo_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvUsers.CurrentRow.Cells[1].Value;
            frmPersonInfo frmPersonInfo = new frmPersonInfo(PersonID);
            frmPersonInfo.ShowDialog();
        }

        private void tsmiChangeToAdmin_Click(object sender, EventArgs e)
        {
            short UserID = (short)dgvUsers.CurrentRow.Cells[0].Value;
            clsUser.ChangeRole(UserID, clsUser.enRole.Admin);
            _LoadData();

        }

        private void tsmiChangeToDoctor_Click(object sender, EventArgs e)
        {
            short UserID = (short)dgvUsers.CurrentRow.Cells[0].Value;
            clsUser.ChangeRole(UserID, clsUser.enRole.Doctor);
            _LoadData();
        }

        private void tsmiChangeToReceptionist_Click(object sender, EventArgs e)
        {
            short UserID = (short)dgvUsers.CurrentRow.Cells[0].Value;
            clsUser.ChangeRole(UserID, clsUser.enRole.Receptionist);
            _LoadData();
        }

        private void tsmiChangeUserRole_Click(object sender, EventArgs e)
        {

            string Role = (string)dgvUsers.CurrentRow.Cells[4].Value;
            switch(Role)
            {
                case "Admin":
                    tsmiChangeToAdmin.Enabled = false;
                    tsmiChangeToDoctor.Enabled = true;
                    tsmiChangeToReceptionist.Enabled = true;
                    break;
                case "Doctor":
                    tsmiChangeToAdmin.Enabled = true;
                    tsmiChangeToDoctor.Enabled = false;
                    tsmiChangeToReceptionist.Enabled = true;

                    break;
                case "Receptionist":
                    tsmiChangeToAdmin.Enabled = true;
                    tsmiChangeToDoctor.Enabled = true;
                    tsmiChangeToReceptionist.Enabled = false;
                    break;
            }
        }

        private void tsmiShowLoginHistory_Click(object sender, EventArgs e)
        {
            short UserID = (short)dgvUsers.CurrentRow.Cells[0].Value;
            frmUserLoginHistory frmUserLoginHistory = new frmUserLoginHistory(UserID);
            frmUserLoginHistory.ShowDialog();
        }

    }
}
