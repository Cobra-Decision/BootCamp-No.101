using Microsoft.EntityFrameworkCore;
using Ticketing.Application.DTO;
using Ticketing.Application.Interfaces.Services;
using Ticketing.Domain;


namespace Ticketing.Infra.Services
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
            bool userExists = await _db.Users.AnyAsync(u => u.Id == createTicket.UserId);
            if (!userExists) throw new KeyNotFoundException("کاربر مورد نظر یافت نشد.");

            bool statusExists = await _db.TicketStatus.AnyAsync(s => s.Id == createTicket.StatusId);
            if (!statusExists) throw new KeyNotFoundException("وضعیت ارسالی معتبر نیست.");

            var ticket = new Ticket
            {
                Title = createTicket.Title,
                UserId = createTicket.UserId,
                TicketStatusId = createTicket.StatusId,
                CreatedAt = createTicket.CreatedAt,
                UpdatedAt = createTicket.UpdatedAt,
            };


            _db.Ticket.Add(ticket);
            await _db.SaveChangesAsync();

        }

        public async Task DeleteById(int id)
        {
            var rowsAffected = await _db.Ticket
                  .Where(t => t.Id == id)
                .ExecuteDeleteAsync();

            if (rowsAffected == 0)
            {
                throw new KeyNotFoundException($"تیکت با شناسه {id} یافت نشد.");
            }
        }

        public async Task<List<Ticket>> GetAll()
        {
            var tickets = await _db.Ticket.ToListAsync();
            return tickets;
        }

        public async Task<TicketDetailsDto?> GetByIdAsync(int id)
        {
            var ticket = await _db.Ticket.Include(t => t.TicketMessages)
                .FirstOrDefaultAsync(t => t.Id == id);
            if (ticket == null)
            {
                return null;
            }

            var ticketdetailsdto = new TicketDetailsDto
            {
                Id = ticket.Id,
                Title = ticket.Title,
                StatusId = ticket.TicketStatusId,
                UserId = ticket.UserId,
                CreatedAt = ticket.CreatedAt,
                UpdatedAt = ticket.UpdatedAt,
                Chat = ticket.TicketMessages.Select(m => m.Message).ToList(),
            };

            return ticketdetailsdto;

        }
    }
}
