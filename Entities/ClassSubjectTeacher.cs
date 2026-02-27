using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;

public class ClassSubjectTeacher: IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid ClassId { get; set; }
    public Class? Class { get; set; }

    public Guid SubjectId { get; set; }
    public Subject? Subject { get; set; }

    public Guid TeacherId { get; set; }
    public Teacher? Teacher { get; set; }

    public Guid AcademicYearId { get; set; }
    public AcademicYear? AcademicYear { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}