using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Application.Interfaces.Services
{
    public interface IAuthService
    {
        Task<(bool succes, string message)> LoginAsync();
    }
}
