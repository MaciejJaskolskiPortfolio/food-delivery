using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryDriverController : ControllerBase
    {
        public DeliveryDriverController() { }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetDeliveryDriverDetails(int id)
        {
            Log.Debug($"Get delivery driver details with id={id}");
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDeliveryDriver([FromBody] object deliveryDriverDto)
        {
            Log.Debug($"Creating delivery driver {JsonConvert.SerializeObject(deliveryDriverDto)}");
            return Created();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateDeliveryDriver(int id, [FromBody] object deliveryDriverDto)
        {
            Log.Debug($"Updating delivery driver {JsonConvert.SerializeObject(deliveryDriverDto)}");
            return Ok();
        }

        [HttpPatch("{id:int}")]
        public async Task<IActionResult> UpdateStatusDeliveryDriver(int id, [FromBody] object statusDto)
        {
            Log.Debug($"Patching delivery driver {JsonConvert.SerializeObject(statusDto)}");
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteDeliveryDriver(int id)
        {
            Log.Debug($"Patching delivery driver with id={id}");
            return Ok();
        }
    }
}
