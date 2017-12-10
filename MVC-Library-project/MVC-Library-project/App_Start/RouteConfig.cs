using System.Web.Mvc;
using System.Web.Routing;

namespace MVCLibraryproject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
<<<<<<< HEAD
                defaults: new { controller = "Member", action = "Home", id = UrlParameter.Optional }
=======
                defaults: new { controller = "Member", action = "Index", id = UrlParameter.Optional }
>>>>>>> bd609e611fbeb26126e7726becbe9397710a4db2
            );
        }
    }
}
