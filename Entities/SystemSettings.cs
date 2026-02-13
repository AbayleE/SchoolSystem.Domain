
namespace SchoolSystem.Domain.Entities;

public class SystemSettings
{
    public Guid Id { get; set; }
    
    public string PlatformName { get; set; } = "SchoolSystem";
    public string SupportEmail { get; set; } = "support@schoolsystem.com";
    
    public bool EnablePayments { get; set; }
    public bool EnableSmsNotifications { get; set; }
    public bool EnableEmailInvitations { get; set; }
    
    public int MaxTenants { get; set; }
    public int MaxUsersPerTenant { get; set; }
    
    public DateTime LastUpdated { get; set; }
}