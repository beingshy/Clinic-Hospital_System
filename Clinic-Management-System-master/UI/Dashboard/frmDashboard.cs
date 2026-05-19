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
using UI.Global;

namespace UI.Dashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        private async void _LoadData()
        {
            var todayAppointmentsTask = clsAppointment.GetTodayAppointmentsCountAsync();
            var weeklyAppointmentsTask = clsAppointment.GetWeeklyAppointmentsCountAsync();
            var createdAppointmentsTask = clsAppointment.GetCreatedAppointmentsThisWeekCountAsync();
            var totalPatientsTask = clsPatient.GetTotalPatientsAsync();
            var newPatientsTask = clsPatient.GetNewPatientsThisWeekAsync();
            var averagePatientAgeTask = clsPatient.GetAveragePatientAgeAsync();
            var totalDoctorsTask = clsDoctor.GetTotalAvailableDoctorsAsync();
            var averageConsultationFeeTask = clsDoctor.GetAverageConsultationFeeAsync();
            var totalDepartmentsTask = clsDepartment.GetTotalDepartmentsAsync();

            await Task.WhenAll(
                todayAppointmentsTask,
                weeklyAppointmentsTask,
                createdAppointmentsTask,
                totalPatientsTask,
                newPatientsTask,
                averagePatientAgeTask,
                totalDoctorsTask,
                averageConsultationFeeTask,
                totalDepartmentsTask
            );

            lblTodayAppointments.Text = todayAppointmentsTask.Result.ToString();
            lblUpcomingAppointmentsThisWeek.Text = weeklyAppointmentsTask.Result.ToString();
            lblAppointmentCreatedThisWeek.Text = createdAppointmentsTask.Result.ToString();
            lblTotalPatients.Text = totalPatientsTask.Result.ToString();
            lblNewPatientsThisWeek.Text = newPatientsTask.Result.ToString();
            lblAveragePatientAge.Text = averagePatientAgeTask.Result.ToString();
            lblTotalAvailableDoctors.Text = totalDoctorsTask.Result.ToString();
            lblAverageConsultationFee.Text = averageConsultationFeeTask.Result.ToString("F2");
            lblTotalDepartments.Text = totalDepartmentsTask.Result.ToString();

            lblWelcomeName.Text = $"Welcome {clsGlobal.CurrentUser.Person.FirstName}...";
            lblUsername.Text = $"@{clsGlobal.CurrentUser.Username}";
            lblDate.Text = DateTime.Now.ToString("d MMM yyyy");
            lblTime.Text = DateTime.Now.ToString("t");
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
