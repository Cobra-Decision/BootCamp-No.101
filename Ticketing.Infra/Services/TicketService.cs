using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Application.DTO;
using Ticketing.Application.Interfaces.Services;
using Ticketing.Domain;


namespace Ticketing.infra.Services
{
    public class TicketService : ITicketService
    {

        private readonly DatabaseContext _db;
        public TicketService(DatabaseContext db)
        {
            _db = db;
        }



        public async Task AddAsync(CreateTicketDto createTicket)
        {
            var ticket = new Ticket
            {
                Id = createTicket.Id,
                Title = createTicket.Title,
                UserId = createTicket.UserId,
                Department_id = createTicket.DepartmentId,
                TicketStatusId = createTicket.StatusId,
                Created_at = createTicket.CreatedAt,
                Updated_at = createTicket.UdatedAt,

            };


            _db.Ticket.Add(ticket);          
            await _db.SaveChangesAsync();
            
        }
        



        public async Task DeleteById(int id)
        {
            var ticket = await _db.Ticket.FirstOrDefaultAsync(T => T.Id == id);
            
             _db.Ticket.Remove(ticket);
            await _db.SaveChangesAsync();
                       
        }




        public async Task<List<Ticket>> GetAll()
        {
            var tickets = await _db.Ticket.ToListAsync();
            return tickets;
        }






        public async Task<TicketDetailsDto> GetByIdAsync(int id)
        {
            var ticket = await _db.Ticket.Include(t => t.TicketMessages)
                .FirstOrDefaultAsync(t => t.Id == id);

            var ticketdetailsdto = new TicketDetailsDto
            {
                Id = ticket.Id,
                Title = ticket.Title,
                StatusId = ticket.TicketStatusId,
                UserId = ticket.UserId,
                DepartmentId = ticket.Department_id,
                CreatedAt = ticket.Created_at,
                UdatedAt = ticket.Updated_at,
                Chat = ticket.TicketMessages.Select(m => m.Message).ToList(),
            };

            return ticketdetailsdto;

        }

        
    }
}
