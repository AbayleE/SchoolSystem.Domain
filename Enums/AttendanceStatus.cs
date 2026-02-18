namespace SchoolSystem.Domain.Enums;

/// <summary>
/// Defines the attendance status of a student for a session.
/// </summary>
public enum AttendanceStatus
{
    /// <summary>Student is present.</summary>
    Present = 0,
    
    /// <summary>Student is absent.</summary>
    Absent = 1,
    
    /// <summary>Student arrived late.</summary>
    Late = 2,
    
    /// <summary>Student left early.</summary>
    EarlyLeave = 3,
    
    /// <summary>Attendance is not yet marked.</summary>
    Unmarked = 4
}