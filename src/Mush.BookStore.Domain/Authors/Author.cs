using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Mush.BookStore.Books;

public class Author : FullAuditedAggregateRoot<Guid>
{
    internal Author(string name, DateTime regDate)
    {
        Name = name;
        RegDate = regDate;
    }
    
    public string Name { get; private set; } = string.Empty;
    public DateTime RegDate { get; private set; }
}