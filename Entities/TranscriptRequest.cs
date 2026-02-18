using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Enums;

namespace SchoolSystem.Domain.Entities;
public class TranscriptRequest : IEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid StudentId { get; set; }
    public Guid AcademicYearId { get; set; }
    public TranscriptStatus Status { get; set; }

    public DateTime RequestedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}