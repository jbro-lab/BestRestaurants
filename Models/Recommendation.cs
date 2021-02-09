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
        [Required]
        public string favoriteDish { get; set; }
        [Required]
        public string phone { get; set; }
    }
}
