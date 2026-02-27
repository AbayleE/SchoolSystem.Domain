using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.ValueObjects;

namespace SchoolSystem.Domain.Entities;

// A pre-enrollment application submitted by a guardian on behalf of a student.
// Has no TenantId — the student doesn't belong to a school yet.
// Links to the school's AcademicYear to know which school and year they're applying for.
public class Application : IEntity
{
    public Guid Id { get; set; }
    public Guid SchoolId { get; set; }
    public Guid AcademicYearId { get; set; }
    public AcademicYear? AcademicYear { get; set; }

    public FullName StudentName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }

    public Guid GradeAppliedId { get; set; }
    public GradeLevel? GradeApplied { get; set; }

    public string? CurrentGradeLevel { get; set; }
    public decimal? Gpa { get; set; }

    public List<Guardian> Guardians { get; set; } = [];
    public Address Address { get; set; } = null!;

    public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;
    public DateTime SubmittedAt { get; set; }
    public DateTime? ReviewedAt { get; set; }
    public string? ReviewNotes { get; set; }
    public Guid? ReviewedByUserId { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}
