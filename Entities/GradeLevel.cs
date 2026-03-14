using System;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;
// A grade level e.g. "Grade 1", "Year 10", "Form 3".
// needed by Class and Application.
public class GradeLevel: IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public string Name { get; set; } = null!;
    public int Order { get; set; } 

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}