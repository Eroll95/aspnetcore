using aspnetcore.Models;
using System.Collections.Generic;

namespace aspnetcore.Services.RestaurantService
{
    public interface IRestaurantRepository
    {
        IEnumerable<Restaurant> GetAllRestaurants();
        Restaurant GetRestaurant(int Id);
    }
}
