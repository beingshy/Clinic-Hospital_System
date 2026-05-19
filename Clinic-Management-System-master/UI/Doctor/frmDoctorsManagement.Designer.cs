namespace UI.Doctor
{
    partial class frmDoctorsManagement
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
            dgvDoctors = new System.Windows.Forms.DataGridView();
            cmsDoctor = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiAddNewDoctor = new System.Windows.Forms.ToolStripMenuItem();
            tsmiEditPatientInfo = new System.Windows.Forms.ToolStripMenuItem();
            tsmiShowDoctorInfo = new System.Windows.Forms.ToolStripMenuItem();
            tsmiShowDoctorPersonalInfo = new System.Windows.Forms.ToolStripMenuItem();
            tsmiShowDoctorUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            lblHeader = new System.Windows.Forms.Label();
            btnAddDoctor = new System.Windows.Forms.Button();
            cbFilter = new System.Windows.Forms.ComboBox();
            lblRecordsValue = new System.Windows.Forms.Label();
            lblRecords = new System.Windows.Forms.Label();
            lblFilterBy = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            txtSearch = new System.Windows.Forms.TextBox();
            cbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            cmsDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvDoctors
            // 
            dgvDoctors.AllowUserToAddRows = false;
            dgvDoctors.AllowUserToDeleteRows = false;
            dgvDoctors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            dgvDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDoctors.BackgroundColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvDoctors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgvDoctors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDoctors.ColumnHeadersHeight = 40;
            dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDoctors.ContextMenuStrip = cmsDoctor;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvDoctors.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDoctors.EnableHeadersVisualStyles = false;
            dgvDoctors.Location = new System.Drawing.Point(24, 252);
            dgvDoctors.MultiSelect = false;
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.ReadOnly = true;
            dgvDoctors.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvDoctors.RowHeadersVisible = false;
            dgvDoctors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvDoctors.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDoctors.RowTemplate.Height = 35;
            dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDoctors.ShowCellErrors = false;
            dgvDoctors.ShowCellToolTips = false;
            dgvDoctors.ShowEditingIcon = false;
            dgvDoctors.ShowRowErrors = false;
            dgvDoctors.Size = new System.Drawing.Size(1281, 532);
            dgvDoctors.TabIndex = 21;
            // 
            // cmsDoctor
            // 
            cmsDoctor.BackColor = System.Drawing.SystemColors.Control;
            cmsDoctor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiAddNewDoctor, tsmiEditPatientInfo, tsmiShowDoctorInfo, tsmiShowDoctorPersonalInfo, tsmiShowDoctorUserInfo });
            cmsDoctor.Name = "cmsPerson";
            cmsDoctor.Size = new System.Drawing.Size(284, 154);
            // 
            // tsmiAddNewDoctor
            // 
            tsmiAddNewDoctor.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiAddNewDoctor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiAddNewDoctor.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiAddNewDoctor.Name = "tsmiAddNewDoctor";
            tsmiAddNewDoctor.Size = new System.Drawing.Size(283, 30);
            tsmiAddNewDoctor.Text = "Add New Doctor";
            tsmiAddNewDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiAddNewDoctor.Click += tsmiAddNewDoctor_Click;
            // 
            // tsmiEditPatientInfo
            // 
            tsmiEditPatientInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiEditPatientInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiEditPatientInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiEditPatientInfo.Name = "tsmiEditPatientInfo";
            tsmiEditPatientInfo.Size = new System.Drawing.Size(283, 30);
            tsmiEditPatientInfo.Text = "Edit Doctor";
            tsmiEditPatientInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiEditPatientInfo.Click += tsmiEditDoctorInfo_Click;
            // 
            // tsmiShowDoctorInfo
            // 
            tsmiShowDoctorInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiShowDoctorInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiShowDoctorInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiShowDoctorInfo.Name = "tsmiShowDoctorInfo";
            tsmiShowDoctorInfo.Size = new System.Drawing.Size(283, 30);
            tsmiShowDoctorInfo.Text = "Doctor Information";
            tsmiShowDoctorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiShowDoctorInfo.Click += tsmiShowDoctorInfo_Click;
            // 
            // tsmiShowDoctorPersonalInfo
            // 
            tsmiShowDoctorPersonalInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiShowDoctorPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiShowDoctorPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiShowDoctorPersonalInfo.Name = "tsmiShowDoctorPersonalInfo";
            tsmiShowDoctorPersonalInfo.Size = new System.Drawing.Size(283, 30);
            tsmiShowDoctorPersonalInfo.Text = "Personal Information";
            tsmiShowDoctorPersonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiShowDoctorPersonalInfo.Click += tsmiShowDoctorPersonalInfo_Click;
            // 
            // tsmiShowDoctorUserInfo
            // 
            tsmiShowDoctorUserInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiShowDoctorUserInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiShowDoctorUserInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiShowDoctorUserInfo.Name = "tsmiShowDoctorUserInfo";
            tsmiShowDoctorUserInfo.Size = new System.Drawing.Size(283, 30);
            tsmiShowDoctorUserInfo.Text = "Doctor User Information";
            tsmiShowDoctorUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiShowDoctorUserInfo.Click += tsmiShowDoctorUserInfo_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHeader.Location = new System.Drawing.Point(493, 124);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(351, 40);
            lblHeader.TabIndex = 16;
            lblHeader.Text = "DOCTORS MANAGEMENT";
            // 
            // btnAddDoctor
            // 
            btnAddDoctor.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnAddDoctor.BackgroundImage = Properties.Resources.Add_NewV2;
            btnAddDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnAddDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddDoctor.FlatAppearance.BorderSize = 0;
            btnAddDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddDoctor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAddDoctor.Location = new System.Drawing.Point(1248, 200);
            btnAddDoctor.Name = "btnAddDoctor";
            btnAddDoctor.Size = new System.Drawing.Size(57, 50);
            btnAddDoctor.TabIndex = 23;
            btnAddDoctor.UseVisualStyleBackColor = false;
            btnAddDoctor.Click += btnAddDoctor_Click;
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
            cbFilter.Items.AddRange(new object[] { "None", "Doctor ID", "Person ID", "Full Name", "License Number", "Status" });
            cbFilter.Location = new System.Drawing.Point(121, 213);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new System.Drawing.Size(245, 33);
            cbFilter.TabIndex = 22;
            cbFilter.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // lblRecordsValue
            // 
            lblRecordsValue.AutoSize = true;
            lblRecordsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRecordsValue.Location = new System.Drawing.Point(90, 792);
            lblRecordsValue.Name = "lblRecordsValue";
            lblRecordsValue.Size = new System.Drawing.Size(48, 21);
            lblRecordsValue.TabIndex = 17;
            lblRecordsValue.Text = "[????]";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRecords.Location = new System.Drawing.Point(24, 792);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new System.Drawing.Size(69, 21);
            lblRecords.TabIndex = 18;
            lblRecords.Text = "Records:";
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblFilterBy.Location = new System.Drawing.Point(24, 214);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new System.Drawing.Size(91, 30);
            lblFilterBy.TabIndex = 19;
            lblFilterBy.Text = "Filter By:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Doctors;
            pictureBox1.Location = new System.Drawing.Point(598, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(133, 103);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSearch.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            txtSearch.Location = new System.Drawing.Point(372, 213);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(245, 34);
            txtSearch.TabIndex = 24;
            txtSearch.Visible = false;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // cbStatus
            // 
            cbStatus.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbStatus.DropDownWidth = 245;
            cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbStatus.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            cbStatus.FormattingEnabled = true;
            cbStatus.IntegralHeight = false;
            cbStatus.Items.AddRange(new object[] { "Active", "On Leave", "Resigned", "Retired", "Terminated" });
            cbStatus.Location = new System.Drawing.Point(372, 213);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new System.Drawing.Size(245, 33);
            cbStatus.TabIndex = 25;
            cbStatus.Visible = false;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // frmDoctorsManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ClientSize = new System.Drawing.Size(1329, 861);
            Controls.Add(dgvDoctors);
            Controls.Add(lblHeader);
            Controls.Add(btnAddDoctor);
            Controls.Add(cbFilter);
            Controls.Add(lblRecordsValue);
            Controls.Add(lblRecords);
            Controls.Add(lblFilterBy);
            Controls.Add(pictureBox1);
            Controls.Add(cbStatus);
            Controls.Add(txtSearch);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "frmDoctorsManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "frmDoctorsManagement";
            Load += frmDoctorsManagement_Load;
            Shown += frmDoctorsManagement_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            cmsDoctor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.ContextMenuStrip cmsDoctor;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPatientInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDoctorInfo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblRecordsValue;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDoctorUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDoctorPersonalInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewDoctor;
    }
}