namespace YekanPedia.MessagingGateway.Console
{
    using Domain;
    using Service.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    public class MessagingGateway : IMessagingGateway
    {
        readonly ITelegramNotification _telegram;
        public MessagingGateway(ITelegramNotification telegram)
        {
            _telegram = telegram;
        }
        public void GivenMessages(NotificationPackage package)
        {
            var TelegramReciever = new List<int>();
            var Message = new List<string> { package.Message.First() };

            var isOneMessage = package.Message.Count == 1;
            if (!isOneMessage)
                Message.Clear();
            #region Telegram
            for (int i = 0; i < package.Type.Count; i++)
            {
                if (package.Type[i].Telegram)
                {
                    if (!isOneMessage)
                    {
                        Message.Add(package.Message[i]);
                    }
                    TelegramReciever.Add(package.Telegram[i]);
                }
            }
            if (TelegramReciever.Count > 0)
            {
                _telegram.Notify(Message, TelegramReciever);
            }
            #endregion
        }
    }
}
