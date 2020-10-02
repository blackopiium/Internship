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
    public class Order_Items_Controller : Controller
    {
        private readonly IOrder_Items_Service _service;
        public Order_Items_Controller(IOrder_Items_Service service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("Order_Items")]
        public async Task<IActionResult> GetOrd()
        {
            try
            {
                return Ok(await _service.GetAllOrd());
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpGet]
        [Route("Order_Items/{Id}")]
        public async Task<IActionResult> GetOrdById(int id)
        {
            try
            {
                return Ok(await _service.GetOrd(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        [Route("Order_Items")]
        public async Task<IActionResult> AddOrd([FromBody] Order_Items_DTO model)
        {
            try
            {
                await _service.AddOrd(model);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }
        }
        [HttpDelete]
        [Route("Order_Items/{Id}")]
        public async Task<IActionResult> DeleteOrd(int id)
        {
            try
            {
                await _service.DeleteOrd(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateOrd([FromBody]Order_Items_DTO model)
        {
            try
            {
                await _service.UpdateOrd(model);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}
