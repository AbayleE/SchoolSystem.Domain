using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.ValueObjects;

namespace SchoolSystem.Domain.Entities;

public class User : IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public FullName? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }

    public string? PasswordHash { get; set; }
    public UserRole Role { get; set; }

    public DateTime CreatedAt { get; set; }
}
