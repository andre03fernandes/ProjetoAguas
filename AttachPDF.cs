namespace ProjetoAguas
{
    using System;
    using System.Windows.Forms;

    public partial class AttachPDF : Form
    {
        public AttachPDF()
        {
            InitializeComponent();
            txtTo.Text = "andre2411fernandes@gmail.com";
        }

        public void Instance()
        {
            EnvioEmail email = new EnvioEmail();
            email.Envio(txtTo.Text, txtMessage.Text, txtSubject.Text, txtPDF.Text);
        }

        private bool Valida()
        {
            if (string.IsNullOrWhiteSpace(txtTo.Text))
            {
                MessageBox.Show("O campo do destinatário é obrigatório", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                MessageBox.Show("Email enviado com sucesso", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Instance();
                return true;
            }
        }

        private void picBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void picAttach_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Find file";
            open.Filter = "PDF files | *.pdf";
            open.InitialDirectory = @"C:\Downloads";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtPDF.Text = open.FileName;
            }
        }

        private void picSend_Click_1(object sender, EventArgs e)
        {
            Valida();
        }
    }
}