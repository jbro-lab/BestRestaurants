using BestRestaurants.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BestRestaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> FavRestaurants = new List<string>();//list for fav restaurants



            foreach(Restaurant r in Restaurant.GetRestaurants())
            {//allows vars to be null and sets a default
                string? favDish = r.favoriteDish ?? "They're all good!";
                string? website = r.website ?? "Coming soon";
                if (website != "Coming soon")
                {
                    FavRestaurants.Add($"{r.rank}: {r.restaurantName} <br> Best Dish: {favDish}" +
                        $"<br> Address: {r.address} <br> Phone: {r.phone} <br> Website: <a href='{website}'>{website}</a>");
                }
                else
                {
                    FavRestaurants.Add($"{r.rank}: {r.restaurantName} <br> Best Dish: {favDish}" +
                        $"<br> Address: {r.address} <br> Phone: {r.phone} <br> Website: {website}");
                }
            };
            return View(FavRestaurants);//returns list of FavRestaurants
        }

        public IActionResult ViewRecs()
        {
            return View(RecommendationData.Recommendations);
        }
        [HttpGet]
        public IActionResult Recommend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Recommend(Recommendation recommendation)
        {
            if (ModelState.IsValid)//validates recommendation
            {
                RecommendationData.AddRecommendation(recommendation);
                return RedirectToAction("ViewRecs");//if valid returns viewRecs
            }
            
            return View();//if not valid returns back to page
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
