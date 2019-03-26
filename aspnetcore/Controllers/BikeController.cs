using aspnetcore.Services.BikeService;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore.Controllers
{
    public class BikeController : Controller
    {
        private readonly IBikesRepository _bikesRepository;
        public BikeController(IBikesRepository bikesRepository)
        {
            _bikesRepository = bikesRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Bikes";

            var bikes = _bikesRepository.GetAllBikes();

            return View(bikes);
        }

        public IActionResult BikeDetails(int id)
        {
            var bike = _bikesRepository.GetBike(id);
            ViewBag.Title = string.Format("{0} {1} - details", bike.Brand, bike.Model);

            return View(bike);
        }

    }
}
