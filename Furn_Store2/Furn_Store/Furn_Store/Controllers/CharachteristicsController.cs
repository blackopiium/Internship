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
    public class CharachteristicsController : Controller
    {
        private readonly ICharachteristics_Service _service;
        public CharachteristicsController(ICharachteristics_Service service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetCharc()
        {
            try
            {
                return Ok(await _service.GetAllCharc());
            }
            catch
            {
                return StatusCode(404);
            }

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCharcById(int id)
        {
            try
            {
                return Ok(await _service.GetCharc(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddCharc([FromBody] Charachteristic_Item_DTO model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid model");
                await _service.AddCharc(model);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharc(int id)
        {
            try
            {
                await _service.DeleteCharc(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
        public async Task<IActionResult> UpdateCharc([FromBody]Charachteristic_Item_DTO model)
        {
            try
            {
                await _service.UpdateCharc(model);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}
