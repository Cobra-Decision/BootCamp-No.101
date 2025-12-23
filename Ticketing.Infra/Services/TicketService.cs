using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketInfra.Migrations;
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
                User_id = createTicket.UserId,
                Department_id = createTicket.DepartmentId,
                Status_id = createTicket.StatusId,
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


        public IQueryable<Ticket> GetAll()
        {
            var tickets = _db.Ticket.AsQueryable();
            return tickets;
        }


        public async Task<TicketDetailsDto> GetByIdAsync(int id)
        {
            var ticket= await _db.Ticket.FirstOrDefaultAsync(T => T.Id == id);
            var ticketDetail = new TicketDetailsDto
            {
                Id = ticket.Id,
                Title = ticket.Title,
                StatusId = ticket.Status_id,
                UserId = ticket.User_id,
                DepartmentId =ticket.Department_id,
                CreatedAt=ticket.Created_at,
                UdatedAt=ticket.Updated_at,
                
            };
            return ticketDetail;

        }

        
    }
}
