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
    public class ItemController : Controller
    {
        IItemService _service;
        public ItemController(IItemService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] ItemParameters parameters)
        {
            if (!parameters.ValidPriceRange)
            {
                return BadRequest("bahama mama");
            }
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            try
            {
                var items = await _service.GetItem(id);
                if (items != null)
                    return Ok(await _service.GetItem(id));
                else
                    return NotFound();
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ItemDTO value)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid model");
                await _service.AddItem(value);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                await _service.DeleteItem(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPut]

        public async Task<IActionResult> UpdateCategory([FromBody]ItemDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _service.UpdateItem(model);

                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }
        [HttpGet("count")]
        public async Task<IActionResult> CountItems([FromQuery] ItemParameters parameters)
        {
            return Ok(await _service.CountItems(parameters));
        }
    }
}
