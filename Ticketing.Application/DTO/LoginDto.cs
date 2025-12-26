using System.ComponentModel.DataAnnotations;

namespace Ticketing.Application.DTO
{
    public class LoginDto
    {
        [Required(ErrorMessage = "نام کاربری الزامی است")]
        public required string UserName { get; set; }

        [Required(ErrorMessage = "رمز عبور الزامی است")]
        public required string Password { get; set; }
    }
}
