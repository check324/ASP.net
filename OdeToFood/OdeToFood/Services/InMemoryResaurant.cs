using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services{
    public class InMemoryResaurant:IRestaurantData{
        public InMemoryResaurant() {
            _restaurants = new List<Restaurant> {
                new Restaurant{ Id = 1, Name = "Tea's Pizza Place"},
                new Restaurant{ Id = 2, Name = "Bei's Pizza Place"},
                new Restaurant{ Id = 3, Name = "Yuner's Pizza Place"},
            };
        }
        public IEnumerable<Restaurant> GetAllRestaurants() {
            return _restaurants.OrderBy(r=>r.Name);
        }

        public Restaurant Get(int id) {
            return _restaurants.FirstOrDefault(r=>r.Id==id);
        }

        public Restaurant Add(Restaurant newRestaurant) {
            newRestaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(newRestaurant);
            return newRestaurant;
        }

        List<Restaurant> _restaurants;
    }
}
