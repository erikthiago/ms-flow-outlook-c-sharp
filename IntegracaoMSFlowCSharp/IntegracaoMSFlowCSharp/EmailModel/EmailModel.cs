namespace IntegracaoMSFlowCSharp.EmailModel
{
    public class EmailModel
    {
        /// <summary>
        /// Construtor utilizando as melhores práticas de desenvolvimento
        /// Dessa forma você já cria a entidade ao instanciar, evitando corrupção de código
        /// </summary>
        /// <param name="subject">Assunto</param>
        /// <param name="to">Destinatário</param>
        /// <param name="cC">Cópia</param>
        /// <param name="body">Corpo do e-mail</param>
        public EmailModel(string subject, string to, string cC, string body)
        {
            Subject = subject;
            To = to;
            CC = cC;
            Body = body;
        }

        public string Subject { get; private set; }
        public string To { get; private set; }
        public string CC { get; private set; }
        public string Body { get; private set; }
    }
}
