using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Receptionist
{
    public partial class frmReceptionistInfo : Form
    {
        public frmReceptionistInfo(short ReceptionistID)
        {
            InitializeComponent();
            ctrlReceptionistInfo1.SetReceptionistID(ReceptionistID);
        }
    }
}
