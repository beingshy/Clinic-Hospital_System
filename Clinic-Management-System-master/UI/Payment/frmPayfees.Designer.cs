namespace UI.Payment
{
    partial class frmPayfees
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
            this.btnPay = new System.Windows.Forms.Button();
            this.gbPaymentInformation = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbPaymentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(195, 182);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(124, 38);
            this.btnPay.TabIndex = 14;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // gbPaymentInformation
            // 
            this.gbPaymentInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gbPaymentInformation.Controls.Add(this.pictureBox4);
            this.gbPaymentInformation.Controls.Add(this.btnPay);
            this.gbPaymentInformation.Controls.Add(this.txtFees);
            this.gbPaymentInformation.Controls.Add(this.label4);
            this.gbPaymentInformation.Controls.Add(this.label1);
            this.gbPaymentInformation.Controls.Add(this.cbMethod);
            this.gbPaymentInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbPaymentInformation.Location = new System.Drawing.Point(15, 58);
            this.gbPaymentInformation.Name = "gbPaymentInformation";
            this.gbPaymentInformation.Size = new System.Drawing.Size(338, 239);
            this.gbPaymentInformation.TabIndex = 5;
            this.gbPaymentInformation.TabStop = false;
            this.gbPaymentInformation.Text = "Payment Information";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pictureBox4.Image = global::UI.Properties.Resources.Saudi_Riyal_Symbol;
            this.pictureBox4.Location = new System.Drawing.Point(284, 64);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // txtFees
            // 
            this.txtFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFees.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtFees.Location = new System.Drawing.Point(24, 60);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(295, 33);
            this.txtFees.TabIndex = 0;
            this.txtFees.Tag = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fees:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Method:";
            // 
            // cbMethod
            // 
            this.cbMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.DropDownWidth = 245;
            this.cbMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMethod.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.IntegralHeight = false;
            this.cbMethod.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Bank Transfer",
            "Mobile Payment"});
            this.cbMethod.Location = new System.Drawing.Point(24, 128);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(295, 33);
            this.cbMethod.TabIndex = 36;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(119, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(131, 40);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "PAY FEES";
            // 
            // frmPayfees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(368, 312);
            this.Controls.Add(this.gbPaymentInformation);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPayfees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddPayment";
            this.Load += new System.EventHandler(this.frmPayfees_Load);
            this.gbPaymentInformation.ResumeLayout(false);
            this.gbPaymentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbPaymentInformation;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}