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

namespace UI.Appointments
{
    public partial class frmAppointmentInfo : Form
    {
        clsAppointment _Appointment;
        public frmAppointmentInfo(int AppointmentID)
        {
            InitializeComponent();
            _Appointment = clsAppointment.Find(AppointmentID);
        }

        private void frmAppointmentInfo_Load(object sender, EventArgs e)
        {
            ctrlSmallAppointmentInfo1.SetAppointmentID((int)_Appointment.AppointmentID);
            ctrlSmallDoctorInfo1.SetDoctorID(_Appointment.DoctorID);
            ctrlSmallPatientInfo1.SetPatientID(_Appointment.PatientID);

        }
    }
}
