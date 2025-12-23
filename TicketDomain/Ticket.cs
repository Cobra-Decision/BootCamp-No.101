using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketDomain
{
    public  class Ticket
    {
        public int Id { get; set; }
        public int User_id { get; set; }
        public int Department_id { get; set; }
        public int Status_id { get; set; }
        public DateTime Created_at { get; set; }
    }
}
