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
using UI.MedicalRecord;
using UI.People;

namespace UI.Patient
{
    public partial class frmPatientsManagement : Form
    {
        enum enPagingStyle { Original, WithName }
        enPagingStyle _CurrentPagingStyle;
        DataTable dtPatients = null;
        short _PageSize;
        short _PageNumber;
        int _Records;
        public frmPatientsManagement()
        {
            InitializeComponent();
            _CurrentPagingStyle = enPagingStyle.Original;
            _PageNumber = 1;
            _PageSize = 14;
        }
        private void _LoadDataTable()
        {
            dtPatients = clsPatient.GetAllPatients(_PageNumber, _PageSize, ref _Records);
        }
        private void _LoadToDataGridView()
        {
            dgvPatients.DataSource = dtPatients;

            if(dgvPatients.Rows.Count > 0)
            {
                dgvPatients.Columns[0].HeaderText = "Patient ID";
                dgvPatients.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvPatients.Columns[1].HeaderText = "Person ID";
                dgvPatients.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvPatients.Columns[2].HeaderText = "Full Name";
                dgvPatients.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvPatients.Columns[3].HeaderText = "National ID";
                dgvPatients.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvPatients.Columns[4].HeaderText = "Blood Type";
                dgvPatients.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvPatients.Columns[5].HeaderText = "Allergies";
                dgvPatients.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvPatients.Columns[6].HeaderText = "Medical History";
                dgvPatients.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvPatients.Columns[7].HeaderText = "E. Contact Name";
                dgvPatients.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvPatients.Columns[8].HeaderText = "E. Contact Phone";
                dgvPatients.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPatients.ClearSelection();
            }
            lblOfTotalPagesAndRows.Text = $"of {Math.Ceiling((decimal)_Records / _PageSize).ToString("N0")} pages ({_Records.ToString("N0")} Patients)";
        }
        private void frmPatientsManagement_Load(object sender, EventArgs e)
        {
            _LoadDataTable();
            _LoadToDataGridView();
            cbFilter.SelectedIndex = 0;
        }
        private void frmPatientsManagement_Shown(object sender, EventArgs e)
        {
            dgvPatients.ClearSelection();

        }
        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFind.Visible = (cbFilter.Text != "None");
            txtSearch.Visible = (cbFilter.Text != "None");

            if(txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }

        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text == "Person ID" || cbFilter.Text == "National ID"
              || cbFilter.Text == "Patient ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            frmAddEditPatient frmAddEditPatient = new frmAddEditPatient();
            frmAddEditPatient.ShowDialog();
            _LoadDataTable();
            _LoadToDataGridView();
        }
        private void tsmiEditPatientInfo_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;
            frmAddEditPatient frmAddEditPatient = new frmAddEditPatient(PatientID);
            frmAddEditPatient.ShowDialog();
            _LoadDataTable();
            _LoadToDataGridView();
        }
        private void tsmiShowPatientInfo_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;
            frmPatientInfo frmPatientInfo = new frmPatientInfo(PatientID);
            frmPatientInfo.ShowDialog();
        }
        private void tsmiPatientMedicalRecords_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;
            frmPatientMedicalRecords frm = new frmPatientMedicalRecords(PatientID);
            frm.ShowDialog();
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if(dtPatients.Rows.Count < _PageSize)
                return;

            _PageNumber++;
            txtPageNumber.Text = _PageNumber.ToString();

            if(_CurrentPagingStyle == enPagingStyle.Original)
            {
                _LoadDataTable();
                _LoadToDataGridView();
            }
            if(_CurrentPagingStyle == enPagingStyle.WithName)
            {
                dtPatients = clsPatient.GetPatientWithName(_PageNumber, _PageSize, ref _Records, txtSearch.Text.Trim());
                _LoadToDataGridView();
            }

        }
        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if(_PageNumber <= 1)
                return;

            _PageNumber--;
            txtPageNumber.Text = _PageNumber.ToString();

            if(_CurrentPagingStyle == enPagingStyle.Original)
            {
                _LoadDataTable();
                _LoadToDataGridView();
            }
            if(_CurrentPagingStyle == enPagingStyle.WithName)
            {
                dtPatients = clsPatient.GetPatientWithName(_PageNumber, _PageSize, ref _Records, txtSearch.Text.Trim());
                _LoadToDataGridView();
            }

        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtSearch.Text))
                return;

            _CurrentPagingStyle = enPagingStyle.Original;

            switch(cbFilter.Text)
            {
                case "None":
                    _LoadDataTable();
                    _LoadToDataGridView();
                    _AllowPagination();
                    break;
                case "Person ID":
                    int PersonID = Int32.Parse(txtSearch.Text.Trim());
                    dtPatients = clsPatient.GetPatientWithPersonID(PersonID);
                    _LoadToDataGridView();
                    btnCancel.Visible = true;
                    _CancelPagination();
                    break;
                case "Patient ID":
                    int PatientID = Int32.Parse(txtSearch.Text.Trim());
                    dtPatients = clsPatient.GetPatientWithPatientID(PatientID);
                    _LoadToDataGridView();
                    btnCancel.Visible = true;
                    _CancelPagination();
                    break;
                case "Full Name":
                    _CurrentPagingStyle = enPagingStyle.WithName;
                    string Name = txtSearch.Text.Trim();
                    dtPatients = clsPatient.GetPatientWithName(_PageNumber, _PageSize, ref _Records, Name);
                    lblOfTotalPagesAndRows.Text = $"of {Math.Ceiling((decimal)_Records / _PageSize)} pages ({_Records} Patient)";
                    _LoadToDataGridView();
                    btnCancel.Visible = true;
                    break;
                case "National ID":
                    string NationalID = txtSearch.Text.Trim();
                    dtPatients = clsPatient.GetPatientWithNationalID(NationalID);
                    lblOfTotalPagesAndRows.Text = $"of {Math.Ceiling((decimal)_Records / _PageSize)} pages ({_Records} Patient)";
                    _LoadToDataGridView();
                    btnCancel.Visible = true;
                    _CancelPagination();
                    break;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _LoadDataTable();
            _LoadToDataGridView();
            _AllowPagination();
            _PageNumber = 1;
            txtPageNumber.Text = _PageNumber.ToString();
            txtSearch.Text = string.Empty;
            btnCancel.Visible = false;
            btnFind.Visible = true;
        }
        private void _CancelPagination()
        {
            btnPreviousPage.Visible = false;
            btnNextPage.Visible = false;
            txtPageNumber.Visible = false;
            lblOfTotalPagesAndRows.Visible = false;
        }
        private void _AllowPagination()
        {
            btnPreviousPage.Visible = true;
            btnNextPage.Visible = true;
            txtPageNumber.Visible = true;
            lblOfTotalPagesAndRows.Visible = true;
        }

        private void tsmiCallPatientEmergencyPhone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet.", "Feature Not Available",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void tsmiAddNewPatient_Click(object sender, EventArgs e)
        {
            frmAddEditPatient frmAddEditPatient = new frmAddEditPatient();
            frmAddEditPatient.ShowDialog();
            _LoadDataTable();
            _LoadToDataGridView();
        }

    }
}
