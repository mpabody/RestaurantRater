using RestarauntRater_Videos_SecondAttempt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestarauntRater_Videos_SecondAttempt.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDbContext _db = new RestaurantDbContext();

        // GET: Restaurant/Index
        public ActionResult Index()
        {
            return View(_db.Restaurants.ToList());
        }
    }
}