using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Enums;
namespace SchoolSystem.Domain.Entities;

// An invitation email sent to onboard a new user.
// Carries TenantId and Role so registration knows exactly who to create.
// SystemOwner invites SchoolAdmins (TenantId = new school).
// SchoolAdmin invites Teachers, Parents, Students (TenantId = their school).
public class Invitation: IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }
    
    public string? Email { get; set; }
    public UserRole Role { get; set; }
    
    public string? Token { get; set; }
    public DateTime ExpiresAt { get; set; }
    public bool Used { get; set; }

    public Guid SentByUserId { get; set; }
    public User? SentByUser { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}