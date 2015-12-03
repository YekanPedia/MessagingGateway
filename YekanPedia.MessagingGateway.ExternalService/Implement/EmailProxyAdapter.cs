
namespace YekanPedia.MessagingGateway.ExternalService.Implement
{
    using System;
    using Interfaces;
    using EmailGateway;

    public class EmailProxyAdapter : IEmailProxyAdapter
    {
        readonly EmailGatewayClient _emailGatewayClient;
        public EmailProxyAdapter()
        {
            _emailGatewayClient = new EmailGatewayClient();
        }
        public void SendEmail(EmailModel model)
        {
            _emailGatewayClient.SendSimpleEmail(model);
        }
    }
}
