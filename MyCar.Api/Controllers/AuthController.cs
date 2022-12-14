using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyCar.Api.Models;
using MyCar.Api.Services;
using System;
using System.Reflection.Metadata;

namespace MyCar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        AuthService authService;

        // constructer
        public AuthController() {
            authService = new AuthService();
        }

        [HttpPost]
        [Route("[action]")]
        public bool Login(LoginRequest request)
            
        {
           var success = authService.Login(request.Username,request.Password);
            return success;
        }

    }
}

