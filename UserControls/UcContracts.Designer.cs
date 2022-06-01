namespace ProjetoAguas.UserControls
{
    partial class UcContracts
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContractType = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblContractDate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.DataGriewContracts = new System.Windows.Forms.DataGridView();
            this.mtxtbPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picReset = new System.Windows.Forms.PictureBox();
            this.picInsert = new System.Windows.Forms.PictureBox();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.cbContractType = new System.Windows.Forms.ComboBox();
            this.dtpContractDate = new System.Windows.Forms.DateTimePicker();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(777, 76);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 43);
            this.btnUpdate.TabIndex = 58;
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
            this.btnDelete.Location = new System.Drawing.Point(661, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 43);
            this.btnDelete.TabIndex = 57;
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
            this.btnReset.Location = new System.Drawing.Point(777, 148);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 43);
            this.btnReset.TabIndex = 56;
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
            this.btnInsert.Location = new System.Drawing.Point(661, 76);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 43);
            this.btnInsert.TabIndex = 55;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(281, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 18);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "Name";
            // 
            // lblContractType
            // 
            this.lblContractType.AutoSize = true;
            this.lblContractType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractType.Location = new System.Drawing.Point(109, 101);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.Size = new System.Drawing.Size(111, 18);
            this.lblContractType.TabIndex = 53;
            this.lblContractType.Text = "Contract Type";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(339, 142);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 18);
            this.lblAddress.TabIndex = 52;
            this.lblAddress.Text = "Address";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(79, 175);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(111, 18);
            this.lblPaymentType.TabIndex = 51;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.Location = new System.Drawing.Point(395, 212);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(96, 18);
            this.lblPostalCode.TabIndex = 50;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // lblContractDate
            // 
            this.lblContractDate.AutoSize = true;
            this.lblContractDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractDate.Location = new System.Drawing.Point(139, 222);
            this.lblContractDate.Name = "lblContractDate";
            this.lblContractDate.Size = new System.Drawing.Size(111, 18);
            this.lblContractDate.TabIndex = 49;
            this.lblContractDate.Text = "Contract Date";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(135, 46);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 18);
            this.lblID.TabIndex = 48;
            this.lblID.Text = "ID";
            // 
            // DataGriewContracts
            // 
            this.DataGriewContracts.AllowUserToDeleteRows = false;
            this.DataGriewContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriewContracts.Location = new System.Drawing.Point(90, 275);
            this.DataGriewContracts.MultiSelect = false;
            this.DataGriewContracts.Name = "DataGriewContracts";
            this.DataGriewContracts.ReadOnly = true;
            this.DataGriewContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGriewContracts.Size = new System.Drawing.Size(813, 215);
            this.DataGriewContracts.TabIndex = 47;
            this.DataGriewContracts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGriewContracts_CellClick);
            // 
            // mtxtbPostalCode
            // 
            this.mtxtbPostalCode.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtbPostalCode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtbPostalCode.ForeColor = System.Drawing.Color.Black;
            this.mtxtbPostalCode.Location = new System.Drawing.Point(491, 211);
            this.mtxtbPostalCode.Mask = "9999-999";
            this.mtxtbPostalCode.Name = "mtxtbPostalCode";
            this.mtxtbPostalCode.Size = new System.Drawing.Size(68, 22);
            this.mtxtbPostalCode.TabIndex = 45;
            this.mtxtbPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(406, 133);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(192, 38);
            this.txtAddress.TabIndex = 44;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(160, 44);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(31, 23);
            this.txtID.TabIndex = 40;
            // 
            // picUpdate
            // 
            this.picUpdate.Image = global::ProjetoAguas.Properties.Resources.Update;
            this.picUpdate.Location = new System.Drawing.Point(754, 83);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(31, 26);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUpdate.TabIndex = 62;
            this.picUpdate.TabStop = false;
            // 
            // picDelete
            // 
            this.picDelete.Image = global::ProjetoAguas.Properties.Resources.Delete;
            this.picDelete.Location = new System.Drawing.Point(647, 156);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(31, 26);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 61;
            this.picDelete.TabStop = false;
            // 
            // picReset
            // 
            this.picReset.Image = global::ProjetoAguas.Properties.Resources.Reset;
            this.picReset.Location = new System.Drawing.Point(763, 156);
            this.picReset.Name = "picReset";
            this.picReset.Size = new System.Drawing.Size(31, 26);
            this.picReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReset.TabIndex = 60;
            this.picReset.TabStop = false;
            // 
            // picInsert
            // 
            this.picInsert.Image = global::ProjetoAguas.Properties.Resources.Insert;
            this.picInsert.Location = new System.Drawing.Point(649, 85);
            this.picInsert.Name = "picInsert";
            this.picInsert.Size = new System.Drawing.Size(31, 26);
            this.picInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInsert.TabIndex = 59;
            this.picInsert.TabStop = false;
            // 
            // cbClients
            // 
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(331, 45);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(145, 21);
            this.cbClients.TabIndex = 70;
            // 
            // cbContractType
            // 
            this.cbContractType.FormattingEnabled = true;
            this.cbContractType.Location = new System.Drawing.Point(216, 100);
            this.cbContractType.Name = "cbContractType";
            this.cbContractType.Size = new System.Drawing.Size(145, 21);
            this.cbContractType.TabIndex = 71;
            // 
            // dtpContractDate
            // 
            this.dtpContractDate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpContractDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpContractDate.Location = new System.Drawing.Point(246, 222);
            this.dtpContractDate.Name = "dtpContractDate";
            this.dtpContractDate.Size = new System.Drawing.Size(91, 20);
            this.dtpContractDate.TabIndex = 76;
            this.dtpContractDate.Value = new System.DateTime(2022, 1, 6, 0, 0, 0, 0);
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Location = new System.Drawing.Point(186, 175);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(145, 21);
            this.cbPaymentType.TabIndex = 77;
            // 
            // UcContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbPaymentType);
            this.Controls.Add(this.dtpContractDate);
            this.Controls.Add(this.cbContractType);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.picUpdate);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.picReset);
            this.Controls.Add(this.picInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblContractType);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblContractDate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.DataGriewContracts);
            this.Controls.Add(this.mtxtbPostalCode);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtID);
            this.Name = "UcContracts";
            this.Size = new System.Drawing.Size(992, 539);
            this.Load += new System.EventHandler(this.UcContracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUpdate;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picReset;
        private System.Windows.Forms.PictureBox picInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblContractDate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView DataGriewContracts;
        private System.Windows.Forms.MaskedTextBox mtxtbPostalCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.ComboBox cbContractType;
        private System.Windows.Forms.DateTimePicker dtpContractDate;
        private System.Windows.Forms.ComboBox cbPaymentType;
    }
}
