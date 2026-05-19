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
using UI.Global;

namespace UI.Payment
{
    public partial class frmPayfees : Form
    {
        public Action<int> OnPayProcessed;
        clsAppointment _Appointment;
        clsPayment _Payment;
        decimal _fees;
        public frmPayfees(int appointmentID)
        {
            InitializeComponent();
            _Appointment = clsAppointment.Find(appointmentID);
            _Payment = new clsPayment();
            _fees = (decimal)clsDoctor.Find(_Appointment.DoctorID).ConsultationFee;
        }

        private void _LoadData()
        {
            if(_Appointment.AppointmentID == null)
                return;

            txtFees.Text = _fees.ToString("F2");
            cbMethod.SelectedIndex = 0;
        }
        private void _Save()
        {

            switch(cbMethod.Text)
            {
                case "Cash":
                    _Payment.PaymentMethod = 1;
                    break;
                case "Debit Card":
                    _Payment.PaymentMethod = 2;
                    break;
                case "Bank Transfer":
                    _Payment.PaymentMethod = 3;
                    break;
                case "Mobile Payment":
                    _Payment.PaymentMethod = 4;
                    break;
            }
            _Payment.Amount = _fees;
            _Payment.PaymentDate = DateTime.Now;
            _Payment.CreatedByUserID = (short)clsGlobal.CurrentUser.UserID;
            _Payment.CreatedAt = DateTime.Now;



            if(MessageBox.Show($"Are you sure you want to pay {_Payment.Amount.ToString("F2")} SAR?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(_Payment.Save())
                {


                    MessageBox.Show("Payment has been successfully processed.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnPayProcessed?.Invoke((int)_Payment.PaymentID);

                    _Appointment.IsPaid = true;
                    _Appointment.PaymentID = _Payment.PaymentID;

                    if(!_Appointment.Save())
                        MessageBox.Show("An error occurred while saving appointment info.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred while processing the payment. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void frmPayfees_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            _Save();
        }
    }


}
