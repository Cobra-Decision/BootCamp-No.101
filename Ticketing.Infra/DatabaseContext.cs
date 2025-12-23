using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Domain;

namespace Ticketing.infra
{
    public class DatabaseContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<TicketMessage> TicketMessage { get; set; }
        public DbSet<TicketStatus> TicketStatus { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

    }
}
