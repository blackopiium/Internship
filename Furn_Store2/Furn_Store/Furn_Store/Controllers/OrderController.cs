using Furn_Store.Business.DTO;
using Furn_Store.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _service;
        public OrderController(IOrderService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("Order")]
        public async Task<IActionResult> GetOrders()
        {
            try
            {
                return Ok(await _service.GetAllOrders());
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpGet]
        [Route("order/{Id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            try
            {
                return Ok(await _service.GetOrder(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        [Route("Order")]
        public async Task<IActionResult> AddOrder([FromBody] OrderDTO model)
        {
            try
            {
                await _service.AddOrder(model);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }
        }
        [HttpDelete]
        [Route("order/{Id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            try
            {
                await _service.DeleteOrder(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateOrder([FromBody]OrderDTO model)
        {
            try
            {
                await _service.UpdateOrder(model);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}
