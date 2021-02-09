using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestRestaurants.Models
{
    public static class RecommendationData
    {
        private static List<Recommendation> recommendations = new List<Recommendation>();

        public static IEnumerable<Recommendation> Recommendations => recommendations;

        public static void AddRecommendation(Recommendation recommendation)
        {
            recommendations.Add(recommendation);
        }
    }
}
