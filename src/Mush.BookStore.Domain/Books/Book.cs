using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Mush.BookStore.Books;

public class Book : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public BookType Type { get; set; }

    public DateTime PublishDate { get; set; }

    public float Price { get; set; }
    
    //Navigation Id
    public Guid AuthorId { get; set; }
}