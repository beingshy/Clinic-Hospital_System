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

namespace UI.Departments
{
    public partial class frmDepartmentsManagement : Form
    {
        public frmDepartmentsManagement()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            DataTable dt = clsDepartment.GetDepartments();
            dgvDepartments.DataSource = dt;

            if(dgvDepartments.Rows.Count > 0)
            {
                dgvDepartments.Columns[0].HeaderText = "Department ID";
                dgvDepartments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvDepartments.Columns[1].HeaderText = "Department Name";
                dgvDepartments.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvDepartments.Columns[2].HeaderText = "Description";
                dgvDepartments.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvDepartments.Columns[3].HeaderText = "Department Location";
                dgvDepartments.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvDepartments.Rows[0].Selected = true;
            }

            lblRecordsValue.Text = dgvDepartments.Rows.Count.ToString();

        }
        private async void _LoadStatistics(byte DepartmentID, string DepartmentName)
        {
            var totalDepartments = clsDepartment.GetTotalDepartmentsAsync();
            var totalDoctorsTask = clsDepartment.TotalDoctorsByDepartmentIDAsync(DepartmentID);
            var totalVisitsTask = clsDepartment.TotalVisitsByDepartmentIDAsync(DepartmentID);
            var totalRevenueTask = clsDepartment.TotalRevenueByDepartmentIDAsync(DepartmentID);

            await Task.WhenAll(totalDepartments, totalDoctorsTask, totalVisitsTask, totalRevenueTask);

            lblTotalDepartmentsValue.Text = totalDepartments.Result.ToString();
            lblTotalDepartments.Visible = true;
            lblTotalDepartmentsValue.Visible = true;


            lblTotalDoctorsValue.Text = totalDoctorsTask.Result.ToString();
            lblTotalDoctorsInDepartment.Text = $"Total Doctors in {DepartmentName} Department";
            lblTotalDoctorsInDepartment.Visible = true;
            lblTotalDoctorsValue.Visible = true;

            lblTotalVisitsValue.Text = totalVisitsTask.Result.ToString();
            lblTotalVisitOfDepartment.Text = $"Total Visits of {DepartmentName} Department";
            lblTotalVisitOfDepartment.Visible = true;
            lblTotalVisitsValue.Visible = true;

            lblTotalRevenueValue.Text = totalRevenueTask.Result.ToString("N0");
            lblTotalRevenueOfDepartment.Text = $"Total Revenue of {DepartmentName} Department";
            pbRiyalSymbol.Visible = true;
            lblTotalRevenueOfDepartment.Visible = true;
            lblTotalRevenueValue.Visible = true;
        }
        private void frmDepartmentsManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void dgvDepartments_SelectionChanged(object sender, EventArgs e)
        {
            byte DepartmentID = Convert.ToByte(dgvDepartments.CurrentRow.Cells[0].Value);
            string DepartmentName = (string)dgvDepartments.CurrentRow.Cells[1].Value;
            _LoadStatistics(DepartmentID, DepartmentName);
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            frmAddEditDepartment frmAdd = new frmAddEditDepartment();
            frmAdd.ShowDialog();
            _LoadData();
        }

        private void tsmiEditDepartment_Click(object sender, EventArgs e)
        {
            frmAddEditDepartment frmAdd = new frmAddEditDepartment(Convert.ToByte(dgvDepartments.CurrentRow.Cells[0].Value));
            frmAdd.ShowDialog();
            _LoadData();
        }

        private void tsmiAddNewDepartment_Click(object sender, EventArgs e)
        {
            frmAddEditDepartment frmAdd = new frmAddEditDepartment();
            frmAdd.ShowDialog();
            _LoadData();
        }
 
    }
}
