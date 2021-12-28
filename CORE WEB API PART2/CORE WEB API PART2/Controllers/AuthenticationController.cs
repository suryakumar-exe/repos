using CORE_WEB_API_PART2.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_WEB_API_PART2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationUser> roleManager;
        private readonly IConfiguration _configurayion;

        public AuthenticationController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationUser> roleManager, IConfiguration configurayion)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configurayion = configurayion;
        }
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var userExit = await userManager.FindByIdAsync(model.UserName);
            if (userExit != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status="Error",Message="Already Exist"});
            ApplicationUser user = new ApplicationUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.UserName
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Already Exist" });
            }
        }

        private IActionResult StatusCode(Func<int, StatusCodeResult> statusCode)
        {
            throw new NotImplementedException();
        }
    }
}
