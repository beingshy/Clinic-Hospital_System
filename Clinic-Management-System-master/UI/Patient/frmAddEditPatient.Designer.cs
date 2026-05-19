namespace UI.Patient
{
    partial class frmAddEditPatient
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cbBloodType = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbPatientInfo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedicalHistory = new System.Windows.Forms.TextBox();
            this.txtEmergencyContactPhone = new System.Windows.Forms.TextBox();
            this.txtEmergencyContactName = new System.Windows.Forms.TextBox();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonFinder1 = new UI.People.Controls.ctrlPersonFinder();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbPatientInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 300;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(727, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 38);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(379, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(190, 40);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "ADD PATIENT";
            // 
            // cbBloodType
            // 
            this.cbBloodType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBloodType.DropDownWidth = 245;
            this.cbBloodType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBloodType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBloodType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cbBloodType.FormattingEnabled = true;
            this.cbBloodType.IntegralHeight = false;
            this.cbBloodType.Items.AddRange(new object[] {
            "Not Known",
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.cbBloodType.Location = new System.Drawing.Point(627, 56);
            this.cbBloodType.Name = "cbBloodType";
            this.cbBloodType.Size = new System.Drawing.Size(213, 33);
            this.cbBloodType.TabIndex = 29;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage2.Controls.Add(this.gbPatientInfo);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Patient";
            // 
            // gbPatientInfo
            // 
            this.gbPatientInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gbPatientInfo.Controls.Add(this.pictureBox2);
            this.gbPatientInfo.Controls.Add(this.pictureBox1);
            this.gbPatientInfo.Controls.Add(this.pictureBox3);
            this.gbPatientInfo.Controls.Add(this.pictureBox5);
            this.gbPatientInfo.Controls.Add(this.pictureBox4);
            this.gbPatientInfo.Controls.Add(this.pictureBox6);
            this.gbPatientInfo.Controls.Add(this.cbBloodType);
            this.gbPatientInfo.Controls.Add(this.label4);
            this.gbPatientInfo.Controls.Add(this.label6);
            this.gbPatientInfo.Controls.Add(this.label5);
            this.gbPatientInfo.Controls.Add(this.label3);
            this.gbPatientInfo.Controls.Add(this.label2);
            this.gbPatientInfo.Controls.Add(this.lblPatientID);
            this.gbPatientInfo.Controls.Add(this.label1);
            this.gbPatientInfo.Controls.Add(this.txtMedicalHistory);
            this.gbPatientInfo.Controls.Add(this.txtEmergencyContactPhone);
            this.gbPatientInfo.Controls.Add(this.txtEmergencyContactName);
            this.gbPatientInfo.Controls.Add(this.txtAllergies);
            this.gbPatientInfo.Enabled = false;
            this.gbPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbPatientInfo.Location = new System.Drawing.Point(13, 10);
            this.gbPatientInfo.Name = "gbPatientInfo";
            this.gbPatientInfo.Size = new System.Drawing.Size(866, 453);
            this.gbPatientInfo.TabIndex = 27;
            this.gbPatientInfo.TabStop = false;
            this.gbPatientInfo.Text = "Patient Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Med. History:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "E. Contact Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "E. Contact Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Allergies:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Patient ID:";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(174, 59);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(60, 25);
            this.lblPatientID.TabIndex = 22;
            this.lblPatientID.Text = "[????]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Blood Type:";
            // 
            // txtMedicalHistory
            // 
            this.txtMedicalHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtMedicalHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedicalHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicalHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtMedicalHistory.Location = new System.Drawing.Point(179, 280);
            this.txtMedicalHistory.Multiline = true;
            this.txtMedicalHistory.Name = "txtMedicalHistory";
            this.txtMedicalHistory.Size = new System.Drawing.Size(661, 106);
            this.txtMedicalHistory.TabIndex = 18;
            this.txtMedicalHistory.Tag = "0";
            this.txtMedicalHistory.UseSystemPasswordChar = true;
            // 
            // txtEmergencyContactPhone
            // 
            this.txtEmergencyContactPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtEmergencyContactPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmergencyContactPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergencyContactPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtEmergencyContactPhone.Location = new System.Drawing.Point(627, 208);
            this.txtEmergencyContactPhone.Name = "txtEmergencyContactPhone";
            this.txtEmergencyContactPhone.Size = new System.Drawing.Size(213, 33);
            this.txtEmergencyContactPhone.TabIndex = 18;
            this.txtEmergencyContactPhone.Tag = "0";
            this.txtEmergencyContactPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonDigitInput);
            // 
            // txtEmergencyContactName
            // 
            this.txtEmergencyContactName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtEmergencyContactName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmergencyContactName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergencyContactName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtEmergencyContactName.Location = new System.Drawing.Point(627, 132);
            this.txtEmergencyContactName.Name = "txtEmergencyContactName";
            this.txtEmergencyContactName.Size = new System.Drawing.Size(213, 33);
            this.txtEmergencyContactName.TabIndex = 18;
            this.txtEmergencyContactName.Tag = "0";
            this.txtEmergencyContactName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonLetterInput);
            // 
            // txtAllergies
            // 
            this.txtAllergies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtAllergies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAllergies.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllergies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAllergies.Location = new System.Drawing.Point(179, 132);
            this.txtAllergies.Multiline = true;
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(213, 106);
            this.txtAllergies.TabIndex = 18;
            this.txtAllergies.Tag = "0";
            this.txtAllergies.UseSystemPasswordChar = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(724, 470);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(152, 38);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonFinder1
            // 
            this.ctrlPersonFinder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ctrlPersonFinder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonFinder1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlPersonFinder1.Location = new System.Drawing.Point(13, 11);
            this.ctrlPersonFinder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonFinder1.Name = "ctrlPersonFinder1";
            this.ctrlPersonFinder1.SearchEnabled = true;
            this.ctrlPersonFinder1.Size = new System.Drawing.Size(872, 462);
            this.ctrlPersonFinder1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.ctrlPersonFinder1);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Person";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 550);
            this.tabControl1.TabIndex = 4;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::UI.Properties.Resources.Hashtag;
            this.pictureBox6.Location = new System.Drawing.Point(146, 60);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::UI.Properties.Resources.Allergies;
            this.pictureBox4.Location = new System.Drawing.Point(146, 136);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::UI.Properties.Resources.history;
            this.pictureBox5.Location = new System.Drawing.Point(146, 284);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI.Properties.Resources.Blood_type;
            this.pictureBox3.Location = new System.Drawing.Point(594, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.Phone;
            this.pictureBox2.Location = new System.Drawing.Point(594, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Fullname;
            this.pictureBox1.Location = new System.Drawing.Point(594, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddEditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(948, 645);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddEditPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditPatient";
            this.Load += new System.EventHandler(this.frmAddEditPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbPatientInfo.ResumeLayout(false);
            this.gbPatientInfo.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNext;
        private People.Controls.ctrlPersonFinder ctrlPersonFinder1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbPatientInfo;
        private System.Windows.Forms.ComboBox cbBloodType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedicalHistory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox txtEmergencyContactPhone;
        private System.Windows.Forms.TextBox txtEmergencyContactName;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}