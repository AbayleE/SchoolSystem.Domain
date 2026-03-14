using System;
using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.Interfaces;
namespace SchoolSystem.Domain.Entities;

// A teacher profile linked to a User account.
public class Teacher : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
    
    public string? Specialization { get; set; }
    public TeacherStatus Status { get; set; }= TeacherStatus.Active;
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}
