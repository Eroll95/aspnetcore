using System.Collections.Generic;
using aspnetcore.Models;


namespace aspnetcore.Services.BikeService
{
    public interface IBikesRepository
    {
        Bike GetBike(int id);
        IEnumerable<Bike> GetAllBikes();
    }
}
