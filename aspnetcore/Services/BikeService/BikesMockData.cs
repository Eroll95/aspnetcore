using System;
using System.Collections.Generic;
using System.Linq;
using aspnetcore.Models;

namespace aspnetcore.Services.BikeService
{
    public class BikesMockData : IBikesRepository
    {
        private List<Bike> _bikesList;

        public BikesMockData()
        {
            if (_bikesList is null)
            {
                Initialize();
            }
        }

        private void Initialize()
        {
            _bikesList = new List<Bike>
            {
                new Bike
                {
                    Id = 1,
                    Brand = "Honda",
                    Model = "RCZ",
                    Acceleration = "2.8s",
                    Power = "675KM",
                    MaxSpeed = "333km/h",
                    Image = "/Assets/a7e.jpg"
                },

                new Bike
                {
                    Id = 2,
                    Brand = "Yamaha",
                    Model = "R500",
                    Acceleration = "3.8s",
                    Power = "500KM",
                    MaxSpeed = "323km/h",
                    Image = "/Assets/a7e.jpg"
                }
            };
        }

        public IEnumerable<Bike> GetAllBikes()
        {
            return _bikesList;
        }

        public Bike GetBike(int id)
        {
            return _bikesList.FirstOrDefault(x => x.Id == id);
        }
    }


}
