using IntegracaoMSFlowCSharp.EmailService;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoMSFlowCSharp.Controllers
{
    [Route("api/send")]
    [ApiController]
    public class SendEmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public SendEmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        // GET: api/send
        [HttpGet(Name = "Get")]
        public string Get()
        {
            try
            {
                _emailService.SendMail(new EmailModel.EmailModel("Assunto", "Destinatario", "Copia", "Corpo do e-mail"));
                return "TUDO CERTO. EMAIL ENVIADO";
            }
            catch (System.Exception ex)
            {
                return string.Format("OPS! DEU ERRADO! ERRO: {0}", ex.Message);
            }
        }
    }
}
