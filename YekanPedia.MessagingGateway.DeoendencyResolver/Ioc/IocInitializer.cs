namespace YekanPedia.MessagingGateway.DeoendencyResolver
{
    using StructureMap;
    using StructureMap.Web.Pipeline;
    using System;
    using ExternalService.Interfaces;
    using ExternalService.Implement;
    using Service.Interfaces;
    using Service.Implement;

    public class IocInitializer
    {
        public static IContainer Container;
        public static void Initialize()
        {
            Container = new Container(x =>
            {
                x.For<IRoboTeleProxyAdapter>().Use<RoboTeleProxyAdapter>();
                x.For<ITelegramNotification>().Use<TelegramNotification>();
            });
        }
        public static object GetInstance(Type pluginType)
        {
            return Container.GetInstance(pluginType);
        }
        public static TPluginType GetInstance<TPluginType>()
        {
            return Container.GetInstance<TPluginType>();
        }
        public static void HttpContextDisposeAndClearAll()
        {
            HttpContextLifecycle.DisposeAndClearAll();
        }
    }
}
