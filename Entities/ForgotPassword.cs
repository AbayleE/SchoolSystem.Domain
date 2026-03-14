using System;
using SchoolSystem.Domain.Enums;

namespace SchoolSystem.Domain.Entities;

public class ForgotPassword
{
    public string? Email { get; set; }
    public UserRole Role { get; set; }
    public string? Token { get; set; }
    public DateTime ExpiresAt { get; set; }
    public bool Used { get; set; }
}