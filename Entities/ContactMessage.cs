using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Domain.Entities;

// A message sent through the public website contact form.
// Not tied to any school — goes to the platform team.
public class ContactMessage : IEntity
{
        public Guid Id { get; set; }

        public  string? Name { get; set; }
        public string? Email { get; set; }
        public  string? Phone { get; set; }
        public  string? Subject { get; set; }
        public  string? Message { get; set; }

        public bool IsResolved { get; set; } = false;

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
}