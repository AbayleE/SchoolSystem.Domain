using SchoolSystem.Domain.Interfaces;
namespace SchoolSystem.Domain.Entities;

// An academic year for a school e.g. "2024/2025".
// Most school data (classes, grades, enrollment) is scoped to an academic year.
public class AcademicYear : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public string? YearName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsCurrent { get; set; }
    
    public List<Term> Terms { get; set; } = [];
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
    
}