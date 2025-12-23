using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Domain
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int User_id { get; set; }
        public int Department_id { get; set; }
        public int Status_id { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }



        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }


    }
}
