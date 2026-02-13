using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;
public class Subject : IEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public string? Name { get; set; }
    public string? Code { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; } = false;

}
