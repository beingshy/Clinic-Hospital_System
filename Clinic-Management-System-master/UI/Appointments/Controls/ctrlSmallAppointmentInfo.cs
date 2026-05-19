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

namespace UI.Appointments.Controls
{
    public partial class ctrlSmallAppointmentInfo : UserControl
    {

        clsAppointment _Appointment;
        public ctrlSmallAppointmentInfo()
        {
            InitializeComponent();
        }

        public void SetAppointmentID(int AppointmentID)
        {
            _Appointment = clsAppointment.Find(AppointmentID);

            if(_Appointment == null)
            {
                ResetValues();
                return;
            }
            _LoadData();
        }
        public void ResetValues()
        {
            string NotExistValue = "[????]";
            lblAppintmentID.Text = NotExistValue;
            lblAppointmentDate.Text = NotExistValue;
            lblAppointmentStatus.Text = NotExistValue;
            lblIsPaid.Text = NotExistValue;
            lblPaymentID.Text = NotExistValue;
            lblMedicalRecord.Text = NotExistValue;
            lblCreatedByAt.Text = "Created By [??] At [??]";
            lblUpdatedByAt.Text = "Last Update By [??] At [??] ";
        }
        private void _LoadData()
        {
            lblAppintmentID.Text = _Appointment.AppointmentID.ToString();
            lblAppointmentDate.Text = _Appointment.AppointmentDate.ToString("dd/MM/yyyy [H:mm]");
            lblAppointmentStatus.Text = _Appointment.AppointmentStatusString;
            lblIsPaid.Text = _Appointment.IsPaid ? "Yes" : "No";
            lblPaymentID.Text = _Appointment.PaymentID?.ToString() ?? "Not Paid";

            if(_Appointment.HasMedicalRecord())
                lblMedicalRecord.Text = _Appointment.GetMedicalRecordID().Value.ToString();
            else
                lblMedicalRecord.Text = "N/A";

            lblCreatedByAt.Text = $"Created By {clsUser.GetUsernameByID(_Appointment.CreatedByUserID)} At {_Appointment.CreatedAt.ToString("d MMM yyyy")}";
            if(_Appointment.UpdatedByUserID != null && _Appointment.UpdatedAt != null)
                lblUpdatedByAt.Text = $"Last Update By {clsUser.GetUsernameByID(_Appointment.UpdatedByUserID)} At {_Appointment.UpdatedAt.Value.ToString("d MMM yyyy")}";
            else
                lblUpdatedByAt.Visible = false;
        }
    }
}
