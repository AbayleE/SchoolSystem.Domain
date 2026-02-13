using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.ValueObjects;

namespace SchoolSystem.Domain.Entities;
public class Parent : IEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }
    
    public Guid UserId { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
    
}
