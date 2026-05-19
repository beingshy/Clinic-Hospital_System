using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.MedicalRecord
{
    public partial class frmMedicalRecordInfo : Form
    {
        int _MedicalRecordID;
        public frmMedicalRecordInfo(int MedicalRecordID)
        {
            _MedicalRecordID = MedicalRecordID;
            InitializeComponent();
        }

        private void frmMedicalRecordInfo_Load(object sender, EventArgs e)
        {
            ctrlMedicalRecordInfo1.SetMedicalRecordID(_MedicalRecordID);
        }
    }
}
