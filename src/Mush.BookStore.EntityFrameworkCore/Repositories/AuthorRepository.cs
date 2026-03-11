using System;
using System.Linq;
using System.Threading.Tasks;
using Mush.BookStore.Authors;
using Mush.BookStore.Books;
using Mush.BookStore.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Mush.BookStore.Repositories;

public class AuthorRepository(
    IDbContextProvider<BookStoreDbContext> dbContextProvider)
    : EfCoreRepository<BookStoreDbContext, Author, Guid>(dbContextProvider), IAuthorRepository
{
}