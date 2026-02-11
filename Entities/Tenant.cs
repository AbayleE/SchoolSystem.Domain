namespace SchoolSystem.Domain.Entities;
public class Tenant
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Subdomain { get; set; }
    public string? LogoUrl { get; set; }
    public DateTime CreatedAt { get; set; }
}
