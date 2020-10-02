using Furn_Store.Business.DTO.Identity;
using Furn_Store.Business.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IAccountService _service;
        public AccountController(IAccountService accountService)
        {
            _service = accountService;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody]RegisterDTO myUser)
        {
            var result = await _service.Register(myUser);
            if (result.Succeeded)
                return Ok("User registered");
            else
            {
                string Errors = "";
                foreach (var error in result.Errors)
                    Errors += $"{error.Description}\n";
                return BadRequest(Errors);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO myUser)
        {
            var result = await _service.Login(myUser);
            if (result.success)
                return Ok(result);
            else
                return BadRequest(result);
        }
        [HttpGet]
        [Route("Exit")]
        public async Task<IActionResult> Exit()
        {
            return Ok(await _service.Exit());
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _service.List());
        }
    }
}
