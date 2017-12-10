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
                defaults: new { controller = "Member", action = "Index", id = UrlParameter.Optional }

=======
                defaults: new { controller = "Librarian", action = "LibEditProfile", id = UrlParameter.Optional }
>>>>>>> 0085273344bbb5ef4fd698ae41d2eb7536c58096
            );
        }
    }
}
