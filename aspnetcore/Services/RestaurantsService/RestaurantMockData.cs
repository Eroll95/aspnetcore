using System.Collections.Generic;
using System.Linq;
using aspnetcore.Models;

namespace aspnetcore.Services.RestaurantService
{
    public class RestaurantMockData : IRestaurantRepository
    {
        private List<Restaurant> _restaurantsList;

        public RestaurantMockData()
        {
           if (_restaurantsList is null)
            {
                Initialize();
            }
        }

        public void Initialize()
        {
            _restaurantsList = new List<Restaurant>
            {
                new Restaurant
                {
                    Id = 1,
                    Name = "McDonalds",
                    Description = "Best burgers ever",
                    Rating = 5
                },

                new Restaurant
                {
                    Id = 2,
                    Name = "Burger King",
                    Description = "Worst burgers ever",
                    Rating = 1
                },

                new Restaurant
                {
                    Id = 3,
                    Name = "KFC",
                    Description = "That's definetly not a chicken",
                    Rating = 1
                }
            };
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return _restaurantsList;
        }

        public Restaurant GetRestaurant(int Id)
        {
            return _restaurantsList.FirstOrDefault(x => x.Id == Id);
        }
    }
}
