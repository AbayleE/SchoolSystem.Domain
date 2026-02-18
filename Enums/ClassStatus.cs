namespace SchoolSystem.Domain.Enums;

/// <summary>
/// Defines the status of a class.
/// </summary>
public enum ClassStatus
{
    /// <summary>Class is active and running.</summary>
    Active = 0,
    
    /// <summary>Class is inactive.</summary>
    Inactive = 1,
    
    /// <summary>Class is archived.</summary>
    Archived = 2
}