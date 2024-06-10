using RentalCar.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace RentalCar.Controllers
{
    public class MoviesController : Controller
    {
        // GET: movies
        public ActionResult Index()

        {
            var model = new Movielist
            {
                ID = 1,
                Name = "Khanchana"

            };

            return View(model);
        }

        // [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")] Attribute routing
        public ActionResult Movie(int year, int month)
        {
            return Content(year + "/" + month);
        }
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;


            return View();
        }
        public ActionResult Customer()
        {
            List<Customers> customerslist = new List<Customers>
            {
                new Customers { ID = 1, NAME = "Sadik" },
                new Customers { ID = 2, NAME = "Rafiq" },
                new Customers { ID = 3, NAME = "Ichiqo" },
                new Customers { ID = 4, NAME = "Urahimi" }
                // ViewBag.Customers = customers;
            };
            ViewBag.Customer = customerslist;

            return View();

        }



    }
}
