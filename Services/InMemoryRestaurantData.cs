using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
            public InMemoryRestaurantData ()
            {
                _restaurants = new List<Restaurant>
                {
                    new Restaurant { Id = 1, Name = "Majdi Restaurant"},
                    new Restaurant { Id = 2, Name = "Kings Restaurant"},
                    new Restaurant { Id = 3, Name = "Majdi Second Restaurant"}
                };

            }

            public IEnumerable<Restaurant> GetAll()
            {
            return _restaurants.OrderBy(r => r.Name);
            }

        public Restaurant Get(int id)
        {
            //deal with the null value in the future
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(r => r.Id) +1;
            _restaurants.Add(restaurant);
            return restaurant;

        }

        List<Restaurant> _restaurants;
    }
}
