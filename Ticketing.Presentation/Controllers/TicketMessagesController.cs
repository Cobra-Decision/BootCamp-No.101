using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketDomain;
using Ticketing.Application.DTO;
using Ticketing.infra;

namespace Ticketing.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketMessagesController : ControllerBase
    {
        private readonly DatabaseContext _db;
        public TicketMessagesController (DatabaseContext db)
        {
            _db = db;
        }
        [HttpPost]
        public IActionResult Create(int ticketid, TicketMessageDto TicketMessageDto)
        {
            var PM=_db

        }

        [HttpGet]


    }
}
