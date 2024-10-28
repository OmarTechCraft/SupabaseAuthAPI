using SupabaseAuthAPI.DTOs;
using System.Threading.Tasks;

namespace SupabaseAuthAPI.Services
{
    public interface IAuthenticationService
    {
        Task<string> RegisterAsync(RegisterRequestDto registerDto);
        Task<string> LoginAsync(LoginRequestDto loginDto);
    }
}
