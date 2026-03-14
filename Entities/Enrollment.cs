using System;
using SchoolSystem.Domain.Interfaces;
namespace SchoolSystem.Domain.Entities;
// Records a student being enrolled in a class for an academic year.
public class Enrollment : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid StudentId { get; set; }
    public Student? Student { get; set; }
    
    public Guid ClassId { get; set; }
    public Class? Class { get; set; }
    
    public Guid AcademicYearId { get; set; }
    public AcademicYear? AcademicYear { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}