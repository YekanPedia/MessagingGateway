namespace YekanPedia.MessagingGateway.Console
{
    using System;
    using System.Web;
    using DeoendencyResolver;

    public class MvcApplication : HttpApplication
    {
       
        protected void Application_Start()
        {
            IocInitializer.Initialize();
        }
      
        protected void Application_EndRequest(object sender, EventArgs e)
        {
            IocInitializer.HttpContextDisposeAndClearAll();
        }
    }
}
