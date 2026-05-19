namespace UI.Patient
{
    partial class frmPatientsManagement
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
            dgvPatients = new System.Windows.Forms.DataGridView();
            cmsPatient = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiAddNewPatient = new System.Windows.Forms.ToolStripMenuItem();
            tsmiEditPatientInfo = new System.Windows.Forms.ToolStripMenuItem();
            tsmiShowPatientInfo = new System.Windows.Forms.ToolStripMenuItem();
            tsmiPatientMedicalRecords = new System.Windows.Forms.ToolStripMenuItem();
            tsmiCallPatientEmergencyPhone = new System.Windows.Forms.ToolStripMenuItem();
            lblHeader = new System.Windows.Forms.Label();
            btnAddPatient = new System.Windows.Forms.Button();
            cbFilter = new System.Windows.Forms.ComboBox();
            lblFilterBy = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            txtSearch = new System.Windows.Forms.TextBox();
            txtPageNumber = new System.Windows.Forms.TextBox();
            btnNextPage = new System.Windows.Forms.Button();
            btnPreviousPage = new System.Windows.Forms.Button();
            lblOfTotalPagesAndRows = new System.Windows.Forms.Label();
            btnFind = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            cmsPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToDeleteRows = false;
            dgvPatients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            dgvPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPatients.BackgroundColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgvPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPatients.ColumnHeadersHeight = 40;
            dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPatients.ContextMenuStrip = cmsPatient;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvPatients.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPatients.EnableHeadersVisualStyles = false;
            dgvPatients.Location = new System.Drawing.Point(24, 254);
            dgvPatients.MultiSelect = false;
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvPatients.RowHeadersVisible = false;
            dgvPatients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvPatients.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPatients.RowTemplate.Height = 35;
            dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.ShowCellErrors = false;
            dgvPatients.ShowCellToolTips = false;
            dgvPatients.ShowEditingIcon = false;
            dgvPatients.ShowRowErrors = false;
            dgvPatients.Size = new System.Drawing.Size(1281, 532);
            dgvPatients.TabIndex = 11;
            // 
            // cmsPatient
            // 
            cmsPatient.BackColor = System.Drawing.SystemColors.Control;
            cmsPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiAddNewPatient, tsmiEditPatientInfo, tsmiShowPatientInfo, tsmiPatientMedicalRecords, tsmiCallPatientEmergencyPhone });
            cmsPatient.Name = "cmsPerson";
            cmsPatient.Size = new System.Drawing.Size(332, 154);
            // 
            // tsmiAddNewPatient
            // 
            tsmiAddNewPatient.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiAddNewPatient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiAddNewPatient.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiAddNewPatient.Name = "tsmiAddNewPatient";
            tsmiAddNewPatient.Size = new System.Drawing.Size(331, 30);
            tsmiAddNewPatient.Text = "Add New Patient";
            tsmiAddNewPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiAddNewPatient.Click += tsmiAddNewPatient_Click;
            // 
            // tsmiEditPatientInfo
            // 
            tsmiEditPatientInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiEditPatientInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiEditPatientInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiEditPatientInfo.Name = "tsmiEditPatientInfo";
            tsmiEditPatientInfo.Size = new System.Drawing.Size(331, 30);
            tsmiEditPatientInfo.Text = "Edit Patient";
            tsmiEditPatientInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiEditPatientInfo.Click += tsmiEditPatientInfo_Click;
            // 
            // tsmiShowPatientInfo
            // 
            tsmiShowPatientInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiShowPatientInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiShowPatientInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiShowPatientInfo.Name = "tsmiShowPatientInfo";
            tsmiShowPatientInfo.Size = new System.Drawing.Size(331, 30);
            tsmiShowPatientInfo.Text = "Patient Information";
            tsmiShowPatientInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiShowPatientInfo.Click += tsmiShowPatientInfo_Click;
            // 
            // tsmiPatientMedicalRecords
            // 
            tsmiPatientMedicalRecords.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiPatientMedicalRecords.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiPatientMedicalRecords.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiPatientMedicalRecords.Name = "tsmiPatientMedicalRecords";
            tsmiPatientMedicalRecords.Size = new System.Drawing.Size(331, 30);
            tsmiPatientMedicalRecords.Text = "Patient's Medical Records";
            tsmiPatientMedicalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiPatientMedicalRecords.Click += tsmiPatientMedicalRecords_Click;
            // 
            // tsmiCallPatientEmergencyPhone
            // 
            tsmiCallPatientEmergencyPhone.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiCallPatientEmergencyPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiCallPatientEmergencyPhone.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiCallPatientEmergencyPhone.Name = "tsmiCallPatientEmergencyPhone";
            tsmiCallPatientEmergencyPhone.Size = new System.Drawing.Size(331, 30);
            tsmiCallPatientEmergencyPhone.Text = "Call Patient Emergency Phone";
            tsmiCallPatientEmergencyPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiCallPatientEmergencyPhone.Click += tsmiCallPatientEmergencyPhone_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHeader.Location = new System.Drawing.Point(493, 124);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(343, 40);
            lblHeader.TabIndex = 6;
            lblHeader.Text = "PATIENTS MANAGEMENT";
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnAddPatient.BackgroundImage = Properties.Resources.Add_NewV2;
            btnAddPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnAddPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddPatient.FlatAppearance.BorderSize = 0;
            btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddPatient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAddPatient.Location = new System.Drawing.Point(1248, 200);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new System.Drawing.Size(57, 50);
            btnAddPatient.TabIndex = 14;
            btnAddPatient.UseVisualStyleBackColor = false;
            btnAddPatient.Click += btnAddPatient_Click;
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
            cbFilter.Items.AddRange(new object[] { "None", "Patient ID", "Person ID", "Full Name", "National ID" });
            cbFilter.Location = new System.Drawing.Point(121, 213);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new System.Drawing.Size(245, 33);
            cbFilter.TabIndex = 12;
            cbFilter.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblFilterBy.Location = new System.Drawing.Point(24, 214);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new System.Drawing.Size(91, 30);
            lblFilterBy.TabIndex = 9;
            lblFilterBy.Text = "Filter By:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Patients;
            pictureBox1.Location = new System.Drawing.Point(598, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(133, 103);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSearch.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            txtSearch.Location = new System.Drawing.Point(372, 212);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(245, 34);
            txtSearch.TabIndex = 15;
            txtSearch.Visible = false;
            txtSearch.KeyPress += txtSearch_KeyPress;
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
            txtPageNumber.TabIndex = 19;
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
            btnNextPage.TabIndex = 17;
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
            btnPreviousPage.TabIndex = 18;
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
            lblOfTotalPagesAndRows.TabIndex = 16;
            lblOfTotalPagesAndRows.Text = "of [????] (???)";
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
            btnFind.TabIndex = 30;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Visible = false;
            btnFind.Click += btnFind_Click;
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
            btnCancel.TabIndex = 31;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmPatientsManagement
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
            Controls.Add(dgvPatients);
            Controls.Add(lblHeader);
            Controls.Add(btnAddPatient);
            Controls.Add(cbFilter);
            Controls.Add(lblFilterBy);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearch);
            Controls.Add(btnFind);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "frmPatientsManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "frmPatientsManagement";
            Load += frmPatientsManagement_Load;
            Shown += frmPatientsManagement_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            cmsPatient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.ContextMenuStrip cmsPatient;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPatientInfo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPatientInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatientMedicalRecords;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Label lblOfTotalPagesAndRows;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ToolStripMenuItem tsmiCallPatientEmergencyPhone;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewPatient;
        private System.Windows.Forms.Button btnCancel;
    }
}