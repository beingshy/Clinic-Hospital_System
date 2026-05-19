namespace UI.Receptionist
{
    partial class frmAddEditReceptionist
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
            this.ctrlPersonFinder1 = new UI.People.Controls.ctrlPersonFinder();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbReceptionistInfo = new System.Windows.Forms.GroupBox();
            this.chkSetEndDate = new System.Windows.Forms.CheckBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReceptionistID = new System.Windows.Forms.Label();
            this.txtReceptionistUsername = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbReceptionistInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 550);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage2.Controls.Add(this.gbReceptionistInfo);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Receptionist";
            // 
            // gbReceptionistInfo
            // 
            this.gbReceptionistInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gbReceptionistInfo.Controls.Add(this.pictureBox3);
            this.gbReceptionistInfo.Controls.Add(this.pictureBox5);
            this.gbReceptionistInfo.Controls.Add(this.pictureBox2);
            this.gbReceptionistInfo.Controls.Add(this.pictureBox4);
            this.gbReceptionistInfo.Controls.Add(this.pictureBox1);
            this.gbReceptionistInfo.Controls.Add(this.chkSetEndDate);
            this.gbReceptionistInfo.Controls.Add(this.dtpEndDate);
            this.gbReceptionistInfo.Controls.Add(this.dtpHireDate);
            this.gbReceptionistInfo.Controls.Add(this.cbStatus);
            this.gbReceptionistInfo.Controls.Add(this.label6);
            this.gbReceptionistInfo.Controls.Add(this.label9);
            this.gbReceptionistInfo.Controls.Add(this.label10);
            this.gbReceptionistInfo.Controls.Add(this.label7);
            this.gbReceptionistInfo.Controls.Add(this.label2);
            this.gbReceptionistInfo.Controls.Add(this.lblReceptionistID);
            this.gbReceptionistInfo.Controls.Add(this.txtReceptionistUsername);
            this.gbReceptionistInfo.Enabled = false;
            this.gbReceptionistInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbReceptionistInfo.Location = new System.Drawing.Point(13, 10);
            this.gbReceptionistInfo.Name = "gbReceptionistInfo";
            this.gbReceptionistInfo.Size = new System.Drawing.Size(866, 453);
            this.gbReceptionistInfo.TabIndex = 27;
            this.gbReceptionistInfo.TabStop = false;
            this.gbReceptionistInfo.Text = "Receptionist Info";
            // 
            // chkSetEndDate
            // 
            this.chkSetEndDate.AutoSize = true;
            this.chkSetEndDate.Location = new System.Drawing.Point(630, 118);
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
            this.dtpEndDate.Location = new System.Drawing.Point(627, 147);
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
            this.dtpHireDate.Location = new System.Drawing.Point(181, 147);
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
            "Terminated"});
            this.cbStatus.Location = new System.Drawing.Point(179, 228);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(213, 33);
            this.cbStatus.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Recp. Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(439, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "End Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(439, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Recp. Username:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Hire Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Recp. ID:";
            // 
            // lblReceptionistID
            // 
            this.lblReceptionistID.AutoSize = true;
            this.lblReceptionistID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionistID.Location = new System.Drawing.Point(174, 66);
            this.lblReceptionistID.Name = "lblReceptionistID";
            this.lblReceptionistID.Size = new System.Drawing.Size(60, 25);
            this.lblReceptionistID.TabIndex = 22;
            this.lblReceptionistID.Text = "[????]";
            // 
            // txtReceptionistUsername
            // 
            this.txtReceptionistUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtReceptionistUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceptionistUsername.Enabled = false;
            this.txtReceptionistUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceptionistUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReceptionistUsername.Location = new System.Drawing.Point(627, 64);
            this.txtReceptionistUsername.Name = "txtReceptionistUsername";
            this.txtReceptionistUsername.Size = new System.Drawing.Size(213, 33);
            this.txtReceptionistUsername.TabIndex = 18;
            this.txtReceptionistUsername.Tag = "3";
            this.txtReceptionistUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonDigitAndNonLetterAndNonPunctuationInput);
            this.txtReceptionistUsername.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
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
            this.lblHeader.Location = new System.Drawing.Point(321, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(285, 40);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "ADD RECEPETIONIST";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI.Properties.Resources.Status;
            this.pictureBox3.Location = new System.Drawing.Point(145, 232);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.Date;
            this.pictureBox2.Location = new System.Drawing.Point(145, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Hashtag;
            this.pictureBox1.Location = new System.Drawing.Point(145, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::UI.Properties.Resources.Username;
            this.pictureBox4.Location = new System.Drawing.Point(592, 68);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::UI.Properties.Resources.Date;
            this.pictureBox5.Location = new System.Drawing.Point(592, 149);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // frmAddEditReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(927, 638);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddEditReceptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditReceptionist";
            this.Load += new System.EventHandler(this.frmAddEditReceptionist_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbReceptionistInfo.ResumeLayout(false);
            this.gbReceptionistInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.Controls.ctrlPersonFinder ctrlPersonFinder1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbReceptionistInfo;
        private System.Windows.Forms.CheckBox chkSetEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReceptionistID;
        private System.Windows.Forms.TextBox txtReceptionistUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}