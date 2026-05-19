namespace UI.Appointments
{
    partial class frmAddEditAppointment
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.txtAppointmentStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbAppointmentDetails = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.lblMedicalRecordID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlSmallPatientFinder1 = new UI.Patient.Controls.ctrlSmallPatientFinder();
            this.ctrlctrlSmallDoctorFinder1 = new UI.Doctor.Controls.ctrlSmallDoctorFinder();
            this.gbAppointmentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(558, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(280, 40);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "ADD APPOINTMENT";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpAppointmentDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpAppointmentDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(178, 51);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(206, 29);
            this.dtpAppointmentDate.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Time:";
            // 
            // dtpAppointmentTime
            // 
            this.dtpAppointmentTime.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpAppointmentTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpAppointmentTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAppointmentTime.Location = new System.Drawing.Point(178, 122);
            this.dtpAppointmentTime.Name = "dtpAppointmentTime";
            this.dtpAppointmentTime.ShowUpDown = true;
            this.dtpAppointmentTime.Size = new System.Drawing.Size(206, 29);
            this.dtpAppointmentTime.TabIndex = 32;
            this.dtpAppointmentTime.Value = new System.DateTime(2025, 2, 14, 8, 0, 0, 0);
            // 
            // txtAppointmentStatus
            // 
            this.txtAppointmentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtAppointmentStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAppointmentStatus.Enabled = false;
            this.txtAppointmentStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointmentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAppointmentStatus.Location = new System.Drawing.Point(178, 192);
            this.txtAppointmentStatus.Name = "txtAppointmentStatus";
            this.txtAppointmentStatus.Size = new System.Drawing.Size(206, 33);
            this.txtAppointmentStatus.TabIndex = 33;
            this.txtAppointmentStatus.Tag = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Payment ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Med. Record:";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(178, 267);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(206, 33);
            this.btnPay.TabIndex = 34;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(178, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(206, 33);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbAppointmentDetails
            // 
            this.gbAppointmentDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gbAppointmentDetails.Controls.Add(this.pictureBox6);
            this.gbAppointmentDetails.Controls.Add(this.pictureBox5);
            this.gbAppointmentDetails.Controls.Add(this.pictureBox3);
            this.gbAppointmentDetails.Controls.Add(this.pictureBox2);
            this.gbAppointmentDetails.Controls.Add(this.pictureBox1);
            this.gbAppointmentDetails.Controls.Add(this.lblPaymentID);
            this.gbAppointmentDetails.Controls.Add(this.lblMedicalRecordID);
            this.gbAppointmentDetails.Controls.Add(this.label9);
            this.gbAppointmentDetails.Controls.Add(this.btnAdd);
            this.gbAppointmentDetails.Controls.Add(this.dtpAppointmentDate);
            this.gbAppointmentDetails.Controls.Add(this.label1);
            this.gbAppointmentDetails.Controls.Add(this.label4);
            this.gbAppointmentDetails.Controls.Add(this.label2);
            this.gbAppointmentDetails.Controls.Add(this.txtAppointmentStatus);
            this.gbAppointmentDetails.Controls.Add(this.dtpAppointmentTime);
            this.gbAppointmentDetails.Controls.Add(this.label3);
            this.gbAppointmentDetails.Controls.Add(this.btnPay);
            this.gbAppointmentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbAppointmentDetails.Location = new System.Drawing.Point(960, 150);
            this.gbAppointmentDetails.Name = "gbAppointmentDetails";
            this.gbAppointmentDetails.Size = new System.Drawing.Size(415, 403);
            this.gbAppointmentDetails.TabIndex = 35;
            this.gbAppointmentDetails.TabStop = false;
            this.gbAppointmentDetails.Text = "Appointment Details";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::UI.Properties.Resources.history;
            this.pictureBox6.Location = new System.Drawing.Point(142, 346);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 36;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::UI.Properties.Resources.Hashtag;
            this.pictureBox5.Location = new System.Drawing.Point(142, 271);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI.Properties.Resources.Status;
            this.pictureBox3.Location = new System.Drawing.Point(142, 196);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.Time;
            this.pictureBox2.Location = new System.Drawing.Point(142, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Date;
            this.pictureBox1.Location = new System.Drawing.Point(142, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentID.Location = new System.Drawing.Point(173, 271);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(45, 25);
            this.lblPaymentID.TabIndex = 35;
            this.lblPaymentID.Text = "N/A";
            this.lblPaymentID.Visible = false;
            // 
            // lblMedicalRecordID
            // 
            this.lblMedicalRecordID.AutoSize = true;
            this.lblMedicalRecordID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMedicalRecordID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalRecordID.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMedicalRecordID.Location = new System.Drawing.Point(173, 346);
            this.lblMedicalRecordID.Name = "lblMedicalRecordID";
            this.lblMedicalRecordID.Size = new System.Drawing.Size(45, 25);
            this.lblMedicalRecordID.TabIndex = 35;
            this.lblMedicalRecordID.Text = "N/A";
            this.lblMedicalRecordID.Visible = false;
            this.lblMedicalRecordID.Click += new System.EventHandler(this.lblMedicalRecordID_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1223, 571);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 38);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlSmallPatientFinder1
            // 
            this.ctrlSmallPatientFinder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ctrlSmallPatientFinder1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSmallPatientFinder1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlSmallPatientFinder1.Location = new System.Drawing.Point(491, 99);
            this.ctrlSmallPatientFinder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSmallPatientFinder1.Name = "ctrlSmallPatientFinder1";
            this.ctrlSmallPatientFinder1.Size = new System.Drawing.Size(444, 468);
            this.ctrlSmallPatientFinder1.TabIndex = 5;
            // 
            // ctrlctrlSmallDoctorFinder1
            // 
            this.ctrlctrlSmallDoctorFinder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ctrlctrlSmallDoctorFinder1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlctrlSmallDoctorFinder1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlctrlSmallDoctorFinder1.Location = new System.Drawing.Point(22, 99);
            this.ctrlctrlSmallDoctorFinder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlctrlSmallDoctorFinder1.Name = "ctrlctrlSmallDoctorFinder1";
            this.ctrlctrlSmallDoctorFinder1.Size = new System.Drawing.Size(444, 468);
            this.ctrlctrlSmallDoctorFinder1.TabIndex = 4;
            // 
            // frmAddEditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1396, 637);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbAppointmentDetails);
            this.Controls.Add(this.ctrlSmallPatientFinder1);
            this.Controls.Add(this.ctrlctrlSmallDoctorFinder1);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddEditAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditAppointment";
            this.Load += new System.EventHandler(this.frmAddOrUpdateAppointment_Load);
            this.gbAppointmentDetails.ResumeLayout(false);
            this.gbAppointmentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private Doctor.Controls.ctrlSmallDoctorFinder ctrlctrlSmallDoctorFinder1;
        private Patient.Controls.ctrlSmallPatientFinder ctrlSmallPatientFinder1;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAppointmentTime;
        private System.Windows.Forms.TextBox txtAppointmentStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbAppointmentDetails;
        private System.Windows.Forms.Label lblMedicalRecordID;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}