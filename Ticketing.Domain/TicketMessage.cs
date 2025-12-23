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
        public int Ticket_Id { get; set; }
        public int User_Id { get; set; }
        public DateTime Created_At { get; set; }




        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
