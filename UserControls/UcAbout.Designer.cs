namespace ProjetoAguas.UserControls
{
    partial class UcAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAbout));
            this.panelContent = new System.Windows.Forms.Panel();
            this.picOndas = new System.Windows.Forms.PictureBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.picCopo = new System.Windows.Forms.PictureBox();
            this.lblFormando = new System.Windows.Forms.Label();
            this.lblFormador = new System.Windows.Forms.Label();
            this.lblUFCD = new System.Windows.Forms.Label();
            this.picGotas = new System.Windows.Forms.PictureBox();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.picPeixe = new System.Windows.Forms.PictureBox();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOndas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeixe)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.picOndas);
            this.panelContent.Controls.Add(this.lblMes);
            this.panelContent.Controls.Add(this.lblVersion);
            this.panelContent.Controls.Add(this.picCopo);
            this.panelContent.Controls.Add(this.lblFormando);
            this.panelContent.Controls.Add(this.lblFormador);
            this.panelContent.Controls.Add(this.lblUFCD);
            this.panelContent.Controls.Add(this.picGotas);
            this.panelContent.Controls.Add(this.picInfo);
            this.panelContent.Controls.Add(this.picPeixe);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(900, 546);
            this.panelContent.TabIndex = 0;
            // 
            // picOndas
            // 
            this.picOndas.Image = global::ProjetoAguas.Properties.Resources._5;
            this.picOndas.Location = new System.Drawing.Point(449, 404);
            this.picOndas.Name = "picOndas";
            this.picOndas.Size = new System.Drawing.Size(70, 55);
            this.picOndas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOndas.TabIndex = 20;
            this.picOndas.TabStop = false;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(436, 359);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(97, 19);
            this.lblMes.TabIndex = 19;
            this.lblMes.Text = "Junho 2022";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(442, 313);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(88, 19);
            this.lblVersion.TabIndex = 17;
            this.lblVersion.Text = "Versão 1.0";
            // 
            // picCopo
            // 
            this.picCopo.Image = ((System.Drawing.Image)(resources.GetObject("picCopo.Image")));
            this.picCopo.Location = new System.Drawing.Point(359, 265);
            this.picCopo.Name = "picCopo";
            this.picCopo.Size = new System.Drawing.Size(37, 35);
            this.picCopo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCopo.TabIndex = 16;
            this.picCopo.TabStop = false;
            // 
            // lblFormando
            // 
            this.lblFormando.AutoSize = true;
            this.lblFormando.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormando.Location = new System.Drawing.Point(395, 273);
            this.lblFormando.Name = "lblFormando";
            this.lblFormando.Size = new System.Drawing.Size(202, 19);
            this.lblFormando.TabIndex = 15;
            this.lblFormando.Text = "CET69 - André Fernandes";
            // 
            // lblFormador
            // 
            this.lblFormador.AutoSize = true;
            this.lblFormador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormador.Location = new System.Drawing.Point(393, 226);
            this.lblFormador.Name = "lblFormador";
            this.lblFormador.Size = new System.Drawing.Size(202, 19);
            this.lblFormador.TabIndex = 14;
            this.lblFormador.Text = "Formador - Rafael Santos";
            // 
            // lblUFCD
            // 
            this.lblUFCD.AutoSize = true;
            this.lblUFCD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUFCD.Location = new System.Drawing.Point(247, 177);
            this.lblUFCD.Name = "lblUFCD";
            this.lblUFCD.Size = new System.Drawing.Size(534, 19);
            this.lblUFCD.TabIndex = 13;
            this.lblUFCD.Text = "UFCD 5413 - Programação de Computadores -  Orientada a Objetos";
            // 
            // picGotas
            // 
            this.picGotas.Image = global::ProjetoAguas.Properties.Resources._2;
            this.picGotas.Location = new System.Drawing.Point(187, 165);
            this.picGotas.Name = "picGotas";
            this.picGotas.Size = new System.Drawing.Size(54, 42);
            this.picGotas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGotas.TabIndex = 12;
            this.picGotas.TabStop = false;
            // 
            // picInfo
            // 
            this.picInfo.Image = global::ProjetoAguas.Properties.Resources.Info;
            this.picInfo.Location = new System.Drawing.Point(444, 98);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(70, 55);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInfo.TabIndex = 11;
            this.picInfo.TabStop = false;
            // 
            // picPeixe
            // 
            this.picPeixe.Image = global::ProjetoAguas.Properties.Resources._3;
            this.picPeixe.Location = new System.Drawing.Point(517, 293);
            this.picPeixe.Name = "picPeixe";
            this.picPeixe.Size = new System.Drawing.Size(55, 35);
            this.picPeixe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPeixe.TabIndex = 18;
            this.picPeixe.TabStop = false;
            // 
            // UcAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContent);
            this.Name = "UcAbout";
            this.Size = new System.Drawing.Size(900, 546);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOndas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeixe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox picOndas;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox picCopo;
        private System.Windows.Forms.Label lblFormando;
        private System.Windows.Forms.Label lblFormador;
        private System.Windows.Forms.Label lblUFCD;
        private System.Windows.Forms.PictureBox picGotas;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.PictureBox picPeixe;
    }
}
