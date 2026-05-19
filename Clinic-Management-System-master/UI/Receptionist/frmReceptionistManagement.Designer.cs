namespace UI.Receptionist
{
    partial class frmReceptionistManagement
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
            dgvReceptionists = new System.Windows.Forms.DataGridView();
            cmsReceptionist = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiAddNewReceptionist = new System.Windows.Forms.ToolStripMenuItem();
            tsmPersonalInformation = new System.Windows.Forms.ToolStripMenuItem();
            tsmShowReceptionistInfo = new System.Windows.Forms.ToolStripMenuItem();
            tsmiPersonalInformation = new System.Windows.Forms.ToolStripMenuItem();
            tsmiReceptionistUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            lblHeader = new System.Windows.Forms.Label();
            btnAddReceptionist = new System.Windows.Forms.Button();
            cbFilter = new System.Windows.Forms.ComboBox();
            lblRecordsValue = new System.Windows.Forms.Label();
            lblRecords = new System.Windows.Forms.Label();
            lblFilterBy = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            txtSearch = new System.Windows.Forms.TextBox();
            cbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvReceptionists).BeginInit();
            cmsReceptionist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvReceptionists
            // 
            dgvReceptionists.AllowUserToAddRows = false;
            dgvReceptionists.AllowUserToDeleteRows = false;
            dgvReceptionists.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            dgvReceptionists.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReceptionists.BackgroundColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dgvReceptionists.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvReceptionists.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgvReceptionists.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvReceptionists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReceptionists.ColumnHeadersHeight = 40;
            dgvReceptionists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReceptionists.ContextMenuStrip = cmsReceptionist;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvReceptionists.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReceptionists.EnableHeadersVisualStyles = false;
            dgvReceptionists.Location = new System.Drawing.Point(24, 252);
            dgvReceptionists.MultiSelect = false;
            dgvReceptionists.Name = "dgvReceptionists";
            dgvReceptionists.ReadOnly = true;
            dgvReceptionists.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvReceptionists.RowHeadersVisible = false;
            dgvReceptionists.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvReceptionists.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvReceptionists.RowTemplate.Height = 35;
            dgvReceptionists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvReceptionists.ShowCellErrors = false;
            dgvReceptionists.ShowCellToolTips = false;
            dgvReceptionists.ShowEditingIcon = false;
            dgvReceptionists.ShowRowErrors = false;
            dgvReceptionists.Size = new System.Drawing.Size(1281, 532);
            dgvReceptionists.TabIndex = 11;
            // 
            // cmsReceptionist
            // 
            cmsReceptionist.BackColor = System.Drawing.SystemColors.Control;
            cmsReceptionist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiAddNewReceptionist, tsmPersonalInformation, tsmShowReceptionistInfo, tsmiPersonalInformation, tsmiReceptionistUserInfo });
            cmsReceptionist.Name = "cmsPerson";
            cmsReceptionist.Size = new System.Drawing.Size(329, 154);
            // 
            // tsmiAddNewReceptionist
            // 
            tsmiAddNewReceptionist.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiAddNewReceptionist.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiAddNewReceptionist.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiAddNewReceptionist.Name = "tsmiAddNewReceptionist";
            tsmiAddNewReceptionist.Size = new System.Drawing.Size(328, 30);
            tsmiAddNewReceptionist.Text = "Add New Receptionist";
            tsmiAddNewReceptionist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiAddNewReceptionist.Click += tsmiAddNewReceptionist_Click;
            // 
            // tsmPersonalInformation
            // 
            tsmPersonalInformation.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmPersonalInformation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmPersonalInformation.Name = "tsmPersonalInformation";
            tsmPersonalInformation.Size = new System.Drawing.Size(328, 30);
            tsmPersonalInformation.Text = "Edit Receptionist";
            tsmPersonalInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmPersonalInformation.Click += tsmEditReceptionist_Click;
            // 
            // tsmShowReceptionistInfo
            // 
            tsmShowReceptionistInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmShowReceptionistInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmShowReceptionistInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmShowReceptionistInfo.Name = "tsmShowReceptionistInfo";
            tsmShowReceptionistInfo.Size = new System.Drawing.Size(328, 30);
            tsmShowReceptionistInfo.Text = "Receptionist Information";
            tsmShowReceptionistInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmShowReceptionistInfo.Click += tsmShowReceptionistInfo_Click;
            // 
            // tsmiPersonalInformation
            // 
            tsmiPersonalInformation.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiPersonalInformation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiPersonalInformation.Name = "tsmiPersonalInformation";
            tsmiPersonalInformation.Size = new System.Drawing.Size(328, 30);
            tsmiPersonalInformation.Text = "Personal Information";
            tsmiPersonalInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiPersonalInformation.Click += tsmiPersonalInformation_Click;
            // 
            // tsmiReceptionistUserInfo
            // 
            tsmiReceptionistUserInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiReceptionistUserInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiReceptionistUserInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiReceptionistUserInfo.Name = "tsmiReceptionistUserInfo";
            tsmiReceptionistUserInfo.Size = new System.Drawing.Size(328, 30);
            tsmiReceptionistUserInfo.Text = "Receptionist User Information";
            tsmiReceptionistUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiReceptionistUserInfo.Click += tsmiReceptionistUserInfo_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHeader.Location = new System.Drawing.Point(460, 124);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(409, 40);
            lblHeader.TabIndex = 6;
            lblHeader.Text = "RECEPTIONIST MANAGEMENT";
            // 
            // btnAddReceptionist
            // 
            btnAddReceptionist.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnAddReceptionist.BackgroundImage = Properties.Resources.Add_NewV2;
            btnAddReceptionist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnAddReceptionist.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddReceptionist.FlatAppearance.BorderSize = 0;
            btnAddReceptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddReceptionist.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAddReceptionist.Location = new System.Drawing.Point(1248, 200);
            btnAddReceptionist.Name = "btnAddReceptionist";
            btnAddReceptionist.Size = new System.Drawing.Size(57, 50);
            btnAddReceptionist.TabIndex = 14;
            btnAddReceptionist.UseVisualStyleBackColor = false;
            btnAddReceptionist.Click += btnAddReceptionist_Click;
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
            cbFilter.Items.AddRange(new object[] { "None", "Receptionist ID", "Full Name", "Status", "Receptionist User" });
            cbFilter.Location = new System.Drawing.Point(121, 213);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new System.Drawing.Size(245, 33);
            cbFilter.TabIndex = 12;
            cbFilter.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // lblRecordsValue
            // 
            lblRecordsValue.AutoSize = true;
            lblRecordsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRecordsValue.Location = new System.Drawing.Point(92, 792);
            lblRecordsValue.Name = "lblRecordsValue";
            lblRecordsValue.Size = new System.Drawing.Size(48, 21);
            lblRecordsValue.TabIndex = 7;
            lblRecordsValue.Text = "[????]";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRecords.Location = new System.Drawing.Point(24, 792);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new System.Drawing.Size(69, 21);
            lblRecords.TabIndex = 8;
            lblRecords.Text = "Records:";
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
            pictureBox1.Image = Properties.Resources.Receptionist;
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
            cbStatus.Items.AddRange(new object[] { "Active", "On Leave", "Resigned", "Terminated" });
            cbStatus.Location = new System.Drawing.Point(372, 213);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new System.Drawing.Size(245, 33);
            cbStatus.TabIndex = 13;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // frmReceptionistManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ClientSize = new System.Drawing.Size(1329, 861);
            Controls.Add(dgvReceptionists);
            Controls.Add(lblHeader);
            Controls.Add(btnAddReceptionist);
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
            Name = "frmReceptionistManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "frmReceptionistManagement";
            Load += frmReceptionistManagement_Load;
            Shown += frmReceptionistManagement_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvReceptionists).EndInit();
            cmsReceptionist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceptionists;
        private System.Windows.Forms.ContextMenuStrip cmsReceptionist;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonalInformation;
        private System.Windows.Forms.ToolStripMenuItem tsmShowReceptionistInfo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAddReceptionist;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblRecordsValue;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiReceptionistUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonalInformation;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewReceptionist;
    }
}