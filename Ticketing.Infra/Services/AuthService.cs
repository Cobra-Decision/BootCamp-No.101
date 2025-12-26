using Microsoft.EntityFrameworkCore;
using Ticketing.Application.DTO;
using Ticketing.Application.Interfaces.Services;
using Ticketing.Domain;

namespace Ticketing.Infra.Services
{
    public class AuthService : IAuthService
    {
        private readonly DatabaseContext _context;
        private readonly IPasswordHasher _passwordHasher;

        public AuthService(DatabaseContext context, IPasswordHasher passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public async Task<(bool success, string message)> LoginAsync(LoginDto dto)
        {
            var user = await _context.Users
                .SingleOrDefaultAsync(x =>
                    x.Email == dto.UserName || x.Phone == dto.UserName);

            if (user is null)
                return (false, "کاربر یافت نشد");

            if (!user.IsActive)
                return (false, "حساب کاربری شما غیرفعال است");

            if (!this._passwordHasher.VerifyPassword(dto.Password, user.Password))
                return (false, "رمز وارد شده صحیح نیست");

            return (true, "وارد شدید");
        }

        public async Task<(bool success, string message)> SignupAsync(SignupDto dto)
        {
            var exists = await _context.Users.AnyAsync(x =>
                x.Email == dto.Email || x.Phone == dto.Phone);

            if (exists)
                return (false, "کاربر با این مشخصات قبلاً ثبت‌نام کرده است");

            var user = new User
            {
                Email = dto.Email,
                Phone = dto.Phone,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Password = this._passwordHasher.HashPassword(dto.Password),
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return (true, "ثبت‌نام با موفقیت انجام شد");
        }
    }
}

