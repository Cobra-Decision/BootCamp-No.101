using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Application.DTO
{
    public class CreateTicketDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public int DepartmentId { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedAt { get; set; }      
        public DateTime UdatedAt { get; set; }
    }
}
