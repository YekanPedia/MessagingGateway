namespace YekanPedia.MessagingGateway.Service.Interfaces
{
    using System.Collections.Generic;
    public interface IEmailNotification
    {
        void Notify(string body, List<string> email);
    }
}
