using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;
public class AuditLog : IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid UserId { get; set; }
    public string? Action { get; set; }
    public string? Entity { get; set; }
    public string? Details { get; set; }

    public DateTime Timestamp { get; set; }
}