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

namespace UI.Users
{
    public partial class frmUserLoginHistory : Form
    {
        short _UserID;
        public frmUserLoginHistory(short UserID)
        {
            InitializeComponent();
            this._UserID = UserID;
        }
        private void _LoadDate()
        {
            lblUsername.Text = clsUser.Find(_UserID).Username;
            DataTable dt = clsLoginHistory.GetUserLoginHistory(_UserID);
            dgvLoginHistory.DataSource = dt;

            if(dgvLoginHistory.Rows.Count > 0)
            {
                dgvLoginHistory.Columns[0].HeaderText = "Login ID";
                dgvLoginHistory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvLoginHistory.Columns[1].HeaderText = "User ID";
                dgvLoginHistory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvLoginHistory.Columns[2].HeaderText = "Login Time";
                dgvLoginHistory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvLoginHistory.Columns[3].HeaderText = "Logout Time";
                dgvLoginHistory.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }

            lblRecordsValue.Text = dgvLoginHistory.Rows.Count.ToString();
        }
        private void frmUserLoginHistory_Load(object sender, EventArgs e)
        {
            _LoadDate();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            frmUserInfo frmUserInfo = new frmUserInfo(_UserID);
            frmUserInfo.ShowDialog();
        }
    }
}
