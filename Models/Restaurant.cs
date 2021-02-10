using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestRestaurants.Models
{
    public class Restaurant//used for the 5 favorite restaurants
    {
        [Required]

        private int _rank; //remains private read only
        
        public int rank { get { return _rank; } }//read only
        [Required]
        public string restaurantName { get; set; }
        
        public string? favoriteDish { get; set; }//allowed to be null
        [Required]
        public string address { get; set; }
        [Phone]
        [Required]
        public string phone { get; set; }
        public string? website { get; set; }//allowed to be null

        public Restaurant(int Rank)
        {
            this._rank = Rank;
            this.website = "Coming soon";//sets webiste to default, rubric was confusing about where to have this
        }                                  //so it's both here and controller for website

        

        public static Restaurant[] GetRestaurants()
        {
            Restaurant Rancheritos = new Restaurant(1)//takes param for rank 1
            {
              
                restaurantName = "Rancheritos",
                favoriteDish = "Carne Asada Breakfast Burrito",
                address = "46 E 1230 N St, Provo, UT 84604",
                phone = "(801) 374-0822",
                website = "https://rancheritosmexicanfood.com/locations/provo/"
            };
            Restaurant AlohaPlate = new Restaurant(3)//so on and so on
            {
               
                restaurantName = "Aloha Plate",
                address = "Brigham Young University, Ernest L. Wilkinson Student Center, Cougareat Food Court Suite 2270, Provo, UT",
                phone = "(801) 422-4134"
            };

            Restaurant Popeyes = new Restaurant(2)
            {
                
                restaurantName = "Popeyes",
                favoriteDish = "The Chicken Sandwich",
                address = "3699 Thanksgiving Way, Lehi, UT 84043",
                phone = "(801) 768-2164",
                website = "https://www.popeyes.com/"
            };

            Restaurant FlamingWok = new Restaurant(5)
            {
               
                restaurantName = "Flaming Wok",
                address = "575 E University Pkwy, Orem, UT 84097",
                phone = "(801) 224 8890",
                website = "https://flamingwokorem.com/"
            };

            Restaurant Creamery = new Restaurant(4)
            {
            
                restaurantName = "Creamery on 9th",
                address = "1209 N 900 E, Provo, UT 84604-2740",
                phone = "(801) 422 2663",
                website = "https://dining.byu.edu/creamery/"
            };
            return new Restaurant[] { Rancheritos, Popeyes, AlohaPlate, Creamery, FlamingWok };//returns array of restaurants
        }
    }
}
