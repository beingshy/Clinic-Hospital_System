namespace UI.Appointments
{
    partial class frmAppointmentsManagement
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
            dgvAppointments = new System.Windows.Forms.DataGridView();
            cmsAppointments = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiAddNewAppointment = new System.Windows.Forms.ToolStripMenuItem();
            tsmiEditPatientInfo = new System.Windows.Forms.ToolStripMenuItem();
            tsmiShowDoctorInfo = new System.Windows.Forms.ToolStripMenuItem();
            tsmiPatientMedicalRecords = new System.Windows.Forms.ToolStripMenuItem();
            tsmiPatientInfo = new System.Windows.Forms.ToolStripMenuItem();
            tsmkDoctorInfo = new System.Windows.Forms.ToolStripMenuItem();
            tsmiCallPatient = new System.Windows.Forms.ToolStripMenuItem();
            lblHeader = new System.Windows.Forms.Label();
            btnAddAppointment = new System.Windows.Forms.Button();
            cbFilter = new System.Windows.Forms.ComboBox();
            lblFilterBy = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            txtSearch = new System.Windows.Forms.TextBox();
            btnFind = new System.Windows.Forms.Button();
            txtPageNumber = new System.Windows.Forms.TextBox();
            btnNextPage = new System.Windows.Forms.Button();
            btnPreviousPage = new System.Windows.Forms.Button();
            lblOfTotalPagesAndRows = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            cmsAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAppointments.BackgroundColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAppointments.ColumnHeadersHeight = 40;
            dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAppointments.ContextMenuStrip = cmsAppointments;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAppointments.EnableHeadersVisualStyles = false;
            dgvAppointments.Location = new System.Drawing.Point(24, 252);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvAppointments.RowHeadersVisible = false;
            dgvAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvAppointments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvAppointments.RowTemplate.Height = 35;
            dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.ShowCellErrors = false;
            dgvAppointments.ShowCellToolTips = false;
            dgvAppointments.ShowEditingIcon = false;
            dgvAppointments.ShowRowErrors = false;
            dgvAppointments.Size = new System.Drawing.Size(1281, 532);
            dgvAppointments.TabIndex = 31;
            // 
            // cmsAppointments
            // 
            cmsAppointments.BackColor = System.Drawing.SystemColors.Control;
            cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiAddNewAppointment, tsmiEditPatientInfo, tsmiShowDoctorInfo, tsmiPatientMedicalRecords, tsmiPatientInfo, tsmkDoctorInfo, tsmiCallPatient });
            cmsAppointments.Name = "cmsPerson";
            cmsAppointments.Size = new System.Drawing.Size(294, 214);
            // 
            // tsmiAddNewAppointment
            // 
            tsmiAddNewAppointment.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiAddNewAppointment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiAddNewAppointment.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiAddNewAppointment.Name = "tsmiAddNewAppointment";
            tsmiAddNewAppointment.Size = new System.Drawing.Size(293, 30);
            tsmiAddNewAppointment.Text = "Add New Appointment";
            tsmiAddNewAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiAddNewAppointment.Click += tsmiAddNewAppointment_Click;
            // 
            // tsmiEditPatientInfo
            // 
            tsmiEditPatientInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiEditPatientInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiEditPatientInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiEditPatientInfo.Name = "tsmiEditPatientInfo";
            tsmiEditPatientInfo.Size = new System.Drawing.Size(293, 30);
            tsmiEditPatientInfo.Text = "Edit Appointment";
            tsmiEditPatientInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiEditPatientInfo.Click += tsmiEditAppointmentInfo_Click;
            // 
            // tsmiShowDoctorInfo
            // 
            tsmiShowDoctorInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiShowDoctorInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiShowDoctorInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiShowDoctorInfo.Name = "tsmiShowDoctorInfo";
            tsmiShowDoctorInfo.Size = new System.Drawing.Size(293, 30);
            tsmiShowDoctorInfo.Text = "Appointment Information";
            tsmiShowDoctorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiShowDoctorInfo.Click += tsmiShowDoctorInfo_Click;
            // 
            // tsmiPatientMedicalRecords
            // 
            tsmiPatientMedicalRecords.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiPatientMedicalRecords.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiPatientMedicalRecords.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiPatientMedicalRecords.Name = "tsmiPatientMedicalRecords";
            tsmiPatientMedicalRecords.Size = new System.Drawing.Size(293, 30);
            tsmiPatientMedicalRecords.Text = "Patient's Medical Records";
            tsmiPatientMedicalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiPatientMedicalRecords.Click += tsmiPatientMedicalRecords_Click;
            // 
            // tsmiPatientInfo
            // 
            tsmiPatientInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiPatientInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiPatientInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiPatientInfo.Name = "tsmiPatientInfo";
            tsmiPatientInfo.Size = new System.Drawing.Size(293, 30);
            tsmiPatientInfo.Text = "Patient Information";
            tsmiPatientInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiPatientInfo.Click += tsmiPatientInfo_Click;
            // 
            // tsmkDoctorInfo
            // 
            tsmkDoctorInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmkDoctorInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmkDoctorInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmkDoctorInfo.Name = "tsmkDoctorInfo";
            tsmkDoctorInfo.Size = new System.Drawing.Size(293, 30);
            tsmkDoctorInfo.Text = "Doctor Information";
            tsmkDoctorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmkDoctorInfo.Click += tsmkDoctorInfo_Click;
            // 
            // tsmiCallPatient
            // 
            tsmiCallPatient.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiCallPatient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiCallPatient.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiCallPatient.Name = "tsmiCallPatient";
            tsmiCallPatient.Size = new System.Drawing.Size(293, 30);
            tsmiCallPatient.Text = "Call Patient";
            tsmiCallPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiCallPatient.Click += tsmiCallPatient_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHeader.Location = new System.Drawing.Point(448, 124);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(433, 40);
            lblHeader.TabIndex = 26;
            lblHeader.Text = "APPOINTMENTS MANAGEMENT";
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnAddAppointment.BackgroundImage = Properties.Resources.Add_NewV2;
            btnAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnAddAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddAppointment.FlatAppearance.BorderSize = 0;
            btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAddAppointment.Location = new System.Drawing.Point(1248, 200);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new System.Drawing.Size(57, 50);
            btnAddAppointment.TabIndex = 33;
            btnAddAppointment.UseVisualStyleBackColor = false;
            btnAddAppointment.Click += btnAddAppointment_Click;
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
            cbFilter.Items.AddRange(new object[] { "None", "Appointment ID", "Patient Name", "Patient ID", "Doctor ID" });
            cbFilter.Location = new System.Drawing.Point(121, 213);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new System.Drawing.Size(245, 33);
            cbFilter.TabIndex = 32;
            cbFilter.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblFilterBy.Location = new System.Drawing.Point(24, 214);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new System.Drawing.Size(91, 30);
            lblFilterBy.TabIndex = 29;
            lblFilterBy.Text = "Filter By:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Appointments;
            pictureBox1.Location = new System.Drawing.Point(598, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(133, 103);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
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
            txtSearch.TabIndex = 34;
            txtSearch.Visible = false;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnFind
            // 
            btnFind.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnFind.BackgroundImage = Properties.Resources.SearchV2;
            btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFind.FlatAppearance.BorderSize = 0;
            btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFind.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnFind.Location = new System.Drawing.Point(623, 212);
            btnFind.Name = "btnFind";
            btnFind.Size = new System.Drawing.Size(34, 34);
            btnFind.TabIndex = 36;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Visible = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtPageNumber
            // 
            txtPageNumber.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            txtPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPageNumber.Enabled = false;
            txtPageNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPageNumber.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            txtPageNumber.Location = new System.Drawing.Point(98, 795);
            txtPageNumber.Multiline = true;
            txtPageNumber.Name = "txtPageNumber";
            txtPageNumber.Size = new System.Drawing.Size(41, 25);
            txtPageNumber.TabIndex = 40;
            txtPageNumber.Text = "1";
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnNextPage.BackgroundImage = Properties.Resources.right;
            btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNextPage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnNextPage.Location = new System.Drawing.Point(61, 790);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new System.Drawing.Size(31, 34);
            btnNextPage.TabIndex = 38;
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnPreviousPage.BackgroundImage = Properties.Resources.left;
            btnPreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnPreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPreviousPage.FlatAppearance.BorderSize = 0;
            btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPreviousPage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPreviousPage.Location = new System.Drawing.Point(24, 790);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new System.Drawing.Size(31, 34);
            btnPreviousPage.TabIndex = 39;
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // lblOfTotalPagesAndRows
            // 
            lblOfTotalPagesAndRows.AutoSize = true;
            lblOfTotalPagesAndRows.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblOfTotalPagesAndRows.Location = new System.Drawing.Point(145, 797);
            lblOfTotalPagesAndRows.Name = "lblOfTotalPagesAndRows";
            lblOfTotalPagesAndRows.Size = new System.Drawing.Size(101, 21);
            lblOfTotalPagesAndRows.TabIndex = 37;
            lblOfTotalPagesAndRows.Text = "of [????] (???)";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnCancel.BackgroundImage = Properties.Resources.cancel;
            btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.Location = new System.Drawing.Point(661, 211);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(41, 37);
            btnCancel.TabIndex = 41;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAppointmentsManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ClientSize = new System.Drawing.Size(1329, 861);
            Controls.Add(btnCancel);
            Controls.Add(txtPageNumber);
            Controls.Add(btnNextPage);
            Controls.Add(btnPreviousPage);
            Controls.Add(lblOfTotalPagesAndRows);
            Controls.Add(dgvAppointments);
            Controls.Add(lblHeader);
            Controls.Add(btnAddAppointment);
            Controls.Add(cbFilter);
            Controls.Add(lblFilterBy);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearch);
            Controls.Add(btnFind);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "frmAppointmentsManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "frmAppointmentsManagement";
            Load += frmAppointmentsManagement_Load;
            Shown += frmAppointmentsManagement_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            cmsAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.ContextMenuStrip cmsAppointments;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPatientInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDoctorInfo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatientMedicalRecords;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Label lblOfTotalPagesAndRows;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatientInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmkDoctorInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCallPatient;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewAppointment;
        private System.Windows.Forms.Button btnCancel;
    }
}