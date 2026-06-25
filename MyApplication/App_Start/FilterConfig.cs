using System.Web.Mvc;

namespace MyApplication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // 1. The Default: Global Error Handling
            // This catches unhandled exceptions and shows a friendly "Error" view 
            // instead of the Yellow Screen of Death.
            filters.Add(new HandleErrorAttribute());

            // 2. Global Security (Optional)
            // If you uncomment the line below, it forces users to log in 
            // before they can access ANY page in your entire application.
            // filters.Add(new AuthorizeAttribute());
        }
    }
}