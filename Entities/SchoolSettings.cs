using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;
public class SchoolSettings : IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public string GradingSystem { get; set; }
    public string AcademicCalendarType { get; set; }
}