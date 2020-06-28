using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data.Model
{
    public enum CuisineType
    {
        None,
        Italian,
        Mexican,
        Indian
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
