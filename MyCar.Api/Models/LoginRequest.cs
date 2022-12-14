using System.ComponentModel.DataAnnotations;

namespace MyCar.Api.Models
{
    
    public class LoginRequest
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
    
}
