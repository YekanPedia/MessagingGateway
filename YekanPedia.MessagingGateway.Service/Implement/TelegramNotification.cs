namespace YekanPedia.MessagingGateway.Service.Implement
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using ExternalService.Interfaces;
    using ExternalService.RoboTeleProxy;

    public class TelegramNotification : ITelegramNotification
    {
        readonly IRoboTeleProxyAdapter _roboTeleAdapter;
        public TelegramNotification(IRoboTeleProxyAdapter roboTeleAdapter)
        {
            _roboTeleAdapter = roboTeleAdapter;
        }
        public void Notify(List<string> messages, List<int> reciever)
        {
            var model = new List<SendMessageModel>();
            if (messages.Count > 1)
            {
                for (int i = 0; i < messages.Count; i++)
                {
                    model.Add(new SendMessageModel
                    {
                        Message = messages[i],
                        ChatId = reciever[i]
                    });
                }
            }
            else
            {
                foreach (var item in reciever)
                {
                    model.Add(new SendMessageModel
                    {
                        Message = messages[0],
                        ChatId =  item
                    });
                }
            }

            _roboTeleAdapter.SendMessage(model);
        }
    }
}
