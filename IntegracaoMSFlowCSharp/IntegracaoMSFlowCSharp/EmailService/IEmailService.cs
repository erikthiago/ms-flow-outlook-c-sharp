using System.Threading.Tasks;

namespace IntegracaoMSFlowCSharp.EmailService
{
    public interface IEmailService
    {
        Task SendMail(EmailModel.EmailModel emailModel);
    }
}
