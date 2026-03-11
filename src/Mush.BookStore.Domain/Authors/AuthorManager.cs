using System;
using Mush.BookStore.Books;
using Volo.Abp;
using Volo.Abp.DependencyInjection;

namespace Mush.BookStore.Authors;

public class AuthorManager: IAuthorManager, ITransientDependency
{
    public Author CreateNew(string name, DateTime regDate)
    {
        if (regDate < DateTime.Now - new TimeSpan(10,10,10))
        {
            throw new BusinessException("reg date can't be in the past");
        }

        var author = new Author(name, regDate);

        return author;
    }
}