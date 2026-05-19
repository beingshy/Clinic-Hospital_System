namespace UI.Doctor.Controls
{
    partial class ctrlSmallDoctorFinder
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.txtSearchByDoctorID = new System.Windows.Forms.TextBox();
            this.ctrlSmallDoctorInfo1 = new UI.Doctor.Controls.ctrlSmallDoctorInfo();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSearch.BackgroundImage = global::UI.Properties.Resources.SearchV2;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(391, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 34);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(9, 8);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(108, 30);
            this.lblFilterBy.TabIndex = 20;
            this.lblFilterBy.Text = "Doctor ID:";
            // 
            // txtSearchByDoctorID
            // 
            this.txtSearchByDoctorID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSearchByDoctorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchByDoctorID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByDoctorID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtSearchByDoctorID.Location = new System.Drawing.Point(118, 8);
            this.txtSearchByDoctorID.Multiline = true;
            this.txtSearchByDoctorID.Name = "txtSearchByDoctorID";
            this.txtSearchByDoctorID.Size = new System.Drawing.Size(267, 34);
            this.txtSearchByDoctorID.TabIndex = 21;
            this.txtSearchByDoctorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonDigitInput);
            // 
            // ctrlSmallDoctorInfo1
            // 
            this.ctrlSmallDoctorInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ctrlSmallDoctorInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSmallDoctorInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlSmallDoctorInfo1.Location = new System.Drawing.Point(6, 42);
            this.ctrlSmallDoctorInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSmallDoctorInfo1.Name = "ctrlSmallDoctorInfo1";
            this.ctrlSmallDoctorInfo1.Size = new System.Drawing.Size(433, 422);
            this.ctrlSmallDoctorInfo1.TabIndex = 23;
            // 
            // ctrlSmallDoctorFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.txtSearchByDoctorID);
            this.Controls.Add(this.ctrlSmallDoctorInfo1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlSmallDoctorFinder";
            this.Size = new System.Drawing.Size(444, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.TextBox txtSearchByDoctorID;
        private ctrlSmallDoctorInfo ctrlSmallDoctorInfo1;
    }
}
