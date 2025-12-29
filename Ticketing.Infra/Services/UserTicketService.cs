using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Application.Interfaces.Services;
using Ticketing.Domain;

namespace Ticketing.Infra.Services
{
    public class UserTicketService : IUserTicketService
    {
        private readonly DatabaseContext _db;
        public UserTicketService(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<List<Ticket>> GetAllTicketByUserid(int id)
        {
            var Tickets = await _db.Ticket.Where(t => t.UserId == id).ToListAsync();
            return Tickets;
        }

        

        public async Task<Ticket> GetTicketByUseridTicketid(int userid, int ticketid)
        {
            var Ticket = await _db.Ticket.FirstOrDefaultAsync(t => t.UserId == userid && t.Id == ticketid);

            return Ticket;
        }
    
    }
}
