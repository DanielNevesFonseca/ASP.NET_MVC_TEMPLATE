using System.Web.Optimization;

namespace MyApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public MvcApplication() : base()
        {
        }

        protected void Application_Start()
        {
            // 1. Areas must ALWAYS be first
            System.Web.Mvc.AreaRegistration.RegisterAllAreas();

            // 2. Routes come second
            RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);

            // 3. Bundles come last
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}