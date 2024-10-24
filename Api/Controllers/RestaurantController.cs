using Domain.Dtos.Restaurant;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _service;

        public RestaurantController(IRestaurantService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetRestaurantsByCity([FromQuery] string cityName)
        {
            Log.Debug($"Get restaurants by city={cityName}");

            var result = await _service.GetRestaurants(cityName);
            return StatusCode(result.Status, result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetRestaurantDetailsById(int id)
        {
            var result = await _service.GetRestaurantById(id);
            return StatusCode(result.Status, result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRestaurant([FromBody] RestaurantDTORequest restaurantDto)
        {
            Log.Debug($"Create Restaurant {JsonConvert.SerializeObject(restaurantDto)}");
            var result = await _service.Create(restaurantDto);
            return StatusCode(result.Status, result);
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
