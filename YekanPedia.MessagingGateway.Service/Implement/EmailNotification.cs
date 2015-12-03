namespace YekanPedia.MessagingGateway.Service.Implement
{
    using System.Collections.Generic;
    using Interfaces;
    using ExternalService.Interfaces;
    using ExternalService.EmailGateway;

    public class EmailNotification : IEmailNotification
    {
        readonly IEmailProxyAdapter _emailAdapter;
        public EmailNotification(IEmailProxyAdapter emailAdapter)
        {
            _emailAdapter = emailAdapter;
        }
        public void Notify(string body, List<string> email)
        {
            var model = new EmailModel
            {
                Subject = "یکان پدیا",
                Body = body,
                EmailAddress = email
            };
            _emailAdapter.SendEmail(model);
        }
    }
}
