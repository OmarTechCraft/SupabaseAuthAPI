using Microsoft.AspNetCore.Mvc;
using SupabaseAuthAPI.DTOs;
using SupabaseAuthAPI.Services;
using System.Threading.Tasks;

namespace SupabaseAuthAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationService _authService;

        public AuthController(IAuthenticationService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto request)
        {
            var token = await _authService.RegisterAsync(request);
            return Ok(new { Token = token });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto request)
        {
            var token = await _authService.LoginAsync(request);
            return Ok(new { Token = token });
        }
    }
}
