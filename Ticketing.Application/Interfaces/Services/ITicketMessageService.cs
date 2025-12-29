using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Application.DTO;

namespace Ticketing.Application.Interfaces.Services
{
    public interface ITicketMessageService
    {
         Task<TicketMessageDto> AddMessage(int ticketid, TicketMessageDto dto);
         Task<List<TicketMessageDto>> GetMessage(int ticketid);

    }
}
