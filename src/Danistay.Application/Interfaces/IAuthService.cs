using Danistay.Application.DTOs.User;

namespace Danistay.Application.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDto?> LoginAsync(LoginDto loginDto);
        Task<UserDto?> GetCurrentUserAsync(string username);
        Task<bool> ValidateTokenAsync(string token);
    }
}
