
using System;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;

// Platform-wide settings controlled by the SystemOwner only.
// One record for the entire platform.
public class SystemSettings : IEntity
{
    public Guid Id { get; set; }

    public string PlatformName { get; set; } = "SchoolSystem";
    public string SupportEmail { get; set; } = "support@schoolsystem.com";

    public bool EnablePayments { get; set; }
    public bool EnableSmsNotifications { get; set; }
    public bool EnableEmailInvitations { get; set; }

    public int MaxTenants { get; set; }
    public int MaxUsersPerTenant { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}