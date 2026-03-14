using System;
using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;

// Join table linking students to their parents with relationship context.
// Replaces the flat ParentId1/ParentId2 fields on Student.
public class StudentParent : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid StudentId { get; set; }
    public Student? Student { get; set; }

    public Guid ParentId { get; set; }
    public Parent? Parent { get; set; }

    public GuardianRelationship Relationship { get; set; }
    public bool IsPrimaryContact { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}