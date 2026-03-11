using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Mush.BookStore.Books;

public class Author : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; private set; } = string.Empty;
    public DateTime RegDate { get; private set; }
}