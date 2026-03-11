using System;
using System.Threading.Tasks;
using Mush.BookStore.Books;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Mush.BookStore.Authors;

public class AuthorDataSeed(
    IAuthorRepository authorRepository,
    IAuthorManager authorManager) : IDataSeedContributor, ITransientDependency
{
    private readonly IAuthorRepository _authorRepository = authorRepository;
    private readonly IAuthorManager _authorManager = authorManager;

    public async Task SeedAsync(DataSeedContext context)
    {
        //will check if an author with name "Musarrat" already exists?
        if (await _authorRepository.GetCountAsync() > 0) return;
        if (await _authorRepository.CountAsync(x => x.Name.Contains("Musarrat")) != 0) return;
        // _authorRepository
        var author = _authorManager.CreateNew("Musarrat", DateTime.Now);
        await _authorRepository.InsertAsync(author);
    }
}