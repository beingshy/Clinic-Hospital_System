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
using static ClinicManagementDB_Business.clsPayment;

namespace UI.Payment
{
    public partial class frmPaymentsManagement : Form
    {
        DataTable dtPayments = null;
        short _PageSize;
        short _PageNumber;
        int _Records;
        public frmPaymentsManagement()
        {
            InitializeComponent();
            _PageNumber = 1;
            _PageSize = 14;
        }
        private void _LoadData()
        {
            dtPayments = clsPayment.GetPayments(_PageNumber, _PageSize, ref _Records);
            dgvPayments.DataSource = dtPayments;

            if(dgvPayments.Rows.Count > 0)
            {
                dgvPayments.Columns[0].HeaderText = "Payment ID";
                dgvPayments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPayments.Columns[1].HeaderText = "Patient ID";
                dgvPayments.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPayments.Columns[2].HeaderText = "Full Name";
                dgvPayments.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvPayments.Columns[3].HeaderText = "Amount";
                dgvPayments.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPayments.Columns[4].HeaderText = "Method";
                dgvPayments.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPayments.Columns[5].HeaderText = "Payment Date";
                dgvPayments.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvPayments.Columns[6].HeaderText = "Created By";
                dgvPayments.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
                dgvPayments.ClearSelection();
            }
            lblOfTotalPagesAndRows.Text = $"of {Math.Ceiling((decimal)_Records / _PageSize).ToString("N0")} pages ({_Records.ToString("N0")} Payments)";
        }
        private async Task _LoadStatisticsAsync()
        {
            var totalPaymentsAmountTask = clsPayment.GetTotalPaymentsAmountAsync();
            var averageAmountPerPaymentTask = clsPayment.GetAverageAmountPerPaymentAsync();
            var totalPaymentsTask = clsPayment.GetTotalPaymentsAsync();
            var mostUsedPaymentMethodTask = clsPayment.GetMostUsedPaymentMethodAsync();

            await Task.WhenAll(totalPaymentsAmountTask, averageAmountPerPaymentTask, totalPaymentsTask, mostUsedPaymentMethodTask);

            lblTotalPaymentsAmountValue.Text = totalPaymentsAmountTask.Result.ToString("N0");
            lblTotalPaymentsAmountValue.Visible = true;
            pbRiyalSymbol1.Visible = true;
            lblTotalPaymentsAmount.Visible = true;

            lblAverageAmountPerPaymentValue.Text = averageAmountPerPaymentTask.Result.ToString("F2");
            lblAverageAmountPerPaymentValue.Visible = true;
            pbRiyalSymbol2.Visible = true;
            lblAverageAmountPerPayment.Visible = true;

            lblTotalPaymentsValue.Text = totalPaymentsTask.Result.ToString();
            lblTotalPaymentsValue.Visible = true;
            lblTotalPayments.Visible = true;

            lblMostUsedPaymentMethodValue.Text = mostUsedPaymentMethodTask.Result;
            lblMostUsedPaymentMethodValue.Visible = true;
            lblIsMostUsedPaymentMethod.Visible = true;
        }
        private void frmPaymentsManagement_Load(object sender, EventArgs e)
        {
            _ = _LoadStatisticsAsync();
            _LoadData();
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if(dtPayments.Rows.Count < _PageSize)
                return;

            _PageNumber++;
            txtPageNumber.Text = _PageNumber.ToString();

            _LoadData();

        }
        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if(_PageNumber <= 1)
                return;

            _PageNumber--;
            txtPageNumber.Text = _PageNumber.ToString();

            _LoadData();

        }

        private void frmPaymentsManagement_Shown(object sender, EventArgs e)
        {
            dgvPayments.ClearSelection();
        }
    }
}
