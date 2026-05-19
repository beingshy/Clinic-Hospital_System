namespace UI.People
{
    partial class frmPersonInfo
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
            ctrlPersonInfo1 = new Controls.ctrlPersonInfo();
            btnClose = new System.Windows.Forms.Button();
            lblHeader = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ctrlPersonInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ctrlPersonInfo1.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            ctrlPersonInfo1.Location = new System.Drawing.Point(11, 61);
            ctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new System.Drawing.Size(878, 407);
            ctrlPersonInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(235, 235, 235);
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Location = new System.Drawing.Point(704, 417);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(177, 44);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHeader.Location = new System.Drawing.Point(271, 10);
            lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(358, 40);
            lblHeader.TabIndex = 15;
            lblHeader.Text = "PERSONAL INFORMATION";
            // 
            // frmPersonInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ClientSize = new System.Drawing.Size(901, 483);
            Controls.Add(lblHeader);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonInfo1);
            ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmPersonInfo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Personal Information";
            Load += frmPersonInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeader;
    }
}