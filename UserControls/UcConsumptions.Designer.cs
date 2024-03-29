﻿namespace ProjetoAguas.UserControls
{
    partial class UcConsumptions
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
            this.dtpConsumeDate = new System.Windows.Forms.DateTimePicker();
            this.cbIDcontract = new System.Windows.Forms.ComboBox();
            this.lblidContract = new System.Windows.Forms.Label();
            this.lblEchelons = new System.Windows.Forms.Label();
            this.lblConsumeDate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.DataGriewConsumptions = new System.Windows.Forms.DataGridView();
            this.lblTotalConsume = new System.Windows.Forms.Label();
            this.txtTotalConsume = new System.Windows.Forms.TextBox();
            this.lblContractType = new System.Windows.Forms.Label();
            this.txtContractType = new System.Windows.Forms.TextBox();
            this.txtEchelons = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtUnitaryValue = new System.Windows.Forms.TextBox();
            this.lblUnitaryValue = new System.Windows.Forms.Label();
            this.txtClients = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picReset = new System.Windows.Forms.PictureBox();
            this.picInsert = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewConsumptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnUpdate.Location = new System.Drawing.Point(382, 229);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 43);
            this.btnUpdate.TabIndex = 43;
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
            this.btnDelete.Location = new System.Drawing.Point(556, 229);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 43);
            this.btnDelete.TabIndex = 42;
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
            this.btnReset.Location = new System.Drawing.Point(738, 229);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 43);
            this.btnReset.TabIndex = 41;
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
            this.btnInsert.Location = new System.Drawing.Point(214, 228);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 43);
            this.btnInsert.TabIndex = 40;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtpConsumeDate
            // 
            this.dtpConsumeDate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpConsumeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpConsumeDate.Location = new System.Drawing.Point(773, 106);
            this.dtpConsumeDate.Name = "dtpConsumeDate";
            this.dtpConsumeDate.Size = new System.Drawing.Size(91, 20);
            this.dtpConsumeDate.TabIndex = 90;
            this.dtpConsumeDate.Value = new System.DateTime(2022, 1, 6, 0, 0, 0, 0);
            // 
            // cbIDcontract
            // 
            this.cbIDcontract.FormattingEnabled = true;
            this.cbIDcontract.Location = new System.Drawing.Point(279, 32);
            this.cbIDcontract.Name = "cbIDcontract";
            this.cbIDcontract.Size = new System.Drawing.Size(116, 21);
            this.cbIDcontract.TabIndex = 88;
            this.cbIDcontract.TextChanged += new System.EventHandler(this.cbIDcontract_TextChanged);
            // 
            // lblidContract
            // 
            this.lblidContract.AutoSize = true;
            this.lblidContract.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidContract.Location = new System.Drawing.Point(196, 33);
            this.lblidContract.Name = "lblidContract";
            this.lblidContract.Size = new System.Drawing.Size(85, 18);
            this.lblidContract.TabIndex = 87;
            this.lblidContract.Text = "IDcontract";
            // 
            // lblEchelons
            // 
            this.lblEchelons.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEchelons.Location = new System.Drawing.Point(122, 105);
            this.lblEchelons.Name = "lblEchelons";
            this.lblEchelons.Size = new System.Drawing.Size(113, 23);
            this.lblEchelons.TabIndex = 84;
            this.lblEchelons.Text = "Echelons";
            this.lblEchelons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConsumeDate
            // 
            this.lblConsumeDate.AutoSize = true;
            this.lblConsumeDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumeDate.Location = new System.Drawing.Point(659, 106);
            this.lblConsumeDate.Name = "lblConsumeDate";
            this.lblConsumeDate.Size = new System.Drawing.Size(117, 18);
            this.lblConsumeDate.TabIndex = 82;
            this.lblConsumeDate.Text = "Consume Date";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(92, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 18);
            this.lblID.TabIndex = 81;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(117, 33);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(31, 23);
            this.txtID.TabIndex = 78;
            // 
            // DataGriewConsumptions
            // 
            this.DataGriewConsumptions.AllowUserToDeleteRows = false;
            this.DataGriewConsumptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriewConsumptions.Location = new System.Drawing.Point(48, 293);
            this.DataGriewConsumptions.Name = "DataGriewConsumptions";
            this.DataGriewConsumptions.ReadOnly = true;
            this.DataGriewConsumptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGriewConsumptions.Size = new System.Drawing.Size(894, 219);
            this.DataGriewConsumptions.TabIndex = 92;
            this.DataGriewConsumptions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGriewConsumptions_CellClick);
            // 
            // lblTotalConsume
            // 
            this.lblTotalConsume.AutoSize = true;
            this.lblTotalConsume.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalConsume.Location = new System.Drawing.Point(214, 173);
            this.lblTotalConsume.Name = "lblTotalConsume";
            this.lblTotalConsume.Size = new System.Drawing.Size(116, 18);
            this.lblTotalConsume.TabIndex = 94;
            this.lblTotalConsume.Text = "Total Consume";
            // 
            // txtTotalConsume
            // 
            this.txtTotalConsume.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalConsume.Enabled = false;
            this.txtTotalConsume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalConsume.ForeColor = System.Drawing.Color.Black;
            this.txtTotalConsume.Location = new System.Drawing.Point(333, 171);
            this.txtTotalConsume.Multiline = true;
            this.txtTotalConsume.Name = "txtTotalConsume";
            this.txtTotalConsume.Size = new System.Drawing.Size(70, 23);
            this.txtTotalConsume.TabIndex = 93;
            this.txtTotalConsume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblContractType
            // 
            this.lblContractType.AutoSize = true;
            this.lblContractType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractType.Location = new System.Drawing.Point(673, 31);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.Size = new System.Drawing.Size(111, 18);
            this.lblContractType.TabIndex = 96;
            this.lblContractType.Text = "Contract Type";
            // 
            // txtContractType
            // 
            this.txtContractType.BackColor = System.Drawing.SystemColors.Control;
            this.txtContractType.Enabled = false;
            this.txtContractType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContractType.ForeColor = System.Drawing.Color.Black;
            this.txtContractType.Location = new System.Drawing.Point(786, 30);
            this.txtContractType.Multiline = true;
            this.txtContractType.Name = "txtContractType";
            this.txtContractType.Size = new System.Drawing.Size(125, 23);
            this.txtContractType.TabIndex = 95;
            // 
            // txtEchelons
            // 
            this.txtEchelons.BackColor = System.Drawing.SystemColors.Control;
            this.txtEchelons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEchelons.ForeColor = System.Drawing.Color.Black;
            this.txtEchelons.Location = new System.Drawing.Point(238, 105);
            this.txtEchelons.Multiline = true;
            this.txtEchelons.Name = "txtEchelons";
            this.txtEchelons.Size = new System.Drawing.Size(62, 23);
            this.txtEchelons.TabIndex = 97;
            this.txtEchelons.TabStop = false;
            this.txtEchelons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEchelons.TextChanged += new System.EventHandler(this.txtEchelons_TextChanged);
            this.txtEchelons.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEchelons_KeyPress);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(455, 31);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(51, 18);
            this.lblClient.TabIndex = 86;
            this.lblClient.Text = "Client";
            // 
            // txtUnitaryValue
            // 
            this.txtUnitaryValue.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnitaryValue.Enabled = false;
            this.txtUnitaryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitaryValue.ForeColor = System.Drawing.Color.Black;
            this.txtUnitaryValue.Location = new System.Drawing.Point(495, 105);
            this.txtUnitaryValue.Multiline = true;
            this.txtUnitaryValue.Name = "txtUnitaryValue";
            this.txtUnitaryValue.Size = new System.Drawing.Size(71, 23);
            this.txtUnitaryValue.TabIndex = 100;
            this.txtUnitaryValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUnitaryValue
            // 
            this.lblUnitaryValue.AutoSize = true;
            this.lblUnitaryValue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitaryValue.Location = new System.Drawing.Point(389, 107);
            this.lblUnitaryValue.Name = "lblUnitaryValue";
            this.lblUnitaryValue.Size = new System.Drawing.Size(107, 18);
            this.lblUnitaryValue.TabIndex = 99;
            this.lblUnitaryValue.Text = "Unitary Value";
            // 
            // txtClients
            // 
            this.txtClients.BackColor = System.Drawing.SystemColors.Control;
            this.txtClients.Enabled = false;
            this.txtClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClients.ForeColor = System.Drawing.Color.Black;
            this.txtClients.Location = new System.Drawing.Point(506, 29);
            this.txtClients.Multiline = true;
            this.txtClients.Name = "txtClients";
            this.txtClients.Size = new System.Drawing.Size(125, 23);
            this.txtClients.TabIndex = 101;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(556, 161);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(92, 43);
            this.btnGenerate.TabIndex = 115;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click_1);
            // 
            // btnEstimate
            // 
            this.btnEstimate.BackColor = System.Drawing.SystemColors.Control;
            this.btnEstimate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEstimate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnEstimate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnEstimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstimate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstimate.Location = new System.Drawing.Point(696, 162);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(84, 43);
            this.btnEstimate.TabIndex = 117;
            this.btnEstimate.Text = "Estimate";
            this.btnEstimate.UseVisualStyleBackColor = false;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProjetoAguas.Properties.Resources.Estimate;
            this.pictureBox5.Location = new System.Drawing.Point(672, 170);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 118;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProjetoAguas.Properties.Resources.Calculator;
            this.pictureBox4.Location = new System.Drawing.Point(531, 169);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 116;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoAguas.Properties.Resources.Euro;
            this.pictureBox2.Location = new System.Drawing.Point(399, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjetoAguas.Properties.Resources.Euro;
            this.pictureBox3.Location = new System.Drawing.Point(562, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 106;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoAguas.Properties.Resources.m_3;
            this.pictureBox1.Location = new System.Drawing.Point(287, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // picUpdate
            // 
            this.picUpdate.Image = global::ProjetoAguas.Properties.Resources.Update;
            this.picUpdate.Location = new System.Drawing.Point(361, 236);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(31, 26);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUpdate.TabIndex = 47;
            this.picUpdate.TabStop = false;
            // 
            // picDelete
            // 
            this.picDelete.Image = global::ProjetoAguas.Properties.Resources.Delete;
            this.picDelete.Location = new System.Drawing.Point(542, 237);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(31, 26);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 46;
            this.picDelete.TabStop = false;
            // 
            // picReset
            // 
            this.picReset.Image = global::ProjetoAguas.Properties.Resources.Reset;
            this.picReset.Location = new System.Drawing.Point(724, 237);
            this.picReset.Name = "picReset";
            this.picReset.Size = new System.Drawing.Size(31, 26);
            this.picReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReset.TabIndex = 45;
            this.picReset.TabStop = false;
            // 
            // picInsert
            // 
            this.picInsert.Image = global::ProjetoAguas.Properties.Resources.Insert;
            this.picInsert.Location = new System.Drawing.Point(204, 237);
            this.picInsert.Name = "picInsert";
            this.picInsert.Size = new System.Drawing.Size(31, 26);
            this.picInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInsert.TabIndex = 44;
            this.picInsert.TabStop = false;
            // 
            // UcConsumptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtTotalConsume);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtUnitaryValue);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtEchelons);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtClients);
            this.Controls.Add(this.lblUnitaryValue);
            this.Controls.Add(this.lblContractType);
            this.Controls.Add(this.txtContractType);
            this.Controls.Add(this.lblTotalConsume);
            this.Controls.Add(this.DataGriewConsumptions);
            this.Controls.Add(this.dtpConsumeDate);
            this.Controls.Add(this.cbIDcontract);
            this.Controls.Add(this.lblidContract);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblEchelons);
            this.Controls.Add(this.lblConsumeDate);
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
            this.Name = "UcConsumptions";
            this.Size = new System.Drawing.Size(992, 539);
            this.Load += new System.EventHandler(this.UcConsumptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewConsumptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpConsumeDate;
        private System.Windows.Forms.ComboBox cbIDcontract;
        private System.Windows.Forms.Label lblidContract;
        private System.Windows.Forms.Label lblEchelons;
        private System.Windows.Forms.Label lblConsumeDate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView DataGriewConsumptions;
        private System.Windows.Forms.Label lblTotalConsume;
        private System.Windows.Forms.TextBox txtTotalConsume;
        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.TextBox txtContractType;
        private System.Windows.Forms.TextBox txtEchelons;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtUnitaryValue;
        private System.Windows.Forms.Label lblUnitaryValue;
        private System.Windows.Forms.TextBox txtClients;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnEstimate;
    }
}
