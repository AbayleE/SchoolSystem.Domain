using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Enums;

namespace SchoolSystem.Domain.Entities;

// A student's request for an official transcript for a given academic year.
public class TranscriptRequest : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid StudentId { get; set; }
    public Student? Student { get; set; }

    public Guid AcademicYearId { get; set; }
    public AcademicYear? AcademicYear { get; set; }

    public TranscriptStatus Status { get; set; } = TranscriptStatus.Pending;
    public DateTime RequestedAt { get; set; }
    public DateTime? CompletedAt { get; set; }

    public Guid? GeneratedFileId { get; set; }
    public FileResource? GeneratedFile { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}