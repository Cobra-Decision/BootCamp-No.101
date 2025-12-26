namespace Ticketing.Application.DTO
{
    public class TicketMessageDto
    {
        public int Id { get; set; }

        public required string Message { get; set; }

        public int UserId { get; set; }

        public int TicketId { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
