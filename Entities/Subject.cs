using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;
public class Subject : IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public string? Name { get; set; }
    public string? Code { get; set; }
}