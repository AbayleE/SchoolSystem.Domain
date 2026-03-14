using System;
using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;
// Tracks every create/update/delete action across the platform for auditing.
// TenantId is nullable — system-level actions (e.g. SystemOwner creating a tenant) have no tenant.
public class AuditLog : IEntity
{
    public Guid Id { get; set; }
    public Guid? TenantId { get; set; }
    public Guid UserId { get; set; }

    public string EntityName { get; set; } = null!;
    public Guid EntityId { get; set; }

    public AuditActionType ActionType { get; set; }
    public string? OldValue { get; set; }
    public string? NewValue { get; set; }
    public string? Details { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}