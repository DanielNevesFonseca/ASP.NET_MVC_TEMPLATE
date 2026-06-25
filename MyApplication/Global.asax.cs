using System.Web.Optimization;
using System.Web.Mvc;

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
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            // 2. Routes come second
            RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);

            // 3. Bundles come last
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}