using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Enums;
namespace SchoolSystem.Domain.Entities;
public class Invitation: IEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }
    
    public string? Email { get; set; }
    public UserRole Role { get; set; }
    
    public string? Token { get; set; }
    public DateTime ExpiresAt { get; set; }
    public bool Used { get; set; }

    public Guid SentByUserId { get; set; }
    public UserRole SentByRole { get; set; }
    public string? SendByEmail { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}