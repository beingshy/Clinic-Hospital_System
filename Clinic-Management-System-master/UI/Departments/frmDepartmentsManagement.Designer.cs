namespace UI.Departments
{
    partial class frmDepartmentsManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            dgvDepartments = new System.Windows.Forms.DataGridView();
            cmsDepartments = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiAddNewDepartment = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            lblHeader = new System.Windows.Forms.Label();
            lblRecordsValue = new System.Windows.Forms.Label();
            lblRecords = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            lblTotalDepartmentsValue = new System.Windows.Forms.Label();
            lblTotalDepartments = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            lblTotalDoctorsValue = new System.Windows.Forms.Label();
            lblTotalDoctorsInDepartment = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            lblTotalVisitsValue = new System.Windows.Forms.Label();
            lblTotalVisitOfDepartment = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            pbRiyalSymbol = new System.Windows.Forms.PictureBox();
            lblTotalRevenueValue = new System.Windows.Forms.Label();
            lblTotalRevenueOfDepartment = new System.Windows.Forms.Label();
            btnAddDepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            cmsDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRiyalSymbol).BeginInit();
            SuspendLayout();
            // 
            // dgvDepartments
            // 
            dgvDepartments.AllowUserToAddRows = false;
            dgvDepartments.AllowUserToDeleteRows = false;
            dgvDepartments.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            dgvDepartments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDepartments.BackgroundColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dgvDepartments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvDepartments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgvDepartments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvDepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvDepartments.ColumnHeadersHeight = 40;
            dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDepartments.ContextMenuStrip = cmsDepartments;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvDepartments.DefaultCellStyle = dataGridViewCellStyle7;
            dgvDepartments.EnableHeadersVisualStyles = false;
            dgvDepartments.Location = new System.Drawing.Point(24, 252);
            dgvDepartments.MultiSelect = false;
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.ReadOnly = true;
            dgvDepartments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvDepartments.RowHeadersVisible = false;
            dgvDepartments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvDepartments.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvDepartments.RowTemplate.Height = 35;
            dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDepartments.ShowCellErrors = false;
            dgvDepartments.ShowCellToolTips = false;
            dgvDepartments.ShowEditingIcon = false;
            dgvDepartments.ShowRowErrors = false;
            dgvDepartments.Size = new System.Drawing.Size(806, 532);
            dgvDepartments.TabIndex = 11;
            dgvDepartments.SelectionChanged += dgvDepartments_SelectionChanged;
            // 
            // cmsDepartments
            // 
            cmsDepartments.BackColor = System.Drawing.SystemColors.Control;
            cmsDepartments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiAddNewDepartment, toolStripMenuItem1 });
            cmsDepartments.Name = "cmsPerson";
            cmsDepartments.Size = new System.Drawing.Size(262, 64);
            // 
            // tsmiAddNewDepartment
            // 
            tsmiAddNewDepartment.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiAddNewDepartment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiAddNewDepartment.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiAddNewDepartment.Name = "tsmiAddNewDepartment";
            tsmiAddNewDepartment.Size = new System.Drawing.Size(261, 30);
            tsmiAddNewDepartment.Text = "Add New Department";
            tsmiAddNewDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiAddNewDepartment.Click += tsmiAddNewDepartment_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(261, 30);
            toolStripMenuItem1.Text = "Edit Department";
            toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolStripMenuItem1.Click += tsmiEditDepartment_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHeader.Location = new System.Drawing.Point(464, 124);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(400, 40);
            lblHeader.TabIndex = 6;
            lblHeader.Text = "DEPARTMENT MANAGEMENT";
            // 
            // lblRecordsValue
            // 
            lblRecordsValue.AutoSize = true;
            lblRecordsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRecordsValue.Location = new System.Drawing.Point(90, 792);
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Departments;
            pictureBox1.Location = new System.Drawing.Point(598, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(133, 103);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(117, 82, 82);
            panel1.Controls.Add(lblTotalDepartmentsValue);
            panel1.Controls.Add(lblTotalDepartments);
            panel1.Location = new System.Drawing.Point(845, 252);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(460, 121);
            panel1.TabIndex = 15;
            // 
            // lblTotalDepartmentsValue
            // 
            lblTotalDepartmentsValue.AutoSize = true;
            lblTotalDepartmentsValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalDepartmentsValue.Location = new System.Drawing.Point(7, 12);
            lblTotalDepartmentsValue.Name = "lblTotalDepartmentsValue";
            lblTotalDepartmentsValue.Size = new System.Drawing.Size(148, 65);
            lblTotalDepartmentsValue.TabIndex = 16;
            lblTotalDepartmentsValue.Text = "[????]";
            lblTotalDepartmentsValue.Visible = false;
            // 
            // lblTotalDepartments
            // 
            lblTotalDepartments.AutoSize = true;
            lblTotalDepartments.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalDepartments.Location = new System.Drawing.Point(12, 77);
            lblTotalDepartments.Name = "lblTotalDepartments";
            lblTotalDepartments.Size = new System.Drawing.Size(217, 32);
            lblTotalDepartments.TabIndex = 16;
            lblTotalDepartments.Text = "Total Departments";
            lblTotalDepartments.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(82, 91, 117);
            panel2.Controls.Add(lblTotalDoctorsValue);
            panel2.Controls.Add(lblTotalDoctorsInDepartment);
            panel2.Location = new System.Drawing.Point(845, 389);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(460, 121);
            panel2.TabIndex = 15;
            // 
            // lblTotalDoctorsValue
            // 
            lblTotalDoctorsValue.AutoSize = true;
            lblTotalDoctorsValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalDoctorsValue.Location = new System.Drawing.Point(7, 12);
            lblTotalDoctorsValue.Name = "lblTotalDoctorsValue";
            lblTotalDoctorsValue.Size = new System.Drawing.Size(148, 65);
            lblTotalDoctorsValue.TabIndex = 16;
            lblTotalDoctorsValue.Text = "[????]";
            lblTotalDoctorsValue.Visible = false;
            // 
            // lblTotalDoctorsInDepartment
            // 
            lblTotalDoctorsInDepartment.AutoSize = true;
            lblTotalDoctorsInDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalDoctorsInDepartment.Location = new System.Drawing.Point(12, 77);
            lblTotalDoctorsInDepartment.Name = "lblTotalDoctorsInDepartment";
            lblTotalDoctorsInDepartment.Size = new System.Drawing.Size(305, 25);
            lblTotalDoctorsInDepartment.TabIndex = 16;
            lblTotalDoctorsInDepartment.Text = "Total Doctors in [????] Department";
            lblTotalDoctorsInDepartment.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(82, 91, 117);
            panel3.Controls.Add(lblTotalVisitsValue);
            panel3.Controls.Add(lblTotalVisitOfDepartment);
            panel3.Location = new System.Drawing.Point(845, 526);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(460, 121);
            panel3.TabIndex = 15;
            // 
            // lblTotalVisitsValue
            // 
            lblTotalVisitsValue.AutoSize = true;
            lblTotalVisitsValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalVisitsValue.Location = new System.Drawing.Point(7, 12);
            lblTotalVisitsValue.Name = "lblTotalVisitsValue";
            lblTotalVisitsValue.Size = new System.Drawing.Size(148, 65);
            lblTotalVisitsValue.TabIndex = 16;
            lblTotalVisitsValue.Text = "[????]";
            lblTotalVisitsValue.Visible = false;
            // 
            // lblTotalVisitOfDepartment
            // 
            lblTotalVisitOfDepartment.AutoSize = true;
            lblTotalVisitOfDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalVisitOfDepartment.Location = new System.Drawing.Point(12, 77);
            lblTotalVisitOfDepartment.Name = "lblTotalVisitOfDepartment";
            lblTotalVisitOfDepartment.Size = new System.Drawing.Size(285, 25);
            lblTotalVisitOfDepartment.TabIndex = 16;
            lblTotalVisitOfDepartment.Text = "Total Visits of [????] Department";
            lblTotalVisitOfDepartment.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(82, 117, 91);
            panel4.Controls.Add(pbRiyalSymbol);
            panel4.Controls.Add(lblTotalRevenueValue);
            panel4.Controls.Add(lblTotalRevenueOfDepartment);
            panel4.Location = new System.Drawing.Point(845, 663);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(460, 121);
            panel4.TabIndex = 15;
            // 
            // pbRiyalSymbol
            // 
            pbRiyalSymbol.Image = Properties.Resources.Saudi_Riyal_Symbol;
            pbRiyalSymbol.Location = new System.Drawing.Point(17, 27);
            pbRiyalSymbol.Name = "pbRiyalSymbol";
            pbRiyalSymbol.Size = new System.Drawing.Size(42, 47);
            pbRiyalSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbRiyalSymbol.TabIndex = 41;
            pbRiyalSymbol.TabStop = false;
            pbRiyalSymbol.Visible = false;
            // 
            // lblTotalRevenueValue
            // 
            lblTotalRevenueValue.AutoSize = true;
            lblTotalRevenueValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalRevenueValue.Location = new System.Drawing.Point(56, 15);
            lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            lblTotalRevenueValue.Size = new System.Drawing.Size(148, 65);
            lblTotalRevenueValue.TabIndex = 16;
            lblTotalRevenueValue.Text = "[????]";
            lblTotalRevenueValue.Visible = false;
            // 
            // lblTotalRevenueOfDepartment
            // 
            lblTotalRevenueOfDepartment.AutoSize = true;
            lblTotalRevenueOfDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalRevenueOfDepartment.Location = new System.Drawing.Point(12, 77);
            lblTotalRevenueOfDepartment.Name = "lblTotalRevenueOfDepartment";
            lblTotalRevenueOfDepartment.Size = new System.Drawing.Size(313, 25);
            lblTotalRevenueOfDepartment.TabIndex = 16;
            lblTotalRevenueOfDepartment.Text = "Total Revenue of [????] Department";
            lblTotalRevenueOfDepartment.Visible = false;
            // 
            // btnAddDepartment
            // 
            btnAddDepartment.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnAddDepartment.BackgroundImage = Properties.Resources.Add_NewV2;
            btnAddDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnAddDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddDepartment.FlatAppearance.BorderSize = 0;
            btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddDepartment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAddDepartment.Location = new System.Drawing.Point(24, 196);
            btnAddDepartment.Name = "btnAddDepartment";
            btnAddDepartment.Size = new System.Drawing.Size(57, 50);
            btnAddDepartment.TabIndex = 16;
            btnAddDepartment.UseVisualStyleBackColor = false;
            btnAddDepartment.Click += btnAddDepartment_Click;
            // 
            // frmDepartmentsManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ClientSize = new System.Drawing.Size(1329, 861);
            Controls.Add(btnAddDepartment);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvDepartments);
            Controls.Add(lblHeader);
            Controls.Add(lblRecordsValue);
            Controls.Add(lblRecords);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "frmDepartmentsManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "frmDepartmentsManagement";
            Load += frmDepartmentsManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            cmsDepartments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRiyalSymbol).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.ContextMenuStrip cmsDepartments;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblRecordsValue;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalDepartmentsValue;
        private System.Windows.Forms.Label lblTotalDepartments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalDoctorsValue;
        private System.Windows.Forms.Label lblTotalDoctorsInDepartment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalVisitsValue;
        private System.Windows.Forms.Label lblTotalVisitOfDepartment;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalRevenueValue;
        private System.Windows.Forms.Label lblTotalRevenueOfDepartment;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.PictureBox pbRiyalSymbol;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewDepartment;
    }
}