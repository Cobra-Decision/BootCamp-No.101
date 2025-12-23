using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ticketing.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateTicket()
        {

        }

        [HttpGet]
        public IActionResult GetAllTickets()
        {

        }


        [HttpGet]
        public IActionResult GetTicketById()
        {
            var ticket =
        }

    }
}
