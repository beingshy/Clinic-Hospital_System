namespace UI.Doctor
{
    partial class frmAddEditDoctor
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbDoctorInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkSetEndDate = new System.Windows.Forms.CheckBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsultationFee = new System.Windows.Forms.TextBox();
            this.txtYearsOfExperience = new System.Windows.Forms.TextBox();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.txtDoctorUsername = new System.Windows.Forms.TextBox();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonFinder1 = new UI.People.Controls.ctrlPersonFinder();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbDoctorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(379, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(197, 40);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "ADD DOCTOR";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 300;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage2.Controls.Add(this.gbDoctorInfo);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Doctor";
            // 
            // gbDoctorInfo
            // 
            this.gbDoctorInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gbDoctorInfo.Controls.Add(this.pictureBox10);
            this.gbDoctorInfo.Controls.Add(this.pictureBox5);
            this.gbDoctorInfo.Controls.Add(this.pictureBox9);
            this.gbDoctorInfo.Controls.Add(this.pictureBox4);
            this.gbDoctorInfo.Controls.Add(this.pictureBox8);
            this.gbDoctorInfo.Controls.Add(this.pictureBox3);
            this.gbDoctorInfo.Controls.Add(this.pictureBox7);
            this.gbDoctorInfo.Controls.Add(this.pictureBox2);
            this.gbDoctorInfo.Controls.Add(this.pictureBox6);
            this.gbDoctorInfo.Controls.Add(this.pictureBox1);
            this.gbDoctorInfo.Controls.Add(this.chkSetEndDate);
            this.gbDoctorInfo.Controls.Add(this.dtpEndDate);
            this.gbDoctorInfo.Controls.Add(this.dtpHireDate);
            this.gbDoctorInfo.Controls.Add(this.cbStatus);
            this.gbDoctorInfo.Controls.Add(this.cbDepartment);
            this.gbDoctorInfo.Controls.Add(this.label6);
            this.gbDoctorInfo.Controls.Add(this.label9);
            this.gbDoctorInfo.Controls.Add(this.label10);
            this.gbDoctorInfo.Controls.Add(this.label5);
            this.gbDoctorInfo.Controls.Add(this.label8);
            this.gbDoctorInfo.Controls.Add(this.label4);
            this.gbDoctorInfo.Controls.Add(this.label7);
            this.gbDoctorInfo.Controls.Add(this.label3);
            this.gbDoctorInfo.Controls.Add(this.label2);
            this.gbDoctorInfo.Controls.Add(this.lblDoctorID);
            this.gbDoctorInfo.Controls.Add(this.label1);
            this.gbDoctorInfo.Controls.Add(this.txtConsultationFee);
            this.gbDoctorInfo.Controls.Add(this.txtYearsOfExperience);
            this.gbDoctorInfo.Controls.Add(this.txtLicenseNumber);
            this.gbDoctorInfo.Controls.Add(this.txtDoctorUsername);
            this.gbDoctorInfo.Controls.Add(this.txtSpecialization);
            this.gbDoctorInfo.Enabled = false;
            this.gbDoctorInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbDoctorInfo.Location = new System.Drawing.Point(13, 10);
            this.gbDoctorInfo.Name = "gbDoctorInfo";
            this.gbDoctorInfo.Size = new System.Drawing.Size(866, 453);
            this.gbDoctorInfo.TabIndex = 27;
            this.gbDoctorInfo.TabStop = false;
            this.gbDoctorInfo.Text = "Doctor Info";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::UI.Properties.Resources.Username;
            this.pictureBox10.Location = new System.Drawing.Point(590, 364);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(27, 25);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 32;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::UI.Properties.Resources.Saudi_Riyal_Symbol;
            this.pictureBox5.Location = new System.Drawing.Point(145, 364);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::UI.Properties.Resources.Date;
            this.pictureBox9.Location = new System.Drawing.Point(590, 290);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(27, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 33;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::UI.Properties.Resources.Date;
            this.pictureBox4.Location = new System.Drawing.Point(145, 290);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::UI.Properties.Resources.Status;
            this.pictureBox8.Location = new System.Drawing.Point(590, 216);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 34;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI.Properties.Resources.Date;
            this.pictureBox3.Location = new System.Drawing.Point(145, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::UI.Properties.Resources.Specialization;
            this.pictureBox7.Location = new System.Drawing.Point(590, 142);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(27, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 35;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.License;
            this.pictureBox2.Location = new System.Drawing.Point(145, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::UI.Properties.Resources.Department;
            this.pictureBox6.Location = new System.Drawing.Point(590, 66);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 36;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Hashtag;
            this.pictureBox1.Location = new System.Drawing.Point(145, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // chkSetEndDate
            // 
            this.chkSetEndDate.AutoSize = true;
            this.chkSetEndDate.Location = new System.Drawing.Point(630, 260);
            this.chkSetEndDate.Name = "chkSetEndDate";
            this.chkSetEndDate.Size = new System.Drawing.Size(117, 25);
            this.chkSetEndDate.TabIndex = 31;
            this.chkSetEndDate.Text = "Set End Date";
            this.chkSetEndDate.UseVisualStyleBackColor = true;
            this.chkSetEndDate.CheckedChanged += new System.EventHandler(this.chkSetEndDate_CheckedChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpEndDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpEndDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(627, 288);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(213, 29);
            this.dtpEndDate.TabIndex = 30;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHireDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpHireDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpHireDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(181, 288);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(213, 29);
            this.dtpHireDate.TabIndex = 30;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.DropDownWidth = 245;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.IntegralHeight = false;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "On Leave",
            "Resigned",
            "Retired",
            "Terminated"});
            this.cbStatus.Location = new System.Drawing.Point(627, 212);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(213, 33);
            this.cbStatus.TabIndex = 29;
            // 
            // cbDepartment
            // 
            this.cbDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.DropDownWidth = 245;
            this.cbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDepartment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.IntegralHeight = false;
            this.cbDepartment.Location = new System.Drawing.Point(627, 62);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(213, 33);
            this.cbDepartment.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Doctor Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(439, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "End Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(439, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Doc. Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Specialization:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Consult Fee:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Exp. Years:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Hire Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "License No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Doctor ID:";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorID.Location = new System.Drawing.Point(174, 66);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(60, 25);
            this.lblDoctorID.TabIndex = 22;
            this.lblDoctorID.Text = "[????]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Department:";
            // 
            // txtConsultationFee
            // 
            this.txtConsultationFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtConsultationFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsultationFee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultationFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtConsultationFee.Location = new System.Drawing.Point(181, 360);
            this.txtConsultationFee.Name = "txtConsultationFee";
            this.txtConsultationFee.Size = new System.Drawing.Size(213, 33);
            this.txtConsultationFee.TabIndex = 18;
            this.txtConsultationFee.Tag = "0";
            this.txtConsultationFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonDigitInput);
            // 
            // txtYearsOfExperience
            // 
            this.txtYearsOfExperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtYearsOfExperience.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYearsOfExperience.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearsOfExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtYearsOfExperience.Location = new System.Drawing.Point(181, 212);
            this.txtYearsOfExperience.Name = "txtYearsOfExperience";
            this.txtYearsOfExperience.Size = new System.Drawing.Size(213, 33);
            this.txtYearsOfExperience.TabIndex = 18;
            this.txtYearsOfExperience.Tag = "1";
            this.txtYearsOfExperience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonDigitInput);
            this.txtYearsOfExperience.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtLicenseNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicenseNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtLicenseNumber.Location = new System.Drawing.Point(181, 138);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(213, 33);
            this.txtLicenseNumber.TabIndex = 18;
            this.txtLicenseNumber.Tag = "10";
            this.txtLicenseNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonDigitInput);
            this.txtLicenseNumber.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // txtDoctorUsername
            // 
            this.txtDoctorUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtDoctorUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorUsername.Enabled = false;
            this.txtDoctorUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtDoctorUsername.Location = new System.Drawing.Point(627, 360);
            this.txtDoctorUsername.Name = "txtDoctorUsername";
            this.txtDoctorUsername.Size = new System.Drawing.Size(213, 33);
            this.txtDoctorUsername.TabIndex = 18;
            this.txtDoctorUsername.Tag = "3";
            this.txtDoctorUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonDigitAndNonLetterAndNonPunctuationInput);
            this.txtDoctorUsername.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSpecialization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecialization.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtSpecialization.Location = new System.Drawing.Point(627, 138);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(213, 33);
            this.txtSpecialization.TabIndex = 18;
            this.txtSpecialization.Tag = "2";
            this.txtSpecialization.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonLetterInput);
            this.txtSpecialization.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 550);
            this.tabControl1.TabIndex = 6;
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
            // frmAddEditDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(948, 645);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddEditDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditDoctor";
            this.Load += new System.EventHandler(this.frmAddEditDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbDoctorInfo.ResumeLayout(false);
            this.gbDoctorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNext;
        private People.Controls.ctrlPersonFinder ctrlPersonFinder1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbDoctorInfo;
        private System.Windows.Forms.CheckBox chkSetEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsultationFee;
        private System.Windows.Forms.TextBox txtYearsOfExperience;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.TextBox txtDoctorUsername;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}