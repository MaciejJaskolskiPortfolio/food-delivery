using Domain.Dtos.Auth;
using Domain.Interfaces.Services;
using FoodDeliveryApp.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("signin")]
        [AllowAnonymous]
        [ValidateModel]
        public async Task<IActionResult> SignIn([FromBody] LoginDto login)
        {
            var result = await _authService.SignIn(login);
            return StatusCode(result.Status, result);
        }

        [HttpPost("signup")]
        [AllowAnonymous]
        [ValidateModel]
        public async Task<IActionResult> SignUp([FromBody] RegisterDto request)
        {
            var result = await _authService.SignUp(request);
            return StatusCode(result.Status, result);
        }
    }
}
