namespace YekanPedia.MessagingGateway.DependencyResolver
{
    using StructureMap;
    using StructureMap.Web.Pipeline;
    using System;
 

    public class IocInitializer
    {
        public static IContainer Container;
        public static void Initialize()
        {
            Container = new Container(x =>
            {
                
                x.For<INotificationService>().Use<NotificationService>();
                x.For<Lazy<INotificationService>>().Use(c => new Lazy<INotificationService>(c.GetInstance<NotificationService>));
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
