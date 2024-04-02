using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalPOCService.functionality;
using finalPOCService.models;
using Microsoft.AspNetCore.Mvc;

namespace finalPOCService.Controllers
{
    [ApiController]
    [Route("exl/[controller]")]
    public class UserController : ControllerBase
    {
        IUser functionality;
        public UserController(IUser _functionality)
        {
            functionality = _functionality;
        }

        [HttpPost]
        [Route("Create UserAccount")]
        public IActionResult CreateUserAccount(User user)
        {
            return Ok(functionality.accountCreate(user));
        }

        [HttpPost]
        [Route("Login Account")]
        public IActionResult LoginAccount(User user)
        {
            return Ok(functionality.loginAccount(user));
        }
    }
}