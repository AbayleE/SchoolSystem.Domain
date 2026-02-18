using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;
public class SchoolSettings :IEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public string? GradingSystem { get; set; }
    public string? AcademicCalendarType { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}