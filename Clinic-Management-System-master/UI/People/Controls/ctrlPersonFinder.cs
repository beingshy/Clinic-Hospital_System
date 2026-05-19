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

namespace UI.People.Controls
{
    public partial class ctrlPersonFinder : UserControl
    {
        public Action<clsPerson> OnPersonSelected;
        clsPerson _Person;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool SearchEnabled
        {
            get
            {
                return txtPersonID.Enabled;
            }
            set
            {
                txtPersonID.Enabled = value;
            }
        }
        public ctrlPersonFinder()
        {
            InitializeComponent();
        }
        public void SetPersonID(int PersonID)
        {
            if(!clsPerson.DoesPersonExist(PersonID))
                return;

            ctrlPersonInfo1.SetPersonID(PersonID);
            txtPersonID.Text = PersonID.ToString();

        }
        private void PreventNonDigitInput(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if((textbox.Text.Length >= 10 || !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))))
            {
                e.Handled = true;
            }
        }
        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPersonID.Text.Trim()))
            {
                MessageBox.Show("The Person ID field is empty. Please enter a valid ID.",
                    "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int PersonID = Int32.Parse(txtPersonID.Text.Trim());
            _Person = clsPerson.Find(PersonID);

            if(_Person == null)
            {
                MessageBox.Show("Person with the specified ID does not exist.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ctrlPersonInfo1.SetPersonID(PersonID);
            OnPersonSelected?.Invoke(_Person);

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson();
            frmAddEditPerson.ShowDialog();
        }
    }
}

