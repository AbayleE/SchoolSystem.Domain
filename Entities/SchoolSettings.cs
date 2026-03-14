using System;
using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;

// School-specific configuration — grading system, calendar type etc.
// One record per school (tenant).
public class SchoolSettings : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public GradingSystem GradingSystem { get; set; }
    public AcademicCalendarType AcademicCalendarType { get; set; }
    public string? TimeZone { get; set; }
    public string? DefaultLanguage { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}