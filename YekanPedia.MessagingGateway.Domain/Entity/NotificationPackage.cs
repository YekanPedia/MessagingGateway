namespace YekanPedia.MessagingGateway.Domain
{
    using System.Collections.Generic;

    public class NotificationPackage
    {
        public List<NotificationKey> Type { get; set; }
        public List<string> Message { get; set; }
        public List<string> Telegram { get; set; }
        public List<string> Sms { get; set; }
        public List<string> Email { get; set; }
    }
    public class NotificationKey
    {
        public bool Sms { get; set; }
        public bool Telegram { get; set; }
        public bool Email { get; set; }
    }
}
