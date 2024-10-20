using Domain.Auth;
using Domain.Dtos.Auth;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Domain.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<AuthUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AuthService(UserManager<AuthUser> userManger, IConfiguration configuration, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManger;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        public async Task<ApiResponse<AuthResponse>> SignIn(LoginDto request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user != null && await _userManager.CheckPasswordAsync(user, request.Password))
            {
                var authClaims = await AddClaimsForUser(user);

                var authSigninKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256)
                    );

                var authResponse = new AuthResponse
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    ValidTo = token.ValidTo
                };

                return new ApiResponse<AuthResponse>
                {
                    Status = StatusCodes.Status200OK,
                    Data = [authResponse],
                    Message = "Login Successful"
                };
            }
            return new ApiResponse<AuthResponse> { Status = StatusCodes.Status400BadRequest, Message = "Credentials incorrect" };
        }

        public async Task<ApiResponse<AuthResponse>> SignUp(RegisterDto request)
        {
            var userExists = await _userManager.FindByEmailAsync(request.Email);

            if (userExists != null)
                return new ApiResponse<AuthResponse> { Status = StatusCodes.Status400BadRequest, Message = "User with given email already exist" };

            var result = await CreateUser(request, UserRoles.USER);

            if (!result.Succeeded)
                return new ApiResponse<AuthResponse> { Status = StatusCodes.Status500InternalServerError, Message = "Something went wrong during registration :(" };

            return new ApiResponse<AuthResponse>
            {
                Status = StatusCodes.Status201Created,
                Message = $"User {request.Email} successfully registered"
            };
        }

        private async Task<List<Claim>> AddClaimsForUser(AuthUser user)
        {
            var userRoles = await _userManager.GetRolesAsync(user);

            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

            foreach (var role in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, role));
            }

            return authClaims;
        }

        private async Task CreateRoles()
        {
            if (!await _roleManager.RoleExistsAsync(UserRoles.ADMIN))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.ADMIN));
            if (!await _roleManager.RoleExistsAsync(UserRoles.RESTAURANT_OWNER))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.RESTAURANT_OWNER));
            if (!await _roleManager.RoleExistsAsync(UserRoles.DELIVERY))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.DELIVERY));
            if (!await _roleManager.RoleExistsAsync(UserRoles.USER))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.USER));
        }

        private async Task<IdentityResult> CreateUser(RegisterDto request, string? role)
        {
            AuthUser user = new AuthUser()
            {
                Email = request.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = request.Username
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            await CreateRoles();

            await _userManager.AddToRoleAsync(user, UserRoles.USER);

            //if (role != null && role == AuthUserRoles.USER && await _roleManager.RoleExistsAsync(AuthUserRoles.USER))
            //{
            //await _userManager.AddToRoleAsync(user, AuthUserRoles.USER);
            //}

            return result;
        }
    }
}
