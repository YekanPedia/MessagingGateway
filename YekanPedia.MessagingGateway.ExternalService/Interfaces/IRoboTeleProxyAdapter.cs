namespace YekanPedia.MessagingGateway.ExternalService.Interfaces
{
    using RoboTeleProxy;
    using System.Collections.Generic;

    public interface IRoboTeleProxyAdapter
    {
        void SendMessage(List<SendMessageModel> model);
    }
}
