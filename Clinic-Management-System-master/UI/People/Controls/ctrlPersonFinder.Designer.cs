namespace UI.People.Controls
{
    partial class ctrlPersonFinder
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
            this.gbPersonFinder = new System.Windows.Forms.GroupBox();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonInfo1 = new UI.People.Controls.ctrlPersonInfo();
            this.gbPersonFinder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersonFinder
            // 
            this.gbPersonFinder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gbPersonFinder.Controls.Add(this.txtPersonID);
            this.gbPersonFinder.Controls.Add(this.btnAddPerson);
            this.gbPersonFinder.Controls.Add(this.btnFindPerson);
            this.gbPersonFinder.Controls.Add(this.label1);
            this.gbPersonFinder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbPersonFinder.Location = new System.Drawing.Point(10, 1);
            this.gbPersonFinder.Name = "gbPersonFinder";
            this.gbPersonFinder.Size = new System.Drawing.Size(852, 103);
            this.gbPersonFinder.TabIndex = 3;
            this.gbPersonFinder.TabStop = false;
            this.gbPersonFinder.Text = "Find Person";
            // 
            // txtPersonID
            // 
            this.txtPersonID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtPersonID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersonID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtPersonID.Location = new System.Drawing.Point(204, 44);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(246, 33);
            this.txtPersonID.TabIndex = 32;
            this.txtPersonID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventNonDigitInput);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddPerson.BackgroundImage = global::UI.Properties.Resources.Add_NewV2;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPerson.FlatAppearance.BorderSize = 0;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.Location = new System.Drawing.Point(780, 33);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(57, 50);
            this.btnAddPerson.TabIndex = 27;
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnFindPerson.BackgroundImage = global::UI.Properties.Resources.SearchV2;
            this.btnFindPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindPerson.FlatAppearance.BorderSize = 0;
            this.btnFindPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPerson.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPerson.Location = new System.Drawing.Point(456, 41);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(34, 34);
            this.btnFindPerson.TabIndex = 27;
            this.btnFindPerson.UseVisualStyleBackColor = false;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By Person ID:";
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ctrlPersonInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(0, 102);
            this.ctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(873, 359);
            this.ctrlPersonInfo1.TabIndex = 0;
            // 
            // ctrlPersonFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.gbPersonFinder);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlPersonFinder";
            this.Size = new System.Drawing.Size(872, 462);
            this.gbPersonFinder.ResumeLayout(false);
            this.gbPersonFinder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.GroupBox gbPersonFinder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.TextBox txtPersonID;
    }
}
