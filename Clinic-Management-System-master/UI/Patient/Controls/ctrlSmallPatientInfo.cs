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
using UI.People.Controls;

namespace UI.Patient.Controls
{
    public partial class ctrlSmallPatientInfo : UserControl
    {
        public ctrlSmallPatientInfo()
        {
            InitializeComponent();
        }
        int? _PatientID;
        clsPatient _Patient;
        public clsPatient SelectedPatient { get { return _Patient; } }
        public void SetPatientID(int PatientID)
        {
            _PatientID = PatientID;
            _Patient = clsPatient.Find(_PatientID);
            if(_Patient != null)
                _LoadData();
        }
        public void ResetValues()
        {
            if(_Patient == null) return;

            _PatientID = null;
            _Patient = null;

            lblPatientID.Text = "[????]";
            lblFullname.Text = "[????]";
            lblPhone.Text = "[????]";
            lblNationalID.Text = "[????]";
            lblGender.Text = "[????]";
            lblCountry.Text = "[????]";
        }
        private void _LoadData()
        {
            lblPatientID.Text = _Patient.PatientID.ToString();
            lblFullname.Text = _Patient.PartialFullName;
            lblPhone.Text = _Patient.Phone;
            lblNationalID.Text = _Patient.NationalID;
            lblGender.Text = _Patient.StringGender;
            lblCountry.Text = _Patient.CountryName;
        }
    }
}
