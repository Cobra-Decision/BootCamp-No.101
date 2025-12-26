using Ticketing.Application.DTO;
using Ticketing.Domain;

namespace Ticketing.Application.Interfaces.Services
{
    public interface ITicketService
    {
        Task AddAsync(CreateTicketDto createTicket);
        Task<List<Ticket>> GetAll();
        Task<TicketDetailsDto?> GetByIdAsync(int id);
        Task DeleteById(int id);
    }
}
