using System.ComponentModel.DataAnnotations;

namespace Ticketing.Application.DTO;

public class CreateTicketDto
{
    [Required(ErrorMessage = "وارد کردن عنوان تیکت الزامی است")]
    [StringLength(100, ErrorMessage = "عنوان تیکت نمی‌تواند بیشتر از ۱۰۰ کاراکتر باشد")]
    public required string Title { get; set; }

    [Required(ErrorMessage = "شناسه کاربر الزامی است")]
    public int UserId { get; set; }


    [Required(ErrorMessage = "وضعیت تیکت باید مشخص باشد")]
    public int StatusId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
