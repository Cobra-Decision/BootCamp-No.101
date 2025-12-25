using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Domain
{
    public class TicketMessage
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Created_At { get; set; }


        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }



    }
}
