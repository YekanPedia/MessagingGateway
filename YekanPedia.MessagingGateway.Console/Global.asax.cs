namespace YekanPedia.MessagingGateway.Console
{
    using System.Web;
    using System.Web.Mvc;

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
        }
    }
}
