using SchoolSystem.Domain.Interfaces;
namespace SchoolSystem.Domain.Entities;
public class AcademicYear : IEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public string? YearName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public bool IsCurrent { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
    
}