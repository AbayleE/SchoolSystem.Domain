using System;
using SchoolSystem.Domain.Enums;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;

// Attendance record for a student in a class on a specific date.
public class Attendance : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid StudentId { get; set; }
    public Student? Student { get; set; }

    public Guid ClassId { get; set; }
    public Class? Class { get; set; }

    public DateTime AttendanceDate { get; set; }
    public AttendanceStatus Status { get; set; }
    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}