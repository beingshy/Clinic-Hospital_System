namespace UI.Patient.Controls
{
    partial class ctrlSmallPatientFinder
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
            this.ctrlSmallPatientInfo1 = new UI.Patient.Controls.ctrlSmallPatientInfo();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.txtSearchByPatienID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlSmallPatientInfo1
            // 
            this.ctrlSmallPatientInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ctrlSmallPatientInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSmallPatientInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlSmallPatientInfo1.Location = new System.Drawing.Point(6, 42);
            this.ctrlSmallPatientInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSmallPatientInfo1.Name = "ctrlSmallPatientInfo1";
            this.ctrlSmallPatientInfo1.Size = new System.Drawing.Size(433, 422);
            this.ctrlSmallPatientInfo1.TabIndex = 0;
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(9, 8);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(109, 30);
            this.lblFilterBy.TabIndex = 16;
            this.lblFilterBy.Text = "Patient ID:";
            // 
            // txtSearchByPatienID
            // 
            this.txtSearchByPatienID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSearchByPatienID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchByPatienID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByPatienID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtSearchByPatienID.Location = new System.Drawing.Point(118, 8);
            this.txtSearchByPatienID.Multiline = true;
            this.txtSearchByPatienID.Name = "txtSearchByPatienID";
            this.txtSearchByPatienID.Size = new System.Drawing.Size(267, 34);
            this.txtSearchByPatienID.TabIndex = 17;
            this.txtSearchByPatienID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonDigitInput);
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
            this.btnSearch.TabIndex = 18;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ctrlSmallPatientFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.txtSearchByPatienID);
            this.Controls.Add(this.ctrlSmallPatientInfo1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlSmallPatientFinder";
            this.Size = new System.Drawing.Size(444, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlSmallPatientInfo ctrlSmallPatientInfo1;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.TextBox txtSearchByPatienID;
        private System.Windows.Forms.Button btnSearch;
    }
}
