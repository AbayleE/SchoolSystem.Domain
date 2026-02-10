using SchoolSystem.Domain.Interfaces;
namespace SchoolSystem.Domain.Entities;

public class Teacher : IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid UserId { get; set; }
    public string Specialization { get; set; }
}
