using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.ValueObjects;

namespace SchoolSystem.Domain.Entities;


public class Application : IEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }
    
    public Guid AcademicYearId { get; set; }
    
    public FullName? StudentName { get; set; }
    public Guid GradeAppliedIDd { get; set; }
    public string? CurrentGradeLevel { get; set; }
    public string? Gpa { get; set; }
    
    public FullName? ParentName { get; set; }
    public string? ParentEmail { get; set; }
    public string? ParentPhone { get; set; }
    
    public Address? Address { get; set; }
    
    public FullName? Parent2Name { get; set; }
    public string? Parent2Email { get; set; }
    public string? Parent2Phone { get; set; }
    
    public ApplicationStatus Status { get; set; }
    public DateTime SubmittedAt { get; set; }
    public DateTime? ReviewedAt { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}
