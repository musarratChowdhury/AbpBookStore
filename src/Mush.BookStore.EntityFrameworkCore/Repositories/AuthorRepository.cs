using System;
using System.Linq;
using System.Threading.Tasks;
using Mush.BookStore.Authors;
using Mush.BookStore.Books;
using Mush.BookStore.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories;

namespace Mush.BookStore.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly IRepository<Author, Guid> _repository;

    public AuthorRepository(IRepository<Author, Guid> repository)
    {
        _repository = repository;
    }

    public async Task<Author> GetAuthorById(Guid id)
    {
        return await _repository.GetAsync(id);
    }
}