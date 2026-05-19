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

namespace UI.MedicalRecord
{
    public partial class frmPatientMedicalRecords : Form
    {
        DataTable dtMedicalRecords = null;
        clsPatient _Patient;
        public frmPatientMedicalRecords(int PatientID)
        {
            _Patient = clsPatient.Find(PatientID);
            InitializeComponent();
        }
        private void _LoadData()
        {
            if(_Patient == null)
                return;

            dtMedicalRecords = clsMedicalRecord.GetPatientMedicalRecords((int)_Patient.PatientID);
            dgvMedicalRecords.DataSource = dtMedicalRecords;

            if(dgvMedicalRecords.Rows.Count > 0)
            {
                dgvMedicalRecords.Columns[0].HeaderText = "Med. Record ID";
                dgvMedicalRecords.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvMedicalRecords.Columns[1].HeaderText = "App. ID";
                dgvMedicalRecords.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvMedicalRecords.Columns[2].HeaderText = "Diagnosis";
                dgvMedicalRecords.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvMedicalRecords.Columns[3].HeaderText = "Prescription";
                dgvMedicalRecords.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvMedicalRecords.Columns[4].HeaderText = "Notes";
                dgvMedicalRecords.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvMedicalRecords.Columns[5].HeaderText = "Created By";
                dgvMedicalRecords.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvMedicalRecords.Columns[6].HeaderText = "Created At";
                dgvMedicalRecords.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            lblRecordsValue.Text = dgvMedicalRecords.Rows.Count.ToString();
        }

        private void frmPatientMedicalRecords_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void tsmiMedicalRecordInfo_Click(object sender, EventArgs e)
        {
            int _MedicalRecordID = (int)dgvMedicalRecords.CurrentRow.Cells[0].Value;
            frmMedicalRecordInfo frm = new frmMedicalRecordInfo(_MedicalRecordID);
            frm.ShowDialog();
        }

        private void frmPatientMedicalRecords_Shown(object sender, EventArgs e)
        {
            dgvMedicalRecords.ClearSelection();
        }
    }
}
