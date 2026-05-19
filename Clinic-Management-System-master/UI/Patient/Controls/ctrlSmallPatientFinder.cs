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

namespace UI.Patient.Controls
{
    public partial class ctrlSmallPatientFinder : UserControl
    {
        public ctrlSmallPatientFinder()
        {
            InitializeComponent();
        }
        public clsPatient SelectedPatient { get { return ctrlSmallPatientInfo1.SelectedPatient; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool DisableSearch
        {
            set
            {
                txtSearchByPatienID.Enabled = !value;
                btnSearch.Enabled = !value;
            }
        }
        private void PreventNonDigitInput(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if(!(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int PatientID = Int32.Parse(txtSearchByPatienID.Text);
            if(clsPatient.DoesPatientExist(PatientID))
            {
                ctrlSmallPatientInfo1.SetPatientID(PatientID);
            }
            else
            {
                MessageBox.Show("Patient with the specified ID does not exist.", "Not Found",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ctrlSmallPatientInfo1.ResetText();
                return;
            }
        }
        public void SetPatientID(int PatientID)
        {
            txtSearchByPatienID.Text = PatientID.ToString();
            ctrlSmallPatientInfo1.SetPatientID(PatientID);

        }
    }
}
