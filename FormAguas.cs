namespace ProjetoAguas
{
    using System.Windows.Forms;
    using System.Drawing;
    using System;
    using UserControls;

    public partial class FormAguas : Form
    {
        public FormAguas()
        {
            InitializeComponent();
            About(); // UserControl que irá aparecer primeiro
        }

        #region Métodos

        // Método que mostra o primeiro UserControl a ser apresentado pelo programa,o UserControl do About

        private void About()
        {
            btnAbout.FlatAppearance.BorderColor = Color.Red;
            UcAbout About = new UcAbout();
            addUserControl(About);
        }

        // Método que substitui o panel do formAguas pelo respetivo UserControl pretendido

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        #endregion

        #region UserControls

        // No evento Click de cada botão, o UserControl aparece novamente no lugar do panel do formAguas

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            UcStatistics statistics = new UcStatistics();
            addUserControl(statistics);
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            UcContracts contracts = new UcContracts();
            addUserControl(contracts);
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            UcInvoices invoices = new UcInvoices();
            addUserControl(invoices);
        }

        private void btnConsumptions_Click(object sender, EventArgs e)
        {
            UcConsumptions consumptions = new UcConsumptions();
            addUserControl(consumptions);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            UcClients clients = new UcClients();
            addUserControl(clients);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            UcAbout about = new UcAbout();
            addUserControl(about);
        }

        #endregion

        #region Data

        // Apresenta a data e a hora, onde as horas vão passando normalmente com um relógio

        private void timerDate_Tick_1(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss tt");
        }

        #endregion

        #region Sair

        // Ao clicar no botão SignOut, o programa dá-te a opção de retornar ao formLogIn

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            btnSignOut.FlatAppearance.BorderColor = Color.Red;
            DialogResult dr = MessageBox.Show("Do you want to return to LogIn?", "LogIn",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                new FormLogIn().Show();
            }
            else
            {
                btnSignOut.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
                return;
            }
        }

        // Ao clicar na imagem " em forma de x" ou seja a imagem de sair, terás a opção de
        // sair do programa, senão permaneces no formAguas

        private void picExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to leave?", "Leave",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        #endregion

        #region BorderColor

        // Ao clicar em um botão a sua borda ficará vermelha, se clicar noutro, a borda do anterior fica
        // com uma cor azul enquanto o novo botão fica com a borda vermelha, e por assim em diante

        private void btnStatistics_MouseClick(object sender, MouseEventArgs e)
        {
            btnStatistics.FlatAppearance.BorderColor = Color.Red;
            btnContracts.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnInvoices.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnConsumptions.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnClients.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnAbout.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnSignOut.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
        }

        private void btnContracts_MouseClick(object sender, MouseEventArgs e)
        {
            btnStatistics.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnContracts.FlatAppearance.BorderColor = Color.Red;
            btnInvoices.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnConsumptions.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnClients.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnAbout.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnSignOut.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
        }

        private void btnInvoices_MouseClick(object sender, MouseEventArgs e)
        {
            btnStatistics.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnContracts.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnInvoices.FlatAppearance.BorderColor = Color.Red;
            btnConsumptions.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnClients.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnAbout.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnSignOut.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
        }

        private void btnConsumptions_MouseClick(object sender, MouseEventArgs e)
        {
            btnStatistics.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnContracts.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnInvoices.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnConsumptions.FlatAppearance.BorderColor = Color.Red;
            btnClients.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnAbout.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnSignOut.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
        }

        private void btnClients_MouseClick(object sender, MouseEventArgs e)
        {
            btnStatistics.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnContracts.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnInvoices.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnConsumptions.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnClients.FlatAppearance.BorderColor = Color.Red;
            btnAbout.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnSignOut.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
        }

        private void btnAbout_MouseClick(object sender, MouseEventArgs e)
        {
            btnStatistics.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnContracts.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnInvoices.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnConsumptions.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnClients.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
            btnAbout.FlatAppearance.BorderColor = Color.Red;
            btnSignOut.FlatAppearance.BorderColor = Color.FromArgb(94, 148, 255);
        }

        #endregion
    }
}