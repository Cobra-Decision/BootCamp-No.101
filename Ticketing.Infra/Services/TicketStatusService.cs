using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Application.DTO;
using Ticketing.Application.Interfaces.Services;
using Ticketing.Domain;

namespace Ticketing.Infra.Services
{
    public  class TicketStatusService : ITicketStatusService
    {
        private readonly DatabaseContext _db;
        public TicketStatusService(DatabaseContext db)
        {
            _db = db;
        }



