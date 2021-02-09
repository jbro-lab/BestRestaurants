using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestRestaurants.Models
{
    public class Restaurant
    {
        [Required]
        public int rank { get; set; }
        [Required]
        public string restaurantName { get; set; }
        
        public string? favoriteDish { get; set; }
        [Required]
        public string address { get; set; }
        public string phone { get; set; }
        public string? website { get; set; }

        

        

        public static Restaurant[] GetRestaurants()
        {
            Restaurant Rancheritos = new Restaurant
            {
                rank = 1,
                restaurantName = "Rancheritos",
                favoriteDish = "Carne Asada Breakfast Burrito",
                address = "46 E 1230 N St, Provo, UT 84604",
                phone = "(801) 374-0822",
                website = "https://rancheritosmexicanfood.com/locations/provo/"
            };
            Restaurant AlohaPlate = new Restaurant
            {
                rank = 3,
                restaurantName = "Aloha Plate",
                address = "Brigham Young University, Ernest L. Wilkinson Student Center, Cougareat Food Court Suite 2270, Provo, UT",
                phone = "(801) 422-4134"
            };

            Restaurant Popeyes = new Restaurant
            {
                rank = 2,
                restaurantName = "Popeyes",
                favoriteDish = "The Chicken Sandwich",
                address = "3699 Thanksgiving Way, Lehi, UT 84043",
                phone = "(801) 768-2164",
                website = "https://www.popeyes.com/"
            };

            Restaurant FlamingWok = new Restaurant
            {
                rank = 5,
                restaurantName = "Flaming Wok",
                address = "575 E University Pkwy, Orem, UT 84097",
                phone = "(801) 224 8890",
                website = "https://flamingwokorem.com/"
            };

            Restaurant Creamery = new Restaurant
            {
                rank = 4,
                restaurantName = "Creamery on 9th",
                address = "1209 N 900 E, Provo, UT 84604-2740",
                phone = "(801) 422 2663",
                website = "https://dining.byu.edu/creamery/"
            };
            return new Restaurant[] { Rancheritos, Popeyes, AlohaPlate, Creamery, FlamingWok };
        }
    }
}
