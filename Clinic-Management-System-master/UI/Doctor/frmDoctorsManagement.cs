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
using UI.Users;

namespace UI.Doctor
{
    public partial class frmDoctorsManagement : Form
    {
        DataTable dtDoctors = null;
        public frmDoctorsManagement()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            dtDoctors = clsDoctor.GetDoctors();
            dgvDoctors.DataSource = dtDoctors;

            if(dgvDoctors.Rows.Count > 0)
            {
                dgvDoctors.Columns[0].HeaderText = "Doctor ID";
                dgvDoctors.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvDoctors.Columns[1].HeaderText = "Full Name";
                dgvDoctors.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvDoctors.Columns[2].HeaderText = "Department Name";
                dgvDoctors.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvDoctors.Columns[3].HeaderText = "License Number";
                dgvDoctors.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvDoctors.Columns[4].HeaderText = "Specialization";
                dgvDoctors.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvDoctors.Columns[5].HeaderText = "Years Exp.";
                dgvDoctors.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvDoctors.Columns[6].HeaderText = "Hire Date";
                dgvDoctors.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvDoctors.Columns[7].HeaderText = "End Date";
                dgvDoctors.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvDoctors.Columns[8].HeaderText = "Doctor Status";
                dgvDoctors.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvDoctors.Columns[9].HeaderText = "Consultation Fee";
                dgvDoctors.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvDoctors.ClearSelection();
            }

            lblRecordsValue.Text = dgvDoctors.Rows.Count.ToString();
        }
        private void frmDoctorsManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
            cbFilter.SelectedIndex = 0;
        }
        private void frmDoctorsManagement_Shown(object sender, EventArgs e)
        {
            dgvDoctors.ClearSelection();

        }
        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dtDoctors != null)
                dtDoctors.DefaultView.RowFilter = "";

            lblRecordsValue.Text = dgvDoctors.Rows.Count.ToString();

            if(cbFilter.Text == "None")
            {
                txtSearch.Visible = false;
                cbStatus.Visible = false;
                return;
            }
            if(cbFilter.Text == "Status")
            {
                txtSearch.Visible = false;
                cbStatus.Visible = true;
            }
            else
            {
                txtSearch.Visible = true;
                cbStatus.Visible = false;
            }


        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dtDoctors.DefaultView.RowFilter = "";
                lblRecordsValue.Text = dgvDoctors.Rows.Count.ToString();
                return;
            }

            string Column = cbFilter.Text.Replace(" ", "");

            if(cbFilter.Text == "Doctor ID" || cbFilter.Text == "License Number")
            {
                dtDoctors.DefaultView.RowFilter = string.Format("[{0}] = {1}", Column, txtSearch.Text.Trim());
            }
            else
            {
                dtDoctors.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", Column, txtSearch.Text.Trim());
            }

            lblRecordsValue.Text = dgvDoctors.Rows.Count.ToString();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text == "License Number" || cbFilter.Text == "Doctor ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtDoctors.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "Status", cbStatus.Text);
            lblRecordsValue.Text = dgvDoctors.Rows.Count.ToString();
        }
        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            frmAddEditDoctor frmAddEditDoctor = new frmAddEditDoctor();
            frmAddEditDoctor.ShowDialog();
            _LoadData();
        }

        private void tsmiEditDoctorInfo_Click(object sender, EventArgs e)
        {
            short DoctorID = (short)dgvDoctors.CurrentRow.Cells[0].Value;
            frmAddEditDoctor frmAddEditDoctor = new frmAddEditDoctor(DoctorID);
            frmAddEditDoctor.ShowDialog();
            _LoadData();
        }

        private void tsmiShowDoctorInfo_Click(object sender, EventArgs e)
        {
            short DoctorID = (short)dgvDoctors.CurrentRow.Cells[0].Value;
            frmDoctorInfo frmDoctorInfo = new frmDoctorInfo(DoctorID);
            frmDoctorInfo.ShowDialog();
        }

        private void tsmiShowDoctorUserInfo_Click(object sender, EventArgs e)
        {
            short DoctorID = (short)dgvDoctors.CurrentRow.Cells[0].Value;
            clsDoctor Doctor = clsDoctor.Find(DoctorID);
            frmUserInfo frmUserInfo = new frmUserInfo(Doctor.DoctorUserID);
            frmUserInfo.ShowDialog();
        }

        private void tsmiShowDoctorPersonalInfo_Click(object sender, EventArgs e)
        {
            short DoctorID = (short)dgvDoctors.CurrentRow.Cells[0].Value;
            clsDoctor Doctor = clsDoctor.Find(DoctorID);
            frmPersonInfo frmPersonInfo = new frmPersonInfo((int)Doctor.PersonID);
            frmPersonInfo.ShowDialog();
        }

        private void tsmiAddNewDoctor_Click(object sender, EventArgs e)
        {
            frmAddEditDoctor frmAddEditDoctor = new frmAddEditDoctor();
            frmAddEditDoctor.ShowDialog();
            _LoadData();
        }

    }
}
