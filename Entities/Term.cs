using System;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;
// A term/semester within an academic year e.g. "Term 1", "Spring Semester".
public class Term : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public string? Name { get; set; }
    public int Order { get; set; }
    public Guid AcademicYearId { get; set; }
    public AcademicYear? AcademicYear { get; set; }
    
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}