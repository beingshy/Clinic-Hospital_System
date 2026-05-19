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
using UI.People;
using UI.Users;

namespace UI.Doctor.Controls
{
    public partial class ctrlDoctorInfo : UserControl
    {
        clsDoctor _Doctor;
        public ctrlDoctorInfo()
        {
            InitializeComponent();
        }
        public void SetDoctorID(short DoctorUD)
        {
            _Doctor = clsDoctor.Find(DoctorUD);

            if(_Doctor == null)
            {
                ResetValues();
                return;
            }
            _LoadData();
        }
        public void ResetValues()
        {
            string NotExistValue = "[????]";
            lblDoctorID.Text = NotExistValue;
            lblLicenseNumber.Text = NotExistValue;
            lblYearsOfExperience.Text = NotExistValue;
            lblConsultationFee.Text = NotExistValue;
            lblDoctorUsername.Text = NotExistValue;
            lblPersonID.Text = NotExistValue;
            lblDepartment.Text = NotExistValue;
            lblSpecialization.Text = NotExistValue;
            lblDoctorStatus.Text = NotExistValue;
            lblHireDate.Text = NotExistValue;
            lblEndDate.Text = NotExistValue;
            lblCreatedByAt.Text = "Created By [??] At [??]";
            lblUpdatedByAt.Text = "Last Update By [??] At [??] ";
        }
        private void _LoadData()
        {
            lblDoctorID.Text = _Doctor.DoctorID.ToString();
            lblLicenseNumber.Text = _Doctor.LicenseNumber;
            lblYearsOfExperience.Text = _Doctor.YearsOfExperience.ToString();

            if(_Doctor.ConsultationFee != null)
            {
                decimal ConsultationFee = (decimal)_Doctor.ConsultationFee;
                lblConsultationFee.Text = ConsultationFee.ToString("F2");
            }
            else
            {
                lblConsultationFee.Text = "N/A";
            }


            lblDoctorUsername.Text = _Doctor.DoctorUser.Username;
            lblPersonID.Text = _Doctor.PersonID.ToString();
            lblDepartment.Text = _Doctor.Department.DepartmentName;
            lblSpecialization.Text = _Doctor.Specialization;
            lblDoctorStatus.Text = _Doctor.DoctorStatusString;
            lblHireDate.Text = _Doctor.HireDate.ToShortDateString();

            if(_Doctor.EndDate != null)
            {
                DateTime EndDate = (DateTime)_Doctor.EndDate;
                lblEndDate.Text = EndDate.ToShortDateString();
            }
            else
            {
                lblEndDate.Text = "N/A";
            }

            lblCreatedByAt.Text = $"Created By {clsUser.GetUsernameByID(_Doctor.CreatedByUserID)} At {_Doctor.CreatedAt.ToString("d MMM yyyy")}";
            if(_Doctor.UpdatedByUserID != null && _Doctor.UpdatedAt != null)
                lblUpdatedByAt.Text = $"Last Update By {clsUser.GetUsernameByID(_Doctor.UpdatedByUserID)} At {_Doctor.UpdatedAt.Value.ToString("d MMM yyyy")}";
            else
                lblUpdatedByAt.Visible = false;
        }
        private void lblDoctorUsername_Click(object sender, EventArgs e)
        {
            frmUserInfo frmUserInfo = new frmUserInfo(_Doctor.DoctorUserID);
            frmUserInfo.ShowDialog();
        }
        private void lblPersonID_Click(object sender, EventArgs e)
        {
            frmPersonInfo frmPersonInfo = new frmPersonInfo((int)_Doctor.PersonID);
            frmPersonInfo.ShowDialog();
        }
    }
}
