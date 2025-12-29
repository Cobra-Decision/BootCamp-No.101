using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Domain;

namespace Ticketing.Application.Interfaces.Services
{
    public interface IUserTicketService
    {
       public Task<List<Ticket>> GetAllTicketByUserid(int id);
       public Task<Ticket> GetTicketByUseridTicketid(int userid, int ticketid);

    }
}
