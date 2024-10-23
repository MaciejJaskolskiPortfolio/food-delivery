using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        public OrdersController() { }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOrdersDetails(int id)
        {
            Log.Debug($"GET: Order by id={id}");
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderOfCurrentUser()
        {
            Log.Debug($"Get Orders of current user");
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] object order)
        {
            Log.Debug($"{JsonConvert.SerializeObject(order)}");
            return Created();
        }

        [HttpPatch("{id:int}")]
        public async Task<IActionResult> UpdateStatus(int id)
        {
            return Ok();
        }
    }
}
