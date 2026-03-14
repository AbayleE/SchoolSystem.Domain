using System;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;
// A grade recorded for a student in a subject for a specific term.
public class Grade : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid StudentId { get; set; }
    public Student? Student { get; set; }

    public Guid SubjectId { get; set; }
    public Subject? Subject { get; set; }

    public Guid TeacherId { get; set; }
    public Teacher? Teacher { get; set; }

    public Guid ClassId { get; set; }
    public Class? Class { get; set; }

    public Guid AcademicYearId { get; set; }
    public AcademicYear? AcademicYear { get; set; }

    public Guid TermId { get; set; }
    public Term? Term { get; set; }

    public decimal Score { get; set; }
    public string? Remarks { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}