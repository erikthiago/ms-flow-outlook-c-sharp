using RestSharp;
using System.Threading.Tasks;

namespace IntegracaoMSFlowCSharp.EmailService
{
    public class SendEmail : IEmailService
    {
        /// <summary>
        /// Método responsável por executar a rotina de acionar o flow e enviar um e-mail
        /// </summary>
        /// <param name="emailModel">O objeto que receberá as informações necessárias para que o envio do e-mail tenha sucesso.</param>
        /// <returns></returns>
        public async Task SendMail(EmailModel.EmailModel emailModel)
        {
            var client = new RestClient("https://seulink.com:443/");
            var request = new RestRequest("workflows/seulink", Method.POST);
            request.AddJsonBody(new
            {
                to = emailModel.To,
                cc = emailModel.CC,
                body = emailModel.Body,
                subject = emailModel.Subject,
            });

            await client.ExecuteTaskAsync(request);
        }
    }
}
