
namespace Ticketing.Domain
{
    public class User
    {
        public int Id { get; set; }

        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        // These are required for your LoginAsync logic (Phone or Email)
        public required string Phone { get; set; }
        public required string Email { get; set; }

        public required string Password { get; set; }

        public bool IsActive { get; set; } = true;

        // Renamed to PascalCase and added default value
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // --- Relations ---
        public List<Ticket> Tickets { get; set; } = new();
        public List<TicketMessage> TicketMessages { get; set; } = new();
    }
}
