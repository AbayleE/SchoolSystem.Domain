using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Enums;
namespace SchoolSystem.Domain.Entities;

public class FileResource : IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public string Url { get; set; }
    public FileType FileType { get; set; }
    public Guid? RelatedEntityId { get; set; }
}