﻿using System.Web.Mvc;

namespace RentalCar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Movie(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}