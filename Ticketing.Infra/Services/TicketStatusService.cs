using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Application.DTO;
using Ticketing.Application.Interfaces.Services;
using Ticketing.Domain;

namespace Ticketing.Infra.Services
{
    public  class TicketStatusService : ITicketStatusService
    {
        private readonly DatabaseContext _db;
        public TicketStatusService(DatabaseContext db)
        {
            _db = db;
        }



        public async Task Edit(int ticketid, StatusDto dto)
        {
            var status = await _db.Ticket
                .Where(t => t.Id == ticketid)
                .Select(t => t.TicketStatus)
                .SingleOrDefaultAsync();
            

            if (status != null)
            {
                status.Id = dto.Id;
                status.Title = dto.Title;
                _db.TicketStatus.Update(status);
                await _db.SaveChangesAsync();
            }


        }


        public async Task<List<StatusDto>> GetAll()
        {
            var statuses = await _db.TicketStatus.Select(s => new StatusDto
            { Id = s.Id, Title = s.Title }).ToListAsync();
            return statuses;
        }



        public async Task Remove(int ticketid)
        {
            var status = await _db.Ticket
                .Where(t => t.Id == ticketid)
                .Select(t => t.TicketStatus)
                .FirstOrDefaultAsync();

            if (status != null)
            {
                _db.TicketStatus.Remove(status);
                await _db.SaveChangesAsync();
            }

        }
    }
}
