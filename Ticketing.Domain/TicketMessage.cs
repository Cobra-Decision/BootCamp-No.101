namespace Ticketing.Domain
{
    public class TicketMessage
    {
        public int Id { get; set; }

        public required string Message { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // --- Relations ---
        // Foreign Key for Ticket
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; } = null!;

        // Foreign Key for User (The sender of the message)
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
