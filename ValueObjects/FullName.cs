using Microsoft.EntityFrameworkCore;

namespace SchoolSystem.Domain.valueObject;
[Owned]
public class FullName
{
    public string First { get; set; }
    public string Middle { get; set; }
    public string Last { get; set; }

    private FullName() { } 

    public FullName(string first, string middle, string last)
    {
        First = first;
        Middle = middle;
        Last = last;
    }
}