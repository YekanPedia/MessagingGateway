

namespace YekanPedia.MessagingGateway.Service
{
    using Interfaces;
    using Implement;

    public static class Factory
    {
        public static INotificationStrategy GetInstance(string key)
        {
            switch (key)
            {
                case "": {
                        return 
                        break; }
                default: return new NullObject();
            }
        }
    }
}
