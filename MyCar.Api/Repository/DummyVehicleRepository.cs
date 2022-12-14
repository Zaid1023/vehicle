using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using MyCar.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCar.Api.Repository
{
    public class DummyVehicleRepository: IVehicleRepository
    {
      /*
        List<Vehicle> _vehicles = new List<Vehicle>
            {
                new Vehicle
                {
                    id = 1,
                    name = "Audi",
                    vehicleNo = "GH-4167",
                    year = 2005
                },
                new Vehicle
                {
                    id = 2,
                    name = "Lambo",
                    vehicleNo = "LK-0000",
                    year = 1995
                },
                new Vehicle
                {
                    id = 3,
                    name = "RR",
                    vehicleNo = "DE-0870",
                    year = 2012
                }
            };
      */

        public bool CreateVehicle(Vehicle vehicle)
        {
            using (var db = new MainDbContext())
            {
                var vehiclesdbset = db.Vehicles.Where(x => x.id == vehicle.id).ToList();
                if (vehiclesdbset.Count == 0)
                {
                    db.Vehicles.Add(vehicle);
                    db.SaveChanges();
                    return true;
                }
                
                else
                {
                    return false;
                }
                

            }

            /* int id = _vehicles.Max(m => m.id) + 1;
             vehicle.id = id;
             _vehicles.Add(vehicle);
             return vehicle;
            */
        }

        public Vehicle DeleteVehicle(int id)
        {
            using (var db = new MainDbContext()) 
            {
                Vehicle vehicle = db.Vehicles.FirstOrDefault(v => v.id == id);
                //Vehicle vehicle = db.Vehicles.Where(v => v.id == id).FirstOrDefault();
                db.Vehicles.Remove(vehicle);
                db.SaveChanges();
                return vehicle; 
            }
        }

        public List<Vehicle> GetVehicles()
        {
            using (var db = new MainDbContext()) 
            {
                return db.Vehicles.ToList(); ;
            }
        }

        public Vehicle UpdateVehicle(Vehicle newVehicle)
        {
            using (var db = new MainDbContext())
            {
                //Vehicle vehicle = db.Vehicles.Where(x => x.id == newVehicle.id);
                var vehiclesDBset = db.Vehicles.Where(x => x.id == newVehicle.id).FirstOrDefault();
                vehiclesDBset.name= newVehicle.name;
                vehiclesDBset.vehicleNo = newVehicle.vehicleNo;
                vehiclesDBset.year = newVehicle.year;
                db.SaveChanges();
                return vehiclesDBset;
            }

        }

     
    }
}
