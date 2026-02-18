using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Enums;
namespace SchoolSystem.Domain.Entities;

public class FileResource :IEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public string? Url { get; set; }
    public string? FileName { get; set; }        
    public long FileSize { get; set; }  
    public FileType FileType { get; set; }
    public Guid? RelatedEntityId { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}