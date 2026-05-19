using ClinicManagementDB_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI.People
{
    public partial class frmPeopleManagement : Form
    {
        enum enPagingStyle { Original, WithName }
        enPagingStyle _CurrentPagingStyle;
        DataTable dtPeople = null;
        short _PageSize;
        short _PageNumber;
        int _Records;
        public frmPeopleManagement()
        {
            InitializeComponent();
            _PageNumber = 1;
            _PageSize = 14;
        }
        private void _LoadDataTable()
        {
            dtPeople = clsPerson.GetPeople(_PageNumber, _PageSize, ref _Records);
        }
        private void _LoadToDataGridView()
        {
            dgvPeople.DataSource = dtPeople;

            if(dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPeople.Columns[1].HeaderText = "Full Name";
                dgvPeople.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvPeople.Columns[2].HeaderText = "National ID";
                dgvPeople.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPeople.Columns[3].HeaderText = "Birth Date";
                dgvPeople.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPeople.Columns[4].HeaderText = "Gender";
                dgvPeople.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPeople.Columns[5].HeaderText = "Phone";
                dgvPeople.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPeople.Columns[6].HeaderText = "Email";
                dgvPeople.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvPeople.Columns[7].HeaderText = "Country Name";
                dgvPeople.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPeople.Columns[8].HeaderText = "Created By";
                dgvPeople.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPeople.ClearSelection();
            }
            lblOfTotalPagesAndRows.Text = $"of {Math.Ceiling((decimal)_Records / _PageSize).ToString("N0")} pages ({_Records.ToString("N0")} People)";
        }
        private void frmPeopleManagement_Load(object sender, EventArgs e)
        {
            _LoadDataTable();
            _LoadToDataGridView();
            cbFilter.SelectedIndex = 0;
        }
        private void frmPeopleManagement_Shown(object sender, EventArgs e)
        {
            dgvPeople.ClearSelection();

        }
        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = (cbFilter.Text != "None");
            btnFind.Visible = (cbFilter.Text != "None");
            if(txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text == "Person ID" || cbFilter.Text == "National ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
            _LoadDataTable();
            _LoadToDataGridView();
        }
        private void tsmPersonalInformation_Click(object sender, EventArgs e)
        {
            frmPersonInfo frmPersonInfo = new frmPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            frmPersonInfo.ShowDialog();
        }
        private void tsmEditPersonalInformation_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frmAddEditPerson.ShowDialog();
            _LoadDataTable();
            _LoadToDataGridView();
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if(dtPeople.Rows.Count < _PageSize)
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
                dtPeople = clsPerson.GetPeopleWithName(_PageNumber, _PageSize, ref _Records, txtSearch.Text.Trim());
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
                dtPeople = clsPerson.GetPeopleWithName(_PageNumber, _PageSize, ref _Records, txtSearch.Text.Trim());
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
                    dtPeople = clsPerson.GetPersonWithPersonID(PersonID);
                    _LoadToDataGridView();
                    btnCancel.Visible = true;
                    _CancelPagination();
                    break;
                case "Full Name":
                    _CurrentPagingStyle = enPagingStyle.WithName;
                    string Name = txtSearch.Text.Trim();
                    dtPeople = clsPerson.GetPeopleWithName(_PageNumber, _PageSize, ref _Records, Name);
                    lblOfTotalPagesAndRows.Text = $"of {Math.Ceiling((decimal)_Records / _PageSize)} pages ({_Records} Person)";
                    _LoadToDataGridView();
                    btnCancel.Visible = true;
                    break;
                case "National ID":
                    string NationalID = txtSearch.Text.Trim();
                    dtPeople = clsPerson.GetPersonWithNationalID(NationalID);
                    lblOfTotalPagesAndRows.Text = $"of {Math.Ceiling((decimal)_Records / _PageSize)} pages ({_Records} Person)";
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
            txtSearch.Text = string.Empty;
            btnCancel.Visible = false;
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
        private void tsmiAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
            _LoadDataTable();
            _LoadToDataGridView();
        }
    }
}
