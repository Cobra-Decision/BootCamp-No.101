using Microsoft.EntityFrameworkCore;
using Ticketing.Domain;

namespace Ticketing.Infra
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                 .HasOne(t => t.User)
                 .WithMany(u => u.Tickets)
                 .HasForeignKey(t => t.UserId)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TicketMessage>()
                 .HasOne(tm => tm.User)
                 .WithMany(u => u.TicketMessages)
                 .HasForeignKey(tm => tm.UserId)
                 .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TicketMessage>()
                .HasOne(tm => tm.Ticket)
                .WithMany(t => t.TicketMessages)
                .HasForeignKey(tm => tm.TicketId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.TicketStatus)
                .WithMany(ts => ts.Tickets)
                .HasForeignKey(t => t.TicketStatusId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

    }
}
