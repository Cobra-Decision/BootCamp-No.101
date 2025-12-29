using Microsoft.AspNetCore.Mvc;
using Ticketing.Application.Interfaces.Services;

namespace Ticketing.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketMessagesController : ControllerBase
    {
        private readonly ITicketMessageService _service;
        public TicketMessagesController(ITicketMessageService service)
        {
            _service = service;
        }
    }
}
