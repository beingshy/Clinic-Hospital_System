using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Patient
{
    public partial class frmPatientInfo : Form
    {
        int _PatientID;
        public frmPatientInfo(int PatientID)
        {
            InitializeComponent();
            _PatientID = PatientID;
        }

        private void frmPatientInfo_Load(object sender, EventArgs e)
        {
            ctrlPatientInfo1.SetPatientID(_PatientID);
        }
    }
}
