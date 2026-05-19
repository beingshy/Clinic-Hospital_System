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

namespace UI.Users.Controls
{
    public partial class ctrlUserInfoVertical : UserControl
    {
        short? _UserID;
        clsUser _User;
        public clsUser SelectedUser { get { return _User; } }
        public ctrlUserInfoVertical()
        {
            InitializeComponent();
        }
        public void SetUserID(short UserID)
        {
            _UserID = UserID;
            _User = clsUser.Find(_UserID);
            if(_User != null)
                _LoadData();
        }
        public void ResetValues()
        {
            if(_User == null) return;

            _UserID = null;
            _User = null;

            lblUserID.Text = "[????]";
            lblUserName.Text = "[????]";
            lblUserStatus.Text = "[????]";
            lblFullName.Text = "[????]";
            lblRole.Text = "[????]";
            lblPhone.Text = "[????]";
            lblEmail.Text = "[????]";
            lblLastLogin.Text = "[????]";
            lblCreatedByAt.Text = $"Created By [??] At [??]";
            lblUpdatedByAt.Text = $"Last Update By [??] At [??]";
        }
        private void _LoadData()
        {
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.Username;
            lblUserStatus.Text = _User.IsActive == true ? "Active" : "Inactive" ;
            lblFullName.Text = _User.Person.PartialFullName;
            lblRole.Text = _User.RoleString;
            lblPhone.Text = _User.Person.Phone;
            lblEmail.Text = _User.Person.Email;
            lblLastLogin.Text = _User.LastLoginAt.HasValue
                ? _User.LastLoginAt.Value.ToString()
                : "Never Logged In";
            lblCreatedByAt.Text = $"Created By {clsUser.GetUsernameByID(_User.CreatedByUserID)} At {_User.CreatedAt.ToString()}";
            if(_User.UpdatedByUserID.HasValue)
            {
                lblUpdatedByAt.Visible = true;
                lblUpdatedByAt.Text = $"Last Update By {clsUser.GetUsernameByID(_User.UpdatedByUserID)} At {_User.UpdatedAt.ToString()} ";
            }
        }

    }
}
