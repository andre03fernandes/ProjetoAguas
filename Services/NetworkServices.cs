namespace ProjetoAguas.Services
{
    using System.Net;

    public class NetworkService
    {
        public Response CheckConnection() // Devolve um objeto do tipo response
        {
            var client = new WebClient();

            try
            {
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return new Response
                    {
                        IsSucess = true,
                    };
                }
            }
            catch
            {
                return new Response
                {
                    IsSucess = false,
                    Message = "Check your network connection!"
                };
            }
        }
    }
}
