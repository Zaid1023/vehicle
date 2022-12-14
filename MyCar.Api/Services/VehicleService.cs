using MyCar.Api.Controllers;
using MyCar.Api.Models;
using MyCar.Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MyCar.Api.Services
{
    public class VehicleService
    {
        IVehicleRepository vehicleRepository;

        public VehicleService()
        {
           vehicleRepository = new DummyVehicleRepository();
        }

        //List vehicle
        public List<Vehicle> GetVehicles()  
        {
            List<Vehicle> vehicles = vehicleRepository.GetVehicles();
            return vehicles;   
        }

        //Create
        public bool CreateVehicle(Vehicle vehicle)
        {
           return vehicleRepository.CreateVehicle(vehicle);
        }

        //Update
        public Vehicle UpdateVehicle(Vehicle vehicle)
        {
           return vehicleRepository.UpdateVehicle(vehicle);
        }

        //Delete
        public Vehicle DeleteVehicle(int id)
        {
           return vehicleRepository.DeleteVehicle(id);  
        }


    }
}
