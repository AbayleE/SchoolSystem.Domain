using System;
using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;

// Represents a school registered on the platform.
// Every school is a tenant — all school-scoped data references this via TenantId.

public class Tenant : IEntity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Subdomain { get; set; }
    public string? LogoUrl { get; set; }
    public TenantStatus Status { get; set; } = TenantStatus.Active;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsSchool { get; set; } = true; // Distinguishes actual schools from potential future tenant types (e.g. districts)
}
