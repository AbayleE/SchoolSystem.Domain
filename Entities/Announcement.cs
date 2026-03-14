using System;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;
// A public or internal announcement posted by a school.
// IsPublic controls whether parents and students can see it.
public class Announcement : IEntity, IHasTenant
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    public required string Title { get; set; }
    public required string Content { get; set; }

    public Guid PostedByUserId { get; set; }
    public User? PostedByUser { get; set; }

    public bool IsPublic { get; set; } = true;
    public DateTime PublishedAt { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}