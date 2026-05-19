namespace UI.Payment
{
    partial class frmPaymentsManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            lblMostUsedPaymentMethodValue = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            lblIsMostUsedPaymentMethod = new System.Windows.Forms.Label();
            lblTotalPaymentsValue = new System.Windows.Forms.Label();
            lblTotalPayments = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            lblAverageAmountPerPaymentValue = new System.Windows.Forms.Label();
            lblAverageAmountPerPayment = new System.Windows.Forms.Label();
            lblTotalPaymentsAmountValue = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            pbRiyalSymbol2 = new System.Windows.Forms.PictureBox();
            lblTotalPaymentsAmount = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            pbRiyalSymbol1 = new System.Windows.Forms.PictureBox();
            lblHeader = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            dgvPayments = new System.Windows.Forms.DataGridView();
            txtPageNumber = new System.Windows.Forms.TextBox();
            btnNextPage = new System.Windows.Forms.Button();
            btnPreviousPage = new System.Windows.Forms.Button();
            lblOfTotalPagesAndRows = new System.Windows.Forms.Label();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRiyalSymbol2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRiyalSymbol1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // lblMostUsedPaymentMethodValue
            // 
            lblMostUsedPaymentMethodValue.AutoSize = true;
            lblMostUsedPaymentMethodValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMostUsedPaymentMethodValue.Location = new System.Drawing.Point(9, 22);
            lblMostUsedPaymentMethodValue.Name = "lblMostUsedPaymentMethodValue";
            lblMostUsedPaymentMethodValue.Size = new System.Drawing.Size(100, 45);
            lblMostUsedPaymentMethodValue.TabIndex = 16;
            lblMostUsedPaymentMethodValue.Text = "[????]";
            lblMostUsedPaymentMethodValue.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(82, 117, 91);
            panel4.Controls.Add(lblMostUsedPaymentMethodValue);
            panel4.Controls.Add(lblIsMostUsedPaymentMethod);
            panel4.Location = new System.Drawing.Point(1023, 663);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(289, 121);
            panel4.TabIndex = 22;
            // 
            // lblIsMostUsedPaymentMethod
            // 
            lblIsMostUsedPaymentMethod.AutoSize = true;
            lblIsMostUsedPaymentMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblIsMostUsedPaymentMethod.Location = new System.Drawing.Point(12, 77);
            lblIsMostUsedPaymentMethod.Name = "lblIsMostUsedPaymentMethod";
            lblIsMostUsedPaymentMethod.Size = new System.Drawing.Size(275, 25);
            lblIsMostUsedPaymentMethod.TabIndex = 16;
            lblIsMostUsedPaymentMethod.Text = "Is Most Used Payment Method";
            lblIsMostUsedPaymentMethod.Visible = false;
            // 
            // lblTotalPaymentsValue
            // 
            lblTotalPaymentsValue.AutoSize = true;
            lblTotalPaymentsValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalPaymentsValue.Location = new System.Drawing.Point(7, 17);
            lblTotalPaymentsValue.Name = "lblTotalPaymentsValue";
            lblTotalPaymentsValue.Size = new System.Drawing.Size(114, 50);
            lblTotalPaymentsValue.TabIndex = 16;
            lblTotalPaymentsValue.Text = "[????]";
            lblTotalPaymentsValue.Visible = false;
            // 
            // lblTotalPayments
            // 
            lblTotalPayments.AutoSize = true;
            lblTotalPayments.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalPayments.Location = new System.Drawing.Point(12, 77);
            lblTotalPayments.Name = "lblTotalPayments";
            lblTotalPayments.Size = new System.Drawing.Size(141, 25);
            lblTotalPayments.TabIndex = 16;
            lblTotalPayments.Text = "Total Payments";
            lblTotalPayments.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(82, 91, 117);
            panel3.Controls.Add(lblTotalPaymentsValue);
            panel3.Controls.Add(lblTotalPayments);
            panel3.Location = new System.Drawing.Point(1023, 526);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(289, 121);
            panel3.TabIndex = 23;
            // 
            // lblAverageAmountPerPaymentValue
            // 
            lblAverageAmountPerPaymentValue.AutoSize = true;
            lblAverageAmountPerPaymentValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAverageAmountPerPaymentValue.Location = new System.Drawing.Point(42, 19);
            lblAverageAmountPerPaymentValue.Name = "lblAverageAmountPerPaymentValue";
            lblAverageAmountPerPaymentValue.Size = new System.Drawing.Size(114, 50);
            lblAverageAmountPerPaymentValue.TabIndex = 16;
            lblAverageAmountPerPaymentValue.Text = "[????]";
            lblAverageAmountPerPaymentValue.Visible = false;
            // 
            // lblAverageAmountPerPayment
            // 
            lblAverageAmountPerPayment.AutoSize = true;
            lblAverageAmountPerPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAverageAmountPerPayment.Location = new System.Drawing.Point(12, 77);
            lblAverageAmountPerPayment.Name = "lblAverageAmountPerPayment";
            lblAverageAmountPerPayment.Size = new System.Drawing.Size(270, 25);
            lblAverageAmountPerPayment.TabIndex = 16;
            lblAverageAmountPerPayment.Text = "Average Amount Per Payment";
            lblAverageAmountPerPayment.Visible = false;
            // 
            // lblTotalPaymentsAmountValue
            // 
            lblTotalPaymentsAmountValue.AutoSize = true;
            lblTotalPaymentsAmountValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalPaymentsAmountValue.Location = new System.Drawing.Point(42, 23);
            lblTotalPaymentsAmountValue.Name = "lblTotalPaymentsAmountValue";
            lblTotalPaymentsAmountValue.Size = new System.Drawing.Size(100, 45);
            lblTotalPaymentsAmountValue.TabIndex = 16;
            lblTotalPaymentsAmountValue.Text = "[????]";
            lblTotalPaymentsAmountValue.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(82, 91, 117);
            panel2.Controls.Add(pbRiyalSymbol2);
            panel2.Controls.Add(lblAverageAmountPerPaymentValue);
            panel2.Controls.Add(lblAverageAmountPerPayment);
            panel2.Location = new System.Drawing.Point(1023, 389);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(289, 121);
            panel2.TabIndex = 24;
            // 
            // pbRiyalSymbol2
            // 
            pbRiyalSymbol2.Image = Properties.Resources.Saudi_Riyal_Symbol;
            pbRiyalSymbol2.Location = new System.Drawing.Point(7, 28);
            pbRiyalSymbol2.Name = "pbRiyalSymbol2";
            pbRiyalSymbol2.Size = new System.Drawing.Size(42, 38);
            pbRiyalSymbol2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbRiyalSymbol2.TabIndex = 41;
            pbRiyalSymbol2.TabStop = false;
            pbRiyalSymbol2.Visible = false;
            // 
            // lblTotalPaymentsAmount
            // 
            lblTotalPaymentsAmount.AutoSize = true;
            lblTotalPaymentsAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalPaymentsAmount.Location = new System.Drawing.Point(12, 77);
            lblTotalPaymentsAmount.Name = "lblTotalPaymentsAmount";
            lblTotalPaymentsAmount.Size = new System.Drawing.Size(274, 32);
            lblTotalPaymentsAmount.TabIndex = 16;
            lblTotalPaymentsAmount.Text = "Total Payments Amount";
            lblTotalPaymentsAmount.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(117, 82, 82);
            panel1.Controls.Add(pbRiyalSymbol1);
            panel1.Controls.Add(lblTotalPaymentsAmountValue);
            panel1.Controls.Add(lblTotalPaymentsAmount);
            panel1.Location = new System.Drawing.Point(1023, 252);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(289, 121);
            panel1.TabIndex = 25;
            // 
            // pbRiyalSymbol1
            // 
            pbRiyalSymbol1.Image = Properties.Resources.Saudi_Riyal_Symbol;
            pbRiyalSymbol1.Location = new System.Drawing.Point(8, 31);
            pbRiyalSymbol1.Name = "pbRiyalSymbol1";
            pbRiyalSymbol1.Size = new System.Drawing.Size(40, 35);
            pbRiyalSymbol1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbRiyalSymbol1.TabIndex = 41;
            pbRiyalSymbol1.TabStop = false;
            pbRiyalSymbol1.Visible = false;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHeader.Location = new System.Drawing.Point(490, 141);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(348, 40);
            lblHeader.TabIndex = 17;
            lblHeader.Text = "PAYMENT MANAGEMENT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Payments;
            pictureBox1.Location = new System.Drawing.Point(598, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(133, 103);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            dgvPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPayments.BackgroundColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgvPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPayments.ColumnHeadersHeight = 40;
            dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvPayments.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPayments.EnableHeadersVisualStyles = false;
            dgvPayments.Location = new System.Drawing.Point(24, 252);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvPayments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPayments.RowTemplate.Height = 35;
            dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.ShowCellErrors = false;
            dgvPayments.ShowCellToolTips = false;
            dgvPayments.ShowEditingIcon = false;
            dgvPayments.ShowRowErrors = false;
            dgvPayments.Size = new System.Drawing.Size(985, 532);
            dgvPayments.TabIndex = 21;
            // 
            // txtPageNumber
            // 
            txtPageNumber.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            txtPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPageNumber.Enabled = false;
            txtPageNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPageNumber.ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            txtPageNumber.Location = new System.Drawing.Point(95, 794);
            txtPageNumber.Multiline = true;
            txtPageNumber.Name = "txtPageNumber";
            txtPageNumber.Size = new System.Drawing.Size(41, 25);
            txtPageNumber.TabIndex = 29;
            txtPageNumber.Text = "1";
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnNextPage.BackgroundImage = Properties.Resources.right;
            btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNextPage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnNextPage.Location = new System.Drawing.Point(58, 789);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new System.Drawing.Size(31, 34);
            btnNextPage.TabIndex = 27;
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnPreviousPage.BackgroundImage = Properties.Resources.left;
            btnPreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnPreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPreviousPage.FlatAppearance.BorderSize = 0;
            btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPreviousPage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPreviousPage.Location = new System.Drawing.Point(21, 789);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new System.Drawing.Size(31, 34);
            btnPreviousPage.TabIndex = 28;
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // lblOfTotalPagesAndRows
            // 
            lblOfTotalPagesAndRows.AutoSize = true;
            lblOfTotalPagesAndRows.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblOfTotalPagesAndRows.Location = new System.Drawing.Point(142, 796);
            lblOfTotalPagesAndRows.Name = "lblOfTotalPagesAndRows";
            lblOfTotalPagesAndRows.Size = new System.Drawing.Size(101, 21);
            lblOfTotalPagesAndRows.TabIndex = 26;
            lblOfTotalPagesAndRows.Text = "of [????] (???)";
            // 
            // frmPaymentsManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ClientSize = new System.Drawing.Size(1329, 861);
            Controls.Add(txtPageNumber);
            Controls.Add(btnNextPage);
            Controls.Add(btnPreviousPage);
            Controls.Add(lblOfTotalPagesAndRows);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblHeader);
            Controls.Add(pictureBox1);
            Controls.Add(dgvPayments);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.FromArgb(235, 235, 235);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "frmPaymentsManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "frmPaymentManagement";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmPaymentsManagement_Load;
            Shown += frmPaymentsManagement_Shown;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRiyalSymbol2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRiyalSymbol1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMostUsedPaymentMethodValue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblIsMostUsedPaymentMethod;
        private System.Windows.Forms.Label lblTotalPaymentsValue;
        private System.Windows.Forms.Label lblTotalPayments;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAverageAmountPerPaymentValue;
        private System.Windows.Forms.Label lblAverageAmountPerPayment;
        private System.Windows.Forms.Label lblTotalPaymentsAmountValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalPaymentsAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Label lblOfTotalPagesAndRows;
        private System.Windows.Forms.PictureBox pbRiyalSymbol2;
        private System.Windows.Forms.PictureBox pbRiyalSymbol1;
    }
}