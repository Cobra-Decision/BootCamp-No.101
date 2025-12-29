using Microsoft.AspNetCore.Mvc;
using Ticketing.Application.DTO;
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




        [HttpGet("{id}")]
        public async Task<IActionResult> VeiwMessages(int ticketid)
        {
           return Ok( _service.GetMessage(ticketid));


        }



        [HttpPost]
        public async  Task<IActionResult> CreateMessage (int ticketid, TicketMessageDto dto)
        {

            return Ok(_service.AddMessage(ticketid, dto));
            
        }

    }
}