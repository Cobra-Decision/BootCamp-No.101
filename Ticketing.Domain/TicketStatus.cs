namespace Ticketing.Domain
{
    public class TicketStatus
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        // --- Relations ---
        public List<Ticket> Tickets { get; set; } = new();
    }
}
