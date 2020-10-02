using Furn_Store.Business.DTO;
using Furn_Store.Business.Interfaces;
using Furn_Store.Data.Parameters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store.Controllers
{
    [Route("api/[controller]")]
    public class FactoryController : Controller
    {
        private readonly IFactoryService _service;
        public FactoryController(IFactoryService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetFactories([FromQuery] FactoryParameters parameters)
        {
            try
            {
                var items = await _service.GetItemPagesFiltered(parameters);
                if (items != null)
                    return Ok(items);
                else
                    return NotFound();
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet("count")]
        public async Task<IActionResult> CountItems([FromQuery] FactoryParameters parameters)
        {
            return Ok(await _service.CountItems(parameters));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFactoryById(int id)
        {
            try
            {
                return Ok(await _service.GetFactory(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
       /* [Route("Factory")]*/
        public async Task<IActionResult> AddFactory([FromBody] FactoryDTO model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid model");
                await _service.AddFactory(model);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFactory(int id)
        {
            try
            {
                await _service.DeleteFactory(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody]FactoryDTO model)
        {
            try
            {
                await _service.UpdateFactory(model);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}
