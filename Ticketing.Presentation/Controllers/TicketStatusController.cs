using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticketing.Application.DTO;
using Ticketing.Application.Interfaces.Services;

namespace Ticketing.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketStatusController : ControllerBase
    {
        private readonly ITicketStatusService _statusService;
        public TicketStatusController(ITicketStatusService statusService)
        {
            _statusService = statusService;
        }


        [HttpPut]
        public async Task<IActionResult> UpdateStatus(int ticketid, StatusDto dto)
        {
            await _statusService.Edit(ticketid, dto);
            return NoContent ();
        }


        [HttpGet]
        public async Task<IActionResult> GetAllStatuses()
        {
            var Statuses = await _statusService.GetAll();
            return Ok(Statuses);
        }



        [HttpDelete]
        public async Task<IActionResult> DeleteStatus(int ticketid)
        {
            await _statusService.Remove(ticketid);
            return NoContent();
        }

    }
}
