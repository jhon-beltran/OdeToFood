﻿using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        public IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestauranData : IRestaurantData
    {
        private readonly List<Restaurant> restaurants;

        public InMemoryRestauranData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "CAB Restaurant", Location = "Maryland", Cuisine = CuisineType.Indian },
                new Restaurant { Id = 2, Name = "BCA Restaurant", Location = "London", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 3, Name = "ABC Restaurant", Location = "California", Cuisine = CuisineType.Mexican }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants
                .OrderBy(restaurant => restaurant.Name);
        }
    }

}
