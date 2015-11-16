namespace YekanPedia.MessagingGateway.Service.Interfaces
{
    using System.Collections.Generic;
    public interface ITelegramNotification
    {
        void Notify(List<string> messages, List<int> reciever);
    }
}
