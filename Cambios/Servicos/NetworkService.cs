namespace Cambios.Servicos
{
    using Modelos;
    using System.Net;

    public class NetworkService
    {
        public Response checkConnection()
        {
            var client = new WebClient();

            try
            {
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return new Response
                    {
                        IsSucess = true
                    };
                }
            }
            catch
            {
                return new Response
                {
                    IsSucess = false,
                    Message = "Configure sua ligação á internet",
                };
            }
            
        }
    }
}
