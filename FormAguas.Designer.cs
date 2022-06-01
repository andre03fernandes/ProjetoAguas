namespace ProjetoAguas
{
    partial class FormAguas
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCabeçalho = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnConsumptions = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelCabeçalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabeçalho
            // 
            this.panelCabeçalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelCabeçalho.Controls.Add(this.lblData);
            this.panelCabeçalho.Controls.Add(this.picExit);
            this.panelCabeçalho.Controls.Add(this.lblUser);
            this.panelCabeçalho.Controls.Add(this.picUser);
            this.panelCabeçalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabeçalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabeçalho.Name = "panelCabeçalho";
            this.panelCabeçalho.Size = new System.Drawing.Size(988, 82);
            this.panelCabeçalho.TabIndex = 0;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(824, 33);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 18);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Date";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picExit
            // 
            this.picExit.Image = global::ProjetoAguas.Properties.Resources.Exit;
            this.picExit.Location = new System.Drawing.Point(934, 23);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(35, 35);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 9;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(103, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(71, 23);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Admin";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picUser
            // 
            this.picUser.Image = global::ProjetoAguas.Properties.Resources.User;
            this.picUser.Location = new System.Drawing.Point(12, 10);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(85, 60);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 7;
            this.picUser.TabStop = false;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelButtons.Controls.Add(this.btnSignOut);
            this.panelButtons.Controls.Add(this.btnAbout);
            this.panelButtons.Controls.Add(this.btnClients);
            this.panelButtons.Controls.Add(this.btnConsumptions);
            this.panelButtons.Controls.Add(this.btnInvoices);
            this.panelButtons.Controls.Add(this.btnContracts);
            this.panelButtons.Controls.Add(this.btnStatistics);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 82);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(988, 47);
            this.panelButtons.TabIndex = 1;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.White;
            this.btnSignOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(849, 2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(137, 43);
            this.btnSignOut.TabIndex = 6;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(707, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(141, 43);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAbout_MouseClick);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.White;
            this.btnClients.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.Location = new System.Drawing.Point(565, 2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(141, 43);
            this.btnClients.TabIndex = 4;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            this.btnClients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClients_MouseClick);
            // 
            // btnConsumptions
            // 
            this.btnConsumptions.BackColor = System.Drawing.Color.White;
            this.btnConsumptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnConsumptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumptions.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumptions.Location = new System.Drawing.Point(424, 2);
            this.btnConsumptions.Name = "btnConsumptions";
            this.btnConsumptions.Size = new System.Drawing.Size(140, 43);
            this.btnConsumptions.TabIndex = 3;
            this.btnConsumptions.Text = "Consumptions";
            this.btnConsumptions.UseVisualStyleBackColor = false;
            this.btnConsumptions.Click += new System.EventHandler(this.btnConsumptions_Click);
            this.btnConsumptions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnConsumptions_MouseClick);
            // 
            // btnInvoices
            // 
            this.btnInvoices.BackColor = System.Drawing.Color.White;
            this.btnInvoices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoices.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoices.Location = new System.Drawing.Point(282, 2);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(141, 43);
            this.btnInvoices.TabIndex = 2;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = false;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            this.btnInvoices.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnInvoices_MouseClick);
            // 
            // btnContracts
            // 
            this.btnContracts.BackColor = System.Drawing.Color.White;
            this.btnContracts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContracts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContracts.Location = new System.Drawing.Point(142, 2);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(139, 43);
            this.btnContracts.TabIndex = 1;
            this.btnContracts.Text = "Contracts";
            this.btnContracts.UseVisualStyleBackColor = false;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            this.btnContracts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnContracts_MouseClick);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.White;
            this.btnStatistics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.Location = new System.Drawing.Point(2, 2);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(139, 43);
            this.btnStatistics.TabIndex = 0;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            this.btnStatistics.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnStatistics_MouseClick);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 129);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(988, 546);
            this.panelContent.TabIndex = 2;
            // 
            // FormAguas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 675);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelCabeçalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAguas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAguas";
            this.panelCabeçalho.ResumeLayout(false);
            this.panelCabeçalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabeçalho;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnConsumptions;
        private System.Windows.Forms.Panel panelContent;
    }
}