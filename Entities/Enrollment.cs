using SchoolSystem.Domain.Interfaces;
namespace SchoolSystem.Domain.Entities;

public class Enrollment : IEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid StudentId { get; set; }
    public Guid ClassId { get; set; }
    public Guid AcademicYearId { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}