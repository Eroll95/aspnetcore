using aspnetcore.Models;
using System.Collections.Generic;

namespace aspnetcore.Services.CarsService
{
    public interface ICarsRepository
    {
        Car GetCar(int id);
        IEnumerable<Car> GetAllCars();
    }
}
