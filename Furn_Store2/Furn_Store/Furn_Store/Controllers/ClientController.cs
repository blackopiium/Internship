using Furn_Store.Business.DTO;
using Furn_Store.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly IClientService _service;
        public ClientController(IClientService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("Client")]
        public async Task<IActionResult> GetClients()
        {
            try
            {
                return Ok(await _service.GetAllClients());
            }
            catch
            {
                return StatusCode(404);
            }

        }
        [HttpGet]
        [Route("Client/{Id}")]
        public async Task<IActionResult> GetClientById(int id)
        {
            try
            {
                return Ok(await _service.GetClient(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        [Route("Client")]
        public async Task<IActionResult> AddClient([FromBody] ClientDTO model)
        {
            try
            {
                await _service.AddClient(model);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }
        }
        [Route("client/{Id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            try
            {
                await _service.DeleteClient(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory([FromBody]ClientDTO model)
        {
            try
            {
                await _service.UpdateClient(model);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}
