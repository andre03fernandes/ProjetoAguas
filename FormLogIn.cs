namespace ProjetoAguas
{
    using System.Windows.Forms;

    public partial class FormLogIn : Form
    {
        public FormLogIn() { InitializeComponent(); }

        #region Buttons

        private void picLogIn_Click(object sender, System.EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "Cinel123")
            {
                this.Hide();
                new FormAguas().Show();
            }
            else
                MessageBox.Show("Username or Password are incorrects!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void picExit_Click(object sender, System.EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja Sair?", "Sair",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        #endregion
    }
}