using Ticketing.Application.DTO;

namespace Ticketing.Application.Interfaces.Services
{
    public interface IAuthService
    {
        Task<(bool success, string message)> LoginAsync(LoginDto dto);
        Task<(bool success, string message)> SignupAsync(SignupDto dto);
    }
}
