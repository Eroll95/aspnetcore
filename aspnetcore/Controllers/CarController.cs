using aspnetcore.Services.CarsService;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarsRepository _carsRepository;

        public CarController(ICarsRepository carsRepository)
        {
            _carsRepository = carsRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Cars";

            var cars = _carsRepository.GetAllCars();

            return View(cars);
        }

        public IActionResult CarDetails(int id)
        {
            var car = _carsRepository.GetCar(id);
            ViewBag.Title = string.Format("{0} {1} - details", car.Brand, car.Model);

            return View(car);
        }
    }
}