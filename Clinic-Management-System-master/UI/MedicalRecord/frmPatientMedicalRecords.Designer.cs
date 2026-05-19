namespace UI.MedicalRecord
{
    partial class frmPatientMedicalRecords
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
            cmsMedicalRecords = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiMedicalRecordInfo = new System.Windows.Forms.ToolStripMenuItem();
            lblRecordsValue = new System.Windows.Forms.Label();
            lblRecords = new System.Windows.Forms.Label();
            dgvMedicalRecords = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblHeader = new System.Windows.Forms.Label();
            cmsMedicalRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicalRecords).BeginInit();
            SuspendLayout();
            // 
            // cmsMedicalRecords
            // 
            cmsMedicalRecords.BackColor = System.Drawing.SystemColors.Control;
            cmsMedicalRecords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiMedicalRecordInfo });
            cmsMedicalRecords.Name = "cmsPerson";
            cmsMedicalRecords.Size = new System.Drawing.Size(248, 34);
            // 
            // tsmiMedicalRecordInfo
            // 
            tsmiMedicalRecordInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tsmiMedicalRecordInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tsmiMedicalRecordInfo.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            tsmiMedicalRecordInfo.Name = "tsmiMedicalRecordInfo";
            tsmiMedicalRecordInfo.Size = new System.Drawing.Size(247, 30);
            tsmiMedicalRecordInfo.Text = "Medical Record Info";
            tsmiMedicalRecordInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsmiMedicalRecordInfo.Click += tsmiMedicalRecordInfo_Click;
            // 
            // lblRecordsValue
            // 
            lblRecordsValue.AutoSize = true;
            lblRecordsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRecordsValue.Location = new System.Drawing.Point(91, 601);
            lblRecordsValue.Name = "lblRecordsValue";
            lblRecordsValue.Size = new System.Drawing.Size(48, 21);
            lblRecordsValue.TabIndex = 17;
            lblRecordsValue.Text = "[????]";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRecords.Location = new System.Drawing.Point(25, 601);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new System.Drawing.Size(69, 21);
            lblRecords.TabIndex = 18;
            lblRecords.Text = "Records:";
            // 
            // dgvMedicalRecords
            // 
            dgvMedicalRecords.AllowUserToAddRows = false;
            dgvMedicalRecords.AllowUserToDeleteRows = false;
            dgvMedicalRecords.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            dgvMedicalRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMedicalRecords.BackgroundColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dgvMedicalRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvMedicalRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgvMedicalRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvMedicalRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMedicalRecords.ColumnHeadersHeight = 40;
            dgvMedicalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMedicalRecords.ContextMenuStrip = cmsMedicalRecords;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvMedicalRecords.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMedicalRecords.EnableHeadersVisualStyles = false;
            dgvMedicalRecords.Location = new System.Drawing.Point(26, 99);
            dgvMedicalRecords.MultiSelect = false;
            dgvMedicalRecords.Name = "dgvMedicalRecords";
            dgvMedicalRecords.ReadOnly = true;
            dgvMedicalRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvMedicalRecords.RowHeadersVisible = false;
            dgvMedicalRecords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvMedicalRecords.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvMedicalRecords.RowTemplate.Height = 35;
            dgvMedicalRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMedicalRecords.ShowCellErrors = false;
            dgvMedicalRecords.ShowCellToolTips = false;
            dgvMedicalRecords.ShowEditingIcon = false;
            dgvMedicalRecords.ShowRowErrors = false;
            dgvMedicalRecords.Size = new System.Drawing.Size(1328, 488);
            dgvMedicalRecords.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(91, 601);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 21);
            label1.TabIndex = 21;
            label1.Text = "[????]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(25, 601);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 21);
            label2.TabIndex = 22;
            label2.Text = "Records:";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHeader.Location = new System.Drawing.Point(556, 29);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(268, 40);
            lblHeader.TabIndex = 20;
            lblHeader.Text = "MEDICAL RECORDS";
            // 
            // frmPatientMedicalRecords
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ClientSize = new System.Drawing.Size(1380, 644);
            Controls.Add(dgvMedicalRecords);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblHeader);
            Controls.Add(lblRecordsValue);
            Controls.Add(lblRecords);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "frmPatientMedicalRecords";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmPatientMedicalRecords";
            Load += frmPatientMedicalRecords_Load;
            Shown += frmPatientMedicalRecords_Shown;
            cmsMedicalRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMedicalRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsMedicalRecords;
        private System.Windows.Forms.ToolStripMenuItem tsmiMedicalRecordInfo;
        private System.Windows.Forms.Label lblRecordsValue;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvMedicalRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeader;
    }
}