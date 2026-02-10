using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.valueObject;

namespace SchoolSystem.Domain.Entities;


public class Application : IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public required FullName Student { get; set; }
    public required string GradeApplied { get; set; }
    public required string CurrentGradeLevel { get; set; }
    public required string Gpa { get; set; }
    
    public required FullName ParentName { get; set; }
    public required string ParentEmail { get; set; }
    public required string ParentPhone { get; set; }
    
    public Address? Address { get; set; }
    
    public string? Parent2Name { get; set; }
    public string? Parent2Email { get; set; }
    public string? Parent2Phone { get; set; }
    
    public ApplicationStatus Status { get; set; }

    public DateTime SubmittedAt { get; set; }
    public DateTime? ReviewedAt { get; set; }
}
