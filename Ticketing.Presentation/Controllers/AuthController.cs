using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticketing.Application.DTO;
using Ticketing.infra.Services;

namespace Ticketing.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        public AuthController(AuthService authService)
        { _authService = authService; }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var Result = await _authService.LoginAsync(loginDto);

            if (!Result.succes)
                return Unauthorized(Result.message);

            return Ok(Result.message);

        }


    }
}
