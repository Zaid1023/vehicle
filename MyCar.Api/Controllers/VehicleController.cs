using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCar.Api.Models;
using MyCar.Api.Repository;
using MyCar.Api.Services;
using System;
using System.Collections.Generic;

namespace MyCar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        VehicleService vehicleService;

        public VehicleController() { 
            vehicleService =new VehicleService();
        }

        //List Vehicle
        [Route("[action]")]
        [HttpGet]
        public List<Vehicle> GetVehicles()
        {
            
            return vehicleService.GetVehicles();
            
        }

        // create 
        [Route("[action]")]
        [HttpPost]
        public ActionResult CreateVehicle([FromBody]Vehicle vehicle) 
        {
            return Ok(vehicleService.CreateVehicle(vehicle));
        }

        // update
        [Route("[action]")]
        [HttpPut]
        public ActionResult UpdateVehicle([FromBody]Vehicle vehicle)
        {
            return Ok(vehicleService.UpdateVehicle(vehicle));
        }

        // delete
        [Route("[action]")]
        [HttpDelete]
        public ActionResult DeleteVehicle(int id)
        {
            return Ok(vehicleService.DeleteVehicle(id));
        }

     
    }
}
