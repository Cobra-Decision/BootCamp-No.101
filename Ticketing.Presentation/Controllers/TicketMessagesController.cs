using Microsoft.AspNetCore.Mvc;
using Ticketing.Application.Interfaces.Services;

namespace Ticketing.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketMessagesController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        public TicketMessagesController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }
    }
}
