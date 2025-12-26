using Microsoft.AspNetCore.Mvc;
using Ticketing.Application.DTO;
using Ticketing.Application.Interfaces.Services;

namespace Ticketing.Presentation.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTickets()
        {
            var tickets = await _ticketService.GetAll();
            return Ok(tickets);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTicketDetail(int id)
        {
            var ticketDto = await _ticketService.GetByIdAsync(id);

            if (ticketDto == null)
            {
                return NotFound(new { message = "تیکت مورد نظر یافت نشد." });
            }

            return Ok(ticketDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTicket(CreateTicketDto createTicketDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                await _ticketService.AddAsync(createTicketDto);
                return StatusCode(201, new { message = "تیکت با موفقیت ثبت شد." });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            try
            {
                await _ticketService.DeleteById(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
    }
}
