namespace SchoolSystem.Domain.Interfaces;

public interface IEntity : IHasTenant
{
    Guid Id { get; set; }
    DateTime CreatedAt { get; set; }
    DateTime UpdatedAt { get; set; }
    DateTime? DeletedAt { get; set; }
    bool IsDeleted { get; set; }
}
