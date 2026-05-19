namespace UI.Users
{
    partial class frmUsersManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            lblRecordsValue = new System.Windows.Forms.Label();
            lblRecords = new System.Windows.Forms.Label();
            cmsUsers = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            tsmiShowUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            tsmiShowPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            tsmiShowLoginHistory = new System.Windows.Forms.ToolStripMenuItem();
            tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            tsmiChangeUserRole = new System.Windows.Forms.ToolStripMenuItem();
            tsmiChangeToAdmin = new System.Windows.Forms.ToolStripMenuItem();
            tsmiChangeToDoctor = new System.Windows.Forms.ToolStripMenuItem();
            tsmiChangeToReceptionist = new System.Windows.Forms.ToolStripMenuItem();
            tsmiActivateOrDeactivate = new System.Windows.Forms.ToolStripMenuItem();
            dgvUsers = new System.Windows.Forms.DataGridView();
            cbFilter = new System.Windows.Forms.ComboBox();
            lblFilterBy = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            cbRole = new System.Windows.Forms.ComboBox();
            lblHeader = new System.Windows.Forms.Label();
            cbIsActive = new System.Windows.Forms.ComboBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnAddUser = new System.Windows.Forms.Button();
            ctrlUserInfoVertical1 = new UI.Users.Controls.ctrlUserInfoVertical();
            cmsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRecordsValue
            // 
            lblRecordsValue.AutoSize = true;
            lblRecordsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRecordsValue.Location = new System.Drawing.Point(106, 792);
            lblRecordsValue.Name = "lblRecordsValue";
            lblRecordsValue.Size = new System.Drawing.Size(48, 21);
            lblRecordsValue.TabIndex = 18;
            lblRecordsValue.Text = "[????]";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRecords.Location = new System.Drawing.Point(24, 792);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new System.Drawing.Size(69, 21);
            lblRecords.TabIndex = 19;
            lblRecords.Text = "Records:";
            // 
            // cmsUsers
            // 
            cmsUsers.BackColor = System.Drawing.SystemColors.Control;
            cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiAddNewUser, toolStripMenuItem2, tsmiShowUserInfo, tsmiShowPersonInfo, tsmiShowLoginHistory, tsmiChangePassword, tsmiChangeUserRole, tsmiActivateOrDeactivate });
            cmsUsers.Name = "cmsPerson";
            cmsUsers.Size = new System.Drawing.Size(256, 244);
            // 
            // tsmiAddNewUser
            // 
            tsmiAddNewUser.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiAddNewUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiAddNewUser.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiAddNewUser.Name = "tsmiAddNewUser";
            tsmiAddNewUser.Size = new System.Drawing.Size(255, 30);
            tsmiAddNewUser.Text = "Add New User";
            tsmiAddNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiAddNewUser.Click += tsmiAddNewUser_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(255, 30);
            toolStripMenuItem2.Text = "Edit User";
            toolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolStripMenuItem2.Click += tsmiEditUser_Click;
            // 
            // tsmiShowUserInfo
            // 
            tsmiShowUserInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiShowUserInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiShowUserInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiShowUserInfo.Name = "tsmiShowUserInfo";
            tsmiShowUserInfo.Size = new System.Drawing.Size(255, 30);
            tsmiShowUserInfo.Text = "User Information";
            tsmiShowUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiShowUserInfo.Click += tsmiShowUserInfo_Click;
            // 
            // tsmiShowPersonInfo
            // 
            tsmiShowPersonInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiShowPersonInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiShowPersonInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiShowPersonInfo.Name = "tsmiShowPersonInfo";
            tsmiShowPersonInfo.Size = new System.Drawing.Size(255, 30);
            tsmiShowPersonInfo.Text = "Personal Information";
            tsmiShowPersonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiShowPersonInfo.Click += tsmiShowPersonInfo_Click;
            // 
            // tsmiShowLoginHistory
            // 
            tsmiShowLoginHistory.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiShowLoginHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiShowLoginHistory.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiShowLoginHistory.Name = "tsmiShowLoginHistory";
            tsmiShowLoginHistory.Size = new System.Drawing.Size(255, 30);
            tsmiShowLoginHistory.Text = "Login History";
            tsmiShowLoginHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiShowLoginHistory.Click += tsmiShowLoginHistory_Click;
            // 
            // tsmiChangePassword
            // 
            tsmiChangePassword.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiChangePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiChangePassword.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiChangePassword.Name = "tsmiChangePassword";
            tsmiChangePassword.Size = new System.Drawing.Size(255, 30);
            tsmiChangePassword.Text = "Change Password";
            tsmiChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiChangePassword.Click += tsmiChangePassword_Click;
            // 
            // tsmiChangeUserRole
            // 
            tsmiChangeUserRole.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiChangeUserRole.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiChangeToAdmin, tsmiChangeToDoctor, tsmiChangeToReceptionist });
            tsmiChangeUserRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiChangeUserRole.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiChangeUserRole.Name = "tsmiChangeUserRole";
            tsmiChangeUserRole.Size = new System.Drawing.Size(255, 30);
            tsmiChangeUserRole.Text = "Change User Role";
            tsmiChangeUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiChangeUserRole.Click += tsmiChangeUserRole_Click;
            // 
            // tsmiChangeToAdmin
            // 
            tsmiChangeToAdmin.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiChangeToAdmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiChangeToAdmin.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiChangeToAdmin.Name = "tsmiChangeToAdmin";
            tsmiChangeToAdmin.Size = new System.Drawing.Size(321, 30);
            tsmiChangeToAdmin.Text = "Change Role to Admin";
            tsmiChangeToAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiChangeToAdmin.Click += tsmiChangeToAdmin_Click;
            // 
            // tsmiChangeToDoctor
            // 
            tsmiChangeToDoctor.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiChangeToDoctor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiChangeToDoctor.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiChangeToDoctor.Name = "tsmiChangeToDoctor";
            tsmiChangeToDoctor.Size = new System.Drawing.Size(321, 30);
            tsmiChangeToDoctor.Text = "Change Role to Doctor";
            tsmiChangeToDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiChangeToDoctor.Click += tsmiChangeToDoctor_Click;
            // 
            // tsmiChangeToReceptionist
            // 
            tsmiChangeToReceptionist.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiChangeToReceptionist.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiChangeToReceptionist.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiChangeToReceptionist.Name = "tsmiChangeToReceptionist";
            tsmiChangeToReceptionist.Size = new System.Drawing.Size(321, 30);
            tsmiChangeToReceptionist.Text = "Change Role To Receptionist";
            tsmiChangeToReceptionist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiChangeToReceptionist.Click += tsmiChangeToReceptionist_Click;
            // 
            // tsmiActivateOrDeactivate
            // 
            tsmiActivateOrDeactivate.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiActivateOrDeactivate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiActivateOrDeactivate.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiActivateOrDeactivate.Name = "tsmiActivateOrDeactivate";
            tsmiActivateOrDeactivate.Size = new System.Drawing.Size(255, 30);
            tsmiActivateOrDeactivate.Text = "Activate User";
            tsmiActivateOrDeactivate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiActivateOrDeactivate.Click += tsmiActivateOrDeactivate_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeight = 40;
            dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.ContextMenuStrip = cmsUsers;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.Location = new System.Drawing.Point(24, 252);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsers.RowTemplate.Height = 35;
            dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.ShowCellErrors = false;
            dgvUsers.ShowCellToolTips = false;
            dgvUsers.ShowEditingIcon = false;
            dgvUsers.ShowRowErrors = false;
            dgvUsers.Size = new System.Drawing.Size(785, 532);
            dgvUsers.TabIndex = 21;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
            // 
            // cbFilter
            // 
            cbFilter.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFilter.DropDownWidth = 245;
            cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbFilter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbFilter.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            cbFilter.FormattingEnabled = true;
            cbFilter.IntegralHeight = false;
            cbFilter.Items.AddRange(new object[] { "None", "User ID", "Person ID", "User Name", "Role", "Is Active" });
            cbFilter.Location = new System.Drawing.Point(121, 209);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new System.Drawing.Size(245, 33);
            cbFilter.TabIndex = 28;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblFilterBy.Location = new System.Drawing.Point(24, 210);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new System.Drawing.Size(91, 30);
            lblFilterBy.TabIndex = 27;
            lblFilterBy.Text = "Filter By:";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSearch.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            txtSearch.Location = new System.Drawing.Point(372, 208);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(245, 34);
            txtSearch.TabIndex = 30;
            txtSearch.Visible = false;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // cbRole
            // 
            cbRole.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbRole.DropDownWidth = 245;
            cbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbRole.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            cbRole.FormattingEnabled = true;
            cbRole.IntegralHeight = false;
            cbRole.Items.AddRange(new object[] { "Admin", "Doctor", "Receptionist" });
            cbRole.Location = new System.Drawing.Point(372, 209);
            cbRole.Name = "cbRole";
            cbRole.Size = new System.Drawing.Size(245, 33);
            cbRole.TabIndex = 29;
            cbRole.Visible = false;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHeader.Location = new System.Drawing.Point(512, 124);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(305, 40);
            lblHeader.TabIndex = 31;
            lblHeader.Text = "USERS MANAGEMENT";
            // 
            // cbIsActive
            // 
            cbIsActive.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbIsActive.DropDownWidth = 245;
            cbIsActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbIsActive.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbIsActive.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            cbIsActive.FormattingEnabled = true;
            cbIsActive.IntegralHeight = false;
            cbIsActive.Items.AddRange(new object[] { "Yes", "No" });
            cbIsActive.Location = new System.Drawing.Point(372, 208);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new System.Drawing.Size(245, 33);
            cbIsActive.TabIndex = 33;
            cbIsActive.Visible = false;
            cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UsersV2;
            pictureBox1.Location = new System.Drawing.Point(598, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(133, 103);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnAddUser.BackgroundImage = Properties.Resources.Add_NewV2;
            btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAddUser.Location = new System.Drawing.Point(1230, 200);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new System.Drawing.Size(57, 50);
            btnAddUser.TabIndex = 26;
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // ctrlUserInfoVertical1
            // 
            ctrlUserInfoVertical1.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            ctrlUserInfoVertical1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ctrlUserInfoVertical1.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            ctrlUserInfoVertical1.Location = new System.Drawing.Point(816, 252);
            ctrlUserInfoVertical1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ctrlUserInfoVertical1.Name = "ctrlUserInfoVertical1";
            ctrlUserInfoVertical1.Size = new System.Drawing.Size(471, 532);
            ctrlUserInfoVertical1.TabIndex = 34;
            // 
            // frmUsersManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ClientSize = new System.Drawing.Size(1329, 861);
            Controls.Add(ctrlUserInfoVertical1);
            Controls.Add(lblHeader);
            Controls.Add(pictureBox1);
            Controls.Add(cbFilter);
            Controls.Add(lblFilterBy);
            Controls.Add(btnAddUser);
            Controls.Add(lblRecordsValue);
            Controls.Add(lblRecords);
            Controls.Add(dgvUsers);
            Controls.Add(txtSearch);
            Controls.Add(cbIsActive);
            Controls.Add(cbRole);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "frmUsersManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "frmUsersManagement";
            Load += frmUsersManagement_Load;
            cmsUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblRecordsValue;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiActivateOrDeactivate;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPersonInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeUserRole;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeToAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeToDoctor;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeToReceptionist;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLoginHistory;
        private Controls.ctrlUserInfoVertical ctrlUserInfoVertical1;
    }
}