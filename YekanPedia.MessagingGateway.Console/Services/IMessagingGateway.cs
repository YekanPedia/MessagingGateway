namespace YekanPedia.MessagingGateway.Console
{
    using System.ServiceModel;
    using Domain;

    [ServiceContract]
    public interface IMessagingGateway
    {
        [OperationContract(IsOneWay = true)]
        void GivenMessages(NotificationPackage package);
    }
}
