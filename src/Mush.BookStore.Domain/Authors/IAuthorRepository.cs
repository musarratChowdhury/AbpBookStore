using System;
using System.Threading.Tasks;
using Mush.BookStore.Books;
using Volo.Abp.Domain.Repositories;

namespace Mush.BookStore.Authors;

public interface IAuthorRepository : IRepository<Author,Guid>
{
}