using ClinicManagementDB_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Global;
using UI.MedicalRecord;
using UI.Patient.Controls;
using UI.Payment;

namespace UI.Appointments
{
    public partial class frmAddEditAppointment : Form
    {
        enum enMode { Add, Edit }
        enMode _FormMode;
        clsAppointment _Appointment;
        public frmAddEditAppointment()
        {
            InitializeComponent();
            _FormMode = enMode.Add;
            this.Text = "Add New APPOINTMENT";
            lblHeader.Text = "ADD APPOINTMENT";
            _Appointment = new clsAppointment();
        }
        public frmAddEditAppointment(int AppointmentID)
        {
            InitializeComponent();
            _FormMode = enMode.Edit;
            this.Text = "Edit APPOINTMENT";
            lblHeader.Text = "EDIT APPOINTMENT";
            _Appointment = clsAppointment.Find(AppointmentID);
        }
        private void frmAddOrUpdateAppointment_Load(object sender, EventArgs e)
        {
            _SetConstraints();
            _LoadData();
        }

        private void _LoadData()
        {
            if(_Appointment.AppointmentID == null)
                return;

            ctrlctrlSmallDoctorFinder1.SetDoctorID(_Appointment.DoctorID);
            ctrlctrlSmallDoctorFinder1.DisableSearch = true;

            ctrlSmallPatientFinder1.SetPatientID(_Appointment.PatientID);
            ctrlSmallPatientFinder1.DisableSearch = true;

            dtpAppointmentDate.Value = _Appointment.AppointmentDate;
            dtpAppointmentTime.Value = _Appointment.AppointmentDate;
            txtAppointmentStatus.Text = _Appointment.AppointmentStatusString;

            if(_Appointment.IsPaid)
            {
                btnPay.Visible = false;
                lblPaymentID.Visible = true;
                lblPaymentID.Text = _Appointment.PaymentID?.ToString();
            }
            else
            {
                btnPay.Visible = true;
                lblPaymentID.Visible = false;
            }

            if(_Appointment.HasMedicalRecord())
            {
                btnAdd.Visible = false;
                lblMedicalRecordID.Visible = true;
                lblMedicalRecordID.Text = _Appointment.GetMedicalRecordID()?.ToString();
            }
            else
            {
                btnAdd.Visible = true;
                lblMedicalRecordID.Visible = false;
            }
        }
        private void _Save()
        {

            if(!_CheckConstrint())
                return;

            TimeSpan TimePart = dtpAppointmentTime.Value.TimeOfDay;
            DateTime DatePart = dtpAppointmentDate.Value.Date;

            DateTime AppointmentDate = DatePart.Add(TimePart);

            _Appointment.AppointmentDate = AppointmentDate;
            _Appointment.AppointmentStatus = 1;
            _Appointment.PatientID = (int)ctrlSmallPatientFinder1.SelectedPatient.PatientID;
            _Appointment.DoctorID = (short)ctrlctrlSmallDoctorFinder1.SelectedDoctor.DoctorID;

            if(_FormMode == enMode.Add)
            {
                _Appointment.CreatedByUserID = (short)clsGlobal.CurrentUser.UserID;
                _Appointment.CreatedAt = DateTime.Now;
            }
            else
            {
                _Appointment.UpdatedByUserID = (short)clsGlobal.CurrentUser.UserID;
                _Appointment.UpdatedAt = DateTime.Now;
            }

            if(MessageBox.Show("Are you sure you want to save this Appointment?", "Confirm Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(_Appointment.Save())
                {
                    MessageBox.Show("Appointment saved successfully.", "Save Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _FormMode = enMode.Edit;
                    this.Text = "Edit Appointment";
                    lblHeader.Text = "EDIT Appointment";
                    txtAppointmentStatus.Text = _Appointment.AppointmentStatusString;
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the Appointment. Please try again.",
                        "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool _CheckConstrint()
        {
            TimeSpan TimePart = dtpAppointmentTime.Value.TimeOfDay;
            DateTime DatePart = dtpAppointmentDate.Value.Date;
            DateTime AppointmentDate = DatePart.Add(TimePart);

            TimeSpan StartTime = new TimeSpan(8, 0, 0);
            TimeSpan EndTime = new TimeSpan(16, 0, 0);

            if(!ctrlctrlSmallDoctorFinder1.SelectedDoctor.IsDoctorAvailable(AppointmentDate)
                && _Appointment.AppointmentDate != AppointmentDate)
            {
                MessageBox.Show("The doctor is not available at the selected time.");
                return false;
            }

            if(!(TimePart <= EndTime && TimePart >= StartTime) && _FormMode == enMode.Add)
            {
                Console.WriteLine("Invalid appointment time! Must be between 8 AM and 4 PM.");
                return false;
            }

            if(ctrlSmallPatientFinder1.SelectedPatient == null)
            {
                MessageBox.Show("Please select a patient.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(ctrlctrlSmallDoctorFinder1.SelectedDoctor == null)
            {
                MessageBox.Show("Please select a doctor.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void _SetConstraints()
        {
            dtpAppointmentDate.MaxDate = DateTime.Now.AddMonths(14);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            frmPayfees frm = new frmPayfees((int)_Appointment.AppointmentID);
            frm.OnPayProcessed += OnPayProcessed;
            frm.ShowDialog();
        }

        private void OnPayProcessed(int PaymentID)
        {
            lblPaymentID.Text = PaymentID.ToString();
            lblPaymentID.Visible = true;
            btnPay.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddMedicalRecord frmAddMedicalRecord = new frmAddMedicalRecord((int)_Appointment.AppointmentID);
            frmAddMedicalRecord.OnMedicalRecordAdded += OnMedicalRecordAdded;
            frmAddMedicalRecord.ShowDialog();
        }
        private void OnMedicalRecordAdded(int MedicalRecordID)
        {
            btnAdd.Visible = false;
            lblMedicalRecordID.Visible = true;
            lblMedicalRecordID.Text = MedicalRecordID.ToString();
        }

        private void lblMedicalRecordID_Click(object sender, EventArgs e)
        {

            if(Int32.TryParse(lblMedicalRecordID.Text, out int MedicalRecordID))
            {
                frmMedicalRecordInfo frm = new frmMedicalRecordInfo(MedicalRecordID);
                frm.ShowDialog();
            }

        }

    }
}
