using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticket.Application.DTO;
using TicketInfra.Services;

namespace TicketPresentation.Controllers
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
            var Result =await _authService.LoginAsync(loginDto);

            if (!Result.succes)
                return Unauthorized(Result.message);

            return Ok(Result.message);

        }


    }
}
