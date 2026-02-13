using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.ValueObjects;

namespace SchoolSystem.Domain.Entities;

public class User : IEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public FullName? Name { get; set; }
    public Address? Address { get; set; }
    
    public string? Email { get; set; }
    public string? Phone { get; set; }

    public string? PasswordHash { get; set; }
    public UserRole Role { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}
