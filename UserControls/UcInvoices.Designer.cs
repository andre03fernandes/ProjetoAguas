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
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.cbIDcontracts = new System.Windows.Forms.ComboBox();
            this.lblIdContracts = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblMonthlyConsumption = new System.Windows.Forms.Label();
            this.txtMonthlyConsumption = new System.Windows.Forms.TextBox();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.txtPaymentType = new System.Windows.Forms.TextBox();
            this.txtClients = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.picPDF = new System.Windows.Forms.PictureBox();
            this.picMonthConsume = new System.Windows.Forms.PictureBox();
            this.picAmount = new System.Windows.Forms.PictureBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picReset = new System.Windows.Forms.PictureBox();
            this.picInsert = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMonthConsume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGriewInvoices
            // 
            this.DataGriewInvoices.AllowUserToDeleteRows = false;
            this.DataGriewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriewInvoices.Location = new System.Drawing.Point(76, 267);
            this.DataGriewInvoices.Name = "DataGriewInvoices";
            this.DataGriewInvoices.ReadOnly = true;
            this.DataGriewInvoices.Size = new System.Drawing.Size(845, 243);
            this.DataGriewInvoices.TabIndex = 115;
            this.DataGriewInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGriewInvoices_CellClick);
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(258, 142);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(91, 20);
            this.dtpInvoiceDate.TabIndex = 113;
            this.dtpInvoiceDate.Value = new System.DateTime(2022, 1, 6, 0, 0, 0, 0);
            // 
            // cbIDcontracts
            // 
            this.cbIDcontracts.FormattingEnabled = true;
            this.cbIDcontracts.Location = new System.Drawing.Point(444, 30);
            this.cbIDcontracts.Name = "cbIDcontracts";
            this.cbIDcontracts.Size = new System.Drawing.Size(90, 21);
            this.cbIDcontracts.TabIndex = 111;
            this.cbIDcontracts.SelectedIndexChanged += new System.EventHandler(this.cbIDcontracts_SelectedIndexChanged);
            // 
            // lblIdContracts
            // 
            this.lblIdContracts.AutoSize = true;
            this.lblIdContracts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdContracts.Location = new System.Drawing.Point(359, 31);
            this.lblIdContracts.Name = "lblIdContracts";
            this.lblIdContracts.Size = new System.Drawing.Size(85, 18);
            this.lblIdContracts.TabIndex = 110;
            this.lblIdContracts.Text = "IDcontract";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(241, 83);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(111, 18);
            this.lblPaymentType.TabIndex = 107;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(151, 142);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(102, 18);
            this.lblInvoiceDate.TabIndex = 105;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(211, 31);
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
            this.txtID.Location = new System.Drawing.Point(236, 29);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(31, 23);
            this.txtID.TabIndex = 101;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(357, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 43);
            this.btnUpdate.TabIndex = 96;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(527, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 43);
            this.btnDelete.TabIndex = 95;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(643, 204);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 43);
            this.btnReset.TabIndex = 94;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(197, 203);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 43);
            this.btnInsert.TabIndex = 93;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblMonthlyConsumption
            // 
            this.lblMonthlyConsumption.AutoSize = true;
            this.lblMonthlyConsumption.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyConsumption.Location = new System.Drawing.Point(569, 141);
            this.lblMonthlyConsumption.Name = "lblMonthlyConsumption";
            this.lblMonthlyConsumption.Size = new System.Drawing.Size(168, 18);
            this.lblMonthlyConsumption.TabIndex = 119;
            this.lblMonthlyConsumption.Text = "Monthly Consumption";
            // 
            // txtMonthlyConsumption
            // 
            this.txtMonthlyConsumption.BackColor = System.Drawing.SystemColors.Control;
            this.txtMonthlyConsumption.Enabled = false;
            this.txtMonthlyConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyConsumption.ForeColor = System.Drawing.Color.Black;
            this.txtMonthlyConsumption.Location = new System.Drawing.Point(741, 139);
            this.txtMonthlyConsumption.Multiline = true;
            this.txtMonthlyConsumption.Name = "txtMonthlyConsumption";
            this.txtMonthlyConsumption.Size = new System.Drawing.Size(71, 23);
            this.txtMonthlyConsumption.TabIndex = 118;
            this.txtMonthlyConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToPay.Location = new System.Drawing.Point(536, 83);
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
            this.txtAmountToPay.Location = new System.Drawing.Point(651, 80);
            this.txtAmountToPay.Multiline = true;
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(70, 23);
            this.txtAmountToPay.TabIndex = 116;
            this.txtAmountToPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.BackColor = System.Drawing.SystemColors.Control;
            this.txtPaymentType.Enabled = false;
            this.txtPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentType.ForeColor = System.Drawing.Color.Black;
            this.txtPaymentType.Location = new System.Drawing.Point(353, 80);
            this.txtPaymentType.Multiline = true;
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Size = new System.Drawing.Size(146, 23);
            this.txtPaymentType.TabIndex = 122;
            this.txtPaymentType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtClients
            // 
            this.txtClients.BackColor = System.Drawing.SystemColors.Control;
            this.txtClients.Enabled = false;
            this.txtClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClients.ForeColor = System.Drawing.Color.Black;
            this.txtClients.Location = new System.Drawing.Point(672, 27);
            this.txtClients.Multiline = true;
            this.txtClients.Name = "txtClients";
            this.txtClients.Size = new System.Drawing.Size(146, 23);
            this.txtClients.TabIndex = 124;
            this.txtClients.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(622, 30);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(51, 18);
            this.lblClient.TabIndex = 123;
            this.lblClient.Text = "Client";
            // 
            // picPDF
            // 
            this.picPDF.Image = global::ProjetoAguas.Properties.Resources.Pdf;
            this.picPDF.Location = new System.Drawing.Point(762, 201);
            this.picPDF.Name = "picPDF";
            this.picPDF.Size = new System.Drawing.Size(60, 45);
            this.picPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPDF.TabIndex = 127;
            this.picPDF.TabStop = false;
            this.picPDF.Click += new System.EventHandler(this.picPDF_Click);
            // 
            // picMonthConsume
            // 
            this.picMonthConsume.Image = global::ProjetoAguas.Properties.Resources.Euro;
            this.picMonthConsume.Location = new System.Drawing.Point(809, 135);
            this.picMonthConsume.Name = "picMonthConsume";
            this.picMonthConsume.Size = new System.Drawing.Size(35, 31);
            this.picMonthConsume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMonthConsume.TabIndex = 121;
            this.picMonthConsume.TabStop = false;
            // 
            // picAmount
            // 
            this.picAmount.Image = global::ProjetoAguas.Properties.Resources.Euro;
            this.picAmount.Location = new System.Drawing.Point(717, 75);
            this.picAmount.Name = "picAmount";
            this.picAmount.Size = new System.Drawing.Size(35, 31);
            this.picAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAmount.TabIndex = 120;
            this.picAmount.TabStop = false;
            // 
            // picUpdate
            // 
            this.picUpdate.Image = global::ProjetoAguas.Properties.Resources.Update;
            this.picUpdate.Location = new System.Drawing.Point(334, 212);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(31, 26);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUpdate.TabIndex = 100;
            this.picUpdate.TabStop = false;
            // 
            // picDelete
            // 
            this.picDelete.Image = global::ProjetoAguas.Properties.Resources.Delete;
            this.picDelete.Location = new System.Drawing.Point(511, 212);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(31, 26);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 99;
            this.picDelete.TabStop = false;
            // 
            // picReset
            // 
            this.picReset.Image = global::ProjetoAguas.Properties.Resources.Reset;
            this.picReset.Location = new System.Drawing.Point(629, 212);
            this.picReset.Name = "picReset";
            this.picReset.Size = new System.Drawing.Size(31, 26);
            this.picReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReset.TabIndex = 98;
            this.picReset.TabStop = false;
            // 
            // picInsert
            // 
            this.picInsert.Image = global::ProjetoAguas.Properties.Resources.Insert;
            this.picInsert.Location = new System.Drawing.Point(185, 212);
            this.picInsert.Name = "picInsert";
            this.picInsert.Size = new System.Drawing.Size(31, 26);
            this.picInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInsert.TabIndex = 97;
            this.picInsert.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProjetoAguas.Properties.Resources.Calculator;
            this.pictureBox4.Location = new System.Drawing.Point(416, 135);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 129;
            this.pictureBox4.TabStop = false;
            // 
            // btnCalcula
            // 
            this.btnCalcula.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalcula.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCalcula.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCalcula.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCalcula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.Location = new System.Drawing.Point(441, 127);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(92, 43);
            this.btnCalcula.TabIndex = 128;
            this.btnCalcula.Text = "Generate";
            this.btnCalcula.UseVisualStyleBackColor = false;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // UcInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.picPDF);
            this.Controls.Add(this.txtClients);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.txtPaymentType);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.txtMonthlyConsumption);
            this.Controls.Add(this.picMonthConsume);
            this.Controls.Add(this.picAmount);
            this.Controls.Add(this.lblMonthlyConsumption);
            this.Controls.Add(this.lblAmountToPay);
            this.Controls.Add(this.DataGriewInvoices);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.cbIDcontracts);
            this.Controls.Add(this.lblIdContracts);
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
            this.Load += new System.EventHandler(this.UcInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMonthConsume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGriewInvoices;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.ComboBox cbIDcontracts;
        private System.Windows.Forms.Label lblIdContracts;
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
        private System.Windows.Forms.TextBox txtMonthlyConsumption;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.PictureBox picAmount;
        private System.Windows.Forms.PictureBox picMonthConsume;
        private System.Windows.Forms.TextBox txtPaymentType;
        private System.Windows.Forms.TextBox txtClients;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.PictureBox picPDF;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnCalcula;
    }
}
