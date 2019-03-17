using aspnetcore.Services.RestaurantService;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public HomeController(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Restaurants";

            var restaurants = _restaurantRepository.GetAllRestaurants();

            return View(restaurants);
        }
    }
}