namespace UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnlSideBar = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            lblUsername = new System.Windows.Forms.Label();
            btnUsers = new System.Windows.Forms.Button();
            btnPayments = new System.Windows.Forms.Button();
            btnDepartments = new System.Windows.Forms.Button();
            btnReceptionists = new System.Windows.Forms.Button();
            btnDoctors = new System.Windows.Forms.Button();
            btnAppointments = new System.Windows.Forms.Button();
            btnPatients = new System.Windows.Forms.Button();
            btnPeople = new System.Windows.Forms.Button();
            btnDashboard = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pnlMain = new System.Windows.Forms.Panel();
            pnlSideBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            pnlSideBar.Controls.Add(panel1);
            pnlSideBar.Controls.Add(btnUsers);
            pnlSideBar.Controls.Add(btnPayments);
            pnlSideBar.Controls.Add(btnDepartments);
            pnlSideBar.Controls.Add(btnReceptionists);
            pnlSideBar.Controls.Add(btnDoctors);
            pnlSideBar.Controls.Add(btnAppointments);
            pnlSideBar.Controls.Add(btnPatients);
            pnlSideBar.Controls.Add(btnPeople);
            pnlSideBar.Controls.Add(btnDashboard);
            pnlSideBar.Controls.Add(pictureBox1);
            pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSideBar.Location = new System.Drawing.Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new System.Drawing.Size(255, 861);
            pnlSideBar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            panel1.Controls.Add(lblUsername);
            panel1.Location = new System.Drawing.Point(50, 162);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(155, 30);
            panel1.TabIndex = 10;
            // 
            // lblUsername
            // 
            lblUsername.BackColor = System.Drawing.Color.Transparent;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblUsername.Location = new System.Drawing.Point(3, 5);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(149, 21);
            lblUsername.TabIndex = 19;
            lblUsername.Text = "[????]";
            lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnUsers.Location = new System.Drawing.Point(0, 765);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new System.Drawing.Size(255, 65);
            btnUsers.TabIndex = 9;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnPayments
            // 
            btnPayments.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPayments.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPayments.Location = new System.Drawing.Point(0, 697);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new System.Drawing.Size(255, 65);
            btnPayments.TabIndex = 8;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = false;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnDepartments
            // 
            btnDepartments.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            btnDepartments.FlatAppearance.BorderSize = 0;
            btnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDepartments.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDepartments.Location = new System.Drawing.Point(0, 629);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new System.Drawing.Size(255, 65);
            btnDepartments.TabIndex = 7;
            btnDepartments.Text = "Departments";
            btnDepartments.UseVisualStyleBackColor = false;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // btnReceptionists
            // 
            btnReceptionists.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            btnReceptionists.FlatAppearance.BorderSize = 0;
            btnReceptionists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReceptionists.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnReceptionists.Location = new System.Drawing.Point(0, 561);
            btnReceptionists.Name = "btnReceptionists";
            btnReceptionists.Size = new System.Drawing.Size(255, 65);
            btnReceptionists.TabIndex = 6;
            btnReceptionists.Text = "Receptionists";
            btnReceptionists.UseVisualStyleBackColor = false;
            btnReceptionists.Click += btnReceptionists_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            btnDoctors.FlatAppearance.BorderSize = 0;
            btnDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDoctors.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDoctors.Location = new System.Drawing.Point(0, 493);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new System.Drawing.Size(255, 65);
            btnDoctors.TabIndex = 5;
            btnDoctors.Text = "Doctors";
            btnDoctors.UseVisualStyleBackColor = false;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            btnAppointments.FlatAppearance.BorderSize = 0;
            btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAppointments.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAppointments.Location = new System.Drawing.Point(0, 425);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new System.Drawing.Size(255, 65);
            btnAppointments.TabIndex = 4;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = false;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnPatients
            // 
            btnPatients.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            btnPatients.FlatAppearance.BorderSize = 0;
            btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPatients.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPatients.Location = new System.Drawing.Point(0, 357);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new System.Drawing.Size(255, 65);
            btnPatients.TabIndex = 3;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = false;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnPeople
            // 
            btnPeople.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            btnPeople.FlatAppearance.BorderSize = 0;
            btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPeople.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPeople.Location = new System.Drawing.Point(0, 289);
            btnPeople.Name = "btnPeople";
            btnPeople.Size = new System.Drawing.Size(255, 65);
            btnPeople.TabIndex = 2;
            btnPeople.Text = "People";
            btnPeople.UseVisualStyleBackColor = false;
            btnPeople.Click += btnPeople_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDashboard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDashboard.Location = new System.Drawing.Point(0, 221);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new System.Drawing.Size(255, 65);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(63, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(128, 123);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(255, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(1329, 861);
            pnlMain.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ClientSize = new System.Drawing.Size(1584, 861);
            Controls.Add(pnlMain);
            Controls.Add(pnlSideBar);
            Font = new System.Drawing.Font("Segoe UI", 12F);
            ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmMain";
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            pnlSideBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnReceptionists;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
    }
}