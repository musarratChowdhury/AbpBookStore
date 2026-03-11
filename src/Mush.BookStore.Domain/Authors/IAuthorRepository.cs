using System;
using System.Threading.Tasks;
using Mush.BookStore.Books;

namespace Mush.BookStore.Authors;

public interface IAuthorRepository
{
    public Task<Author> GetAuthorById(Guid id);
}