namespace ProjetoAguas
{
    using System.Windows.Forms;

    public partial class FormLogIn : Form
    {
        public FormLogIn() { InitializeComponent();}

        #region Buttons

        // Validação dos campos de logIn, se o username não for Admin e a password não
        // for Cinel123, aparece uma mensagem de erro.

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

        // Ao clicar em Exit, o programa pergunta-te se queres sair, se sim,
        // o programa fecha, senão retorna ao form LogIn.

        private void picExit_Click(object sender, System.EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to leave?", "Leave",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        #endregion
    }
}