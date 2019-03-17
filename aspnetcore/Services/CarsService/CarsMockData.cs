using System.Collections.Generic;
using System.Linq;
using aspnetcore.Models;

namespace aspnetcore.Services.CarsService
{
    public class CarsMockData : ICarsRepository
    {
        private List<Car> _carsList;

        public CarsMockData()
        {
            if(_carsList is null)
            {
                Initialize();
            }
        }

        public void Initialize()
        {
            _carsList = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    Brand = "McLaren",
                    Model = "675LT",
                    PricePerHour = 2390,
                    PricePerDay = 7290,
                    PriceForWeekend = 19990,
                    PricePerWeek = 399990,
                    Acceleration = "2.8s",
                    Power = "675KM",
                    Torque = "700Nm",
                    MaxSpeed = "333km/h",
                    Image = "/Assets/750lt.jpg"
                },

                new Car
                {
                    Id = 2,
                    Brand = "Porsche",
                    Model = "911r",
                    PricePerHour = 2090,
                    PricePerDay = 6690,
                    PriceForWeekend = 16090,
                    PricePerWeek = 29990,
                    Acceleration = "3.8s",
                    Power = "500KM",
                    Torque = "460Nm",
                    MaxSpeed = "323km/h",
                    Image = "/Assets/911r.jpg"
                }
            };
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _carsList;
        }

        public Car GetCar(int id)
        {
            return _carsList.FirstOrDefault(x => x.Id == id);
        }
    }
}
