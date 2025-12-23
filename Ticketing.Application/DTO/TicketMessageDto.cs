using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Application.DTO
{
    public class TicketMessageDto
    {
        public int id { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
        public int TicketId { get; set; }
        public int CreatedAt { get; set; }

    }
}
