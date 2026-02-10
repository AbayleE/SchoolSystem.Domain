using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;
public class Grade : IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public Guid StudentId { get; set; }
    public Guid SubjectId { get; set; }
    public Guid TeacherId { get; set; }

    public Guid TermId { get; set; }
    public double Score { get; set; }
}