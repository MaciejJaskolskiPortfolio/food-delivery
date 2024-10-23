using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuItemController : ControllerBase
    {
        [HttpGet("{restaurantId:int}")]
        public async Task<IActionResult> GetAllMenuItemsByRestaurant(int restaurantId)
        {
            Log.Information($"Getting all items by restaurantId={restaurantId}", restaurantId);
            // TODO
            return Ok();
        }

        [HttpPost("{restaurantId:int}")]
        public async Task<IActionResult> AddMenuItemsToRestaurant([FromBody] object MenuItemsDto)
        {
            // TODO
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateMenuItem(int id)
        {
            // TODO
            return Ok();
        }

        [HttpPatch("{id:int}")]
        public async Task<IActionResult> DisableMenuItems([FromBody] object toDisable)
        {
            // TODO
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            // TODO
            return Ok();
        }
    }
}
