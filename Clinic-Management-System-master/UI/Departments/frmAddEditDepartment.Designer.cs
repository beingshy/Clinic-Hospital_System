namespace UI.Departments
{
    partial class frmAddEditDepartment
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDepartmentDescription = new System.Windows.Forms.TextBox();
            this.gbDepartmentInformation = new System.Windows.Forms.GroupBox();
            this.txtDepartmentLocation = new System.Windows.Forms.TextBox();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbDepartmentInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 300;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(24, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 38);
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
            this.btnSave.Location = new System.Drawing.Point(195, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 38);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDepartmentDescription
            // 
            this.txtDepartmentDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtDepartmentDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartmentDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtDepartmentDescription.Location = new System.Drawing.Point(24, 205);
            this.txtDepartmentDescription.Multiline = true;
            this.txtDepartmentDescription.Name = "txtDepartmentDescription";
            this.txtDepartmentDescription.Size = new System.Drawing.Size(295, 85);
            this.txtDepartmentDescription.TabIndex = 11;
            this.txtDepartmentDescription.Tag = "0";
            this.txtDepartmentDescription.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // gbDepartmentInformation
            // 
            this.gbDepartmentInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gbDepartmentInformation.Controls.Add(this.btnCancel);
            this.gbDepartmentInformation.Controls.Add(this.btnSave);
            this.gbDepartmentInformation.Controls.Add(this.txtDepartmentLocation);
            this.gbDepartmentInformation.Controls.Add(this.txtDepartmentDescription);
            this.gbDepartmentInformation.Controls.Add(this.txtDepartmentID);
            this.gbDepartmentInformation.Controls.Add(this.txtDepartmentName);
            this.gbDepartmentInformation.Controls.Add(this.label3);
            this.gbDepartmentInformation.Controls.Add(this.label2);
            this.gbDepartmentInformation.Controls.Add(this.label4);
            this.gbDepartmentInformation.Controls.Add(this.label1);
            this.gbDepartmentInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbDepartmentInformation.Location = new System.Drawing.Point(22, 63);
            this.gbDepartmentInformation.Name = "gbDepartmentInformation";
            this.gbDepartmentInformation.Size = new System.Drawing.Size(338, 458);
            this.gbDepartmentInformation.TabIndex = 3;
            this.gbDepartmentInformation.TabStop = false;
            this.gbDepartmentInformation.Text = "Department Information";
            // 
            // txtDepartmentLocation
            // 
            this.txtDepartmentLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtDepartmentLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartmentLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtDepartmentLocation.Location = new System.Drawing.Point(24, 330);
            this.txtDepartmentLocation.Multiline = true;
            this.txtDepartmentLocation.Name = "txtDepartmentLocation";
            this.txtDepartmentLocation.Size = new System.Drawing.Size(295, 55);
            this.txtDepartmentLocation.TabIndex = 11;
            this.txtDepartmentLocation.Tag = "0";
            this.txtDepartmentLocation.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtDepartmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartmentID.Enabled = false;
            this.txtDepartmentID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtDepartmentID.Location = new System.Drawing.Point(24, 60);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(295, 33);
            this.txtDepartmentID.TabIndex = 0;
            this.txtDepartmentID.Tag = "3";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartmentName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtDepartmentName.Location = new System.Drawing.Point(24, 128);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(295, 33);
            this.txtDepartmentName.TabIndex = 0;
            this.txtDepartmentName.Tag = "3";
            this.txtDepartmentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonLetterInput);
            this.txtDepartmentName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextbox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Department Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Department Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Name:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(61, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(261, 40);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "ADD DEPARTMENT";
            // 
            // frmAddEditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(383, 546);
            this.Controls.Add(this.gbDepartmentInformation);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddEditDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Department";
            this.Load += new System.EventHandler(this.frmAddEditDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbDepartmentInformation.ResumeLayout(false);
            this.gbDepartmentInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbDepartmentInformation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDepartmentLocation;
        private System.Windows.Forms.TextBox txtDepartmentDescription;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.Label label4;
    }
}