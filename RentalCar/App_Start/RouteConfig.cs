using System.Web.Mvc;
using System.Web.Routing;

namespace RentalCar
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            // If you want to use a conventional route as a fallback, you can uncomment and correct it
            // routes.MapRoute(
            //     name: "moviesbyreleaseddate",
            //     url: "movies/released/{year}/{month}",
            //     defaults: new { controller = "movies", action = "Movie" }
            // );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
