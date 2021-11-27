using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mongodbtest.Models;
using mongodbtest.Services;

namespace mongodbtest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _user;
        UserController(UserService userservice)
        {
            _user = userservice;
        }
        [HttpGet("all")]
        public async Task<ActionResult> Index()
        {
            //get list of users

            var userDTOs = await _user.GetAllAsync();
            return Ok(userDTOs);

            

        }
    }
}
