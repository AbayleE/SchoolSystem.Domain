using SchoolSystem.Domain.Interfaces;
namespace SchoolSystem.Domain.Entities;
public class AcademicYear : IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public string YearName { get; set; }
    public bool IsCurrent { get; set; }
}