using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Application.DTO;


namespace Ticketing.Application.Interfaces.Services
{
    public interface ITicketStatusService
    {

        public Task Remove(int id);
        public Task<List<StatusDto>> GetAll();
        public Task Edit(int ticketid, StatusDto dto);




    }
}
