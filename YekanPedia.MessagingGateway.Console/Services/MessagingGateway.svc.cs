namespace YekanPedia.MessagingGateway.Console
{
    using Domain;
    using Service.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class MessagingGateway : IMessagingGateway
    {
        readonly ITelegramNotification _telegram;
        readonly IEmailNotification _emailNotification;
        public MessagingGateway(ITelegramNotification telegram, IEmailNotification emailNotification)
        {
            _telegram = telegram;
            _emailNotification = emailNotification;
        }
        public void GivenMessages(NotificationPackage package)
        {
            var TelegramReciever = new List<int>();
            var Message = new List<string> { package.Message.First() };

            var isOneMessage = package.Message.Count == 1;
            if (!isOneMessage)
                Message.Clear();
            #region Telegram  
            try
            {
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

            }
            catch (Exception)
            {

            }
            #endregion
            #region Email
            try
            {
                var email = new List<string>();
                for (int i = 0; i < package.Type.Count; i++)
                {
                    if (package.Type[i].Email)
                    {
                        email.Add(package.Email[i]);
                    }
                }
                if (email.Count > 0)
                {
                    _emailNotification.Notify(Message.First(), email);
                }
            }
            catch (Exception)
            {
            }
            #endregion
        }
    }
}
