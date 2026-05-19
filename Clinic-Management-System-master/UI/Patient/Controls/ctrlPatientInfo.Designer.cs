namespace UI.Patient.Controls
{
    partial class ctrlPatientInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCreatedByAt = new System.Windows.Forms.Label();
            this.lblUpdatedByAt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMedicalHistory = new System.Windows.Forms.Label();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.lblEmergencyContactPhone = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblEmergencyContactName = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPatientInformation = new System.Windows.Forms.GroupBox();
            this.ctrlPersonInfo1 = new UI.People.Controls.ctrlPersonInfo();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gbPatientInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreatedByAt
            // 
            this.lblCreatedByAt.AutoSize = true;
            this.lblCreatedByAt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByAt.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCreatedByAt.Location = new System.Drawing.Point(37, 206);
            this.lblCreatedByAt.Name = "lblCreatedByAt";
            this.lblCreatedByAt.Size = new System.Drawing.Size(160, 20);
            this.lblCreatedByAt.TabIndex = 0;
            this.lblCreatedByAt.Text = "Created By [??] At [??] ";
            // 
            // lblUpdatedByAt
            // 
            this.lblUpdatedByAt.AutoSize = true;
            this.lblUpdatedByAt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatedByAt.ForeColor = System.Drawing.Color.DarkGray;
            this.lblUpdatedByAt.Location = new System.Drawing.Point(37, 228);
            this.lblUpdatedByAt.Name = "lblUpdatedByAt";
            this.lblUpdatedByAt.Size = new System.Drawing.Size(187, 20);
            this.lblUpdatedByAt.TabIndex = 0;
            this.lblUpdatedByAt.Text = "Last Update By [??] At [??] ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(459, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "E. Contact Phone:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(459, 45);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 25);
            this.label20.TabIndex = 0;
            this.label20.Text = "Blood Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(459, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "E. Contact Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Med. History:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Allergies:";
            // 
            // lblMedicalHistory
            // 
            this.lblMedicalHistory.AutoSize = true;
            this.lblMedicalHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalHistory.Location = new System.Drawing.Point(186, 165);
            this.lblMedicalHistory.Name = "lblMedicalHistory";
            this.lblMedicalHistory.Size = new System.Drawing.Size(60, 25);
            this.lblMedicalHistory.TabIndex = 0;
            this.lblMedicalHistory.Text = "[????]";
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergies.Location = new System.Drawing.Point(186, 105);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(60, 25);
            this.lblAllergies.TabIndex = 0;
            this.lblAllergies.Text = "[????]";
            // 
            // lblEmergencyContactPhone
            // 
            this.lblEmergencyContactPhone.AutoSize = true;
            this.lblEmergencyContactPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyContactPhone.Location = new System.Drawing.Point(652, 165);
            this.lblEmergencyContactPhone.Name = "lblEmergencyContactPhone";
            this.lblEmergencyContactPhone.Size = new System.Drawing.Size(60, 25);
            this.lblEmergencyContactPhone.TabIndex = 0;
            this.lblEmergencyContactPhone.Text = "[????]";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodType.Location = new System.Drawing.Point(652, 45);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(60, 25);
            this.lblBloodType.TabIndex = 0;
            this.lblBloodType.Text = "[????]";
            // 
            // lblEmergencyContactName
            // 
            this.lblEmergencyContactName.AutoSize = true;
            this.lblEmergencyContactName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyContactName.Location = new System.Drawing.Point(652, 105);
            this.lblEmergencyContactName.Name = "lblEmergencyContactName";
            this.lblEmergencyContactName.Size = new System.Drawing.Size(60, 25);
            this.lblEmergencyContactName.TabIndex = 0;
            this.lblEmergencyContactName.Text = "[????]";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(186, 45);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(60, 25);
            this.lblPatientID.TabIndex = 0;
            this.lblPatientID.Text = "[????]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID:";
            // 
            // gbPatientInformation
            // 
            this.gbPatientInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gbPatientInformation.Controls.Add(this.pictureBox3);
            this.gbPatientInformation.Controls.Add(this.pictureBox8);
            this.gbPatientInformation.Controls.Add(this.pictureBox2);
            this.gbPatientInformation.Controls.Add(this.pictureBox5);
            this.gbPatientInformation.Controls.Add(this.pictureBox1);
            this.gbPatientInformation.Controls.Add(this.pictureBox4);
            this.gbPatientInformation.Controls.Add(this.lblCreatedByAt);
            this.gbPatientInformation.Controls.Add(this.lblUpdatedByAt);
            this.gbPatientInformation.Controls.Add(this.label9);
            this.gbPatientInformation.Controls.Add(this.label20);
            this.gbPatientInformation.Controls.Add(this.label7);
            this.gbPatientInformation.Controls.Add(this.label8);
            this.gbPatientInformation.Controls.Add(this.label6);
            this.gbPatientInformation.Controls.Add(this.lblMedicalHistory);
            this.gbPatientInformation.Controls.Add(this.lblAllergies);
            this.gbPatientInformation.Controls.Add(this.lblEmergencyContactPhone);
            this.gbPatientInformation.Controls.Add(this.lblBloodType);
            this.gbPatientInformation.Controls.Add(this.lblEmergencyContactName);
            this.gbPatientInformation.Controls.Add(this.lblPatientID);
            this.gbPatientInformation.Controls.Add(this.label1);
            this.gbPatientInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbPatientInformation.Location = new System.Drawing.Point(3, 344);
            this.gbPatientInformation.Name = "gbPatientInformation";
            this.gbPatientInformation.Size = new System.Drawing.Size(852, 264);
            this.gbPatientInformation.TabIndex = 3;
            this.gbPatientInformation.TabStop = false;
            this.gbPatientInformation.Text = "Patient Information";
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ctrlPersonInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(-7, -11);
            this.ctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(873, 359);
            this.ctrlPersonInfo1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI.Properties.Resources.Blood_type;
            this.pictureBox3.Location = new System.Drawing.Point(620, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::UI.Properties.Resources.Hashtag;
            this.pictureBox8.Location = new System.Drawing.Point(156, 45);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.Phone;
            this.pictureBox2.Location = new System.Drawing.Point(620, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::UI.Properties.Resources.history;
            this.pictureBox5.Location = new System.Drawing.Point(156, 165);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Fullname;
            this.pictureBox1.Location = new System.Drawing.Point(620, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::UI.Properties.Resources.Allergies;
            this.pictureBox4.Location = new System.Drawing.Point(156, 105);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // ctrlPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.gbPatientInformation);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlPatientInfo";
            this.Size = new System.Drawing.Size(859, 619);
            this.gbPatientInformation.ResumeLayout(false);
            this.gbPatientInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.Label lblCreatedByAt;
        private System.Windows.Forms.Label lblUpdatedByAt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMedicalHistory;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.Label lblEmergencyContactPhone;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblEmergencyContactName;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPatientInformation;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
