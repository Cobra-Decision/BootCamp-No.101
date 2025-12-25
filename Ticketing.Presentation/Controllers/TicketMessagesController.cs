using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ticketing.Application.DTO;
using Ticketing.infra;
using Ticketing.infra.Services;

namespace Ticketing.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketMessagesController : ControllerBase
    {
        private readonly TicketService _ticketService;
        public TicketMessagesController(TicketService ticketService)
        {
            _ticketService = ticketService;
        }




        





        


        









    }
}
