namespace ProjetoAguas
{
    partial class AttachPDF
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picSend = new System.Windows.Forms.PictureBox();
            this.picAttach = new System.Windows.Forms.PictureBox();
            this.txtPDF = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAttach)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Gainsboro;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.lblFile);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.picBack);
            this.panelContent.Controls.Add(this.picSend);
            this.panelContent.Controls.Add(this.picAttach);
            this.panelContent.Controls.Add(this.txtPDF);
            this.panelContent.Controls.Add(this.txtMessage);
            this.panelContent.Controls.Add(this.lblMessage);
            this.panelContent.Controls.Add(this.txtSubject);
            this.panelContent.Controls.Add(this.lblSubject);
            this.panelContent.Controls.Add(this.txtTo);
            this.panelContent.Controls.Add(this.lblDestino);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(622, 358);
            this.panelContent.TabIndex = 0;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(369, 73);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(33, 18);
            this.lblFile.TabIndex = 22;
            this.lblFile.Text = "File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 21;
            // 
            // picBack
            // 
            this.picBack.Image = global::ProjetoAguas.Properties.Resources.Comeback;
            this.picBack.Location = new System.Drawing.Point(564, 9);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(37, 34);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 20;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click_1);
            // 
            // picSend
            // 
            this.picSend.Image = global::ProjetoAguas.Properties.Resources.Send;
            this.picSend.Location = new System.Drawing.Point(520, 292);
            this.picSend.Name = "picSend";
            this.picSend.Size = new System.Drawing.Size(89, 53);
            this.picSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSend.TabIndex = 19;
            this.picSend.TabStop = false;
            this.picSend.Click += new System.EventHandler(this.picSend_Click_1);
            // 
            // picAttach
            // 
            this.picAttach.Image = global::ProjetoAguas.Properties.Resources.Attach;
            this.picAttach.Location = new System.Drawing.Point(531, 88);
            this.picAttach.Name = "picAttach";
            this.picAttach.Size = new System.Drawing.Size(42, 31);
            this.picAttach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAttach.TabIndex = 18;
            this.picAttach.TabStop = false;
            this.picAttach.Click += new System.EventHandler(this.picAttach_Click_1);
            // 
            // txtPDF
            // 
            this.txtPDF.Enabled = false;
            this.txtPDF.Location = new System.Drawing.Point(369, 94);
            this.txtPDF.Multiline = true;
            this.txtPDF.Name = "txtPDF";
            this.txtPDF.Size = new System.Drawing.Size(156, 22);
            this.txtPDF.TabIndex = 17;
            this.txtPDF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(93, 144);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(371, 170);
            this.txtMessage.TabIndex = 16;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(21, 143);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(74, 18);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.Text = "Message";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(84, 92);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(156, 22);
            this.txtSubject.TabIndex = 14;
            this.txtSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(21, 93);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(63, 18);
            this.lblSubject.TabIndex = 13;
            this.lblSubject.Text = "Subject";
            // 
            // txtTo
            // 
            this.txtTo.Enabled = false;
            this.txtTo.Location = new System.Drawing.Point(47, 43);
            this.txtTo.Multiline = true;
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(193, 22);
            this.txtTo.TabIndex = 12;
            this.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(21, 44);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(24, 18);
            this.lblDestino.TabIndex = 11;
            this.lblDestino.Text = "To";
            // 
            // AttachPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 358);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttachPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttachPDF";
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAttach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox picSend;
        private System.Windows.Forms.PictureBox picAttach;
        private System.Windows.Forms.TextBox txtPDF;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblFile;
    }
}