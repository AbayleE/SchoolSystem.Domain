using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;
public class AuditLog : IEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid UserId { get; set; }
    
    public string? EntityName { get; set; }
    public Guid EntityId { get; set; }
    
    public AuditActionType ActionType { get; set; }
    public string? Details { get; set; }
    
    public string? OldValue { get; set; }
    public string? NewValue { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}