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
            List<string> FavRestaurants = new List<string>();



            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                string? favDish = r.favoriteDish ?? "They're all good!";
                string? website = r.website ?? "Coming soon";
                FavRestaurants.Add($"{r.rank}: {r.restaurantName} \n\t Best Dish: {favDish}" +
                    $"\n\t Address: {r.address} \n\t Phone: {r.phone} \n\t Website: {website}");
            };
            return View(FavRestaurants);
        }

        public IActionResult ViewRecs()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Recommend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Recommend(Recommendation recommendation)
        {
            RecommendationData.AddRecommendation(recommendation);
            return View("ViewRecs");
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
