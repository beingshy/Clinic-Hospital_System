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
    public partial class ctrlPersonInfo : UserControl
    {
        clsPerson _Person;
        public ctrlPersonInfo()
        {
            InitializeComponent();
        }
        public void SetPersonID(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);

            if(_Person == null)
            {
                ResetValues();
                return;
            }
            _LoadData();
        }
        public void ResetValues()
        {
            string NotExistValue = "[????]";
            lblFullName.Text = NotExistValue;
            lblPersonID.Text = NotExistValue;
            lblNationalID.Text = NotExistValue;
            lblBirthDate.Text = NotExistValue;
            lblEmail.Text = NotExistValue;
            lblGender.Text = NotExistValue;
            lblPhone.Text = NotExistValue;
            lblCountry.Text = NotExistValue;
            lblAddress.Text = NotExistValue;
            lblCreatedByAt.Text = "Created By [??] At [??]";
            lblUpdatedByAt.Text = "Last Update By [??] At [??] ";
        }
        private void _LoadData()
        {
            lblFullName.Text = _Person.FullName;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblNationalID.Text = _Person.NationalID.ToString();
            lblBirthDate.Text = _Person.BirthDate.ToString("dd/MM/yyyy");
            lblEmail.Text = _Person.Email;
            lblGender.Text = _Person.StringGender;
            lblPhone.Text = _Person.Phone;
            lblCountry.Text = _Person.CountryName;
            lblAddress.Text = _Person.Address ?? "[????]";

            lblCreatedByAt.Text = $"Created By {clsUser.GetUsernameByID(_Person.CreatedByUserID)} At {_Person.CreatedAt.ToString("d MMM yyyy")}";
            if(_Person.UpdatedByUserID != null && _Person.UpdatedAt != null)
                lblUpdatedByAt.Text = $"Last Update By {clsUser.GetUsernameByID(_Person.UpdatedByUserID)} At {_Person.UpdatedAt.Value.ToString("d MMM yyyy")}";
            else
                lblUpdatedByAt.Visible = false;
        }
    }
}