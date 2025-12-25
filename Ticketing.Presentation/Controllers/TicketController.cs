using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticketing.Application.DTO;
using Ticketing.Application.Interfaces.Services;
using Ticketing.infra.Services;

namespace Ticketing.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly TicketService _ticketService;
        public TicketController(TicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> CreateTicket(int id)
        {
            await _ticketService.DeleteById(id);
            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateTicket(CreateTicketDto createTicketDto)
        {
            await _ticketService.AddAsync(createTicketDto);
            return NoContent();
        }



        [HttpGet]
        public async Task<IActionResult> GetTickets()
        {
            var tickets = await _ticketService.GetAll();
            return Ok(tickets);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTicketDetaild(int id)
        {
            var ticketdetaildto = await _ticketService.GetByIdAsync(id);
            return Ok(ticketdetaildto);


        }


    }
}
