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
    [Route("api/[controller]")]
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        [HttpPost]
        [Route("GiveRole")]
        public async Task GiveRole([FromQuery] string id, [FromQuery] string role)
        {
            await _roleService.AppointRole(id, role);
        }

        [HttpGet]
        [Route("Roles")]
        public async Task<IList<string>> GetRoles([FromQuery] string id)
        {
            return await _roleService.GetAllRolesByUserId(id);
        }


        [HttpPost]
        [Route("CreateRole")]
        public async Task<IActionResult> CreateRole([FromBody] MyRoleDTO role)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid model");
            await _roleService.CreateRole(role);
            return Ok(role);
        }


    }
}
