using System;
using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Enums;

namespace SchoolSystem.Domain.Entities;

// A notification sent to a specific user via one or more channels (in-app, email, SMS).
// One record per delivery — if you send email + SMS that's two Notification records.
public class Notification : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid UserId { get; set; }
    public User? User { get; set; }

    public string Subject { get; set; } = null!;
    public string Message { get; set; } = null!;

    public NotificationType Type { get; set; }
    public NotificationChannel Channel { get; set; }

    public bool IsRead { get; set; } = false;
    public DateTime? ReadAt { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}