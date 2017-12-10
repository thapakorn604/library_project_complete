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
                defaults: new { controller = "Librarian", action = "Book", id = UrlParameter.Optional }
>>>>>>> 0ee9aa28ddec02869bac57dcbb54f74727c9453d
            );
        }
    }
}
