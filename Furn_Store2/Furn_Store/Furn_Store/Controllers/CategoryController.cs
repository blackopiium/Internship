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
    public class CategoryController : Controller
    {
        ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] CategoryParameters parameters)
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
        public async Task<IActionResult> CountItems([FromQuery] CategoryParameters parameters)
        {
            return Ok(await _service.CountItems(parameters));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            try
            {
                return Ok(await _service.GetCategory(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] CategoryDTO model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid model");
                await _service.AddCategory(model);
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
                await _service.DeleteCategory(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody]CategoryDTO model)
        {
            try
            {
                await _service.UpdateCategory(model);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}
