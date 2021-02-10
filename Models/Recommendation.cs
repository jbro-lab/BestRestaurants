using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestRestaurants.Models
{
    public class Recommendation
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string restaurantName { get; set; }
       
        public string favoriteDish { get; set; }
        [Phone]
        [Required]
        [RegularExpression(@"^\([\d]{3}\) [\d]{3}-[\d]{4}$",
        ErrorMessage = "Phone must be in format: (###) ###-####")]
        public string phone { get; set; }

        public Recommendation()
        {
            this.favoriteDish = "It's all tasty";//sets favorite dish to default
        }
    }
}
