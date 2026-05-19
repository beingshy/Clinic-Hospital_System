namespace UI.Users
{
    partial class frmUserInfo
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
            this.ctrlUserInfoVertical1 = new UI.Users.Controls.ctrlUserInfoVertical();
            this.SuspendLayout();
            // 
            // ctrlUserInfoVertical1
            // 
            this.ctrlUserInfoVertical1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctrlUserInfoVertical1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlUserInfoVertical1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlUserInfoVertical1.Location = new System.Drawing.Point(12, 16);
            this.ctrlUserInfoVertical1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlUserInfoVertical1.Name = "ctrlUserInfoVertical1";
            this.ctrlUserInfoVertical1.Size = new System.Drawing.Size(471, 561);
            this.ctrlUserInfoVertical1.TabIndex = 0;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(495, 593);
            this.Controls.Add(this.ctrlUserInfoVertical1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserInfo";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlUserInfoVertical ctrlUserInfoVertical1;
    }
}