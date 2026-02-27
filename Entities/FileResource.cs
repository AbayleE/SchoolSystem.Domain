using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Enums;
namespace SchoolSystem.Domain.Entities;

// A file uploaded anywhere in the system — application docs, assignment submissions, etc.
// RelatedEntityId + RelatedEntityType identify what the file belongs to.
// TenantId is nullable because application files have no tenant yet.
// Replaces both the old FileResource and ApplicationDocument entities.
public class FileResource : IEntity
{
    public Guid Id { get; set; }
    public Guid? TenantId { get; set; }

    public string FileUrl { get; set; } = null!;
    public string FileName { get; set; } = null!;
    public long FileSize { get; set; }
    public FileType FileType { get; set; }

    public Guid? RelatedEntityId { get; set; }
    public string? RelatedEntityType { get; set; }
    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}