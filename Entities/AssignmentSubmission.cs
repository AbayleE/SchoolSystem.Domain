using System;
using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;

public class AssignmentSubmission : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }


    public Guid AssignmentId { get; set; }
    public Assignment? Assignment { get; set; }

    public Guid StudentId { get; set; }
    public Student? Student { get; set; }

    public Guid FileId { get; set; }
    public FileResource? File { get; set; }

    public SubmissionStatus Status { get; set; } = SubmissionStatus.Submitted;
    public DateTime SubmittedAt { get; set; }

    public int? Score { get; set; }
    public string? Feedback { get; set; }
    public DateTime? GradedAt { get; set; }


    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}
