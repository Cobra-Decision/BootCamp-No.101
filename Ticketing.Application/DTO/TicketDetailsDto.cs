
namespace Ticketing.Application.DTO
{
    public class TicketDetailsDto
    {
        public int Id { get; set; }
        public required string Title { get; set; }

        public int UserId { get; set; }
        public int StatusId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
        public List<string> Chat { get; set; } = new();
    }
}
