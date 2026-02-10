using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.valueObject;

namespace SchoolSystem.Domain.Entities;
public class Parent : IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid UserId { get; set; }
    public Address Address { get; set; }
}
