namespace SchoolSystem.Domain.Enums;

/// <summary>
/// Defines the grading scale for student assessments.
/// </summary>
public enum GradeScale
{
    /// <summary>Excellent performance (90-100).</summary>
    A = 0,
    
    /// <summary>Very good performance (80-89).</summary>
    B = 1,
    
    /// <summary>Good performance (70-79).</summary>
    C = 2,
    
    /// <summary>Satisfactory performance (60-69).</summary>
    D = 3,
    
    /// <summary>Unsatisfactory performance (below 60).</summary>
    F = 4
}