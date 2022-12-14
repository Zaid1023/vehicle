using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MyCar.Api.Models
{
    public class Vehicle
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string vehicleNo { get; set; }
        public int year { get; set; }
    }
}
