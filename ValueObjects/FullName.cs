using Microsoft.EntityFrameworkCore;

namespace SchoolSystem.Domain.ValueObjects;
[Owned]
public class FullName
{
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }

    private FullName() { }

    public FullName(string first, string middle, string last)
    {
        FirstName = first;
        MiddleName = middle;
        LastName = last;
    }
}