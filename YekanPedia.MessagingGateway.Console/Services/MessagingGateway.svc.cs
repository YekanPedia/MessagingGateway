namespace YekanPedia.MessagingGateway.Console
{
    using Domain;
    using Service.Interfaces;
    using DeoendencyResolver;
    using System.Collections.Generic;
    using System.Linq;
    public class MessagingGateway : IMessagingGateway
    {

        readonly ITelegramNotification _telegram;
        public MessagingGateway()
        {
            _telegram = IocInitializer.GetInstance<ITelegramNotification>();
        }
        public void GivenMessages(NotificationPackage message)
        {
            var TelegramReciever = new List<int>();
            var Message = new List<string>() { message.Message.First() };

            var isOneMessage = message.Message.Count == 1;
            if (!isOneMessage)
                Message.Clear();
            for (int i = 0; i < message.Type.Count; i++)
            {
                if (message.Type[i].Telegram)
                {
                    if (!isOneMessage)
                    {
                        Message.Add(message.Message[i]);
                    }
                    TelegramReciever.Add(message.Telegram[i]);
                }
            }
            _telegram.Notify(Message, TelegramReciever);
        }
    }
}
