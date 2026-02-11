using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Enums;
namespace SchoolSystem.Domain.Entities;

public class ApplicationDocument : IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid ApplicationId { get; set; }
    public string? FileUrl { get; set; }
    public FileType FileType { get; set; }
}
