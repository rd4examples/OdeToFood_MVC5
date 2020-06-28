using OdeToFood.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> Restaurants;

        public InMemoryRestaurantData()
        {
            Restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Cuisine = CuisineType.Indian },
                new Restaurant { Id = 1, Name = "Scott's Italian", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 1, Name = "Scott's Mexican", Cuisine = CuisineType.Mexican }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return Restaurants.OrderBy(r => r.Name);
        }
    }
}
