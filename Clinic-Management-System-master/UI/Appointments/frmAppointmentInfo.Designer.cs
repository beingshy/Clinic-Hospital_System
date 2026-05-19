namespace UI.Appointments
{
    partial class frmAppointmentInfo
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
            this.ctrlSmallAppointmentInfo1 = new UI.Appointments.Controls.ctrlSmallAppointmentInfo();
            this.ctrlSmallDoctorInfo1 = new UI.Doctor.Controls.ctrlSmallDoctorInfo();
            this.ctrlSmallPatientInfo1 = new UI.Patient.Controls.ctrlSmallPatientInfo();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlSmallAppointmentInfo1
            // 
            this.ctrlSmallAppointmentInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ctrlSmallAppointmentInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSmallAppointmentInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlSmallAppointmentInfo1.Location = new System.Drawing.Point(860, 70);
            this.ctrlSmallAppointmentInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSmallAppointmentInfo1.Name = "ctrlSmallAppointmentInfo1";
            this.ctrlSmallAppointmentInfo1.Size = new System.Drawing.Size(433, 422);
            this.ctrlSmallAppointmentInfo1.TabIndex = 0;
            // 
            // ctrlSmallDoctorInfo1
            // 
            this.ctrlSmallDoctorInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ctrlSmallDoctorInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSmallDoctorInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlSmallDoctorInfo1.Location = new System.Drawing.Point(10, 70);
            this.ctrlSmallDoctorInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSmallDoctorInfo1.Name = "ctrlSmallDoctorInfo1";
            this.ctrlSmallDoctorInfo1.Size = new System.Drawing.Size(433, 422);
            this.ctrlSmallDoctorInfo1.TabIndex = 1;
            // 
            // ctrlSmallPatientInfo1
            // 
            this.ctrlSmallPatientInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ctrlSmallPatientInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSmallPatientInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlSmallPatientInfo1.Location = new System.Drawing.Point(435, 70);
            this.ctrlSmallPatientInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSmallPatientInfo1.Name = "ctrlSmallPatientInfo1";
            this.ctrlSmallPatientInfo1.Size = new System.Drawing.Size(433, 422);
            this.ctrlSmallPatientInfo1.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(444, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(414, 40);
            this.lblHeader.TabIndex = 18;
            this.lblHeader.Text = "APPOINTMENT INFORMATION";
            // 
            // frmAppointmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1302, 506);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.ctrlSmallPatientInfo1);
            this.Controls.Add(this.ctrlSmallDoctorInfo1);
            this.Controls.Add(this.ctrlSmallAppointmentInfo1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAppointmentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAppointmentInfo";
            this.Load += new System.EventHandler(this.frmAppointmentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlSmallAppointmentInfo ctrlSmallAppointmentInfo1;
        private Doctor.Controls.ctrlSmallDoctorInfo ctrlSmallDoctorInfo1;
        private Patient.Controls.ctrlSmallPatientInfo ctrlSmallPatientInfo1;
        private System.Windows.Forms.Label lblHeader;
    }
}