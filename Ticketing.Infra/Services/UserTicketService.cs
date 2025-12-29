using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Application.Interfaces.Services;
using Ticketing.Domain;

namespace Ticketing.Infra.Services
{
    public class UserTicketService : IUserTicketService
    {
        private readonly DatabaseContext _db;
        public UserTicketService(DatabaseContext db)
        {
            _db = db;
        }

