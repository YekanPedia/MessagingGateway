namespace YekanPedia.MessagingGateway.Service.Interfaces
{
    using System.Collections.Generic;
    public interface INotificationStrategy
    {
        void Notify(List<string> messages, List<string> reciever);
    }
}
