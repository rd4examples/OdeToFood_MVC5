using OdeToFood.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
