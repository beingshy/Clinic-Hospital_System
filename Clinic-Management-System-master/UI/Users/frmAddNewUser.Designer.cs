namespace UI.Users
{
    partial class frmAddNewUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonFinder1 = new UI.People.Controls.ctrlPersonFinder();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.pnlSideCard = new System.Windows.Forms.Panel();
            this.ctrlUserInfoVertical1 = new UI.Users.Controls.ctrlUserInfoVertical();
            this.label10 = new System.Windows.Forms.Label();
            this.rdInactive = new System.Windows.Forms.RadioButton();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.rdActive = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassowrd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbUserInfo.SuspendLayout();
            this.pnlSideCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 550);
            this.tabControl1.TabIndex = 0;
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage2.Controls.Add(this.gbUserInfo);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add User";
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gbUserInfo.Controls.Add(this.pictureBox6);
            this.gbUserInfo.Controls.Add(this.pictureBox5);
            this.gbUserInfo.Controls.Add(this.pictureBox3);
            this.gbUserInfo.Controls.Add(this.pictureBox2);
            this.gbUserInfo.Controls.Add(this.pictureBox1);
            this.gbUserInfo.Controls.Add(this.cbRole);
            this.gbUserInfo.Controls.Add(this.pnlSideCard);
            this.gbUserInfo.Controls.Add(this.label10);
            this.gbUserInfo.Controls.Add(this.rdInactive);
            this.gbUserInfo.Controls.Add(this.txtCreatedBy);
            this.gbUserInfo.Controls.Add(this.rdActive);
            this.gbUserInfo.Controls.Add(this.label3);
            this.gbUserInfo.Controls.Add(this.label2);
            this.gbUserInfo.Controls.Add(this.label1);
            this.gbUserInfo.Controls.Add(this.txtPassowrd);
            this.gbUserInfo.Controls.Add(this.label6);
            this.gbUserInfo.Controls.Add(this.txtUsername);
            this.gbUserInfo.Enabled = false;
            this.gbUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbUserInfo.Location = new System.Drawing.Point(23, 10);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(850, 453);
            this.gbUserInfo.TabIndex = 27;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "User Info";
            // 
            // cbRole
            // 
            this.cbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.DropDownWidth = 245;
            this.cbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.IntegralHeight = false;
            this.cbRole.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Receptionist"});
            this.cbRole.Location = new System.Drawing.Point(179, 216);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(213, 33);
            this.cbRole.TabIndex = 29;
            // 
            // pnlSideCard
            // 
            this.pnlSideCard.Controls.Add(this.ctrlUserInfoVertical1);
            this.pnlSideCard.Enabled = false;
            this.pnlSideCard.Location = new System.Drawing.Point(427, 17);
            this.pnlSideCard.Name = "pnlSideCard";
            this.pnlSideCard.Size = new System.Drawing.Size(414, 429);
            this.pnlSideCard.TabIndex = 27;
            // 
            // ctrlUserInfoVertical1
            // 
            this.ctrlUserInfoVertical1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctrlUserInfoVertical1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlUserInfoVertical1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlUserInfoVertical1.Location = new System.Drawing.Point(-24, -99);
            this.ctrlUserInfoVertical1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlUserInfoVertical1.Name = "ctrlUserInfoVertical1";
            this.ctrlUserInfoVertical1.Size = new System.Drawing.Size(471, 561);
            this.ctrlUserInfoVertical1.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Created By:";
            // 
            // rdInactive
            // 
            this.rdInactive.AutoSize = true;
            this.rdInactive.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInactive.Location = new System.Drawing.Point(302, 298);
            this.rdInactive.Name = "rdInactive";
            this.rdInactive.Size = new System.Drawing.Size(95, 29);
            this.rdInactive.TabIndex = 25;
            this.rdInactive.TabStop = true;
            this.rdInactive.Text = "Inactive";
            this.rdInactive.UseVisualStyleBackColor = true;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtCreatedBy.Location = new System.Drawing.Point(179, 376);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(213, 33);
            this.txtCreatedBy.TabIndex = 26;
            this.txtCreatedBy.Tag = "10";
            // 
            // rdActive
            // 
            this.rdActive.AutoSize = true;
            this.rdActive.Checked = true;
            this.rdActive.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdActive.Location = new System.Drawing.Point(179, 298);
            this.rdActive.Name = "rdActive";
            this.rdActive.Size = new System.Drawing.Size(81, 29);
            this.rdActive.TabIndex = 24;
            this.rdActive.TabStop = true;
            this.rdActive.Text = "Active";
            this.rdActive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Role:";
            // 
            // txtPassowrd
            // 
            this.txtPassowrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtPassowrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassowrd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassowrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtPassowrd.Location = new System.Drawing.Point(179, 136);
            this.txtPassowrd.Name = "txtPassowrd";
            this.txtPassowrd.Size = new System.Drawing.Size(213, 33);
            this.txtPassowrd.TabIndex = 18;
            this.txtPassowrd.Tag = "4";
            this.txtPassowrd.UseSystemPasswordChar = true;
            this.txtPassowrd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventInvalidPasswordInput);
            this.txtPassowrd.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Status:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtUsername.Location = new System.Drawing.Point(179, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(213, 33);
            this.txtUsername.TabIndex = 18;
            this.txtUsername.Tag = "3";
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonDigitAndNonLetterInput);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(721, 469);
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
            this.lblHeader.Location = new System.Drawing.Point(387, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(151, 40);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "ADD USER";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 300;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::UI.Properties.Resources.Username;
            this.pictureBox6.Location = new System.Drawing.Point(143, 380);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::UI.Properties.Resources.Status;
            this.pictureBox5.Location = new System.Drawing.Point(143, 300);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI.Properties.Resources.Specialization;
            this.pictureBox3.Location = new System.Drawing.Point(143, 220);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.Password;
            this.pictureBox2.Location = new System.Drawing.Point(143, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Username;
            this.pictureBox1.Location = new System.Drawing.Point(143, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(925, 654);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditUser";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.pnlSideCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private People.Controls.ctrlPersonFinder ctrlPersonFinder1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.RadioButton rdInactive;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassowrd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlSideCard;
        private Controls.ctrlUserInfoVertical ctrlUserInfoVertical1;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.RadioButton rdActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}