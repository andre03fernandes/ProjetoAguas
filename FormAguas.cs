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
            DataAtual();
            About();
        }

        #region Métodos

        private void About()
        {
            btnAbout.FlatAppearance.BorderColor = Color.Red;
            UcAbout About = new UcAbout();
            addUserControl(About);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        #endregion

        #region UserControls

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

        DateTime Data = DateTime.Now;

        private void DataAtual()
        {
            lblData.Text = Data.ToString("dd/MM/yyyy");
        }

        #endregion

        #region Sair

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            btnSignOut.FlatAppearance.BorderColor = Color.Red;
            DialogResult dr = MessageBox.Show("Deseja regressar ao LogIn?", "LogIn",
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

        private void picExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja sair?", "Sair",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        #endregion

        #region BorderColor

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