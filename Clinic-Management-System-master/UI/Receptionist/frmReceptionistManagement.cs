using ClinicManagementDB_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.People;
using UI.Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.Receptionist
{
    public partial class frmReceptionistManagement : Form
    {
        DataTable dtReceptionists = null;
        public frmReceptionistManagement()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {

            dtReceptionists = clsReceptionist.GetReceptionists();
            dgvReceptionists.DataSource = dtReceptionists;

            if(dgvReceptionists.Rows.Count > 0)
            {
                dgvReceptionists.Columns[0].HeaderText = "Receptionist ID";
                dgvReceptionists.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvReceptionists.Columns[1].HeaderText = "Full Name";
                dgvReceptionists.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvReceptionists.Columns[2].HeaderText = "Hire Date";
                dgvReceptionists.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvReceptionists.Columns[3].HeaderText = "End Date";
                dgvReceptionists.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvReceptionists.Columns[4].HeaderText = "Status";
                dgvReceptionists.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvReceptionists.Columns[5].HeaderText = "Receptionist User";
                dgvReceptionists.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            lblRecordsValue.Text = dgvReceptionists.Rows.Count.ToString();
        }
        private void frmReceptionistManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
            cbFilter.SelectedIndex = 0;
        }
        private void frmReceptionistManagement_Shown(object sender, EventArgs e)
        {
            dgvReceptionists.ClearSelection();
        }
        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dtReceptionists != null)
                dtReceptionists.DefaultView.RowFilter = "";
            lblRecordsValue.Text = dgvReceptionists.Rows.Count.ToString();

            txtSearch.Visible = (cbFilter.Text != "None") && (cbFilter.Text != "Status");
            cbStatus.Visible = (cbFilter.Text == "Status");

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
                dtReceptionists.DefaultView.RowFilter = "";
                lblRecordsValue.Text = dgvReceptionists.Rows.Count.ToString();
                return;
            }

            string Column = cbFilter.Text.Replace(" ", "");

            if(cbFilter.Text == "Receptionist ID")
            {
                dtReceptionists.DefaultView.RowFilter = string.Format("[{0}] = {1}", Column, txtSearch.Text.Trim());
            }
            else
            {
                dtReceptionists.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", Column, txtSearch.Text.Trim());
            }

            lblRecordsValue.Text = dgvReceptionists.Rows.Count.ToString();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text == "Receptionist ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtReceptionists.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "Status", cbStatus.Text);
            lblRecordsValue.Text = dgvReceptionists.Rows.Count.ToString();
        }

        private void btnAddReceptionist_Click(object sender, EventArgs e)
        {
            frmAddEditReceptionist frmAddEditReceptionist = new frmAddEditReceptionist();
            frmAddEditReceptionist.ShowDialog();
            _LoadData();
        }

        private void tsmEditReceptionist_Click(object sender, EventArgs e)
        {
            short ReceptionistID = (short)dgvReceptionists.CurrentRow.Cells[0].Value;
            frmAddEditReceptionist frmAddEditReceptionist = new frmAddEditReceptionist(ReceptionistID);
            frmAddEditReceptionist.ShowDialog();
            _LoadData();
        }

        private void tsmShowReceptionistInfo_Click(object sender, EventArgs e)
        {
            short ReceptionistID = (short)dgvReceptionists.CurrentRow.Cells[0].Value;
            frmReceptionistInfo frmReceptionistInfo = new frmReceptionistInfo(ReceptionistID);
            frmReceptionistInfo.ShowDialog();
        }

        private void tsmiReceptionistUserInfo_Click(object sender, EventArgs e)
        {
            string ReceptionistUsername = (string)dgvReceptionists.CurrentRow.Cells[5].Value;
            frmUserInfo frmUserInfo = new frmUserInfo((short)clsUser.Find(ReceptionistUsername).UserID);
            frmUserInfo.ShowDialog();
        }

        private void tsmiPersonalInformation_Click(object sender, EventArgs e)
        {
            short ReceptionistID = (short)dgvReceptionists.CurrentRow.Cells[0].Value;
            frmPersonInfo frmPersonInfo = new frmPersonInfo(clsReceptionist.Find(ReceptionistID).PersonID);
            frmPersonInfo.ShowDialog();
        }

        private void tsmiAddNewReceptionist_Click(object sender, EventArgs e)
        {
            frmAddEditReceptionist frmAddEditReceptionist = new frmAddEditReceptionist();
            frmAddEditReceptionist.ShowDialog();
            _LoadData();
        }

    }
}
