using System;
using System.Collections.Generic;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;

// A parent profile linked to a User account.
// Connected to their children via StudentParent.
public class Parent : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
    
    public List<StudentParent> Students { get; set; } = [];
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
    
}
