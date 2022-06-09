namespace ProjetoAguas
{
    using System;
    using System.Net.Mail;

    public class EnvioEmail
    {
        Attachment anexo;
        SmtpClient smtp = new SmtpClient();
        MailMessage mail = new MailMessage();

        #region Escondido por ter a senha

        public void Envio(string destino, string mensagem, string assunto, string anexar)
        {
            anexo = new Attachment(anexar);

            mail.Attachments.Add(anexo);

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("andre2411fernandes@gmail.com", "pqygujcbmdvzldfv");
            mail.From = new MailAddress("andre2411fernandes@gmail.com", "Water Company");

            if(!string.IsNullOrWhiteSpace(destino))
            {
                mail.To.Add(new MailAddress(destino));
            }

            mail.Subject = assunto;
            mail.Body = mensagem;
            smtp.Send(mail);
        }

        #endregion
    }
}
