using System.ComponentModel.DataAnnotations;

namespace Ticketing.Application.DTO
{
    public class SignupDto
    {
        [Required(ErrorMessage = "نام الزامی است")]
        [MaxLength(50, ErrorMessage = "نام نباید بیشتر از ۵۰ کاراکتر باشد")]
        public required string FirstName { get; set; }

        [Required(ErrorMessage = "نام خانوادگی الزامی است")]
        [MaxLength(50, ErrorMessage = "نام خانوادگی نباید بیشتر از ۵۰ کاراکتر باشد")]
        public required string LastName { get; set; }

        [Required(ErrorMessage = "ایمیل الزامی است")]
        [EmailAddress(ErrorMessage = "ایمیل معتبر نیست")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "شماره تلفن الزامی است")]
        [Phone(ErrorMessage = "شماره تلفن معتبر نیست")]
        public required string Phone { get; set; }

        [Required(ErrorMessage = "رمز عبور الزامی است")]
        public required string Password { get; set; }
    }
}
