using System;
using SchoolSystem.Domain.Interfaces;
namespace SchoolSystem.Domain.Entities;

// A class/classroom in a school e.g. "Grade 5A".
// Scoped to a grade level and academic year.
public class Class : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public string Name { get; set; } = null!;
    public Guid GradeLevelId { get; set; }
    public GradeLevel? GradeLevel { get; set; }
    public Guid AcademicYearId { get; set; }
    public AcademicYear? AcademicYear { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}