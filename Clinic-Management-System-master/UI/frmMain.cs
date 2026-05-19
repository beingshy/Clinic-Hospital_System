using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Appointments;
using UI.Departments;
using UI.Doctor;
using UI.Global;
using UI.Patient;
using UI.People;
using UI.Receptionist;
using UI.Users;
using UI.Payment;
using UI.Dashboard;

namespace UI
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public partial class frmMain : Form
    {
        public delegate void FormClose();
        public event FormClose OnFormClose;
        private void LoadForm(Form frm)
        {
            pnlMain.Controls.Clear();

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(frm);
            pnlMain.Tag = frm;
            frm.Show();
        }
        public frmMain()
        {
            InitializeComponent();

        }

        private void _ShowNotImplementedFeatureMessage(object sender, EventArgs e)
        {

        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            LoadForm(new frmPeopleManagement());
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            LoadForm(new frmDepartmentsManagement());

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUsersManagement());
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFormClose?.Invoke();
            clsGlobal.CurrentUser = null;
            clsGlobal.CurrentLoginHistory.LogoutTime = DateTime.Now;
            clsGlobal.CurrentLoginHistory.Save();
            clsGlobal.CurrentLoginHistory = null;
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            LoadForm(new frmPatientsManagement());
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            LoadForm(new frmDoctorsManagement());
        }

        private void btnReceptionists_Click(object sender, EventArgs e)
        {
            LoadForm(new frmReceptionistManagement());
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            LoadForm(new frmAppointmentsManagement());

        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            LoadForm(new frmPaymentsManagement());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new frmDashboard());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"@{clsGlobal.CurrentUser.Username}";
            LoadForm(new frmDashboard());
        }
    }
}
