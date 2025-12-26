
using Microsoft.AspNetCore.Mvc;
using Ticketing.Application.DTO;
using Ticketing.Application.Interfaces.Services;

namespace Ticketing.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var (success, message) = await _authService.LoginAsync(loginDto);

        return success
            ? Ok(new { message })
            : Unauthorized(new { message });
    }

    [HttpPost("signup")]
    public async Task<IActionResult> Signup([FromBody] SignupDto signupDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var (success, message) = await _authService.SignupAsync(signupDto);

        return success
            ? Ok(new { message })
            : Unauthorized(new { message });
    }
}

