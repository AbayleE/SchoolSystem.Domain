using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;

// A student profile linked to a User account.
// Connects to parents via StudentParent join table.
public class Student : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public StudentStatus Status { get; set; }
   
    public List<StudentParent> Parents { get; set; } = [];
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}
