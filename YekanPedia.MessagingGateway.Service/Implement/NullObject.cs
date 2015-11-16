namespace YekanPedia.MessagingGateway.Service.Implement
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    public class NullObject : INotificationStrategy
    {
        public void Notify(List<string> messages, List<string> reciever)
        {
        }
    }
}
