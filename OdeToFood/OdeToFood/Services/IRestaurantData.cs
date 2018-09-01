using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services{
    public interface IRestaurantData{
        IEnumerable<Restaurant> GetAllRestaurants();
        Restaurant Get(int id);
        Restaurant Add(Restaurant newRestaurant);
    }
}
