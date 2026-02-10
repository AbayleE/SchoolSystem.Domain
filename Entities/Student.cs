using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.valueObject;
namespace SchoolSystem.Domain.Entities;
public class Student : IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public FullName Name { get; set; }
    public DateTime DOB { get; set; }
    public string Gender { get; set; }

    public Guid ParentId { get; set; }
    public string Status { get; set; }

    public DateTime CreatedAt { get; set; }
}
