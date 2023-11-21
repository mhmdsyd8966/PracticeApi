using Microsoft.AspNetCore.Mvc;
using WebApi.Iservices;
using WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zzApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;

        }

        
        // POST api/<OrderController>
        [HttpPost]
        public IActionResult Post([FromBody] Cart cart)
        {
            var order = _orderService.AddOrder(cart);
            return Ok(order);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var order =_orderService.DeleteOrder(id);
            return Ok(order);
        }
    }
}
