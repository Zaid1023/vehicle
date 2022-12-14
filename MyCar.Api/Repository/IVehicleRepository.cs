using MyCar.Api.Controllers;
using MyCar.Api.Models;
using System;
using System.Collections.Generic;

namespace MyCar.Api.Repository
{
    public interface IVehicleRepository
    {
        // Type Name(input) - structure of a funtion/method 
        // Type name - structure of an input 

        //Give Out All Vehicles
        List<Vehicle> GetVehicles();

        //Create A Vehicle
        bool CreateVehicle(Vehicle vehicle);

        //Change a Vehicle
        Vehicle UpdateVehicle(Vehicle vehicle);
        
        //remove a vehicle
        Vehicle DeleteVehicle (int id);
        // void CreateVehicle();
    }
}
