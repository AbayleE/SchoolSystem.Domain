using System;
using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.ValueObjects;

namespace SchoolSystem.Domain.Entities;

// A person who can log in — every role (admin, teacher, student, parent) has a User record.
// The role-specific entities (Student, Teacher, Parent) extend this via UserId.
public class User : IEntity , IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public FullName? Name { get; set; }
    public Address? Address { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? PasswordHash { get; set; }
    public UserRole Role { get; set; }
    public bool IsActive { get; set; } = true;
    
    public string? PasswordResetToken { get; set; }
    public DateTime? PasswordResetTokenExpiry { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}
