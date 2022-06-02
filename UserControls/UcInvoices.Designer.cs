namespace ProjetoAguas.UserControls
{
    partial class UcInvoices
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
            if (disposing && (components != null))
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
            this.DataGriewInvoices = new System.Windows.Forms.DataGridView();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picReset = new System.Windows.Forms.PictureBox();
            this.picInsert = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblMonthlyConsumption = new System.Windows.Forms.Label();
            this.txtUnitaryValue = new System.Windows.Forms.TextBox();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGriewInvoices
            // 
            this.DataGriewInvoices.AllowUserToDeleteRows = false;
            this.DataGriewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriewInvoices.Location = new System.Drawing.Point(91, 284);
            this.DataGriewInvoices.Name = "DataGriewInvoices";
            this.DataGriewInvoices.ReadOnly = true;
            this.DataGriewInvoices.Size = new System.Drawing.Size(813, 215);
            this.DataGriewInvoices.TabIndex = 115;
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Location = new System.Drawing.Point(196, 99);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(145, 21);
            this.cbPaymentType.TabIndex = 114;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(261, 189);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(91, 20);
            this.dtpInvoiceDate.TabIndex = 113;
            this.dtpInvoiceDate.Value = new System.DateTime(2022, 1, 6, 0, 0, 0, 0);
            // 
            // cbClients
            // 
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(340, 47);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(145, 21);
            this.cbClients.TabIndex = 111;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(290, 48);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(51, 18);
            this.lblClient.TabIndex = 110;
            this.lblClient.Text = "Client";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(89, 99);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(111, 18);
            this.lblPaymentType.TabIndex = 107;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(154, 189);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(102, 18);
            this.lblInvoiceDate.TabIndex = 105;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(144, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 18);
            this.lblID.TabIndex = 104;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(169, 39);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(31, 23);
            this.txtID.TabIndex = 101;
            // 
            // picUpdate
            // 
            this.picUpdate.Image = global::ProjetoAguas.Properties.Resources.Update;
            this.picUpdate.Location = new System.Drawing.Point(773, 99);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(31, 26);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUpdate.TabIndex = 100;
            this.picUpdate.TabStop = false;
            // 
            // picDelete
            // 
            this.picDelete.Image = global::ProjetoAguas.Properties.Resources.Delete;
            this.picDelete.Location = new System.Drawing.Point(666, 172);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(31, 26);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 99;
            this.picDelete.TabStop = false;
            // 
            // picReset
            // 
            this.picReset.Image = global::ProjetoAguas.Properties.Resources.Reset;
            this.picReset.Location = new System.Drawing.Point(782, 172);
            this.picReset.Name = "picReset";
            this.picReset.Size = new System.Drawing.Size(31, 26);
            this.picReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReset.TabIndex = 98;
            this.picReset.TabStop = false;
            // 
            // picInsert
            // 
            this.picInsert.Image = global::ProjetoAguas.Properties.Resources.Insert;
            this.picInsert.Location = new System.Drawing.Point(668, 101);
            this.picInsert.Name = "picInsert";
            this.picInsert.Size = new System.Drawing.Size(31, 26);
            this.picInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInsert.TabIndex = 97;
            this.picInsert.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(796, 92);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 43);
            this.btnUpdate.TabIndex = 96;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(680, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 43);
            this.btnDelete.TabIndex = 95;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(796, 164);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 43);
            this.btnReset.TabIndex = 94;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(680, 92);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 43);
            this.btnInsert.TabIndex = 93;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // lblMonthlyConsumption
            // 
            this.lblMonthlyConsumption.AutoSize = true;
            this.lblMonthlyConsumption.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyConsumption.Location = new System.Drawing.Point(327, 141);
            this.lblMonthlyConsumption.Name = "lblMonthlyConsumption";
            this.lblMonthlyConsumption.Size = new System.Drawing.Size(168, 18);
            this.lblMonthlyConsumption.TabIndex = 119;
            this.lblMonthlyConsumption.Text = "Monthly Consumption";
            // 
            // txtUnitaryValue
            // 
            this.txtUnitaryValue.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnitaryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitaryValue.ForeColor = System.Drawing.Color.Black;
            this.txtUnitaryValue.Location = new System.Drawing.Point(499, 139);
            this.txtUnitaryValue.Multiline = true;
            this.txtUnitaryValue.Name = "txtUnitaryValue";
            this.txtUnitaryValue.Size = new System.Drawing.Size(71, 23);
            this.txtUnitaryValue.TabIndex = 118;
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToPay.Location = new System.Drawing.Point(396, 225);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(114, 18);
            this.lblAmountToPay.TabIndex = 117;
            this.lblAmountToPay.Text = "Amount to Pay";
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.BackColor = System.Drawing.SystemColors.Control;
            this.txtAmountToPay.Enabled = false;
            this.txtAmountToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountToPay.ForeColor = System.Drawing.Color.Black;
            this.txtAmountToPay.Location = new System.Drawing.Point(511, 222);
            this.txtAmountToPay.Multiline = true;
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(70, 23);
            this.txtAmountToPay.TabIndex = 116;
            // 
            // UcInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMonthlyConsumption);
            this.Controls.Add(this.txtUnitaryValue);
            this.Controls.Add(this.lblAmountToPay);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.DataGriewInvoices);
            this.Controls.Add(this.cbPaymentType);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.picUpdate);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.picReset);
            this.Controls.Add(this.picInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnInsert);
            this.Name = "UcInvoices";
            this.Size = new System.Drawing.Size(992, 539);
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGriewInvoices;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox picUpdate;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picReset;
        private System.Windows.Forms.PictureBox picInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblMonthlyConsumption;
        private System.Windows.Forms.TextBox txtUnitaryValue;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.TextBox txtAmountToPay;
    }
}
