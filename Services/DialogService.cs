namespace ProjetoAguas.Services
{
    using System.Windows.Forms;

    public class DialogService
    {
        public void MostrarMensagem(string titulo, string mensagem)
        {
            MessageBox.Show(mensagem, titulo);
        }
    }
}
