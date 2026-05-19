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

namespace UI.Doctor.Controls
{
    public partial class ctrlSmallDoctorInfo : UserControl
    {
        public ctrlSmallDoctorInfo()
        {
            InitializeComponent();
        }

        short? _DoctorID;
        clsDoctor _Doctor;
        public clsDoctor SelectedDoctor { get { return _Doctor; } }
        public void SetDoctorID(short DoctorID)
        {
            _DoctorID = DoctorID;
            _Doctor = clsDoctor.Find(_DoctorID);
            if(_Doctor != null)
                _LoadData();
        }
        public void ResetValues()
        {
            if(_Doctor == null) return;

            _DoctorID = null;
            _Doctor = null;

            lblDoctorID.Text = "[????]";
            lblFullname.Text = "[????]";
            lblExpYears.Text = "[????]";
            lblDepartment.Text = "[????]";
            lblSpecialization.Text = "[????]";
            lblConsultFee.Text = "[????]";
        }
        private void _LoadData()
        {
            lblDoctorID.Text = _Doctor.DoctorID.ToString();
            lblFullname.Text = _Doctor.PartialFullName;
            lblExpYears.Text = _Doctor.YearsOfExperience.ToString();
            lblDepartment.Text = _Doctor.Department.DepartmentName;
            lblSpecialization.Text = _Doctor.Specialization;

            if(_Doctor.ConsultationFee != null)
            {
                decimal ConsultationFee = (decimal)_Doctor.ConsultationFee;
                lblConsultFee.Text = ConsultationFee.ToString("F2");
            }
            else
            {
                lblConsultFee.Text = "[????]";
            }
        }
    }
}
