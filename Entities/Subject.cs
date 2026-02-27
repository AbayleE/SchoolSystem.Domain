using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;
// A subject taught at the school e.g. "Mathematics", "English".
public class Subject : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public string? Name { get; set; }
    public string? Code { get; set; }

    public DateTime CreatedAt { get; set; } 
    public DateTime UpdatedAt { get; set; } 
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; } = false;

}
