using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : ControllerBase
    {
        public RestaurantController() { }

        [HttpGet]
        public async Task<IActionResult> GetRestaurantsByCity([FromQuery] string cityName)
        {
            Log.Debug($"Get restaurants by city={cityName}");
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRestaurant([FromBody] object restaurantDto)
        {
            Log.Debug($"Create Restaurant {JsonConvert.SerializeObject(restaurantDto)}");
            return Created();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateRestaurant(int id)
        {
            Log.Debug($"Updating restaurant with id={id}");
            return Ok();
        }

        [HttpPatch("{id:int}")]
        public async Task<IActionResult> UpdateStatus(int id, [FromBody] object updateRestaurantDto)
        {
            Log.Debug($"Patching restaurant with id={id} with {JsonConvert.SerializeObject(updateRestaurantDto)}");
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteRestaurant(int id)
        {
            Log.Debug($"Deleting restaurant with id={id}");
            return Ok();
        }

    }
}
