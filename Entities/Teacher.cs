using SchoolSystem.Domain.Interfaces;
namespace SchoolSystem.Domain.Entities;

public class Teacher : IEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid UserId { get; set; }
    public string? Specialization { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}
