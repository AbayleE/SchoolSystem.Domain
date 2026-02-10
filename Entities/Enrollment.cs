using SchoolSystem.Domain.Interfaces;
namespace SchoolSystem.Domain.Entities;

public class Enrollment : IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid StudentId { get; set; }
    public Guid ClassId { get; set; }
    public Guid AcademicYearId { get; set; }
}