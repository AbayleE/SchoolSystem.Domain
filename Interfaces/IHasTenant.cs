using System;

namespace SchoolSystem.Domain.Interfaces;

public interface IHasTenant
{
    Guid TenantId { get; set; }
}
