namespace YekanPedia.MessagingGateway.ExternalService.Implement
{
    using Interfaces;
    using RoboTeleProxy;
    using System.Collections.Generic;

    public class RoboTeleProxyAdapter : IRoboTeleProxyAdapter
    {
        const string _userName = "YekanPediaBot";
        const string _password = "Yekan123!@#";
        readonly RoboTeleProxyClient _roboTeleProxyClient;
        public RoboTeleProxyAdapter()
        {
            _roboTeleProxyClient = new RoboTeleProxyClient();
        }
        public void SendMessage(List<SendMessageModel> model)
        {
            _roboTeleProxyClient.SendMessage(model, new SecurityModel
            {
                UserName = _userName,
                Password = _password
            });
        }
    }
}
