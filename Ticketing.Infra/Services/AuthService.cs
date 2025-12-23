using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Application.DTO;
using Ticketing.Application.Interfaces.Services;
using Ticketing.infra;

namespace Ticketing.infra.Services
{
    public class AuthService : IAuthService
    {
        private readonly DatabaseContext _context;
        public AuthService(DatabaseContext context)
        { _context = context; }
        public async Task<(bool succes, string message)> LoginAsync(LoginDto dto)
        {
            var user = _context.Users.SingleOrDefault(x => x.Email == dto.UserName || x.Phone == dto.UserName);

            if (user == null)
                return (false, "کاربر یافت نشد");

            if (user.Password != dto.Password)
                return (false, "رمز وارد شده صحیح نیست");

            if (!user.IsActive)
                return (false, "شما ثبت نام نکرده اید.");

            return (true, "وارد شدید");




        }

        public Task<(bool succes, string message)> LoginAsync()
        {
            throw new NotImplementedException();
        }
    }
}
