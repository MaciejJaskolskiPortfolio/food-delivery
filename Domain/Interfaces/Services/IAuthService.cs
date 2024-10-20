using Domain.Dtos.Auth;

namespace Domain.Interfaces.Services
{
    public interface IAuthService
    {
        Task<ApiResponse<AuthResponse>> SignIn(LoginDto request);
        Task<ApiResponse<AuthResponse>> SignUp(RegisterDto request);
    }
}
