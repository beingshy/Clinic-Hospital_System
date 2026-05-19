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
    public partial class frmUserInfo : Form
    {
        short _UserID;
        public frmUserInfo(short userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserInfoVertical1.SetUserID(_UserID);
        }
    }
}
