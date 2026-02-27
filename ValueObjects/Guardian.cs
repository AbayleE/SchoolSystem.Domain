using SchoolSystem.Domain.Enums;

namespace SchoolSystem.Domain.ValueObjects;

public class Guardian
{
    public FullName Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public GuardianRelationship Relationship { get; set; }
    public bool IsPrimaryContact { get; set; }
    
    private Guardian() { }
    
    public Guardian(string firstName, string lastName, string email, string phone, GuardianRelationship relationship, bool isPrimary,  string? middleName = null)
    {
        Name = new FullName(firstName, middleName ?? "", lastName);
        Email = email;
        Phone = phone;
        Relationship = relationship;
        IsPrimaryContact = isPrimary;
    }
}