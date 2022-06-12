namespace ProjetoAguas.UserControls
{
    partial class UcClients
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
            this.mtxtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.DataGriewClients = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNIF = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picReset = new System.Windows.Forms.PictureBox();
            this.picInsert = new System.Windows.Forms.PictureBox();
            this.mtxtbNIF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtbTelephone
            // 
            this.mtxtbTelephone.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtbTelephone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtbTelephone.ForeColor = System.Drawing.Color.Black;
            this.mtxtbTelephone.Location = new System.Drawing.Point(297, 99);
            this.mtxtbTelephone.Mask = "999-999-999";
            this.mtxtbTelephone.Name = "mtxtbTelephone";
            this.mtxtbTelephone.Size = new System.Drawing.Size(159, 22);
            this.mtxtbTelephone.TabIndex = 23;
            this.mtxtbTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtbTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtbTelephone_KeyPress);
            // 
            // mtxtbPostalCode
            // 
            this.mtxtbPostalCode.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtbPostalCode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtbPostalCode.ForeColor = System.Drawing.Color.Black;
            this.mtxtbPostalCode.Location = new System.Drawing.Point(639, 165);
            this.mtxtbPostalCode.Mask = "9999-999";
            this.mtxtbPostalCode.Name = "mtxtbPostalCode";
            this.mtxtbPostalCode.Size = new System.Drawing.Size(78, 22);
            this.mtxtbPostalCode.TabIndex = 22;
            this.mtxtbPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtbPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtbPostalCode_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(609, 98);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(211, 38);
            this.txtAddress.TabIndex = 21;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(603, 31);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 23);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(329, 31);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 23);
            this.txtName.TabIndex = 19;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(187, 34);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(31, 23);
            this.txtID.TabIndex = 17;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataGriewClients
            // 
            this.DataGriewClients.AllowUserToDeleteRows = false;
            this.DataGriewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriewClients.Location = new System.Drawing.Point(123, 277);
            this.DataGriewClients.Name = "DataGriewClients";
            this.DataGriewClients.ReadOnly = true;
            this.DataGriewClients.Size = new System.Drawing.Size(748, 239);
            this.DataGriewClients.TabIndex = 24;
            this.DataGriewClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGriewClients_CellClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(162, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 18);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "ID";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(267, 166);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(30, 18);
            this.lblNIF.TabIndex = 26;
            this.lblNIF.Text = "NIF";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.Location = new System.Drawing.Point(540, 167);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(96, 18);
            this.lblPostalCode.TabIndex = 27;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(211, 100);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(86, 18);
            this.lblTelephone.TabIndex = 28;
            this.lblTelephone.Text = "Telephone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(540, 99);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 18);
            this.lblAddress.TabIndex = 29;
            this.lblAddress.Text = "Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(554, 33);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 18);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(274, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 18);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Name";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(238, 213);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 43);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(712, 214);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 43);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(563, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 43);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(405, 215);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 43);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // picUpdate
            // 
            this.picUpdate.Image = global::ProjetoAguas.Properties.Resources.Update;
            this.picUpdate.Location = new System.Drawing.Point(382, 222);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(31, 26);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUpdate.TabIndex = 39;
            this.picUpdate.TabStop = false;
            // 
            // picDelete
            // 
            this.picDelete.Image = global::ProjetoAguas.Properties.Resources.Delete;
            this.picDelete.Location = new System.Drawing.Point(549, 222);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(31, 26);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 38;
            this.picDelete.TabStop = false;
            // 
            // picReset
            // 
            this.picReset.Image = global::ProjetoAguas.Properties.Resources.Reset;
            this.picReset.Location = new System.Drawing.Point(698, 222);
            this.picReset.Name = "picReset";
            this.picReset.Size = new System.Drawing.Size(31, 26);
            this.picReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReset.TabIndex = 37;
            this.picReset.TabStop = false;
            // 
            // picInsert
            // 
            this.picInsert.Image = global::ProjetoAguas.Properties.Resources.Insert;
            this.picInsert.Location = new System.Drawing.Point(226, 222);
            this.picInsert.Name = "picInsert";
            this.picInsert.Size = new System.Drawing.Size(31, 26);
            this.picInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInsert.TabIndex = 36;
            this.picInsert.TabStop = false;
            // 
            // mtxtbNIF
            // 
            this.mtxtbNIF.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtbNIF.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtbNIF.ForeColor = System.Drawing.Color.Black;
            this.mtxtbNIF.Location = new System.Drawing.Point(297, 165);
            this.mtxtbNIF.Mask = "999999999";
            this.mtxtbNIF.Name = "mtxtbNIF";
            this.mtxtbNIF.Size = new System.Drawing.Size(159, 22);
            this.mtxtbNIF.TabIndex = 40;
            this.mtxtbNIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtbNIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtbNIF_KeyPress);
            // 
            // UcClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtxtbNIF);
            this.Controls.Add(this.picUpdate);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.picReset);
            this.Controls.Add(this.picInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.DataGriewClients);
            this.Controls.Add(this.mtxtbTelephone);
            this.Controls.Add(this.mtxtbPostalCode);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Name = "UcClients";
            this.Size = new System.Drawing.Size(992, 539);
            this.Load += new System.EventHandler(this.UcClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtbTelephone;
        private System.Windows.Forms.MaskedTextBox mtxtbPostalCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView DataGriewClients;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox picInsert;
        private System.Windows.Forms.PictureBox picReset;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picUpdate;
        private System.Windows.Forms.MaskedTextBox mtxtbNIF;
    }
}
