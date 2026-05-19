namespace UI.Users
{
    partial class frmChangeUserPassword
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
            this.ctrlUserInfoVertical1 = new UI.Users.Controls.ctrlUserInfoVertical();
            this.ctrlPersonInfo1 = new UI.People.Controls.ctrlPersonInfo();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPersonalInformation = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPersonalInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlUserInfoVertical1
            // 
            this.ctrlUserInfoVertical1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctrlUserInfoVertical1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlUserInfoVertical1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlUserInfoVertical1.Location = new System.Drawing.Point(13, 14);
            this.ctrlUserInfoVertical1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlUserInfoVertical1.Name = "ctrlUserInfoVertical1";
            this.ctrlUserInfoVertical1.Size = new System.Drawing.Size(471, 561);
            this.ctrlUserInfoVertical1.TabIndex = 0;
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ctrlPersonInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(492, 2);
            this.ctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(873, 359);
            this.ctrlPersonInfo1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Current Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password:";
            // 
            // gbPersonalInformation
            // 
            this.gbPersonalInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gbPersonalInformation.Controls.Add(this.btnSave);
            this.gbPersonalInformation.Controls.Add(this.txtCurrentPassword);
            this.gbPersonalInformation.Controls.Add(this.txtConfirmPassword);
            this.gbPersonalInformation.Controls.Add(this.txtNewPassword);
            this.gbPersonalInformation.Controls.Add(this.label6);
            this.gbPersonalInformation.Controls.Add(this.label2);
            this.gbPersonalInformation.Controls.Add(this.label1);
            this.gbPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbPersonalInformation.Location = new System.Drawing.Point(502, 382);
            this.gbPersonalInformation.Name = "gbPersonalInformation";
            this.gbPersonalInformation.Size = new System.Drawing.Size(852, 183);
            this.gbPersonalInformation.TabIndex = 3;
            this.gbPersonalInformation.TabStop = false;
            this.gbPersonalInformation.Text = "Personal Information";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(665, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 38);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtCurrentPassword.Location = new System.Drawing.Point(213, 111);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(173, 33);
            this.txtCurrentPassword.TabIndex = 5;
            this.txtCurrentPassword.Tag = "4";
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            this.txtCurrentPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventInvalidPasswordInput);
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(654, 47);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(173, 33);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.Tag = "4";
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventInvalidPasswordInput);
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtNewPassword.Location = new System.Drawing.Point(213, 47);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(173, 33);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.Tag = "4";
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventInvalidPasswordInput);
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Confirm Password:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 300;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1388, 600);
            this.Controls.Add(this.gbPersonalInformation);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Controls.Add(this.ctrlUserInfoVertical1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChangeUserPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangeUserPassword";
            this.Load += new System.EventHandler(this.frmChangeUserPassword_Load);
            this.gbPersonalInformation.ResumeLayout(false);
            this.gbPersonalInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlUserInfoVertical ctrlUserInfoVertical1;
        private People.Controls.ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPersonalInformation;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}