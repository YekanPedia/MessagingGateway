namespace YekanPedia.MessagingGateway.ExternalService.Interfaces
{
    using EmailGateway;

    public interface IEmailProxyAdapter
    {
        void SendEmail(EmailModel model);
    }
}
