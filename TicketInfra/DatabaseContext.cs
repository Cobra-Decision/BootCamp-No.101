using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketDomain;

namespace TicketInfra
{
    public class DatabaseContext : DbContext 
    {
        
        public DbSet<User> Users { get; set; }

        public DatabaseContext (DbContextOptions<DatabaseContext> options)  : base (options)
        {

        }

    }
}
