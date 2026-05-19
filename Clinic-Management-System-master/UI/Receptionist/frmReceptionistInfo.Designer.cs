namespace UI.Receptionist
{
    partial class frmReceptionistInfo
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
            this.ctrlReceptionistInfo1 = new UI.Receptionist.Controls.ctrlReceptionistInfo();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlReceptionistInfo1
            // 
            this.ctrlReceptionistInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ctrlReceptionistInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlReceptionistInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlReceptionistInfo1.Location = new System.Drawing.Point(9, 66);
            this.ctrlReceptionistInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlReceptionistInfo1.Name = "ctrlReceptionistInfo1";
            this.ctrlReceptionistInfo1.Size = new System.Drawing.Size(866, 284);
            this.ctrlReceptionistInfo1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(233, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(419, 40);
            this.lblHeader.TabIndex = 18;
            this.lblHeader.Text = "RECEPETIONIST INFORMATION";
            // 
            // frmReceptionistInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(885, 362);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.ctrlReceptionistInfo1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReceptionistInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReceptionistInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlReceptionistInfo ctrlReceptionistInfo1;
        private System.Windows.Forms.Label lblHeader;
    }
}