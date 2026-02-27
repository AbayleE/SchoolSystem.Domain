using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;
// An assignment given to a class by a teacher for a specific subject and term.
// Note: assigned to a class, not an individual student.
public class Assignment : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }
    
    public Guid ClassId { get; set; }
    public Class? Class { get; set; }

    public Guid TeacherId { get; set; }
    public Teacher? Teacher { get; set; }

    public Guid SubjectId { get; set; }
    public Subject? Subject { get; set; }

    public Guid TermId { get; set; }
    public Term? Term { get; set; }

    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime DueDate { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}
