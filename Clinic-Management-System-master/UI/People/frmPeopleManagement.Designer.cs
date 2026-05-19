namespace UI.People
{
    partial class frmPeopleManagement
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
            lblHeader = new System.Windows.Forms.Label();
            dgvPeople = new System.Windows.Forms.DataGridView();
            cmsPerson = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            tsmPersonalInformation = new System.Windows.Forms.ToolStripMenuItem();
            tsmEditPersonalInformation = new System.Windows.Forms.ToolStripMenuItem();
            lblFilterBy = new System.Windows.Forms.Label();
            cbFilter = new System.Windows.Forms.ComboBox();
            txtSearch = new System.Windows.Forms.TextBox();
            lblOfTotalPagesAndRows = new System.Windows.Forms.Label();
            txtPageNumber = new System.Windows.Forms.TextBox();
            btnCancel = new System.Windows.Forms.Button();
            btnFind = new System.Windows.Forms.Button();
            btnNextPage = new System.Windows.Forms.Button();
            btnPreviousPage = new System.Windows.Forms.Button();
            btnAddPerson = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            cmsPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHeader.Location = new System.Drawing.Point(504, 124);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(321, 40);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "PEOPLE MANAGEMENT";
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            dgvPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPeople.BackgroundColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dgvPeople.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvPeople.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgvPeople.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPeople.ColumnHeadersHeight = 40;
            dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPeople.ContextMenuStrip = cmsPerson;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvPeople.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPeople.EnableHeadersVisualStyles = false;
            dgvPeople.Location = new System.Drawing.Point(24, 254);
            dgvPeople.MultiSelect = false;
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dgvPeople.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvPeople.RowHeadersVisible = false;
            dgvPeople.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvPeople.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPeople.RowTemplate.Height = 35;
            dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPeople.ShowCellErrors = false;
            dgvPeople.ShowCellToolTips = false;
            dgvPeople.ShowEditingIcon = false;
            dgvPeople.ShowRowErrors = false;
            dgvPeople.Size = new System.Drawing.Size(1281, 532);
            dgvPeople.TabIndex = 2;
            // 
            // cmsPerson
            // 
            cmsPerson.BackColor = System.Drawing.SystemColors.Control;
            cmsPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiAddNewPerson, tsmPersonalInformation, tsmEditPersonalInformation });
            cmsPerson.Name = "cmsPerson";
            cmsPerson.Size = new System.Drawing.Size(293, 94);
            // 
            // tsmiAddNewPerson
            // 
            tsmiAddNewPerson.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiAddNewPerson.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiAddNewPerson.Name = "tsmiAddNewPerson";
            tsmiAddNewPerson.Size = new System.Drawing.Size(292, 30);
            tsmiAddNewPerson.Text = "Add New Person";
            tsmiAddNewPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiAddNewPerson.Click += tsmiAddNewPerson_Click;
            // 
            // tsmPersonalInformation
            // 
            tsmPersonalInformation.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmPersonalInformation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmPersonalInformation.Name = "tsmPersonalInformation";
            tsmPersonalInformation.Size = new System.Drawing.Size(292, 30);
            tsmPersonalInformation.Text = "Personal Information";
            tsmPersonalInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmPersonalInformation.Click += tsmPersonalInformation_Click;
            // 
            // tsmEditPersonalInformation
            // 
            tsmEditPersonalInformation.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmEditPersonalInformation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmEditPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmEditPersonalInformation.Name = "tsmEditPersonalInformation";
            tsmEditPersonalInformation.Size = new System.Drawing.Size(292, 30);
            tsmEditPersonalInformation.Text = "Edit Personal Information";
            tsmEditPersonalInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmEditPersonalInformation.Click += tsmEditPersonalInformation_Click;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblFilterBy.Location = new System.Drawing.Point(24, 214);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new System.Drawing.Size(91, 30);
            lblFilterBy.TabIndex = 0;
            lblFilterBy.Text = "Filter By:";
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
            cbFilter.Items.AddRange(new object[] { "None", "Person ID", "Full Name", "National ID" });
            cbFilter.Location = new System.Drawing.Point(121, 213);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new System.Drawing.Size(245, 33);
            cbFilter.TabIndex = 3;
            cbFilter.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
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
            txtSearch.TabIndex = 5;
            txtSearch.Visible = false;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // lblOfTotalPagesAndRows
            // 
            lblOfTotalPagesAndRows.AutoSize = true;
            lblOfTotalPagesAndRows.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblOfTotalPagesAndRows.Location = new System.Drawing.Point(145, 797);
            lblOfTotalPagesAndRows.Name = "lblOfTotalPagesAndRows";
            lblOfTotalPagesAndRows.Size = new System.Drawing.Size(101, 21);
            lblOfTotalPagesAndRows.TabIndex = 0;
            lblOfTotalPagesAndRows.Text = "of [????] (???)";
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
            txtPageNumber.TabIndex = 6;
            txtPageNumber.Text = "1";
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
            btnCancel.TabIndex = 28;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
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
            btnFind.TabIndex = 28;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Visible = false;
            btnFind.Click += btnFind_Click;
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
            btnNextPage.TabIndex = 4;
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
            btnPreviousPage.TabIndex = 4;
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnAddPerson.BackgroundImage = Properties.Resources.Add_NewV2;
            btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddPerson.FlatAppearance.BorderSize = 0;
            btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddPerson.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAddPerson.Location = new System.Drawing.Point(1248, 199);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new System.Drawing.Size(57, 50);
            btnAddPerson.TabIndex = 4;
            btnAddPerson.UseVisualStyleBackColor = false;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PeopleV2;
            pictureBox1.Location = new System.Drawing.Point(598, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(133, 103);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmPeopleManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ClientSize = new System.Drawing.Size(1329, 861);
            Controls.Add(txtPageNumber);
            Controls.Add(btnNextPage);
            Controls.Add(btnPreviousPage);
            Controls.Add(btnAddPerson);
            Controls.Add(cbFilter);
            Controls.Add(dgvPeople);
            Controls.Add(lblOfTotalPagesAndRows);
            Controls.Add(lblFilterBy);
            Controls.Add(lblHeader);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearch);
            Controls.Add(btnCancel);
            Controls.Add(btnFind);
            Font = new System.Drawing.Font("Segoe UI", 12F);
            ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "frmPeopleManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "frmPeopleManagement";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmPeopleManagement_Load;
            Shown += frmPeopleManagement_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            cmsPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblOfTotalPagesAndRows;
        private System.Windows.Forms.ContextMenuStrip cmsPerson;
        private System.Windows.Forms.ToolStripMenuItem tsmEditPersonalInformation;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonalInformation;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewPerson;
    }
}