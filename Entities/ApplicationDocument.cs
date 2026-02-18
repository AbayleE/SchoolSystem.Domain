using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Enums;
namespace SchoolSystem.Domain.Entities;

public class ApplicationDocument : IEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid ApplicationId { get; set; }
    public Application? Application { get; set; }
    
    public string? FileUrl { get; set; }
    public string? FileName { get; set; }
    public long FileSize { get; set; } 
    
    public FileType FileType { get; set; }
    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}
