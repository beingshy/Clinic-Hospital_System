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
using UI.Doctor;
using UI.MedicalRecord;
using UI.Patient;

namespace UI.Appointments
{
    public partial class frmAppointmentsManagement : Form
    {
        enum enPagingStyle { Original, WithName }
        enPagingStyle _CurrentPagingStyle;
        DataTable dtAppointments = null;
        short _PageSize;
        short _PageNumber;
        int _Records;
        public frmAppointmentsManagement()
        {
            InitializeComponent();
            _CurrentPagingStyle = enPagingStyle.Original;
            _PageNumber = 1;
            _PageSize = 14;
        }
        private void _LoadDataTable()
        {
            dtAppointments = clsAppointment.GetAllAppointments(_PageNumber, _PageSize, ref _Records);
        }
        private void _LoadToDataGridView()
        {
            dgvAppointments.DataSource = dtAppointments;

            if(dgvAppointments.Rows.Count > 0)
            {
                dgvAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvAppointments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                dgvAppointments.Columns[1].HeaderText = "Patient ID";
                dgvAppointments.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvAppointments.Columns[2].HeaderText = "Patient Name";
                dgvAppointments.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                dgvAppointments.Columns[3].HeaderText = "Doctor ID";
                dgvAppointments.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvAppointments.Columns[4].HeaderText = "Appointment Date";
                dgvAppointments.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvAppointments.Columns[5].HeaderText = "Status";
                dgvAppointments.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvAppointments.Columns[6].HeaderText = "Is Paid";
                dgvAppointments.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvAppointments.Columns[7].HeaderText = "Payment ID";
                dgvAppointments.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvAppointments.ClearSelection();
            }
            lblOfTotalPagesAndRows.Text = $"of {Math.Ceiling((decimal)_Records / _PageSize).ToString("N0")} pages ({_Records.ToString("N0")} Appointments)";

        }
        private void frmAppointmentsManagement_Load(object sender, EventArgs e)
        {
            _LoadDataTable();
            _LoadToDataGridView();
            cbFilter.SelectedIndex = 0;
        }
        private void frmAppointmentsManagement_Shown(object sender, EventArgs e)
        {
            dgvAppointments.ClearSelection();

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
            if(cbFilter.Text == "App. ID" || cbFilter.Text == "Patient ID" || cbFilter.Text == "Doctor ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            frmAddEditAppointment frmAddEditAppointment = new frmAddEditAppointment();
            frmAddEditAppointment.ShowDialog();
            _LoadDataTable();
            _LoadToDataGridView();
        }
        private void tsmiEditAppointmentInfo_Click(object sender, EventArgs e)
        {
            int AppointmentId = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            frmAddEditAppointment frmAddEditAppointment = new frmAddEditAppointment(AppointmentId);
            frmAddEditAppointment.ShowDialog();
            _LoadDataTable();
            _LoadToDataGridView();
        }
        private void tsmiShowDoctorInfo_Click(object sender, EventArgs e)
        {
            int AppointmentId = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            frmAppointmentInfo frmAppointmentInfo = new frmAppointmentInfo(AppointmentId);
            frmAppointmentInfo.ShowDialog();
        }
        private void tsmiPatientMedicalRecords_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvAppointments.CurrentRow.Cells[1].Value;
            frmPatientMedicalRecords frm = new frmPatientMedicalRecords(PatientID);
            frm.ShowDialog();
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if(dtAppointments.Rows.Count < _PageSize)
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
                dtAppointments = clsAppointment.GetAppointmentWithName(_PageNumber, _PageSize, ref _Records, txtSearch.Text.Trim());
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
                dtAppointments = clsAppointment.GetAppointmentWithName(_PageNumber, _PageSize, ref _Records, txtSearch.Text.Trim());
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
                case "Patient ID":
                    int PatientID = Int32.Parse(txtSearch.Text.Trim());
                    dtAppointments = clsAppointment.GetAppointmentsWithPatientID(_PageNumber, _PageSize, ref _Records, PatientID);
                    _LoadToDataGridView();
                    btnCancel.Visible = true;
                    break;
                case "Appointment ID":
                    int AppointmentID = Int32.Parse(txtSearch.Text.Trim());
                    dtAppointments = clsAppointment.GetAppointmentWithAppointmentID(AppointmentID);
                    _LoadToDataGridView();
                    btnCancel.Visible = true;
                    _CancelPagination();
                    break;
                case "Patient Name":
                    _CurrentPagingStyle = enPagingStyle.WithName;
                    string Name = txtSearch.Text.Trim();
                    dtAppointments = clsAppointment.GetAppointmentWithName(_PageNumber, _PageSize, ref _Records, Name);
                    lblOfTotalPagesAndRows.Text = $"of {Math.Ceiling((decimal)_Records / _PageSize)} pages ({_Records} Appointment)";
                    _LoadToDataGridView();
                    btnCancel.Visible = true;
                    break;
                case "Doctor ID":
                    int DoctorID = Int32.Parse(txtSearch.Text.Trim());
                    dtAppointments = clsAppointment.GetAppointmentsWithDoctorID(_PageNumber, _PageSize, ref _Records, DoctorID);
                    _LoadToDataGridView();
                    btnCancel.Visible = true;
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

        private void tsmiPatientInfo_Click(object sender, EventArgs e)
        {
            int PatinetID = (int)dgvAppointments.CurrentRow.Cells[1].Value;
            frmPatientInfo frmPatientInfo = new frmPatientInfo(PatinetID);
            frmPatientInfo.ShowDialog();
        }

        private void tsmkDoctorInfo_Click(object sender, EventArgs e)
        {
            short DoctorID = (short)dgvAppointments.CurrentRow.Cells[3].Value;
            frmDoctorInfo frmDoctorInfo = new frmDoctorInfo(DoctorID);
            frmDoctorInfo.ShowDialog();
        }

        private void tsmiCallPatient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet.", "Feature Not Available",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void tsmiAddNewAppointment_Click(object sender, EventArgs e)
        {
            frmAddEditAppointment frmAddEditAppointment = new frmAddEditAppointment();
            frmAddEditAppointment.ShowDialog();
            _LoadDataTable();
            _LoadToDataGridView();
        }


    }
}
