namespace Ticketing.Domain
{
    public class Ticket
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public int TicketStatusId { get; set; }
        public TicketStatus TicketStatus { get; set; } = null!;

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public List<TicketMessage> TicketMessages { get; set; } = new();
    }
}
