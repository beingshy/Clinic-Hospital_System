using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementDB_Business;

namespace UI.Departments
{
    public partial class frmAddEditDepartment : Form
    {
        clsDepartment _Department;
        public frmAddEditDepartment()
        {
            InitializeComponent();
            this.Text = "Add New Department";
            lblHeader.Text = "ADD DEPARTMENT";
            _Department = new clsDepartment();
        }
        public frmAddEditDepartment(byte DepartmentID)
        {
            InitializeComponent();
            this.Text = "Edit Department";
            lblHeader.Text = "EDIT DEPARTMENT";
            _Department = new clsDepartment();
            _Department = clsDepartment.Find(DepartmentID);
        }
        private void frmAddEditDepartment_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void _LoadData()
        {
            if(_Department.DepartmentID == null)
                return;

            txtDepartmentID.Text = _Department.DepartmentID.ToString();
            txtDepartmentName.Text = _Department.DepartmentName;
            txtDepartmentDescription.Text = _Department.DepartmentDescription;
            txtDepartmentLocation.Text = _Department.DepartmentLocation;
        }
        private void PreventNonLetterInput(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            if(e.KeyChar == ' ' && textbox.Text.EndsWith(" "))
            {
                e.Handled = true;
            }
            if((textbox.Text.Length >= 200 ||
                !(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '-')))
            {
                e.Handled = true;
            }

        }
        private void ValidateTextbox(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if(textbox.Text.Length < Int16.Parse(textbox.Tag.ToString()))
            {
                textbox.BackColor = Color.FromArgb(91, 15, 15);
                errorProvider1.SetError(textbox, "Please Enter a Valid Value");
                e.Cancel = true;
            }
            else
            {
                textbox.BackColor = Color.FromArgb(35, 35, 35);
                errorProvider1.SetError(textbox, null);
            }
        }
        private void _Save()
        {
            if(!this.ValidateChildren())
            {
                return;
            }
            _Department.DepartmentName = txtDepartmentName.Text.Trim();
            _Department.DepartmentDescription = string.IsNullOrWhiteSpace(txtDepartmentDescription.Text.Trim())
                ? null : txtDepartmentDescription.Text.Trim();
            _Department.DepartmentLocation = string.IsNullOrWhiteSpace(txtDepartmentLocation.Text.Trim()) ? null : txtDepartmentLocation.Text.Trim();

            if(MessageBox.Show("Are you sure you want to save this department?", "Confirm Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(_Department.Save())
                {
                    txtDepartmentID.Text = _Department.DepartmentID.ToString();
                    MessageBox.Show("department saved successfully.", "Save Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Text = "Edit Department";
                    lblHeader.Text = "EDIT DEPARTMENT";
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the department. Please try again.",
                        "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
