using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Ticketing.Infra.Services;

namespace Ticketing.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTicketController : ControllerBase
    {
        private readonly UserTicketService _userTicketService;
        public UserTicketController (UserTicketService userTicketService)
        {
            _userTicketService = userTicketService;
        }


        [HttpGet]
        public async Task<IActionResult> GetTickets(int id)
        {
            return Ok(await _userTicketService.GetAllTicketByUserid(id));
        }


