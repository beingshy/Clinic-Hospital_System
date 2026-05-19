using System.Windows.Forms;

namespace UI.People
{
    partial class frmAddEditPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbPersonalInformation = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtByUser = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbPersonalInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // gbPersonalInformation
            // 
            this.gbPersonalInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gbPersonalInformation.Controls.Add(this.pictureBox9);
            this.gbPersonalInformation.Controls.Add(this.pictureBox8);
            this.gbPersonalInformation.Controls.Add(this.pictureBox7);
            this.gbPersonalInformation.Controls.Add(this.pictureBox6);
            this.gbPersonalInformation.Controls.Add(this.pictureBox5);
            this.gbPersonalInformation.Controls.Add(this.pictureBox4);
            this.gbPersonalInformation.Controls.Add(this.pictureBox3);
            this.gbPersonalInformation.Controls.Add(this.pictureBox2);
            this.gbPersonalInformation.Controls.Add(this.pictureBox1);
            this.gbPersonalInformation.Controls.Add(this.btnCancel);
            this.gbPersonalInformation.Controls.Add(this.btnSave);
            this.gbPersonalInformation.Controls.Add(this.cbCountry);
            this.gbPersonalInformation.Controls.Add(this.rdFemale);
            this.gbPersonalInformation.Controls.Add(this.rdMale);
            this.gbPersonalInformation.Controls.Add(this.dtpBirthDate);
            this.gbPersonalInformation.Controls.Add(this.txtByUser);
            this.gbPersonalInformation.Controls.Add(this.txtEmail);
            this.gbPersonalInformation.Controls.Add(this.txtAddress);
            this.gbPersonalInformation.Controls.Add(this.txtPhone);
            this.gbPersonalInformation.Controls.Add(this.txtNationalID);
            this.gbPersonalInformation.Controls.Add(this.txtLastName);
            this.gbPersonalInformation.Controls.Add(this.txtThirdName);
            this.gbPersonalInformation.Controls.Add(this.txtSecondName);
            this.gbPersonalInformation.Controls.Add(this.txtFirstName);
            this.gbPersonalInformation.Controls.Add(this.label5);
            this.gbPersonalInformation.Controls.Add(this.label4);
            this.gbPersonalInformation.Controls.Add(this.label3);
            this.gbPersonalInformation.Controls.Add(this.label13);
            this.gbPersonalInformation.Controls.Add(this.label9);
            this.gbPersonalInformation.Controls.Add(this.label11);
            this.gbPersonalInformation.Controls.Add(this.label12);
            this.gbPersonalInformation.Controls.Add(this.label7);
            this.gbPersonalInformation.Controls.Add(this.label10);
            this.gbPersonalInformation.Controls.Add(this.label8);
            this.gbPersonalInformation.Controls.Add(this.label6);
            this.gbPersonalInformation.Controls.Add(this.label2);
            this.gbPersonalInformation.Controls.Add(this.label1);
            this.gbPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbPersonalInformation.Location = new System.Drawing.Point(33, 69);
            this.gbPersonalInformation.Name = "gbPersonalInformation";
            this.gbPersonalInformation.Size = new System.Drawing.Size(920, 432);
            this.gbPersonalInformation.TabIndex = 1;
            this.gbPersonalInformation.TabStop = false;
            this.gbPersonalInformation.Text = "Personal Information";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(535, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 38);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(716, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 38);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbCountry
            // 
            this.cbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.DropDownWidth = 245;
            this.cbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCountry.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.IntegralHeight = false;
            this.cbCountry.Location = new System.Drawing.Point(655, 183);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(213, 33);
            this.cbCountry.TabIndex = 8;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemale.Location = new System.Drawing.Point(314, 185);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(90, 29);
            this.rdFemale.TabIndex = 7;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMale.Location = new System.Drawing.Point(201, 185);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(72, 29);
            this.rdMale.TabIndex = 6;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpBirthDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpBirthDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(655, 124);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(213, 29);
            this.dtpBirthDate.TabIndex = 5;
            // 
            // txtByUser
            // 
            this.txtByUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtByUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtByUser.Enabled = false;
            this.txtByUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtByUser.Location = new System.Drawing.Point(655, 305);
            this.txtByUser.Name = "txtByUser";
            this.txtByUser.Size = new System.Drawing.Size(213, 33);
            this.txtByUser.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtEmail.Location = new System.Drawing.Point(655, 246);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 33);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Tag = "4";
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmailTextbox);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAddress.Location = new System.Drawing.Point(191, 309);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(213, 91);
            this.txtAddress.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtPhone.Location = new System.Drawing.Point(191, 246);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(213, 33);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.Tag = "10";
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonDigitInput);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // txtNationalID
            // 
            this.txtNationalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtNationalID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationalID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtNationalID.Location = new System.Drawing.Point(191, 124);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(213, 33);
            this.txtNationalID.TabIndex = 4;
            this.txtNationalID.Tag = "10";
            this.txtNationalID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonDigitInput);
            this.txtNationalID.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtLastName.Location = new System.Drawing.Point(716, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(151, 33);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Tag = "3";
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonLetterInput);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // txtThirdName
            // 
            this.txtThirdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtThirdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThirdName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtThirdName.Location = new System.Drawing.Point(541, 65);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(151, 33);
            this.txtThirdName.TabIndex = 2;
            this.txtThirdName.Tag = "0";
            this.txtThirdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonLetterInput);
            this.txtThirdName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // txtSecondName
            // 
            this.txtSecondName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtSecondName.Location = new System.Drawing.Point(366, 65);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(151, 33);
            this.txtSecondName.TabIndex = 1;
            this.txtSecondName.Tag = "3";
            this.txtSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonLetterInput);
            this.txtSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtFirstName.Location = new System.Drawing.Point(191, 65);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(151, 33);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Tag = "3";
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonLetterInput);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(741, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Third Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Second Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(508, 307);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "By User:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(508, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Country:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(508, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(508, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Birth Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "National ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 300;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(398, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(191, 40);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "ADD PERSON";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::UI.Properties.Resources.Country;
            this.pictureBox9.Location = new System.Drawing.Point(617, 187);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(27, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 23;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::UI.Properties.Resources.Gender;
            this.pictureBox8.Location = new System.Drawing.Point(153, 187);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 24;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::UI.Properties.Resources.Date;
            this.pictureBox7.Location = new System.Drawing.Point(617, 126);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(27, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::UI.Properties.Resources.Hashtag;
            this.pictureBox6.Location = new System.Drawing.Point(617, 307);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::UI.Properties.Resources.Address;
            this.pictureBox5.Location = new System.Drawing.Point(153, 311);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::UI.Properties.Resources.Phone;
            this.pictureBox4.Location = new System.Drawing.Point(153, 248);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI.Properties.Resources.email;
            this.pictureBox3.Location = new System.Drawing.Point(617, 248);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.NationalID;
            this.pictureBox2.Location = new System.Drawing.Point(153, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Fullname;
            this.pictureBox1.Location = new System.Drawing.Point(153, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(986, 525);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.gbPersonalInformation);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Person";
            this.Load += new System.EventHandler(this.frmAddOrUpdatePerson_Load);
            this.gbPersonalInformation.ResumeLayout(false);
            this.gbPersonalInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPersonalInformation;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtByUser;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Label lblHeader;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
    }
}