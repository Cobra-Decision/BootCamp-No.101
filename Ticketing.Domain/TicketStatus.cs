using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Domain
{
    public class TicketStatus
    {
        public int Id { get; set; }
        public string Title { get; set; }


        
        public List<Ticket> Tickets { get; set; }

       
      
    }
}
