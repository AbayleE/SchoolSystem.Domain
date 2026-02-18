using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Enums;

namespace SchoolSystem.Domain.Entities;
public class Notification : IEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid UserId { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }

    public NotificationType Type { get; set; }
    public DateTime? ReadAt { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}