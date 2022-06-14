namespace ProjetoAguas
{
    using System.Net.Mail;

    public class EnvioEmail
    {
        Attachment anexo;
        SmtpClient smtp = new SmtpClient();
        MailMessage mail = new MailMessage();

        #region Escondido por ter a senha do email

        // Credenciais necessárias para o envio do email (email, porta, host, etc...)

        public void Envio(string destino, string mensagem, string assunto, string anexar)
        {
            anexo = new Attachment(anexar);

            mail.Attachments.Add(anexo);

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("andre2411fernandes@gmail.com", "pqygujcbmdvzldfv"); //  Credenciais do email
            mail.From = new MailAddress("andre2411fernandes@gmail.com", "Water Company");

            if (!string.IsNullOrWhiteSpace(destino))
            {
                mail.To.Add(new MailAddress(destino));
            }

            mail.Subject = assunto; // Assunto do email
            mail.Body = mensagem; // Mensagem do email
            smtp.Send(mail);
        }

        #endregion
    }
}