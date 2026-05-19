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
    public partial class ctrlSmallDoctorFinder : UserControl
    {
        public ctrlSmallDoctorFinder()
        {
            InitializeComponent();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool DisableSearch
        {
            set
            {
                txtSearchByDoctorID.Enabled = !value;
                btnSearch.Enabled = !value;
            }
        }
        public clsDoctor SelectedDoctor { get { return ctrlSmallDoctorInfo1.SelectedDoctor; } }
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
            short DoctorID = Int16.Parse(txtSearchByDoctorID.Text);
            if(clsDoctor.DoesDoctorExistByDoctorID(DoctorID))
            {
                ctrlSmallDoctorInfo1.SetDoctorID(DoctorID);
            }
            else
            {
                MessageBox.Show("Doctor with the specified ID does not exist.", "Not Found",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ctrlSmallDoctorInfo1.ResetText();
                return;
            }
        }

        public void SetDoctorID(short DoctorID)
        {
            txtSearchByDoctorID.Text = DoctorID.ToString();
            ctrlSmallDoctorInfo1.SetDoctorID(DoctorID);
        }

    }
}
